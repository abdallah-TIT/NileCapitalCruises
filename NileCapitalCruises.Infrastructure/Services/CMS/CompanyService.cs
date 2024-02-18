using AutoMapper;
using NileCapitalCruises.Core.IRepositories;
using NileCapitalCruises.Core.Models;
using NileCapitalCruises.Infrastructure.Data.Specification.CMS;
using NileCapitalCruises.Infrastructure.Data.Specification.CMS.CompanySpecification;
using NileCapitalCruises.Infrastructure.Dtos.CMS.RequestDtos.CompanyDtos;
using NileCapitalCruises.Infrastructure.Dtos.CMS.RequestDtos.ItineraryDtos;
using NileCapitalCruises.Infrastructure.Dtos.CMS.ResponseDtos.CityDtos;
using NileCapitalCruises.Infrastructure.Dtos.CMS.ResponseDtos.CompanyDtos;
using NileCapitalCruises.Infrastructure.Dtos.CMS.ResponseDtos.ItineraryDtos;
using NileCapitalCruises.Infrastructure.Dtos.CMS.ResponseDtos.ItineraryTypeDtos;
using NileCapitalCruises.Infrastructure.Helpers.ApiResponses;
using NileCapitalCruises.Infrastructure.Helpers.Utils;
using NileCapitalCruises.Infrastructure.IServices.CMS;
using System.Transactions;


namespace NileCapitalCruises.Infrastructure.Services.CMS
{
    public class CompanyService : ICompanyService
    {
        private readonly IGenericRepo<Company> _companyRepo;
        private readonly IGenericRepo<CompanyContent> _companyContentRepo;
        private readonly IMapper _mapper;
        private readonly IHandleContents<CompanyContent> _handleContent;

        public CompanyService(
            IGenericRepo<Company> companyRepo,
            IGenericRepo<CompanyContent> companyContentRepo,
            IMapper mapper,
            IHandleContents<CompanyContent> handleContent)
        {
            _companyRepo = companyRepo;
            _mapper = mapper;
            _handleContent = handleContent;
            _companyContentRepo = companyContentRepo;
        }

        public async Task<IResponse> CreateCompany(CompanyRequestDto requestDto)
        {

            using (var scope = new TransactionScope(TransactionScopeAsyncFlowOption.Enabled))
            {
                try
                {
                    var request = _mapper.Map<Company>(requestDto);
                    var newItem = await _companyRepo.CreateEntityAsync(request);
                    if (newItem == null) return FailResponse.Error(new List<string> { StatusCodeAndErrorsMessagesStandard.ItemNotCreated }, StatusCodeAndErrorsMessagesStandard.BadRequest);

                    newItem.CompanyUrl = HandleUrlsName.CreateUrlByName(newItem.CompanyNameSys);

                    await _companyRepo.SaveChangesAsync();

                    // For Creating Content based on the numbers of master language table
                    await _handleContent.CreateContents(newItem.Id, newItem.CompanyContents);

                    await _companyRepo.SaveChangesAsync();

                    var companyDto = _mapper.Map<CMSBasicCompanyResponseDto>(newItem);
                    scope.Complete();
                    return SuccessSingleResponse<CMSBasicCompanyResponseDto>.Success(companyDto, StatusCodeAndErrorsMessagesStandard.Created);
                }
                catch (Exception)
                {
                    return FailResponse.Error(new List<string> { StatusCodeAndErrorsMessagesStandard.ItemNotCreated }, StatusCodeAndErrorsMessagesStandard.InternalServerError);
                }
            }
        }

        public async Task<IResponse> UpdateCompany(int companyId, CompanyRequestDto requestDto)
        {

            try
            {
                var existingItem = await _companyRepo.GetByIdAsync(companyId);

                if (existingItem == null)
                    return FailResponse.Error(new List<string> { StatusCodeAndErrorsMessagesStandard.NoItem }, StatusCodeAndErrorsMessagesStandard.NotFound);

                _mapper.Map(requestDto, existingItem);

                _companyRepo.UpdateEntity(existingItem);
                await _companyRepo.SaveChangesAsync();

                var updatedDto = _mapper.Map<CMSBasicCompanyResponseDto>(existingItem);
                
                return SuccessSingleResponse<CMSBasicCompanyResponseDto>.Success(updatedDto, StatusCodeAndErrorsMessagesStandard.OK);
            }
            catch (Exception)
            {
                return FailResponse.Error(new List<string> { StatusCodeAndErrorsMessagesStandard.ItemNotUpdated }, StatusCodeAndErrorsMessagesStandard.BadRequest);
            }
        }


