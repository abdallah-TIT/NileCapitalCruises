
using AutoMapper;
using NileCapitalCruises.Core.IRepositories;
using NileCapitalCruises.Core.Models;
using NileCapitalCruises.Infrastructure.Dtos.CMS.RequestDtos.CityDtos;
using NileCapitalCruises.Infrastructure.Dtos.CMS.RequestDtos.CompanyDtos;
using NileCapitalCruises.Infrastructure.Dtos.CMS.RequestDtos.DurationDtos;
using NileCapitalCruises.Infrastructure.Dtos.CMS.RequestDtos.ItineraryDtos;
using NileCapitalCruises.Infrastructure.Dtos.CMS.ResponseDtos.CityDtos;
using NileCapitalCruises.Infrastructure.Dtos.CMS.ResponseDtos.CompanyDtos;
using NileCapitalCruises.Infrastructure.Dtos.CMS.ResponseDtos.ItineraryDtos;
using NileCapitalCruises.Infrastructure.Helpers.ApiResponses;
using NileCapitalCruises.Infrastructure.Helpers.Utils;
using NileCapitalCruises.Infrastructure.IServices;
using NileCapitalCruises.Infrastructure.IServices.CMS;
using Microsoft.AspNetCore.Http;
using System.Transactions;
using NileCapitalCruises.Infrastructure.Data.Specification.CMS.CruiseSpecification;
using NileCapitalCruises.Infrastructure.Dtos.CMS.RequestDtos.CruiseDtos;
using NileCapitalCruises.Infrastructure.Dtos.CMS.ResponseDtos.CruiseDtos;
using NileCapitalCruises.Infrastructure.Data.Specification.CMS.ItinerarySpecification;
using NileCapitalCruises.Infrastructure.Data.Specification.CMS;
using System.Security.Claims;
using NileCapitalCruises.Infrastructure.Data.Specification.CMS.CompanySpecification;
using NileCapitalCruises.Infrastructure.Dtos.BookingEngine.ResponseDtos.ItineraryDtos;

namespace NileCapitalCruises.Infrastructure.Services.CMS
{
    public class CMSItineraryService : CMSIItineraryService
    {
        private readonly IGenericRepo<Itinerary> _itineraryRepo;
        private readonly IHandleContents<ItineraryContent> _handleContent;
        private readonly IGenericRepo<ItineraryContent> _itineraryContentRepo;
        private readonly HttpContext _httpContext;
        private readonly ITokenService _tokenService;
        private readonly IMapper _mapper;

        public CMSItineraryService(
            IGenericRepo<Itinerary> itineraryRepo,
            IGenericRepo<ItineraryContent> itineraryContentRepo,
            IHandleContents<ItineraryContent> handleContent,
            IHttpContextAccessor httpContextAccessor,
             ITokenService tokenService,
            IMapper mapper
            )
        {
            _itineraryRepo = itineraryRepo;
            _itineraryContentRepo = itineraryContentRepo;
            _handleContent = handleContent;
            _httpContext = httpContextAccessor.HttpContext;
            _tokenService = tokenService;
            _mapper = mapper;
           
        }
        public async Task<IResponse> CreateItinerary(int companyId, CMSItineraryRequestDto requestDto)
        {

            using (var scope = new TransactionScope(TransactionScopeAsyncFlowOption.Enabled))
            {
                try
                {
                    var claims = _tokenService.GetClaimsFromJwt(_httpContext);
                    if (claims.ContainsKey("CompanyId") && int.Parse(claims["CompanyId"]) != companyId)
                    {
                        return FailResponse.Error(new List<string> { StatusCodeAndErrorsMessagesStandard.ForbiddenAccess }, StatusCodeAndErrorsMessagesStandard.BadRequest);

                    }
                        

                    var request = _mapper.Map<Itinerary>(requestDto);
                    request.CompanyId = companyId;
                    var newItem = await _itineraryRepo.CreateEntityAsync(request);
                    if (newItem == null) return FailResponse.Error(new List<string> { StatusCodeAndErrorsMessagesStandard.ItemNotCreated }, StatusCodeAndErrorsMessagesStandard.BadRequest);

                    newItem.ItineraryUrl = HandleUrlsName.CreateUrlByName(newItem.ItineraryNameSys);

                    await _itineraryRepo.SaveChangesAsync();

                    // For Creating Content based on the numbers of master language table
                    await _handleContent.CreateContents(newItem.Id, newItem.ItineraryContents);

                    await _itineraryRepo.SaveChangesAsync();

                    var companyDto = _mapper.Map<CMSBasicItineraryResponseDto>(newItem);
                    scope.Complete();
                    return SuccessSingleResponse<CMSBasicItineraryResponseDto>.Success(companyDto, StatusCodeAndErrorsMessagesStandard.Created);
                }
                catch (Exception)
                {
                    return FailResponse.Error(new List<string> { StatusCodeAndErrorsMessagesStandard.ItemNotCreated }, StatusCodeAndErrorsMessagesStandard.InternalServerError);
                }
            }
        }

