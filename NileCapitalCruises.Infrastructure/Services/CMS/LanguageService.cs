using AutoMapper;
using NileCapitalCruises.Core.IRepositories;
using NileCapitalCruises.Core.Models;
using NileCapitalCruises.Infrastructure.Data;
using NileCapitalCruises.Infrastructure.Dtos.CMS.RequestDtos.LanguageDtos;
using NileCapitalCruises.Infrastructure.Dtos.CMS.RequestDtos.OperationDateDtos;
using NileCapitalCruises.Infrastructure.Dtos.CMS.RequestDtos.WeekDayDtos;
using NileCapitalCruises.Infrastructure.Dtos.CMS.ResponseDtos.LanguageDtos;
using NileCapitalCruises.Infrastructure.Dtos.CMS.ResponseDtos.OperationDateDtos;
using NileCapitalCruises.Infrastructure.Dtos.CMS.ResponseDtos.WeekDayDtos;
using NileCapitalCruises.Infrastructure.Helpers.ApiResponses;
using NileCapitalCruises.Infrastructure.Helpers.Utils;
using NileCapitalCruises.Infrastructure.IServices.CMS;
using Microsoft.EntityFrameworkCore;
using System.Transactions;
using NileCapitalCruises.Infrastructure.Dtos.CMS.RequestDtos.PeriodDtos;
using NileCapitalCruises.Infrastructure.Dtos.CMS.ResponseDtos.PeriodDtos;

namespace NileCapitalCruises.Infrastructure.Services.CMS
{
    public class LanguageService : ILanguageService
    {
        private readonly IGenericRepo<Language> _languageRepo;
        private readonly IHandleContents<Language> _handleContents;
        private readonly IMapper _mapper;

        public LanguageService(IGenericRepo<Language> languageRepo, IHandleContents<Language> handleContents, IMapper mapper)
        {
            _languageRepo = languageRepo;
            _handleContents = handleContents;
            _mapper = mapper;
        }

        private List<TableInfo> GetTablesWithLangId(NileCapitalCruisesWSDBContext context)
        {
            var tableInfos = new List<TableInfo>();

            var model = context.Model;

            foreach (var entityType in model.GetEntityTypes())
            {
                var tableName = entityType.GetTableName();
                var s = entityType.GetProperties().ToList();
                if (entityType.GetProperties().Any(p => p.Name == "LanguageId"))
                {
                    tableInfos.Add(new TableInfo
                    {
                        TableName = tableName,
                        ColumnName = "LangID"
                    });
                }
            }

            return tableInfos;
        }

        private void AddRecordsToTable(DbContext context, string tableName, int languageId)
        {
            // Get the entity type for the specified table name
            var entityType = context.Model.GetEntityTypes().FirstOrDefault(e => e.GetTableName() == tableName);

            if (entityType != null)
            {
                // Get the DbSet for the entity type using reflection
                var dbSetProperty = context.GetType().GetProperties().FirstOrDefault(p =>
                    p.PropertyType.IsGenericType &&
                    p.PropertyType.GetGenericTypeDefinition() == typeof(DbSet<>) &&
                    p.PropertyType.GenericTypeArguments[0] == entityType.ClrType);

                if (dbSetProperty != null)
                {
                    // Invoke the Add method on the DbSet
                    var dbSet = (IQueryable<object>)dbSetProperty.GetValue(context);
                    var uniqueOriginalTableIds = new HashSet<int>(
                        dbSet.Select(entity => (int)entity.GetType().GetProperty("OriginalTableId").GetValue(entity))
                    );

                    var langidProperty = entityType.GetProperties().FirstOrDefault(p => p.Name == "LanguageId");
                    var originalTableIdProperty = entityType.GetProperties().FirstOrDefault(p => p.Name == "OriginalTableId");

                    if (langidProperty != null && originalTableIdProperty != null)
                    {
                        foreach (var number in uniqueOriginalTableIds)
                        {
                            var entityInstance = Activator.CreateInstance(entityType.ClrType);
                            langidProperty.PropertyInfo.SetValue(entityInstance, languageId);
                            originalTableIdProperty.PropertyInfo.SetValue(entityInstance, number);
                            dbSetProperty.GetValue(context).GetType().GetMethod("Add").Invoke(dbSetProperty.GetValue(context), new[] { entityInstance });
                        }
                    }
                    context.SaveChanges();
                }
                else
                {
                    Console.WriteLine($"DbSet not found for table: {tableName}");
                }
            }
            else
            {
                Console.WriteLine($"Table not found: {tableName}");
            }
        }


