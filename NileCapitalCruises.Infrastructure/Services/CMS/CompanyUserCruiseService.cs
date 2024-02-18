using AutoMapper;
using NileCapitalCruises.Core.ApiModels;
using NileCapitalCruises.Core.IRepositories;
using NileCapitalCruises.Core.Models;
using NileCapitalCruises.Infrastructure.Data.Specification.CMS;
using NileCapitalCruises.Infrastructure.Data.Specification.CMS.CompanyUserSpecification;
using NileCapitalCruises.Infrastructure.Data.Specification.CMS.CompanyUserCruiseSpecification;
using NileCapitalCruises.Infrastructure.Data.Specification.CMS.CruiseSpecification;
using NileCapitalCruises.Infrastructure.Dtos.CMS.RequestDtos.CompanyUserCruiseDtos;
using NileCapitalCruises.Infrastructure.Dtos.CMS.RequestDtos.CompanyUserDtos;
using NileCapitalCruises.Infrastructure.Dtos.CMS.ResponseDtos.CruiseDtos;
using NileCapitalCruises.Infrastructure.Helpers.ApiResponses;
using NileCapitalCruises.Infrastructure.IServices;
using NileCapitalCruises.Infrastructure.IServices.CMS;
using Microsoft.AspNetCore.Http;


namespace NileCapitalCruises.Infrastructure.Services.CMS
{
    public class CompanyUserCruiseService : ICompanyUserCruiseService
    {
        private readonly IGenericRepo<CompanyUserCruise> _companyUserCruiseRepo;
        private readonly IGenericRepo<CompanyUser> _companyUserRepo;
        private readonly IGenericRepo<Cruise> _cruiseRepo;
        private readonly IMapper _mapper;
        private readonly ICruiseService _cruiseService;
        private readonly ICompanyUserService _companyUserService;
        private readonly ITokenService _tokenService;
        private readonly HttpContext _httpContext;

        public CompanyUserCruiseService(
            IGenericRepo<CompanyUserCruise> companyUserCruiseRepo,
            IGenericRepo<CompanyUser> companyUserRepo,
            IMapper mapper,
            ICruiseService cruiseService,
            ICompanyUserService companyUserService,
            ITokenService tokenService,
            IHttpContextAccessor httpContextAccessor,
            IGenericRepo<Cruise> cruiseRepo)
        {
            _companyUserCruiseRepo = companyUserCruiseRepo;
            _companyUserRepo = companyUserRepo;
            _mapper = mapper;
            _tokenService = tokenService;
            _httpContext = httpContextAccessor.HttpContext;
            _cruiseService = cruiseService;
            _companyUserService = companyUserService;
            _cruiseRepo = cruiseRepo;
        }
        public async Task<IResponse> AssignCruiseToUser(int companyId, CompanyUserCruiseRequestDto requestDto)
        {
            var claims = _tokenService.GetClaimsFromJwt(_httpContext);
            if (claims.ContainsKey("CompanyId") && int.Parse(claims["CompanyId"]) != companyId)
            {
                return FailResponse.Error(new List<string> { StatusCodeAndErrorsMessagesStandard.ForbiddenAccess }, StatusCodeAndErrorsMessagesStandard.BadRequest);

            }

            var spec = new CompanyUserCruiseSpecification(requestDto.CompanyUserId, requestDto.CruiseId);
            var existingItem = await _companyUserCruiseRepo.GetEntityWithSpecAsync(spec);

            if (existingItem != null)
                return FailResponse.Error(new List<string> { StatusCodeAndErrorsMessagesStandard.ItemAlreadyExist }, StatusCodeAndErrorsMessagesStandard.NotFound);


            if (!await _cruiseService.IsAvailableAsync(requestDto.CruiseId, companyId))
                return FailResponse.Error(new List<string> { StatusCodeAndErrorsMessagesStandard.InvalidCruiseId }, StatusCodeAndErrorsMessagesStandard.BadRequest);
            
            if (!await _companyUserService.IsAvailableAsync(requestDto.CompanyUserId, companyId))
                return FailResponse.Error(new List<string> { StatusCodeAndErrorsMessagesStandard.InvalidCompanyUserId }, StatusCodeAndErrorsMessagesStandard.BadRequest);

            var request = _mapper.Map<CompanyUserCruise>(requestDto);
            var newItems = await _companyUserCruiseRepo.CreateEntityAsync(request);
            if (newItems == null) return FailResponse.Error(new List<string> { StatusCodeAndErrorsMessagesStandard.ItemNotCreated }, StatusCodeAndErrorsMessagesStandard.BadRequest);
            await _companyUserCruiseRepo.SaveChangesAsync();
            return BaseSuccessResponse.Success(StatusCodeAndErrorsMessagesStandard.OK);

        }