        public async Task<IResponse> GetCompanies(PaginationSpecParams paginationSpecParams)
        {
            var spec = new CompanySpecification(paginationSpecParams);
            var countSpec = new CompanyWithFiltersForCountSpecification(paginationSpecParams);
            var totalItems = await _companyRepo.CountAsync(countSpec);
            var items = await _companyRepo.ListAsync(spec);
            if (items.Count() <= 0) return FailResponse.Error(new List<string> { StatusCodeAndErrorsMessagesStandard.NoItem }, StatusCodeAndErrorsMessagesStandard.NotFound);


            var data = _mapper.Map<IReadOnlyList<CMSCompanyWithContentResponseDto>>(items);

            return SuccessPaginationResponse<CMSCompanyWithContentResponseDto>.Success(
                    data != null,
                    StatusCodeAndErrorsMessagesStandard.OK,
                    data,
                    paginationSpecParams.PageIndex,
                    paginationSpecParams.PageSize,
                    totalItems
                );
        }


        public async Task<IResponse> GetCompany(int companyId)
        {
            var spec = new CompanySpecification(companyId);
            var item = await _companyRepo.GetEntityWithSpecAsync(spec);
            if (item == null) return FailResponse.Error(new List<string> { StatusCodeAndErrorsMessagesStandard.NoItem }, StatusCodeAndErrorsMessagesStandard.NotFound);
            var itemDto = _mapper.Map<CMSBasicCompanyResponseDto>(item);
            return SuccessSingleResponse<CMSBasicCompanyResponseDto>.Success(itemDto, StatusCodeAndErrorsMessagesStandard.OK);
        }

        public async Task<IResponse> DeleteCompany(int companyId)
        {
            using (var scope = new TransactionScope(TransactionScopeAsyncFlowOption.Enabled))
            {
                try
                {
                    var existingItem = await _companyRepo.GetByIdAsync(companyId);

                    if (existingItem == null)
                        return FailResponse.Error(new List<string> { StatusCodeAndErrorsMessagesStandard.NoItem }, StatusCodeAndErrorsMessagesStandard.NotFound);

                    var spec = new CompanyContentSpecification(companyId);
                    var relatedItems = await _companyContentRepo.ListAsync(spec);

                    relatedItems.Select(item =>
                    {
                        _companyContentRepo.DeleteSoftEntity(item);
                        return item;
                    }).ToList();
                    _companyRepo.DeleteSoftEntity(existingItem);

                    // Use ForEach to apply soft delete to each related item
                   
                    await _companyRepo.SaveChangesAsync();
                    await _companyContentRepo.SaveChangesAsync();

                    scope.Complete();
                    return BaseSuccessResponse.Success(StatusCodeAndErrorsMessagesStandard.OK);
                }
                catch (Exception)
                {
                    return FailResponse.Error(new List<string> { StatusCodeAndErrorsMessagesStandard.ItemNotDeleted }, StatusCodeAndErrorsMessagesStandard.BadRequest);
                }
            }

            
        }




        public async Task<IResponse> GetCompanyContent(int companyId, string languageCode = "en")
        {
            var spec = new CompanyContentSpecification(companyId, languageCode);
            var item = await _companyContentRepo.GetEntityWithSpecAsync(spec);
            if (item == null) return FailResponse.Error(new List<string> { StatusCodeAndErrorsMessagesStandard.NoItem }, StatusCodeAndErrorsMessagesStandard.NotFound);
            var itemDto = _mapper.Map<CMSCompanyContentResponseDto>(item);
            return SuccessSingleResponse<CMSCompanyContentResponseDto>.Success(itemDto, StatusCodeAndErrorsMessagesStandard.OK);
        }

        public async Task<IResponse> UpdateCompanyContent(int companyId,  CMSCompanyContentRequestDto requestDto, string languageCode = "en")
        {
            var spec = new CompanyContentSpecification(companyId, languageCode);
            var item = await _companyContentRepo.GetEntityWithSpecAsync(spec);
            if (item == null) return FailResponse.Error(new List<string> { StatusCodeAndErrorsMessagesStandard.NoItem }, StatusCodeAndErrorsMessagesStandard.NotFound);
            _mapper.Map(requestDto, item);

            try
            {
               
                _companyContentRepo.UpdateEntity(item);
                await _companyRepo.SaveChangesAsync();

                var updatedDto = _mapper.Map<CMSCompanyContentResponseDto>(item);

                return SuccessSingleResponse<CMSCompanyContentResponseDto>.Success(updatedDto, StatusCodeAndErrorsMessagesStandard.OK);
            }
            catch (Exception)
            {
                return FailResponse.Error(new List<string> { StatusCodeAndErrorsMessagesStandard.ItemNotUpdated }, StatusCodeAndErrorsMessagesStandard.BadRequest);
            }


        }



    }
}
