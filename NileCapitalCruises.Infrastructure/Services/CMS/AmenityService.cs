using AutoMapper;
using NileCapitalCruises.Core.IRepositories;
using NileCapitalCruises.Core.Models;
using NileCapitalCruises.Infrastructure.Data.Specification.CMS.FacilitySpecification;
using NileCapitalCruises.Infrastructure.Data.Specification.CMS;
using NileCapitalCruises.Infrastructure.Dtos.CMS.RequestDtos.CabinDtos;
using NileCapitalCruises.Infrastructure.Dtos.CMS.ResponseDtos.AmenityDtos;
using NileCapitalCruises.Infrastructure.Dtos.CMS.ResponseDtos.FacilityDtos;
using NileCapitalCruises.Infrastructure.Helpers.ApiResponses;
using NileCapitalCruises.Infrastructure.Helpers.Utils;
using NileCapitalCruises.Infrastructure.IServices;
using NileCapitalCruises.Infrastructure.IServices.CMS;
using Microsoft.AspNetCore.Http;
using System.Transactions;
using NileCapitalCruises.Infrastructure.Data.Specification.CMS.AmenitySpecification;
using NileCapitalCruises.Infrastructure.Dtos.CMS.RequestDtos.AmenityDtos;
using NileCapitalCruises.Infrastructure.Dtos.CMS.ResponseDtos.CabinAmenityDtos;


namespace NileCapitalCruises.Infrastructure.Services.CMS
{
    public class AmenityService : IAmenityService
    {
        private readonly IGenericRepo<Amenity> _amenityRepo;
        private readonly IGenericRepo<AmenityContent> _amenityContentRepo;
        private readonly IMapper _mapper;
        private readonly IHandleContents<AmenityContent> _handleContent;
        private readonly ITokenService _tokenService;
        private readonly HttpContext _httpContext;


        public AmenityService(
            IGenericRepo<Amenity> amenityRepo,
            IGenericRepo<AmenityContent> amenityContentRepo,
             ITokenService tokenService,
             IHttpContextAccessor httpContextAccessor,
            IMapper mapper,
            IHandleContents<AmenityContent> handleContent)
        {
            _tokenService = tokenService;
            _httpContext = httpContextAccessor.HttpContext;
            _amenityRepo = amenityRepo;
            _mapper = mapper;
            _handleContent = handleContent;
            _amenityContentRepo = amenityContentRepo;
        }

        public async Task<IResponse> CreateAmenity(AmenityRequestDto requestDto)
        {

            using (var scope = new TransactionScope(TransactionScopeAsyncFlowOption.Enabled))
            {
                try
                {
                    var request = _mapper.Map<Amenity>(requestDto);
                    var newItem = await _amenityRepo.CreateEntityAsync(request);
                    if (newItem == null) return FailResponse.Error(new List<string> { StatusCodeAndErrorsMessagesStandard.ItemNotCreated }, StatusCodeAndErrorsMessagesStandard.BadRequest);

                    newItem.AmenityUrl = HandleUrlsName.CreateUrlByName(newItem.AmenityNameSys);

                    await _amenityRepo.SaveChangesAsync();

                    // For Creating Content based on the numbers of master language table
                    await _handleContent.CreateContents(newItem.Id, newItem.AmenityContents);

                    await _amenityRepo.SaveChangesAsync();

                    var companyDto = _mapper.Map<BasicAmenityResponseDto>(newItem);
                    scope.Complete();
                    return SuccessSingleResponse<BasicAmenityResponseDto>.Success(companyDto, StatusCodeAndErrorsMessagesStandard.Created);
                }
                catch (Exception)
                {
                    return FailResponse.Error(new List<string> { StatusCodeAndErrorsMessagesStandard.ItemNotCreated }, StatusCodeAndErrorsMessagesStandard.InternalServerError);
                }
            }
        }


        public async Task<IResponse> UpdateAmenity(int amenityId, AmenityRequestDto requestDto)
        {

            try
            {
                var existingItem = await _amenityRepo.GetByIdAsync(amenityId);

                if (existingItem == null)
                    return FailResponse.Error(new List<string> { StatusCodeAndErrorsMessagesStandard.NoItem }, StatusCodeAndErrorsMessagesStandard.NotFound);

                _mapper.Map(requestDto, existingItem);

                _amenityRepo.UpdateEntity(existingItem);
                await _amenityRepo.SaveChangesAsync();

                var updatedDto = _mapper.Map<BasicAmenityResponseDto>(existingItem);

                return SuccessSingleResponse<BasicAmenityResponseDto>.Success(updatedDto, StatusCodeAndErrorsMessagesStandard.OK);
            }
            catch (Exception)
            {
                return FailResponse.Error(new List<string> { StatusCodeAndErrorsMessagesStandard.ItemNotUpdated }, StatusCodeAndErrorsMessagesStandard.BadRequest);
            }
        }

