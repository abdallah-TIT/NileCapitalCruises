using AutoMapper;
using NileCapitalCruises.Core.IRepositories;
using NileCapitalCruises.Core.Models;
using NileCapitalCruises.Infrastructure.Data.Specification.CMS.CabinAmenitySpecification;
using NileCapitalCruises.Infrastructure.Data.Specification.CMS.CabinSpecification;
using NileCapitalCruises.Infrastructure.Data.Specification.CMS.CruiseFacilitySpecification;
using NileCapitalCruises.Infrastructure.Data.Specification.CMS.CruiseSpecification;
using NileCapitalCruises.Infrastructure.Dtos.CMS.RequestDtos.CabinAmenityDtos;
using NileCapitalCruises.Infrastructure.Dtos.CMS.RequestDtos.CruiseFacilityDtos;
using NileCapitalCruises.Infrastructure.Dtos.CMS.ResponseDtos.CabinAmenityDtos;
using NileCapitalCruises.Infrastructure.Dtos.CMS.ResponseDtos.CruiseFacilityDtos;
using NileCapitalCruises.Infrastructure.Helpers.ApiResponses;
using NileCapitalCruises.Infrastructure.IServices;
using NileCapitalCruises.Infrastructure.IServices.CMS;
using Microsoft.AspNetCore.Http;
using System.Transactions;


namespace NileCapitalCruises.Infrastructure.Services.CMS
{
    public class CabinAmenityService : ICabinAmenityService
    {
        private readonly IGenericRepo<CabinAmenity> _cabinAmenityRepo;
        private readonly IMapper _mapper;
        private readonly HttpContext _httpContext;
        private readonly ITokenService _tokenService;
        private readonly IGenericRepo<Cabin> _cabinRepo;

        public CabinAmenityService(
            IGenericRepo<CabinAmenity> cabinAmenityRepo,
        IMapper mapper,
        IHttpContextAccessor httpContextAccessor,
             ITokenService tokenService
,
             IGenericRepo<Cabin> cabinRepo)
        {
            _cabinAmenityRepo =  cabinAmenityRepo;
            _mapper = mapper;
            _httpContext = httpContextAccessor.HttpContext;
            _tokenService = tokenService;
            _cabinRepo = cabinRepo;
        }


        public async Task<IResponse> UpdateAmenitiesToCabin(int cabinId, int companyId, IEnumerable<CabinAmenityRequestDto> requestDto)
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


                    var cabinAmenitySpec = new CabinAmenitySpecification(cabinId);
                    var cabinAmenityItems = await _cabinAmenityRepo.ListAsync(cabinAmenitySpec);
                    if (cabinAmenityItems.Count() > 0)
                        _cabinAmenityRepo.DeleteEntities(cabinAmenityItems);


                    var spec = new CabinSpecification(cabinId);
                    var item = await _cabinRepo.GetEntityWithSpecAsync(spec);
                    if (item == null) return FailResponse.Error(new List<string> { StatusCodeAndErrorsMessagesStandard.InvalidCruiseId }, StatusCodeAndErrorsMessagesStandard.NotFound);


                    var request = _mapper.Map<IEnumerable<CabinAmenity>>(requestDto);

                     request.Select(x => x.CabinId = cabinId).ToList();


                    var newItems = await _cabinAmenityRepo.CreateEntitiesAsync(request);
                    if (newItems.Count() <= 0) return FailResponse.Error(new List<string> { StatusCodeAndErrorsMessagesStandard.NoItem }, StatusCodeAndErrorsMessagesStandard.NotFound);

                   

                    await _cabinAmenityRepo.SaveChangesAsync();

                    

                   
                    scope.Complete();
                    return BaseSuccessResponse.Success( StatusCodeAndErrorsMessagesStandard.Created);
                }
                catch (Exception)
                {
                    return FailResponse.Error(new List<string> { StatusCodeAndErrorsMessagesStandard.ItemNotCreated }, StatusCodeAndErrorsMessagesStandard.InternalServerError);
                }
            }
        }


        public async Task<IResponse> GetAmenities(int cabinId, string languageCode = "en")
        {
            var spec = new CabinAmenitySpecification(cabinId, languageCode);
            var items = await _cabinAmenityRepo.ListAsync(spec);
            if (items.Count() <= 0) return FailResponse.Error(new List<string> { StatusCodeAndErrorsMessagesStandard.NoItem }, StatusCodeAndErrorsMessagesStandard.NotFound);


            var data = _mapper.Map<IReadOnlyList<AmenityResponseDto>>(items);

            return SuccessPaginationResponse<AmenityResponseDto>.Success(
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
