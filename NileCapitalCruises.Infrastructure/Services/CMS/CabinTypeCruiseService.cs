using AutoMapper;
using NileCapitalCruises.Core.IRepositories;
using NileCapitalCruises.Core.Models;
using NileCapitalCruises.Infrastructure.Dtos.CMS.RequestDtos.CabinTypeCruiseDtos;
using NileCapitalCruises.Infrastructure.Dtos.CMS.ResponseDtos.CabinTypeCruiseDtos;
using NileCapitalCruises.Infrastructure.Helpers.ApiResponses;
using NileCapitalCruises.Infrastructure.IServices;
using NileCapitalCruises.Infrastructure.IServices.CMS;
using Microsoft.AspNetCore.Http;
using System.Transactions;
using NileCapitalCruises.Infrastructure.Data.Specification.CMS;
using NileCapitalCruises.Infrastructure.Data.Specification.CMS.CabinTypeCruiseSpecification;

namespace NileCapitalCruises.Infrastructure.Services.CMS
{
    public class CabinTypeCruiseService : ICabinTypeCruiseService
    {
        private readonly IGenericRepo<CabinTypeCruise> _cabinTypeCruiseRepo;
        private readonly IMapper _mapper;
        private readonly ITokenService _tokenService;
        private readonly HttpContext _httpContext;

        public CabinTypeCruiseService(

            IMapper mapper,
            IGenericRepo<CabinTypeCruise> cabinTypeCruiseRepo,
            ITokenService tokenService,
            IHttpContextAccessor httpContextAccessor)
        {

            _mapper = mapper;
            _cabinTypeCruiseRepo = cabinTypeCruiseRepo;
            _tokenService = tokenService;
            _httpContext = httpContextAccessor.HttpContext;
        }



        public async Task<IResponse> CreateCabinTypeCruise(CabinTypeCruiseRequestDto requestDto, int companyId)
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

                    var request = _mapper.Map<CabinTypeCruise>(requestDto);
                    var newItem = await _cabinTypeCruiseRepo.CreateEntityAsync(request);
                    if (newItem == null) return FailResponse.Error(new List<string> { StatusCodeAndErrorsMessagesStandard.ItemNotCreated }, StatusCodeAndErrorsMessagesStandard.BadRequest);
                    

                    await _cabinTypeCruiseRepo.SaveChangesAsync();

                    var cruiseDto = _mapper.Map<BasicCabinTypeCruiseResponseDto>(newItem);
                    scope.Complete();
                    return SuccessSingleResponse<BasicCabinTypeCruiseResponseDto>.Success(cruiseDto, StatusCodeAndErrorsMessagesStandard.Created);
                }
                catch (Exception)
                {
                    return FailResponse.Error(new List<string> { "Transaction failed." }, StatusCodeAndErrorsMessagesStandard.InternalServerError);
                }
            }

        }

        public async Task<IResponse> GetCabinTypeCruises(int cruiseId, int companyId, PaginationSpecParams paginationSpecParams)
        {

            var claims = _tokenService.GetClaimsFromJwt(_httpContext);
            if (claims.ContainsKey("CompanyId") && int.Parse(claims["CompanyId"]) != companyId)
            {
                return FailResponse.Error(new List<string> { StatusCodeAndErrorsMessagesStandard.ForbiddenAccess }, StatusCodeAndErrorsMessagesStandard.BadRequest);

            }



            var spec = new CMSCabinTypeCruiseSpecification(paginationSpecParams, cruiseId);

            var countSpec = new CMSCabinTypeCruiseWithFiltersForCountSpecification(paginationSpecParams, cruiseId);
            var totalItems = await _cabinTypeCruiseRepo.CountAsync(countSpec);
            var items = await _cabinTypeCruiseRepo.ListAsync(spec);
            if (items.Count() <= 0) return FailResponse.Error(new List<string> { StatusCodeAndErrorsMessagesStandard.NoItem }, StatusCodeAndErrorsMessagesStandard.NotFound);


            var data = _mapper.Map<IReadOnlyList<CMSCabinTypeCruiseWithContentResponseDto>>(items);

            return SuccessPaginationResponse<CMSCabinTypeCruiseWithContentResponseDto>.Success(
                    data != null,
                    StatusCodeAndErrorsMessagesStandard.OK,
                    data,
                    paginationSpecParams.PageIndex,
                    paginationSpecParams.PageSize,
                    totalItems
                );
        }
    }
}
