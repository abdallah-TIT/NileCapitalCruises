using AutoMapper;
using NileCapitalCruises.Core.IRepositories;
using NileCapitalCruises.Core.Models;
using NileCapitalCruises.Infrastructure.Data.Specification.CMS;
using NileCapitalCruises.Infrastructure.Data.Specification.CMS.CabinTypeSpecification;
using NileCapitalCruises.Infrastructure.Dtos.CMS.RequestDtos.CabinTypeDtos;
using NileCapitalCruises.Infrastructure.Dtos.CMS.ResponseDtos.CabinTypeDtos;
using NileCapitalCruises.Infrastructure.Dtos.CMS.ResponseDtos.CityDtos;
using NileCapitalCruises.Infrastructure.Helpers.ApiResponses;
using NileCapitalCruises.Infrastructure.Helpers.Utils;
using NileCapitalCruises.Infrastructure.IServices.CMS;
using System.Transactions;

namespace NileCapitalCruises.Infrastructure.Services.CMS
{
    public class CabinTypeService : ICabinTypeService
    {
        private readonly IGenericRepo<CabinType> _cabinTypeRepo;
        private readonly IGenericRepo<CabinTypeContent> _cabinTypeContentRepo;
        private readonly IHandleContents<CabinTypeContent> _handleContent;
        private readonly IMapper _mapper;

        public CabinTypeService(
            IGenericRepo<CabinType> cabinTypeRepo,
            IGenericRepo<CabinTypeContent> cabinTypeContentRepo,
            IHandleContents<CabinTypeContent> handleContent,
            IMapper mapper)
        {
            _cabinTypeRepo = cabinTypeRepo;
            _cabinTypeContentRepo = cabinTypeContentRepo;
            _handleContent = handleContent;
            _mapper = mapper;
        }

        public async Task<IResponse> CreateCabinType(CabinTypeRequestDto requestDto)
        {

            using (var scope = new TransactionScope(TransactionScopeAsyncFlowOption.Enabled))
            {
                try
                {
                    var request = _mapper.Map<CabinType>(requestDto);
                    var newItem = await _cabinTypeRepo.CreateEntityAsync(request);
                    if (newItem == null) return FailResponse.Error(new List<string> { StatusCodeAndErrorsMessagesStandard.ItemNotCreated }, StatusCodeAndErrorsMessagesStandard.BadRequest);

                    newItem.CabinTypeUrl = HandleUrlsName.CreateUrlByName(newItem.CabinTypeNameSys);

                    await _cabinTypeRepo.SaveChangesAsync();

                    // For Creating Content based on the numbers of master language table
                    await _handleContent.CreateContents(newItem.Id, newItem.CabinTypeContents);

                    await _cabinTypeRepo.SaveChangesAsync();

                    var cabinTypeDto = _mapper.Map<BasicCabinTypeResponseDto>(newItem);
                    scope.Complete();
                    return SuccessSingleResponse<BasicCabinTypeResponseDto>.Success(cabinTypeDto, StatusCodeAndErrorsMessagesStandard.Created);
                }
                catch (Exception)
                {
                    return FailResponse.Error(new List<string> { StatusCodeAndErrorsMessagesStandard.ItemNotCreated }, StatusCodeAndErrorsMessagesStandard.InternalServerError);
                }
            }
        }


        public async Task<IResponse> UpdateCabinType(int cabinTypeId, CabinTypeRequestDto requestDto)
        {

            try
            {
                var existingItem = await _cabinTypeRepo.GetByIdAsync(cabinTypeId);

                if (existingItem == null)
                    return FailResponse.Error(new List<string> { StatusCodeAndErrorsMessagesStandard.NoItem }, StatusCodeAndErrorsMessagesStandard.NotFound);

                _mapper.Map(requestDto, existingItem);

                _cabinTypeRepo.UpdateEntity(existingItem);
                await _cabinTypeRepo.SaveChangesAsync();

                var updatedDto = _mapper.Map<BasicCabinTypeResponseDto>(existingItem);

                return SuccessSingleResponse<BasicCabinTypeResponseDto>.Success(updatedDto, StatusCodeAndErrorsMessagesStandard.OK);
            }
            catch (Exception)
            {
                return FailResponse.Error(new List<string> { StatusCodeAndErrorsMessagesStandard.ItemNotUpdated }, StatusCodeAndErrorsMessagesStandard.BadRequest);
            }
        }