        public async Task<IResponse> RemoveCruiseFromUser(int companyId, CompanyUserCruiseRequestDto requestDto)
        {
            try
            {
                var claims = _tokenService.GetClaimsFromJwt(_httpContext);
                if (claims.ContainsKey("CompanyId") && int.Parse(claims["CompanyId"]) != companyId)
                {
                    return FailResponse.Error(new List<string> { StatusCodeAndErrorsMessagesStandard.ForbiddenAccess }, StatusCodeAndErrorsMessagesStandard.BadRequest);

                }

                var spec = new CompanyUserCruiseSpecification(requestDto.CompanyUserId, requestDto.CruiseId);
                var existingItem = await _companyUserCruiseRepo.GetEntityWithSpecAsync(spec);

                if (existingItem == null)
                    return FailResponse.Error(new List<string> { StatusCodeAndErrorsMessagesStandard.UserNotAssignToCruise }, StatusCodeAndErrorsMessagesStandard.NotFound);

                
                _companyUserCruiseRepo.DeleteSoftEntity(existingItem);
                await _companyUserCruiseRepo.SaveChangesAsync();
                
                return BaseSuccessResponse.Success(StatusCodeAndErrorsMessagesStandard.OK);
            }
            catch (Exception)
            {
                return FailResponse.Error(new List<string> { StatusCodeAndErrorsMessagesStandard.ItemNotDeleted }, StatusCodeAndErrorsMessagesStandard.BadRequest);
            }
            
           

        }

        public async Task<IResponse> GetCruisesForUser(int companyUserId,int companyId, PaginationSpecParams paginationSpecParams)
        {
            var claims = _tokenService.GetClaimsFromJwt(_httpContext);
            if (claims.ContainsKey("CompanyId") && int.Parse(claims["CompanyId"]) != companyId)
            {
                return FailResponse.Error(new List<string> { StatusCodeAndErrorsMessagesStandard.ForbiddenAccess }, StatusCodeAndErrorsMessagesStandard.BadRequest);

            }

            var spec = new CompanyUserSpecification(companyUserId, companyId);
            var user = await _companyUserRepo.GetEntityWithSpecAsync(spec);

            if (user == null)
                return FailResponse.Error(new List<string> { StatusCodeAndErrorsMessagesStandard.InvalidCompanyUserId }, StatusCodeAndErrorsMessagesStandard.BadRequest);

            var cruisesSpec = new CruiseSpecification(paginationSpecParams, companyId, companyUserId);
            var countcruisesSpec = new CruisesWithFiltersForCountSpecification(paginationSpecParams, companyId);
            var totalItems = await _cruiseRepo.CountAsync(countcruisesSpec);
            var items = await _cruiseRepo.ListAsync(cruisesSpec);
            if (items.Count() <= 0) return FailResponse.Error(new List<string> { StatusCodeAndErrorsMessagesStandard.UserNotAssignToAnyCruise }, StatusCodeAndErrorsMessagesStandard.NotFound);


            var data = _mapper.Map<IReadOnlyList<CMSCruiseWithContentResponseDto>>(items);

            return SuccessPaginationResponse<CMSCruiseWithContentResponseDto>.Success(
                    data != null,
                    StatusCodeAndErrorsMessagesStandard.OK,
                    data,
                    paginationSpecParams.PageIndex,
                    paginationSpecParams.PageSize,
                    totalItems
                );
        }