        public async Task<IResponse> CreateLanguage(CMSLanguageRequestDto requestDto)
        {
            using (var scope = new TransactionScope(TransactionScopeAsyncFlowOption.Enabled))
            {
                try
                {
                    var request = _mapper.Map<Language>(requestDto);
                    var newItem = await _languageRepo.CreateEntityAsync(request);
                    if (newItem == null) return FailResponse.Error(new List<string> { StatusCodeAndErrorsMessagesStandard.ItemNotCreated }, StatusCodeAndErrorsMessagesStandard.BadRequest);
                    _languageRepo.SaveChanges();
                    var languageDto = _mapper.Map<CMSBasicLanguageResponseDto>(newItem);
                    
                    // this code is when i add a new language will insert to all the tables has content a new record
                    using (var context = new NileCapitalCruisesWSDBContext())
                    {
                        var tablesWithLangId = GetTablesWithLangId(context);
                        foreach (var tableInfo in tablesWithLangId)
                        {
                            AddRecordsToTable(context, tableInfo.TableName, newItem.Id);
                        }
                    };

                    scope.Complete();
                    return SuccessSingleResponse<CMSBasicLanguageResponseDto>.Success(languageDto, StatusCodeAndErrorsMessagesStandard.Created);
                }
                catch (Exception)
                {
                    return FailResponse.Error(new List<string> { "Transaction failed." }, StatusCodeAndErrorsMessagesStandard.InternalServerError);
                }
            }
        }


        public async Task<IResponse> UpdateLanguage(int languageId, CMSLanguageRequestDto requestDto)
        {

            try
            {
                var existingItem = await _languageRepo.GetByIdAsync(languageId);

                if (existingItem == null)
                    return FailResponse.Error(new List<string> { StatusCodeAndErrorsMessagesStandard.NoItem }, StatusCodeAndErrorsMessagesStandard.NotFound);

                _mapper.Map(requestDto, existingItem);

                _languageRepo.UpdateEntity(existingItem);
                await _languageRepo.SaveChangesAsync();

                var updatedDto = _mapper.Map<CMSBasicLanguageResponseDto>(existingItem);

                return SuccessSingleResponse<CMSBasicLanguageResponseDto>.Success(updatedDto, StatusCodeAndErrorsMessagesStandard.OK);
            }
            catch (Exception)
            {
                return FailResponse.Error(new List<string> { StatusCodeAndErrorsMessagesStandard.ItemNotUpdated }, StatusCodeAndErrorsMessagesStandard.BadRequest);
            }
        }


        public async Task<IResponse> GetLanguages()
        {
            var languages = await _languageRepo.ListAllAsync();
            if (languages.Count <= 0) return FailResponse.Error(new List<string> { StatusCodeAndErrorsMessagesStandard.NoItem }, StatusCodeAndErrorsMessagesStandard.NotFound);
            var data = _mapper.Map<IReadOnlyList<CMSBasicLanguageResponseDto>>(languages);
            return SuccessListResponse<CMSBasicLanguageResponseDto>.Success(
                    data != null,
                    StatusCodeAndErrorsMessagesStandard.OK,
                    data
                );
        }
    }

    public class TableInfo
    {
        public string TableName { get; set; }
        public string ColumnName { get; set; }
    }  
}