        public async Task<IResponse> GetCabinTypes(PaginationSpecParams paginationSpecParams)
        {
            var spec = new CabinTypeSpecification(paginationSpecParams);
            var countSpec = new CabinTypeWithFiltersForCountSpecification(paginationSpecParams);
            var totalItems = await _cabinTypeRepo.CountAsync(countSpec);
            var items = await _cabinTypeRepo.ListAsync(spec);
            if (items.Count() <= 0) return FailResponse.Error(new List<string> { StatusCodeAndErrorsMessagesStandard.NoItem }, StatusCodeAndErrorsMessagesStandard.NotFound);


            var data = _mapper.Map<IReadOnlyList<CabinTypeWithContentResponseDto>>(items);

            return SuccessPaginationResponse<CabinTypeWithContentResponseDto>.Success(
                    data != null,
                    StatusCodeAndErrorsMessagesStandard.OK,
                    data,
                    paginationSpecParams.PageIndex,
                    paginationSpecParams.PageSize,
                    totalItems
                );
        }


        public async Task<IResponse> GetCabinType(int cabinTypeId)
        {
            var spec = new CabinTypeSpecification(cabinTypeId);
            var item = await _cabinTypeRepo.GetEntityWithSpecAsync(spec);
            if (item == null) return FailResponse.Error(new List<string> { StatusCodeAndErrorsMessagesStandard.NoItem }, StatusCodeAndErrorsMessagesStandard.NotFound);
            var itemDto = _mapper.Map<BasicCabinTypeResponseDto>(item);
            return SuccessSingleResponse<BasicCabinTypeResponseDto>.Success(itemDto, StatusCodeAndErrorsMessagesStandard.OK);
        }


        public async Task<IResponse> DeleteCabinType(int cabinTypeId)
        {
            using (var scope = new TransactionScope(TransactionScopeAsyncFlowOption.Enabled))
            {
                try
                {
                    var existingItem = await _cabinTypeRepo.GetByIdAsync(cabinTypeId);

                    if (existingItem == null)
                        return FailResponse.Error(new List<string> { StatusCodeAndErrorsMessagesStandard.NoItem }, StatusCodeAndErrorsMessagesStandard.NotFound);

                    var spec = new CabinTypeContentSpecification(cabinTypeId);
                    var relatedItems = await _cabinTypeContentRepo.ListAsync(spec);

                    relatedItems.Select(item =>
                    {
                        _cabinTypeContentRepo.DeleteSoftEntity(item);
                        return item;
                    }).ToList();
                    _cabinTypeRepo.DeleteSoftEntity(existingItem);

                    // Use ForEach to apply soft delete to each related item

                    await _cabinTypeRepo.SaveChangesAsync();
                    await _cabinTypeContentRepo.SaveChangesAsync();

                    scope.Complete();
                    return BaseSuccessResponse.Success(StatusCodeAndErrorsMessagesStandard.OK);
                }
                catch (Exception)
                {
                    return FailResponse.Error(new List<string> { StatusCodeAndErrorsMessagesStandard.ItemNotDeleted }, StatusCodeAndErrorsMessagesStandard.BadRequest);
                }
            }


        }


        public async Task<IResponse> GetCabinTypeContent(int cabinTypeId, string languageCode = "en")
        {
            var spec = new CabinTypeContentSpecification(cabinTypeId, languageCode);
            var item = await _cabinTypeContentRepo.GetEntityWithSpecAsync(spec);
            if (item == null) return FailResponse.Error(new List<string> { StatusCodeAndErrorsMessagesStandard.NoItem }, StatusCodeAndErrorsMessagesStandard.NotFound);
            var itemDto = _mapper.Map<CabinTypeContentResponseDto>(item);
            return SuccessSingleResponse<CabinTypeContentResponseDto>.Success(itemDto, StatusCodeAndErrorsMessagesStandard.OK);
        }


        public async Task<IResponse> UpdateCabinTypeContent(int cabinTypeId, CabinTypeContentRequestDto requestDto, string languageCode = "en")
        {
            var spec = new CabinTypeContentSpecification(cabinTypeId, languageCode);
            var item = await _cabinTypeContentRepo.GetEntityWithSpecAsync(spec);
            if (item == null) return FailResponse.Error(new List<string> { StatusCodeAndErrorsMessagesStandard.NoItem }, StatusCodeAndErrorsMessagesStandard.NotFound);
            _mapper.Map(requestDto, item);

            try
            {

                _cabinTypeContentRepo.UpdateEntity(item);
                await _cabinTypeContentRepo.SaveChangesAsync();

                var updatedDto = _mapper.Map<CabinTypeContentResponseDto>(item);

                return SuccessSingleResponse<CabinTypeContentResponseDto>.Success(updatedDto, StatusCodeAndErrorsMessagesStandard.OK);
            }
            catch (Exception)
            {
                return FailResponse.Error(new List<string> { StatusCodeAndErrorsMessagesStandard.ItemNotUpdated }, StatusCodeAndErrorsMessagesStandard.BadRequest);
            }


        }


    }
}
