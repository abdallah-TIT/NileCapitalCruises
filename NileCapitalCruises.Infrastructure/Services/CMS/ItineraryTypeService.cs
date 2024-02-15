using AutoMapper;
using NileCapitalCruises.Core.IRepositories;
using NileCapitalCruises.Core.Models;
using NileCapitalCruises.Infrastructure.Data.Specification.CMS.CompanySpecification;
using NileCapitalCruises.Infrastructure.Data.Specification.CMS;
using NileCapitalCruises.Infrastructure.Dtos.CMS.RequestDtos.CompanyDtos;
using NileCapitalCruises.Infrastructure.Dtos.CMS.RequestDtos.ItineraryTypeDtos;
using NileCapitalCruises.Infrastructure.Dtos.CMS.ResponseDtos.CompanyDtos;
using NileCapitalCruises.Infrastructure.Dtos.CMS.ResponseDtos.ItineraryTypeDtos;
using NileCapitalCruises.Infrastructure.Helpers.ApiResponses;
using NileCapitalCruises.Infrastructure.Helpers.Utils;
using NileCapitalCruises.Infrastructure.IServices.CMS;
using System.Transactions;
using NileCapitalCruises.Infrastructure.Data.Specification.BookingEngine.ItineraryTypeSpecification;
using NileCapitalCruises.Infrastructure.Data.Specification.CMS.ItineraryTypeSpecification;
using NileCapitalCruises.Infrastructure.Dtos.BookingEngine.ResponseDtos.ItineraryTypeDtos;


namespace NileCapitalCruises.Infrastructure.Services.CMS
{
    public class ItineraryTypeService : IItineraryTypeService
    {
        private readonly IGenericRepo<ItineraryType> _itineraryTypeRepo;
        private readonly IGenericRepo<ItineraryTypeContent> _itineraryTypeContentRepo;
        private readonly IMapper _mapper;
        private readonly IHandleContents<ItineraryTypeContent> _handleContent;

        public ItineraryTypeService(
            IGenericRepo<ItineraryType> itineraryTypeRepo,
            IGenericRepo<ItineraryTypeContent> itineraryTypeContentRepo,
            IMapper mapper,
            IHandleContents<ItineraryTypeContent> handleContent)
        {
            _itineraryTypeRepo = itineraryTypeRepo;
            _mapper = mapper;
            _handleContent = handleContent;
            _itineraryTypeContentRepo = itineraryTypeContentRepo;
        }

        public async Task<IResponse> CreateItineraryType(CMSItineraryTypeRequestDto requestDto)
        {

            using (var scope = new TransactionScope(TransactionScopeAsyncFlowOption.Enabled))
            {
                try
                {
                    var request = _mapper.Map<ItineraryType>(requestDto);
                    var newItem = await _itineraryTypeRepo.CreateEntityAsync(request);
                    if (newItem == null) return FailResponse.Error(new List<string> { StatusCodeAndErrorsMessagesStandard.ItemNotCreated }, StatusCodeAndErrorsMessagesStandard.BadRequest);

                    newItem.ItineraryTypeUrl = HandleUrlsName.CreateUrlByName(newItem.ItineraryTypeNameSys);

                    await _itineraryTypeRepo.SaveChangesAsync();

                    // For Creating Content based on the numbers of master language table
                    await _handleContent.CreateContents(newItem.Id, newItem.ItineraryTypeContents);

                    await _itineraryTypeRepo.SaveChangesAsync();

                    var companyDto = _mapper.Map<CMSBasicItineraryTypeResponseDto>(newItem);
                    scope.Complete();
                    return SuccessSingleResponse<CMSBasicItineraryTypeResponseDto>.Success(companyDto, StatusCodeAndErrorsMessagesStandard.Created);
                }
                catch (Exception)
                {
                    return FailResponse.Error(new List<string> { StatusCodeAndErrorsMessagesStandard.ItemNotCreated }, StatusCodeAndErrorsMessagesStandard.InternalServerError);
                }
            }
        }

        public async Task<IResponse> UpdateItineraryType(int itineraryTypeId, CMSItineraryTypeRequestDto requestDto)
        {

            try
            {
                var existingItem = await _itineraryTypeRepo.GetByIdAsync(itineraryTypeId);

                if (existingItem == null)
                    return FailResponse.Error(new List<string> { StatusCodeAndErrorsMessagesStandard.NoItem }, StatusCodeAndErrorsMessagesStandard.NotFound);

                _mapper.Map(requestDto, existingItem);

                _itineraryTypeRepo.UpdateEntity(existingItem);
                await _itineraryTypeRepo.SaveChangesAsync();

                var updatedDto = _mapper.Map<CMSBasicItineraryTypeResponseDto>(existingItem);

                return SuccessSingleResponse<CMSBasicItineraryTypeResponseDto>.Success(updatedDto, StatusCodeAndErrorsMessagesStandard.OK);
            }
            catch (Exception)
            {
                return FailResponse.Error(new List<string> { StatusCodeAndErrorsMessagesStandard.ItemNotUpdated }, StatusCodeAndErrorsMessagesStandard.BadRequest);
            }
        }


