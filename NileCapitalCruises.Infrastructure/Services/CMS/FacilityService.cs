using AutoMapper;
using NileCapitalCruises.Core.IRepositories;
using NileCapitalCruises.Core.Models;
using NileCapitalCruises.Infrastructure.Data.Specification.CMS;
using NileCapitalCruises.Infrastructure.Data.Specification.CMS.FacilitySpecification;
using NileCapitalCruises.Infrastructure.Dtos.CMS.RequestDtos.CruiseFacilityDtos;
using NileCapitalCruises.Infrastructure.Dtos.CMS.RequestDtos.FacilityDtos;
using NileCapitalCruises.Infrastructure.Dtos.CMS.RequestDtos.ItineraryTypeDtos;
using NileCapitalCruises.Infrastructure.Dtos.CMS.ResponseDtos.AmenityDtos;
using NileCapitalCruises.Infrastructure.Dtos.CMS.ResponseDtos.FacilityDtos;
using NileCapitalCruises.Infrastructure.Dtos.CMS.ResponseDtos.ItineraryDtos;
using NileCapitalCruises.Infrastructure.Helpers.ApiResponses;
using NileCapitalCruises.Infrastructure.Helpers.Utils;
using NileCapitalCruises.Infrastructure.IServices.CMS;
using System.Transactions;


namespace NileCapitalCruises.Infrastructure.Services.CMS
{
    public class FacilityService : IFacilityService
    {
        private readonly IGenericRepo<Facility> _facilityRepo;
        private readonly IGenericRepo<FacilityContent> _facilityContentRepo;
        private readonly IMapper _mapper;
        private readonly IHandleContents<FacilityContent> _handleContent;

        public FacilityService(
            IGenericRepo<Facility> facilityRepo,
            IGenericRepo<FacilityContent> facilityContentRepo,
            IMapper mapper,
            IHandleContents<FacilityContent> handleContent)
        {
            _facilityRepo = facilityRepo;
            _mapper = mapper;
            _handleContent = handleContent;
            _facilityContentRepo = facilityContentRepo;
        }

        public async Task<IResponse> CreateFacility(FacilityRequestDto requestDto)
        {

            using (var scope = new TransactionScope(TransactionScopeAsyncFlowOption.Enabled))
            {
                try
                {
                    var request = _mapper.Map<Facility>(requestDto);
                    var newItem = await _facilityRepo.CreateEntityAsync(request);
                    if (newItem == null) return FailResponse.Error(new List<string> { StatusCodeAndErrorsMessagesStandard.ItemNotCreated }, StatusCodeAndErrorsMessagesStandard.BadRequest);

                    newItem.FacilityUrl = HandleUrlsName.CreateUrlByName(newItem.FacilityNameSys);

                    await _facilityRepo.SaveChangesAsync();

                    // For Creating Content based on the numbers of master language table
                    await _handleContent.CreateContents(newItem.Id, newItem.FacilityContents);

                    await _facilityRepo.SaveChangesAsync();

                    var companyDto = _mapper.Map<BasicFacilityResponseDto>(newItem);
                    scope.Complete();
                    return SuccessSingleResponse<BasicFacilityResponseDto>.Success(companyDto, StatusCodeAndErrorsMessagesStandard.Created);
                }
                catch (Exception)
                {
                    return FailResponse.Error(new List<string> { StatusCodeAndErrorsMessagesStandard.ItemNotCreated }, StatusCodeAndErrorsMessagesStandard.InternalServerError);
                }
            }
        }



        public async Task<IResponse> UpdateFacility(int facilityId, FacilityRequestDto requestDto)
        {

            try
            {
                var existingItem = await _facilityRepo.GetByIdAsync(facilityId);

                if (existingItem == null)
                    return FailResponse.Error(new List<string> { StatusCodeAndErrorsMessagesStandard.NoItem }, StatusCodeAndErrorsMessagesStandard.NotFound);

                _mapper.Map(requestDto, existingItem);

                _facilityRepo.UpdateEntity(existingItem);
                await _facilityRepo.SaveChangesAsync();

                var updatedDto = _mapper.Map<BasicFacilityResponseDto>(existingItem);

                return SuccessSingleResponse<BasicFacilityResponseDto>.Success(updatedDto, StatusCodeAndErrorsMessagesStandard.OK);
            }
            catch (Exception)
            {
                return FailResponse.Error(new List<string> { StatusCodeAndErrorsMessagesStandard.ItemNotUpdated }, StatusCodeAndErrorsMessagesStandard.BadRequest);
            }
        }