        public async Task<IResponse> GetAmenities(PaginationSpecParams paginationSpecParams)
        {
            var spec = new AmenitySpecification(paginationSpecParams);
            var countSpec = new AmenityWithFiltersForCountSpecification(paginationSpecParams);
            var totalItems = await _amenityRepo.CountAsync(countSpec);
            var items = await _amenityRepo.ListAsync(spec);
            if (items.Count() <= 0) return FailResponse.Error(new List<string> { StatusCodeAndErrorsMessagesStandard.NoItem }, StatusCodeAndErrorsMessagesStandard.NotFound);


            var data = _mapper.Map<IReadOnlyList<AmenityWithContentResponseDto>>(items);

            return SuccessPaginationResponse<AmenityWithContentResponseDto>.Success(
                    data != null,
                    StatusCodeAndErrorsMessagesStandard.OK,
                    data,
                    paginationSpecParams.PageIndex,
                    paginationSpecParams.PageSize,
                    totalItems
                );
        }

        public async Task<IResponse> GetAmenity(int amenityId)
        {
            var spec = new AmenitySpecification(amenityId);
            var item = await _amenityRepo.GetEntityWithSpecAsync(spec);
            if (item == null) return FailResponse.Error(new List<string> { StatusCodeAndErrorsMessagesStandard.NoItem }, StatusCodeAndErrorsMessagesStandard.NotFound);
            var itemDto = _mapper.Map<BasicAmenityResponseDto>(item);
            return SuccessSingleResponse<BasicAmenityResponseDto>.Success(itemDto, StatusCodeAndErrorsMessagesStandard.OK);
        }

        public async Task<IResponse> DeleteAmenity(int amenityId)
        {
            using (var scope = new TransactionScope(TransactionScopeAsyncFlowOption.Enabled))
            {
                try
                {
                    var existingItem = await _amenityRepo.GetByIdAsync(amenityId);

                    if (existingItem == null)
                        return FailResponse.Error(new List<string> { StatusCodeAndErrorsMessagesStandard.NoItem }, StatusCodeAndErrorsMessagesStandard.NotFound);

                    var spec = new AmenityContentSpecification(amenityId);
                    var relatedItems = await _amenityContentRepo.ListAsync(spec);

                    relatedItems.Select(item =>
                    {
                        _amenityContentRepo.DeleteSoftEntity(item);
                        return item;
                    }).ToList();
                    _amenityRepo.DeleteSoftEntity(existingItem);

                    // Use ForEach to apply soft delete to each related item

                    await _amenityRepo.SaveChangesAsync();
                    await _amenityContentRepo.SaveChangesAsync();

                    scope.Complete();
                    return BaseSuccessResponse.Success(StatusCodeAndErrorsMessagesStandard.OK);
                }
                catch (Exception)
                {
                    return FailResponse.Error(new List<string> { StatusCodeAndErrorsMessagesStandard.ItemNotDeleted }, StatusCodeAndErrorsMessagesStandard.BadRequest);
                }
            }


        }

        public async Task<IResponse> GetAmenityContent(int amenityId, string languageCode = "en")
        {
            var spec = new AmenityContentSpecification(amenityId, languageCode);
            var item = await _amenityContentRepo.GetEntityWithSpecAsync(spec);
            if (item == null) return FailResponse.Error(new List<string> { StatusCodeAndErrorsMessagesStandard.NoItem }, StatusCodeAndErrorsMessagesStandard.NotFound);
            var itemDto = _mapper.Map<AmenityContentResponseDto>(item);
            return SuccessSingleResponse<AmenityContentResponseDto>.Success(itemDto, StatusCodeAndErrorsMessagesStandard.OK);
        }


        public async Task<IResponse> UpdateAmenityContent(int amenityId, AmenityContentRequestDto requestDto, string languageCode = "en")
        {
            var spec = new AmenityContentSpecification(amenityId, languageCode);
            var item = await _amenityContentRepo.GetEntityWithSpecAsync(spec);
            if (item == null) return FailResponse.Error(new List<string> { StatusCodeAndErrorsMessagesStandard.NoItem }, StatusCodeAndErrorsMessagesStandard.NotFound);
            _mapper.Map(requestDto, item);

            try
            {

                _amenityContentRepo.UpdateEntity(item);
                await _amenityContentRepo.SaveChangesAsync();

                var updatedDto = _mapper.Map<AmenityContentResponseDto>(item);

                return SuccessSingleResponse<AmenityContentResponseDto>.Success(updatedDto, StatusCodeAndErrorsMessagesStandard.OK);
            }
            catch (Exception)
            {
                return FailResponse.Error(new List<string> { StatusCodeAndErrorsMessagesStandard.ItemNotUpdated }, StatusCodeAndErrorsMessagesStandard.BadRequest);
            }


        }



    }
}