        public async Task<IResponse> GetUsersForCruise(int cruiseId, int companyId, PaginationSpecParams paginationSpecParams)
        {
            var claims = _tokenService.GetClaimsFromJwt(_httpContext);
            if (claims.ContainsKey("CompanyId") && int.Parse(claims["CompanyId"]) != companyId)
            {
                return FailResponse.Error(new List<string> { StatusCodeAndErrorsMessagesStandard.ForbiddenAccess }, StatusCodeAndErrorsMessagesStandard.BadRequest);

            }

            var spec = new CruiseSpecification(cruiseId, companyId);
            var item = await _cruiseRepo.GetEntityWithSpecAsync(spec);

            if (item == null)
                return FailResponse.Error(new List<string> { StatusCodeAndErrorsMessagesStandard.InvalidCruiseId }, StatusCodeAndErrorsMessagesStandard.BadRequest);

            var usersSpec = new CompanyUserSpecification(paginationSpecParams, companyId, cruiseId);
            var countusersSpec = new CompanyUserWithFiltersForCountSpecification(paginationSpecParams, companyId);
            var totalItems = await _companyUserRepo.CountAsync(countusersSpec);
            var items = await _companyUserRepo.ListAsync(usersSpec);
            if (items.Count() <= 0) return FailResponse.Error(new List<string> { StatusCodeAndErrorsMessagesStandard.CruiseNoHaveAnyUserToMangeIt }, StatusCodeAndErrorsMessagesStandard.NotFound);


            var data = _mapper.Map<IReadOnlyList<CompanyUserResponseDto>>(items);

            return SuccessPaginationResponse<CompanyUserResponseDto>.Success(
                    data != null,
                    StatusCodeAndErrorsMessagesStandard.OK,
                    data,
                    paginationSpecParams.PageIndex,
                    paginationSpecParams.PageSize,
                    totalItems
                );
        }

        //public async Task<IResponse> AssignCruiseToUser(int companyId, IEnumerable<CompanyUserCruiseRequestDto> requestDto)
        //{
        //    var claims = _tokenService.GetClaimsFromJwt(_httpContext);
        //    if (claims.ContainsKey("CompanyId") && int.Parse(claims["CompanyId"]) != companyId)
        //    {
        //        return FailResponse.Error(new List<string> { StatusCodeAndErrorsMessagesStandard.ForbiddenAccess }, StatusCodeAndErrorsMessagesStandard.BadRequest);

        //    }

        //    var request = _mapper.Map<IEnumerable<CompanyUserCruise>>(requestDto);
        //    var newItems = await _companyUserCruiseRepo.CreateEntitiesAsync(request);
        //    if (newItems == null) return FailResponse.Error(new List<string> { StatusCodeAndErrorsMessagesStandard.ItemNotCreated }, StatusCodeAndErrorsMessagesStandard.BadRequest);
        //    await _companyUserCruiseRepo.SaveChangesAsync();
        //    return BaseSuccessResponse.Success(StatusCodeAndErrorsMessagesStandard.OK);

        //}
        //public async Task<(List<CompanyUserCruiseRequestDto> existingItems, List<CompanyUserCruise> createdItems)> AssignCruiseToUserTest(IEnumerable<CompanyUserCruiseRequestDto> cruiseRequests)
        //{


        //    var results = await Task.WhenAll(cruiseRequests.Select(async requestDto =>
        //    {
        //        var companyUserCruise = _mapper.Map<CompanyUserCruise>(requestDto);
        //        var isExistingItem = await _companyUserCruiseRepo.AnyAsync(new CompanyUserCruiseSpecification(requestDto.CompanyUserId, requestDto.CruiseId));

        //        return (requestDto, isExistingItem, companyUserCruise);
        //    }));

        //    var existingItems = results
        //          .Where(result => result.isExistingItem)
        //          .Select(result => result.requestDto)
        //          .ToList();

        //    var createdItems = results
        //        .Where(result => !result.isExistingItem)
        //        .Select(result => result.companyUserCruise)
        //        .ToList();

        //    // Add created items to the repository
        //    await _companyUserCruiseRepo.CreateEntitiesAsync(createdItems);
        //    await _companyUserCruiseRepo.SaveChangesAsync();
        //    return (existingItems, createdItems);
        //}



    }
}