        public async Task<IResponse> UpdateItinerary(int itineraryId, int companyId, CMSItineraryRequestDto requestDto)
        {

            try
            {
                var spec = new CMSItinerarySpecification(itineraryId, companyId);
                var existingItem = await _itineraryRepo.GetEntityWithSpecAsync(spec);

                if (existingItem == null)
                    return FailResponse.Error(new List<string> { StatusCodeAndErrorsMessagesStandard.NoItem }, StatusCodeAndErrorsMessagesStandard.NotFound);

                _mapper.Map(requestDto, existingItem);

                _itineraryRepo.UpdateEntity(existingItem);
                await _itineraryRepo.SaveChangesAsync();

                var updatedDto = _mapper.Map<CMSBasicItineraryResponseDto>(existingItem);

                return SuccessSingleResponse<CMSBasicItineraryResponseDto>.Success(updatedDto, StatusCodeAndErrorsMessagesStandard.OK);
            }
            catch (Exception)
            {
                return FailResponse.Error(new List<string> { StatusCodeAndErrorsMessagesStandard.ItemNotUpdated }, StatusCodeAndErrorsMessagesStandard.BadRequest);
            }
        }

        public async Task<IResponse> GetItineraries(int cruiseId, PaginationSpecParams paginationSpecParams)
        {

            var spec = new CMSItinerarySpecification(paginationSpecParams, cruiseId);
            var countSpec = new CMSItineraryWithFiltersForCountSpecification(paginationSpecParams, cruiseId);
            var totalItems = await _itineraryRepo.CountAsync(countSpec);
            var items = await _itineraryRepo.ListAsync(spec);
            if (items.Count() <= 0) return FailResponse.Error(new List<string> { StatusCodeAndErrorsMessagesStandard.NoItem }, StatusCodeAndErrorsMessagesStandard.NotFound);


            var data = _mapper.Map<IReadOnlyList<CMSItineraryWithContentResponseDto>>(items);

            return SuccessPaginationResponse<CMSItineraryWithContentResponseDto>.Success(
                    data != null,
                    StatusCodeAndErrorsMessagesStandard.OK,
                    data,
                    paginationSpecParams.PageIndex,
                    paginationSpecParams.PageSize,
                    totalItems
                );
        }

        public async Task<IResponse> GetItinerary(int itineraryId)
        {
            var spec = new CMSItinerarySpecification(itineraryId);
            var item = await _itineraryRepo.GetEntityWithSpecAsync(spec);
            if (item == null) return FailResponse.Error(new List<string> { StatusCodeAndErrorsMessagesStandard.NoItem }, StatusCodeAndErrorsMessagesStandard.NotFound);
            var itemDto = _mapper.Map<CMSBasicItineraryResponseDto>(item);
            return SuccessSingleResponse<CMSBasicItineraryResponseDto>.Success(itemDto, StatusCodeAndErrorsMessagesStandard.OK);
        }

        public async Task<IResponse> DeleteItinerary(int itineraryId)
        {
            using (var scope = new TransactionScope(TransactionScopeAsyncFlowOption.Enabled))
            {
                try
                {
                    var existingItem = await _itineraryRepo.GetByIdAsync(itineraryId);

                    if (existingItem == null)
                        return FailResponse.Error(new List<string> { StatusCodeAndErrorsMessagesStandard.NoItem }, StatusCodeAndErrorsMessagesStandard.NotFound);

                    var spec = new CMSItineraryContentSpecification(itineraryId);
                    var relatedItems = await _itineraryContentRepo.ListAsync(spec);

                    relatedItems.Select(item =>
                    {
                        _itineraryContentRepo.DeleteSoftEntity(item);
                        return item;
                    }).ToList();
                    _itineraryRepo.DeleteSoftEntity(existingItem);

                    // Use ForEach to apply soft delete to each related item

                    await _itineraryRepo.SaveChangesAsync();
                    await _itineraryContentRepo.SaveChangesAsync();

                    scope.Complete();
                    return BaseSuccessResponse.Success(StatusCodeAndErrorsMessagesStandard.OK);
                }
                catch (Exception)
                {
                    return FailResponse.Error(new List<string> { StatusCodeAndErrorsMessagesStandard.ItemNotDeleted }, StatusCodeAndErrorsMessagesStandard.BadRequest);
                }
            }


        }

        public async Task<IResponse> GetItineraryContent(int itineraryId, string languageCode = "en")
        {
            var spec = new CMSItineraryContentSpecification(itineraryId, languageCode);
            var item = await _itineraryContentRepo.GetEntityWithSpecAsync(spec);
            if (item == null) return FailResponse.Error(new List<string> { StatusCodeAndErrorsMessagesStandard.NoItem }, StatusCodeAndErrorsMessagesStandard.NotFound);
            var itemDto = _mapper.Map<CMSItineraryContentResponseDto>(item);
            return SuccessSingleResponse<CMSItineraryContentResponseDto>.Success(itemDto, StatusCodeAndErrorsMessagesStandard.OK);
        }


        public async Task<IResponse> UpdateItineraryContent(int itineraryId, CMSItineraryContentRequestDto requestDto, string languageCode = "en")
        {
            var spec = new CMSItineraryContentSpecification(itineraryId, languageCode);
            var item = await _itineraryContentRepo.GetEntityWithSpecAsync(spec);
            if (item == null) return FailResponse.Error(new List<string> { StatusCodeAndErrorsMessagesStandard.NoItem }, StatusCodeAndErrorsMessagesStandard.NotFound);
            _mapper.Map(requestDto, item);

            try
            {

                _itineraryContentRepo.UpdateEntity(item);
                await _itineraryRepo.SaveChangesAsync();

                var updatedDto = _mapper.Map<CMSItineraryContentResponseDto>(item);

                return SuccessSingleResponse<CMSItineraryContentResponseDto>.Success(updatedDto, StatusCodeAndErrorsMessagesStandard.OK);
            }
            catch (Exception)
            {
                return FailResponse.Error(new List<string> { StatusCodeAndErrorsMessagesStandard.ItemNotUpdated }, StatusCodeAndErrorsMessagesStandard.BadRequest);
            }


        }

    }
}
