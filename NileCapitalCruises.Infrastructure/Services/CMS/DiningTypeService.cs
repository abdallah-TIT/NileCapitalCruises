using AutoMapper;
using NileCapitalCruises.Core.IRepositories;
using NileCapitalCruises.Core.Models;
using NileCapitalCruises.Infrastructure.Data.Specification.CMS;
using NileCapitalCruises.Infrastructure.Data.Specification.CMS.CompanySpecification;
using NileCapitalCruises.Infrastructure.Data.Specification.CMS.DiningTypeSpecification;
using NileCapitalCruises.Infrastructure.Dtos.CMS.RequestDtos.CompanyDtos;
using NileCapitalCruises.Infrastructure.Dtos.CMS.RequestDtos.DiningTypeDtos;
using NileCapitalCruises.Infrastructure.Dtos.CMS.ResponseDtos.CompanyDtos;
using NileCapitalCruises.Infrastructure.Dtos.CMS.ResponseDtos.DiningTypeDtos;
using NileCapitalCruises.Infrastructure.Helpers.ApiResponses;
using NileCapitalCruises.Infrastructure.Helpers.Utils;
using NileCapitalCruises.Infrastructure.IServices.CMS;
using System.Transactions;


namespace NileCapitalCruises.Infrastructure.Services.CMS
{
    public class DiningTypeService : IDiningTypeService
    {
        private readonly IGenericRepo<DiningType> _diningTypeRepo;
        private readonly IGenericRepo<DiningTypeContent> _diningTypeContentRepo;
        private readonly IMapper _mapper;
        private readonly IHandleContents<DiningTypeContent> _handleContent;

        public DiningTypeService(
            IGenericRepo<DiningType> diningTypeRepo,
            IGenericRepo<DiningTypeContent> diningTypeContentRepo,
            IMapper mapper,
            IHandleContents<DiningTypeContent> handleContent)
        {
            _diningTypeRepo = diningTypeRepo;
            _mapper = mapper;
            _handleContent = handleContent;
            _diningTypeContentRepo = diningTypeContentRepo;
        }

        public async Task<IResponse> CreateDiningType(DiningTypeRequestDto requestDto)
        {

            using (var scope = new TransactionScope(TransactionScopeAsyncFlowOption.Enabled))
            {
                try
                {
                    var request = _mapper.Map<DiningType>(requestDto);
                    var newItem = await _diningTypeRepo.CreateEntityAsync(request);
                    if (newItem == null) return FailResponse.Error(new List<string> { StatusCodeAndErrorsMessagesStandard.ItemNotCreated }, StatusCodeAndErrorsMessagesStandard.BadRequest);

                    newItem.DiningTypeUrl = HandleUrlsName.CreateUrlByName(newItem.DiningTypeNameSys);

                    await _diningTypeRepo.SaveChangesAsync();

                    // For Creating Content based on the numbers of master language table
                    await _handleContent.CreateContents(newItem.Id, newItem.DiningTypeContents);

                    await _diningTypeRepo.SaveChangesAsync();

                    var diningTypeDto = _mapper.Map<BasicDiningTypeResponseDto>(newItem);
                    scope.Complete();
                    return SuccessSingleResponse<BasicDiningTypeResponseDto>.Success(diningTypeDto, StatusCodeAndErrorsMessagesStandard.Created);
                }
                catch (Exception)
                {
                    return FailResponse.Error(new List<string> { StatusCodeAndErrorsMessagesStandard.ItemNotCreated }, StatusCodeAndErrorsMessagesStandard.InternalServerError);
                }
            }
        }

        public async Task<IResponse> UpdateDiningType(int diningTypeId, DiningTypeRequestDto requestDto)
        {

            try
            {
                var existingItem = await _diningTypeRepo.GetByIdAsync(diningTypeId);

                if (existingItem == null)
                    return FailResponse.Error(new List<string> { StatusCodeAndErrorsMessagesStandard.NoItem }, StatusCodeAndErrorsMessagesStandard.NotFound);

                _mapper.Map(requestDto, existingItem);

                _diningTypeRepo.UpdateEntity(existingItem);
                await _diningTypeRepo.SaveChangesAsync();

                var updatedDto = _mapper.Map<BasicDiningTypeResponseDto>(existingItem);

                return SuccessSingleResponse<BasicDiningTypeResponseDto>.Success(updatedDto, StatusCodeAndErrorsMessagesStandard.OK);
            }
            catch (Exception)
            {
                return FailResponse.Error(new List<string> { StatusCodeAndErrorsMessagesStandard.ItemNotUpdated }, StatusCodeAndErrorsMessagesStandard.BadRequest);
            }
        }