        public async Task<IResponse> GetItineraryTypes(PaginationSpecParams paginationSpecParams)
        {
            var spec = new CMSItineraryTypeSpecification(paginationSpecParams);
            var countSpec = new CMSItineraryTypeWithFiltersForCountSpecification(paginationSpecParams);
            var totalItems = await _itineraryTypeRepo.CountAsync(countSpec);
            var items = await _itineraryTypeRepo.ListAsync(spec);
            if (items.Count() <= 0) return FailResponse.Error(new List<string> { StatusCodeAndErrorsMessagesStandard.NoItem }, StatusCodeAndErrorsMessagesStandard.NotFound);


            var data = _mapper.Map<IReadOnlyList<CMSItineraryTypeWithContentResponseDto>>(items);

            return SuccessPaginationResponse<CMSItineraryTypeWithContentResponseDto>.Success(
                    data != null,
                    StatusCodeAndErrorsMessagesStandard.OK,
                    data,
                    paginationSpecParams.PageIndex,
                    paginationSpecParams.PageSize,
                    totalItems
                );
        }



        public async Task<IResponse> GetItineraryType(int itineraryTypesId)
        {
            var spec = new CMSItineraryTypeSpecification(itineraryTypesId);
            var item = await _itineraryTypeRepo.GetEntityWithSpecAsync(spec);
            if (item == null) return FailResponse.Error(new List<string> { StatusCodeAndErrorsMessagesStandard.NoItem }, StatusCodeAndErrorsMessagesStandard.NotFound);
            var itemDto = _mapper.Map<CMSBasicItineraryTypeResponseDto>(item);
            return SuccessSingleResponse<CMSBasicItineraryTypeResponseDto>.Success(itemDto, StatusCodeAndErrorsMessagesStandard.OK);
        }


        public async Task<IResponse> DeleteItineraryType(int itineraryTypeId)
        {
            using (var scope = new TransactionScope(TransactionScopeAsyncFlowOption.Enabled))
            {
                try
                {
                    var existingItem = await _itineraryTypeRepo.GetByIdAsync(itineraryTypeId);

                    if (existingItem == null)
                        return FailResponse.Error(new List<string> { StatusCodeAndErrorsMessagesStandard.NoItem }, StatusCodeAndErrorsMessagesStandard.NotFound);

                    var spec = new CMSItineraryTypeContentSpecification(itineraryTypeId);
                    var relatedItems = await _itineraryTypeContentRepo.ListAsync(spec);

                    relatedItems.Select(item =>
                    {
                        _itineraryTypeContentRepo.DeleteSoftEntity(item);
                        return item;
                    }).ToList();
                    _itineraryTypeRepo.DeleteSoftEntity(existingItem);

                    // Use ForEach to apply soft delete to each related item

                    await _itineraryTypeRepo.SaveChangesAsync();
                    await _itineraryTypeContentRepo.SaveChangesAsync();

                    scope.Complete();
                    return BaseSuccessResponse.Success(StatusCodeAndErrorsMessagesStandard.OK);
                }
                catch (Exception)
                {
                    return FailResponse.Error(new List<string> { StatusCodeAndErrorsMessagesStandard.ItemNotDeleted }, StatusCodeAndErrorsMessagesStandard.BadRequest);
                }
            }


        }



        public async Task<IResponse> GetItineraryTypeContents(int itineraryTypeId)
        {
            var spec = new CMSItineraryTypeContentSpecification(itineraryTypeId);
            
            var items = await _itineraryTypeContentRepo.ListAsync(spec);
            if (items.Count() <= 0) return FailResponse.Error(new List<string> { StatusCodeAndErrorsMessagesStandard.NoItem }, StatusCodeAndErrorsMessagesStandard.NotFound);


            var data = _mapper.Map<IReadOnlyList<CMSItineraryTypeContentResponseDto>>(items);

            return SuccessListResponse<CMSItineraryTypeContentResponseDto>.Success(
                    data != null,
                    StatusCodeAndErrorsMessagesStandard.OK,
                    data
                    
                );



           
        }


        public async Task<IResponse> GetItineraryTypeContent(int itineraryTypeId, string languageCode = "en")
        {
            var spec = new CMSItineraryTypeContentSpecification(itineraryTypeId, languageCode);
            var item = await _itineraryTypeContentRepo.GetEntityWithSpecAsync(spec);
            if (item == null) return FailResponse.Error(new List<string> { StatusCodeAndErrorsMessagesStandard.NoItem }, StatusCodeAndErrorsMessagesStandard.NotFound);
            var itemDto = _mapper.Map<CMSItineraryTypeContentResponseDto>(item);
            return SuccessSingleResponse<CMSItineraryTypeContentResponseDto>.Success(itemDto, StatusCodeAndErrorsMessagesStandard.OK);
        }

        public async Task<IResponse> UpdateItineraryTypeContent(int itineraryTypeId, CMSItineraryTypeContentRequestDto requestDto, string languageCode = "en")
        {
            var spec = new CMSItineraryTypeContentSpecification(itineraryTypeId, languageCode);
            var item = await _itineraryTypeContentRepo.GetEntityWithSpecAsync(spec);
            if (item == null) return FailResponse.Error(new List<string> { StatusCodeAndErrorsMessagesStandard.NoItem }, StatusCodeAndErrorsMessagesStandard.NotFound);
            _mapper.Map(requestDto, item);

            try
            {

                _itineraryTypeContentRepo.UpdateEntity(item);
                await _itineraryTypeContentRepo.SaveChangesAsync();

                var updatedDto = _mapper.Map<CMSItineraryTypeContentResponseDto>(item);

                return SuccessSingleResponse<CMSItineraryTypeContentResponseDto>.Success(updatedDto, StatusCodeAndErrorsMessagesStandard.OK);
            }
            catch (Exception)
            {
                return FailResponse.Error(new List<string> { StatusCodeAndErrorsMessagesStandard.ItemNotUpdated }, StatusCodeAndErrorsMessagesStandard.BadRequest);
            }


        }


    }
}
