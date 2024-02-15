using AutoMapper;
using NileCapitalCruises.Core.IRepositories;
using NileCapitalCruises.Core.Models;
using NileCapitalCruises.Infrastructure.Data.Specification.CMS.CruiseFacilitySpecification;
using NileCapitalCruises.Infrastructure.Data.Specification.CMS.CruiseSpecification;
using NileCapitalCruises.Infrastructure.Dtos.CMS.RequestDtos.CabinAmenityDtos;
using NileCapitalCruises.Infrastructure.Dtos.CMS.RequestDtos.CruiseFacilityDtos;
using NileCapitalCruises.Infrastructure.Dtos.CMS.ResponseDtos.CruiseFacilityDtos;
using NileCapitalCruises.Infrastructure.Dtos.CMS.ResponseDtos.ItineraryTypeDtos;
using NileCapitalCruises.Infrastructure.Helpers.ApiResponses;
using NileCapitalCruises.Infrastructure.IServices;
using NileCapitalCruises.Infrastructure.IServices.CMS;
using Microsoft.AspNetCore.Http;
using System.Transactions;


namespace NileCapitalCruises.Infrastructure.Services.CMS
{
    public class CruiseFacilityService : ICruiseFacilityService
    {
        private readonly IGenericRepo<CruiseFacility> _cruiseFacilityRepo;
        private readonly IMapper _mapper;
        private readonly HttpContext _httpContext;
        private readonly ITokenService _tokenService;
        private readonly IGenericRepo<Cruise> _cruiseRepo;

        public CruiseFacilityService(
            IGenericRepo<CruiseFacility> cruiseFacilityRepo,
        IMapper mapper,
        IHttpContextAccessor httpContextAccessor,
             ITokenService tokenService
,
             IGenericRepo<Cruise> cruiseRepo)
        {
            _cruiseFacilityRepo = cruiseFacilityRepo;
            _mapper = mapper;
            _httpContext = httpContextAccessor.HttpContext;
            _tokenService = tokenService;
            _cruiseRepo = cruiseRepo;
        }


        public async Task<IResponse> UpdateFacilitiesToCruise(int cruiseId, int companyId, IEnumerable<CruiseFacilityRequestDto> requestDto)
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


                    var cruiseFacilitySpec = new CruiseFacilitySpecification(cruiseId);
                    var cruiseFacilityItems = await _cruiseFacilityRepo.ListAsync(cruiseFacilitySpec);
                    if (cruiseFacilityItems.Count() > 0)
                         _cruiseFacilityRepo.DeleteEntities(cruiseFacilityItems);


                    var spec = new CruiseSpecification(cruiseId, companyId);
                    var item = await _cruiseRepo.GetEntityWithSpecAsync(spec);
                    if (item == null) return FailResponse.Error(new List<string> { StatusCodeAndErrorsMessagesStandard.InvalidCruiseId }, StatusCodeAndErrorsMessagesStandard.NotFound);


                    var request = _mapper.Map<IEnumerable<CruiseFacility>>(requestDto);

                     request.Select(x => x.CruiseId = cruiseId).ToList();


                    var newItems = await _cruiseFacilityRepo.CreateEntitiesAsync(request);
                    if (newItems.Count() <= 0) return FailResponse.Error(new List<string> { StatusCodeAndErrorsMessagesStandard.NoItem }, StatusCodeAndErrorsMessagesStandard.NotFound);

                   

                    await _cruiseFacilityRepo.SaveChangesAsync();

                    

                   
                    scope.Complete();
                    return BaseSuccessResponse.Success( StatusCodeAndErrorsMessagesStandard.Created);
                }
                catch (Exception)
                {
                    return FailResponse.Error(new List<string> { StatusCodeAndErrorsMessagesStandard.ItemNotCreated }, StatusCodeAndErrorsMessagesStandard.InternalServerError);
                }
            }
        }


        public async Task<IResponse> GetFacilities(int cruiseId, string languageCode = "en")
        {
            var spec = new CruiseFacilitySpecification(cruiseId, languageCode);
            var items = await _cruiseFacilityRepo.ListAsync(spec);
            if (items.Count() <= 0) return FailResponse.Error(new List<string> { StatusCodeAndErrorsMessagesStandard.NoItem }, StatusCodeAndErrorsMessagesStandard.NotFound);


            var data = _mapper.Map<IReadOnlyList<FacilityResponseDto>>(items);

            return SuccessPaginationResponse<FacilityResponseDto>.Success(
                    data != null,
                    StatusCodeAndErrorsMessagesStandard.OK,
                    data,
                    1,
                    1,
                    1
                );
        }


    }
}