        public async Task<IResponse> GetDiningTypes(PaginationSpecParams paginationSpecParams)
        {
            var spec = new DiningTypeSpecification(paginationSpecParams);
            var countSpec = new DiningTypeWithFiltersForCountSpecification(paginationSpecParams);
            var totalItems = await _diningTypeRepo.CountAsync(countSpec);
            var items = await _diningTypeRepo.ListAsync(spec);
            if (items.Count() <= 0) return FailResponse.Error(new List<string> { StatusCodeAndErrorsMessagesStandard.NoItem }, StatusCodeAndErrorsMessagesStandard.NotFound);


            var data = _mapper.Map<IReadOnlyList<DiningTypeWithContentResponseDto>>(items);

            return SuccessPaginationResponse<DiningTypeWithContentResponseDto>.Success(
                    data != null,
                    StatusCodeAndErrorsMessagesStandard.OK,
                    data,
                    paginationSpecParams.PageIndex,
                    paginationSpecParams.PageSize,
                    totalItems
                );
        }


        public async Task<IResponse> GetDiningType(int diningTypeId)
        {
            var spec = new DiningTypeSpecification(diningTypeId);
            var item = await _diningTypeRepo.GetEntityWithSpecAsync(spec);
            if (item == null) return FailResponse.Error(new List<string> { StatusCodeAndErrorsMessagesStandard.NoItem }, StatusCodeAndErrorsMessagesStandard.NotFound);
            var itemDto = _mapper.Map<BasicDiningTypeResponseDto>(item);
            return SuccessSingleResponse<BasicDiningTypeResponseDto>.Success(itemDto, StatusCodeAndErrorsMessagesStandard.OK);
        }


        public async Task<IResponse> DeleteDiningType(int diningTypeId)
        {
            using (var scope = new TransactionScope(TransactionScopeAsyncFlowOption.Enabled))
            {
                try
                {
                    var existingItem = await _diningTypeRepo.GetByIdAsync(diningTypeId);

                    if (existingItem == null)
                        return FailResponse.Error(new List<string> { StatusCodeAndErrorsMessagesStandard.NoItem }, StatusCodeAndErrorsMessagesStandard.NotFound);

                    var spec = new DiningTypeContentSpecification(diningTypeId);
                    var relatedItems = await _diningTypeContentRepo.ListAsync(spec);

                    relatedItems.Select(item =>
                    {
                        _diningTypeContentRepo.DeleteSoftEntity(item);
                        return item;
                    }).ToList();
                    _diningTypeRepo.DeleteSoftEntity(existingItem);

                    // Use ForEach to apply soft delete to each related item

                    await _diningTypeRepo.SaveChangesAsync();
                    await _diningTypeContentRepo.SaveChangesAsync();

                    scope.Complete();
                    return BaseSuccessResponse.Success(StatusCodeAndErrorsMessagesStandard.OK);
                }
                catch (Exception)
                {
                    return FailResponse.Error(new List<string> { StatusCodeAndErrorsMessagesStandard.ItemNotDeleted }, StatusCodeAndErrorsMessagesStandard.BadRequest);
                }
            }


        }

        public async Task<IResponse> GetDiningTypeContent(int diningTypeId, string languageCode = "en")
        {
            var spec = new DiningTypeContentSpecification(diningTypeId, languageCode);
            var item = await _diningTypeContentRepo.GetEntityWithSpecAsync(spec);
            if (item == null) return FailResponse.Error(new List<string> { StatusCodeAndErrorsMessagesStandard.NoItem }, StatusCodeAndErrorsMessagesStandard.NotFound);
            var itemDto = _mapper.Map<DiningTypeContentResponseDto>(item);
            return SuccessSingleResponse<DiningTypeContentResponseDto>.Success(itemDto, StatusCodeAndErrorsMessagesStandard.OK);
        }


        public async Task<IResponse> UpdateDiningTypeContent(int diningTypeId, DiningTypeContentRequestDto requestDto, string languageCode = "en")
        {
            var spec = new DiningTypeContentSpecification(diningTypeId, languageCode);
            var item = await _diningTypeContentRepo.GetEntityWithSpecAsync(spec);
            if (item == null) return FailResponse.Error(new List<string> { StatusCodeAndErrorsMessagesStandard.NoItem }, StatusCodeAndErrorsMessagesStandard.NotFound);
            _mapper.Map(requestDto, item);

            try
            {

                _diningTypeContentRepo.UpdateEntity(item);
                await _diningTypeContentRepo.SaveChangesAsync();

                var updatedDto = _mapper.Map<DiningTypeContentResponseDto>(item);

                return SuccessSingleResponse<DiningTypeContentResponseDto>.Success(updatedDto, StatusCodeAndErrorsMessagesStandard.OK);
            }
            catch (Exception)
            {
                return FailResponse.Error(new List<string> { StatusCodeAndErrorsMessagesStandard.ItemNotUpdated }, StatusCodeAndErrorsMessagesStandard.BadRequest);
            }


        }




    }
}