        public async Task<IResponse> GetFacilities(PaginationSpecParams paginationSpecParams)
        {
            var spec = new FacilitySpecification(paginationSpecParams);
            var countSpec = new FacilityWithFiltersForCountSpecification(paginationSpecParams);
            var totalItems = await _facilityRepo.CountAsync(countSpec);
            var items = await _facilityRepo.ListAsync(spec);
            if (items.Count() <= 0) return FailResponse.Error(new List<string> { StatusCodeAndErrorsMessagesStandard.NoItem }, StatusCodeAndErrorsMessagesStandard.NotFound);


            var data = _mapper.Map<IReadOnlyList<FacilityWithContentResponseDto>>(items);

            return SuccessPaginationResponse<FacilityWithContentResponseDto>.Success(
                    data != null,
                    StatusCodeAndErrorsMessagesStandard.OK,
                    data,
                    paginationSpecParams.PageIndex,
                    paginationSpecParams.PageSize,
                    totalItems
                );
        }


        public async Task<IResponse> GetFacility(int facilityId)
        {
            var spec = new FacilitySpecification(facilityId);
            var item = await _facilityRepo.GetEntityWithSpecAsync(spec);
            if (item == null) return FailResponse.Error(new List<string> { StatusCodeAndErrorsMessagesStandard.NoItem }, StatusCodeAndErrorsMessagesStandard.NotFound);
            var itemDto = _mapper.Map<BasicFacilityResponseDto>(item);
            return SuccessSingleResponse<BasicFacilityResponseDto>.Success(itemDto, StatusCodeAndErrorsMessagesStandard.OK);
        }

        public async Task<IResponse> DeleteFacility(int facilityId)
        {
            using (var scope = new TransactionScope(TransactionScopeAsyncFlowOption.Enabled))
            {
                try
                {
                    var existingItem = await _facilityRepo.GetByIdAsync(facilityId);

                    if (existingItem == null)
                        return FailResponse.Error(new List<string> { StatusCodeAndErrorsMessagesStandard.NoItem }, StatusCodeAndErrorsMessagesStandard.NotFound);

                    var spec = new FacilityContentSpecification(facilityId);
                    var relatedItems = await _facilityContentRepo.ListAsync(spec);

                    relatedItems.Select(item =>
                    {
                        _facilityContentRepo.DeleteSoftEntity(item);
                        return item;
                    }).ToList();
                    _facilityRepo.DeleteSoftEntity(existingItem);

                    // Use ForEach to apply soft delete to each related item

                    await _facilityRepo.SaveChangesAsync();
                    await _facilityContentRepo.SaveChangesAsync();

                    scope.Complete();
                    return BaseSuccessResponse.Success(StatusCodeAndErrorsMessagesStandard.OK);
                }
                catch (Exception)
                {
                    return FailResponse.Error(new List<string> { StatusCodeAndErrorsMessagesStandard.ItemNotDeleted }, StatusCodeAndErrorsMessagesStandard.BadRequest);
                }
            }


        }




        public async Task<IResponse> GetFacilityContent(int facilityId, string languageCode = "en")
        {
            var spec = new FacilityContentSpecification(facilityId, languageCode);
            var item = await _facilityContentRepo.GetEntityWithSpecAsync(spec);
            if (item == null) return FailResponse.Error(new List<string> { StatusCodeAndErrorsMessagesStandard.NoItem }, StatusCodeAndErrorsMessagesStandard.NotFound);
            var itemDto = _mapper.Map<FacilityContentResponseDto>(item);
            return SuccessSingleResponse<FacilityContentResponseDto>.Success(itemDto, StatusCodeAndErrorsMessagesStandard.OK);
        }

        public async Task<IResponse> UpdateFacilityContent(int facilityId, FacilityContentRequestDto requestDto, string languageCode = "en")
        {
            var spec = new FacilityContentSpecification(facilityId, languageCode);
            var item = await _facilityContentRepo.GetEntityWithSpecAsync(spec);
            if (item == null) return FailResponse.Error(new List<string> { StatusCodeAndErrorsMessagesStandard.NoItem }, StatusCodeAndErrorsMessagesStandard.NotFound);
            _mapper.Map(requestDto, item);

            try
            {

                _facilityContentRepo.UpdateEntity(item);
                await _facilityRepo.SaveChangesAsync();

                var updatedDto = _mapper.Map<FacilityContentResponseDto>(item);

                return SuccessSingleResponse<FacilityContentResponseDto>.Success(updatedDto, StatusCodeAndErrorsMessagesStandard.OK);
            }
            catch (Exception)
            {
                return FailResponse.Error(new List<string> { StatusCodeAndErrorsMessagesStandard.ItemNotUpdated }, StatusCodeAndErrorsMessagesStandard.BadRequest);
            }


        }



    }
}
