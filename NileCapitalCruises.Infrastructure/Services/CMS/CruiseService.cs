using AutoMapper;
using NileCapitalCruises.Core.IRepositories;
using NileCapitalCruises.Core.Models;
using NileCapitalCruises.Infrastructure.Data.Specification.CMS;
using NileCapitalCruises.Infrastructure.Data.Specification.CMS.CruiseSpecification;
using NileCapitalCruises.Infrastructure.Dtos.CMS.RequestDtos.CruiseDtos;
using NileCapitalCruises.Infrastructure.Dtos.CMS.ResponseDtos.CruiseDtos;
using NileCapitalCruises.Infrastructure.Helpers.ApiResponses;
using NileCapitalCruises.Infrastructure.Helpers.Utils;
using NileCapitalCruises.Infrastructure.IServices;
using NileCapitalCruises.Infrastructure.IServices.CMS;
using Microsoft.AspNetCore.Http;
using Microsoft.AspNetCore.JsonPatch;
using System.Security.Claims;
using System.Transactions;

namespace NileCapitalCruises.Infrastructure.Services.CMS
{
    public class CruiseService : ICruiseService
    {
        private readonly IGenericRepo<CompanyUserCruise> _companyUserCruiseRepo;
        private readonly IGenericRepo<Cruise> _cruiseRepo;
        private readonly IGenericRepo<CruiseContent> _cruiseContentRepo;
        private readonly IGenericRepo<CruisePhoto> _cruisePhotoRepo;
        private readonly IHandleContents<CruiseContent> _handleContent;
        private readonly IMapper _mapper;
        private readonly ITokenService _tokenService;
        private readonly HttpContext _httpContext;
        public CruiseService(
            IGenericRepo<Cruise> cruiseRepo,
            IGenericRepo<CompanyUserCruise> companyUserCruise,
            IGenericRepo<CruiseContent> cruiseContentRepo,
            IGenericRepo<CruisePhoto> cruisePhotoRepo,
            IHandleContents<CruiseContent> handleContent,
            IMapper mapper,
            ITokenService tokenService,
            IHttpContextAccessor httpContextAccessor

            )

        {
            _companyUserCruiseRepo = companyUserCruise;
            _cruiseRepo = cruiseRepo;
            _cruiseContentRepo = cruiseContentRepo;
            _handleContent = handleContent;
            _mapper = mapper;
            _tokenService = tokenService;
            _httpContext = httpContextAccessor.HttpContext;
            _cruisePhotoRepo = cruisePhotoRepo;
        }

        public async Task<IResponse> GetCruise(int cruiseId, int companyId)
        {
            var claims = _tokenService.GetClaimsFromJwt(_httpContext);
            if (claims.ContainsKey("CompanyId") && int.Parse(claims["CompanyId"]) != companyId)
            {
                return FailResponse.Error(new List<string> { StatusCodeAndErrorsMessagesStandard.ForbiddenAccess }, StatusCodeAndErrorsMessagesStandard.BadRequest);

            }

            var spec = new CruiseSpecification(cruiseId, companyId);
            var cruise = await _cruiseRepo.GetEntityWithSpecAsync(spec);
            if (cruise == null) return FailResponse.Error(new List<string> { StatusCodeAndErrorsMessagesStandard.NoItem }, StatusCodeAndErrorsMessagesStandard.NotFound);
            var cruiseDto = _mapper.Map<BasicCruiseResponseDto>(cruise);
            return SuccessSingleResponse<BasicCruiseResponseDto>.Success(cruiseDto, StatusCodeAndErrorsMessagesStandard.OK);
        }

        public async Task<IResponse> GetCruiseContent(int cruiseId,int companyId, string languageCode = "en")
        {
            var claims = _tokenService.GetClaimsFromJwt(_httpContext);
            if (claims.ContainsKey("CompanyId") && int.Parse(claims["CompanyId"]) != companyId)
            {
                return FailResponse.Error(new List<string> { StatusCodeAndErrorsMessagesStandard.ForbiddenAccess }, StatusCodeAndErrorsMessagesStandard.BadRequest);

            }

            var spec = new CruiseContentSpecification(cruiseId, languageCode);
            var item = await _cruiseContentRepo.GetEntityWithSpecAsync(spec);
            if (item == null) return FailResponse.Error(new List<string> { StatusCodeAndErrorsMessagesStandard.NoItem }, StatusCodeAndErrorsMessagesStandard.NotFound);
            var itemDto = _mapper.Map<CruiseContentResponseDto>(item);
            return SuccessSingleResponse<CruiseContentResponseDto>.Success(itemDto, StatusCodeAndErrorsMessagesStandard.OK);
        }

        public async Task<IResponse> UpdateCruiseContent(int cruiseId, int companyId, CruiseContentRequestDto requestDto, string languageCode = "en")
        {
            var claims = _tokenService.GetClaimsFromJwt(_httpContext);
            if (claims.ContainsKey("CompanyId") && int.Parse(claims["CompanyId"]) != companyId)
            {
                return FailResponse.Error(new List<string> { StatusCodeAndErrorsMessagesStandard.ForbiddenAccess }, StatusCodeAndErrorsMessagesStandard.BadRequest);

            }
            var spec = new CruiseContentSpecification(cruiseId, languageCode);
            var item = await _cruiseContentRepo.GetEntityWithSpecAsync(spec);
            if (item == null) return FailResponse.Error(new List<string> { StatusCodeAndErrorsMessagesStandard.NoItem }, StatusCodeAndErrorsMessagesStandard.NotFound);
            _mapper.Map(requestDto, item);

            try
            {

                _cruiseContentRepo.UpdateEntity(item);
                await _cruiseContentRepo.SaveChangesAsync();

                var updatedDto = _mapper.Map<CruiseContentResponseDto>(item);

                return SuccessSingleResponse<CruiseContentResponseDto>.Success(updatedDto, StatusCodeAndErrorsMessagesStandard.OK);
            }
            catch (Exception)
            {
                return FailResponse.Error(new List<string> { StatusCodeAndErrorsMessagesStandard.ItemNotUpdated }, StatusCodeAndErrorsMessagesStandard.BadRequest);
            }


        }

        public async Task<IResponse> GetCruisePhotos(int cruiseId, int companyId)
        {
            var claims = _tokenService.GetClaimsFromJwt(_httpContext);
            if (claims.ContainsKey("CompanyId") && int.Parse(claims["CompanyId"]) != companyId)
            {
                return FailResponse.Error(new List<string> { StatusCodeAndErrorsMessagesStandard.ForbiddenAccess }, StatusCodeAndErrorsMessagesStandard.BadRequest);

            }

            var spec = new CruisePhotoSpecification(null,cruiseId);
            var items = await _cruisePhotoRepo.ListAsync(spec);
            if (items.Count() <= 0) return FailResponse.Error(new List<string> { StatusCodeAndErrorsMessagesStandard.NoItem }, StatusCodeAndErrorsMessagesStandard.NotFound);
            var itemsDto = _mapper.Map< IEnumerable<CruisePhotoResponseDto>>(items);
            return SuccessSingleResponse< IEnumerable<CruisePhotoResponseDto>>.Success(itemsDto, StatusCodeAndErrorsMessagesStandard.OK);
        }

        public async Task<IResponse> CreateCruisePhotos(int cruiseId, int companyId, IEnumerable<CruisePhotoRequestDto> requestDto)
        {
            var claims = _tokenService.GetClaimsFromJwt(_httpContext);
            if (claims.ContainsKey("CompanyId") && int.Parse(claims["CompanyId"]) != companyId)
            {
                return FailResponse.Error(new List<string> { StatusCodeAndErrorsMessagesStandard.ForbiddenAccess }, StatusCodeAndErrorsMessagesStandard.BadRequest);

            }

          

            var newItems = _mapper.Map<IEnumerable<CruisePhoto>>(requestDto);

            try
            {

                await _cruisePhotoRepo.CreateEntitiesAsync(newItems);
                await _cruisePhotoRepo.SaveChangesAsync();

                var createdDto = _mapper.Map<IEnumerable<CruisePhotoResponseDto>>(newItems);

                return SuccessSingleResponse<IEnumerable<CruisePhotoResponseDto>>.Success(createdDto, StatusCodeAndErrorsMessagesStandard.OK);
            }
            catch (Exception)
            {
                return FailResponse.Error(new List<string> { StatusCodeAndErrorsMessagesStandard.ItemNotUpdated }, StatusCodeAndErrorsMessagesStandard.BadRequest);
            }


        }



        public async Task<IResponse> DeleteCruisePhoto(int photoId,int companyId)
        {
           
                try
                {
                    var claims = _tokenService.GetClaimsFromJwt(_httpContext);
                    if (claims.ContainsKey("CompanyId") && int.Parse(claims["CompanyId"]) != companyId)
                    {
                        return FailResponse.Error(new List<string> { StatusCodeAndErrorsMessagesStandard.ForbiddenAccess }, StatusCodeAndErrorsMessagesStandard.BadRequest);

                    }

                    var spec = new CruisePhotoSpecification(photoId,null);
                    var existingItem = await _cruisePhotoRepo.GetEntityWithSpecAsync(spec);

                   

                    if (existingItem == null)
                        return FailResponse.Error(new List<string> { StatusCodeAndErrorsMessagesStandard.NoItem }, StatusCodeAndErrorsMessagesStandard.NotFound);


                    _cruisePhotoRepo.DeleteSoftEntity(existingItem);

                    await _cruisePhotoRepo.SaveChangesAsync();
                   

                   
                    return BaseSuccessResponse.Success(StatusCodeAndErrorsMessagesStandard.OK);
                }
                catch (Exception)
                {
                    return FailResponse.Error(new List<string> { StatusCodeAndErrorsMessagesStandard.ItemNotDeleted }, StatusCodeAndErrorsMessagesStandard.BadRequest);
                }
            


        }




        //public async Task<IResponse> UpdateCruisePhotos(int cruiseId, int companyId, IEnumerable<CruisePhotoRequestDto> requestDto)
        //{
        //    var claims = _tokenService.GetClaimsFromJwt(_httpContext);
        //    if (claims.ContainsKey("CompanyId") && int.Parse(claims["CompanyId"]) != companyId)
        //    {
        //        return FailResponse.Error(new List<string> { StatusCodeAndErrorsMessagesStandard.ForbiddenAccess }, StatusCodeAndErrorsMessagesStandard.BadRequest);

        //    }

        //    var spec = new CruisePhotoSpecification(cruiseId);

        //    var OldItems = await _cruisePhotoRepo.ListAsync(spec);

        //    if (OldItems.Count() > 0)
        //    {
        //        _cruisePhotoRepo.DeleteEntities(OldItems);
        //        await _cruisePhotoRepo.SaveChangesAsync();
        //    }

        //    var newItems = _mapper.Map<IEnumerable<CruisePhoto>>(requestDto);

        //    try
        //    {

        //        await _cruisePhotoRepo.CreateEntitiesAsync(newItems);
        //        await _cruisePhotoRepo.SaveChangesAsync();

        //        var updatedDto = _mapper.Map< IEnumerable<CruisePhotoResponseDto>>(newItems);

        //        return SuccessSingleResponse< IEnumerable<CruisePhotoResponseDto>>.Success(updatedDto, StatusCodeAndErrorsMessagesStandard.OK);
        //    }
        //    catch (Exception)
        //    {
        //        return FailResponse.Error(new List<string> { StatusCodeAndErrorsMessagesStandard.ItemNotUpdated }, StatusCodeAndErrorsMessagesStandard.BadRequest);
        //    }


        //}

        public async Task<IResponse> GetCruiseByUrlName(string cruiseUrl, string languageCode = "en")
        {
            var cruiseUrlSpec = new CruiseSpecification(cruiseUrl);
            var cruiseByUrl = await _cruiseRepo.GetEntityWithSpecAsync(cruiseUrlSpec);

            var spec = new CruiseSpecification(cruiseByUrl.Id, languageCode, _mapper);
            var cruise = await _cruiseRepo.GetEntityWithSpecAsync(spec);
            if (cruise == null) return FailResponse.Error(new List<string> { StatusCodeAndErrorsMessagesStandard.NoItem }, StatusCodeAndErrorsMessagesStandard.NotFound);
            var cruiseDto = _mapper.Map<CruisesResponseDto>(cruise);
            return SuccessSingleResponse<CruisesResponseDto>.Success(cruiseDto, StatusCodeAndErrorsMessagesStandard.OK);
        }

        
        //public async Task<IResponse> RemoveCruiseFromUser(int companyId, CruiseToUserRequestDto requestDto)
        //{
        //    var claims = _tokenService.GetClaimsFromJwt(_httpContext);
        //    if (claims.ContainsKey("CompanyId") && int.Parse(claims["CompanyId"]) != companyId)
        //    {
        //        return FailResponse.Error(new List<string> { StatusCodeAndErrorsMessagesStandard.ForbiddenAccess }, StatusCodeAndErrorsMessagesStandard.BadRequest);
        //    }
            
        //    var request = _mapper.Map<IEnumerable<CompanyUserCruise>>(requestDto.CompanyUserCruises);
        //    _companyUserCruiseRepo.DeleteSoftEntities(request);
        //    await _companyUserCruiseRepo.SaveChangesAsync();
        //    return BaseSuccessResponse.Success(StatusCodeAndErrorsMessagesStandard.OK);

        //}
        public async Task<IResponse> GetCruises(int companyId,PaginationSpecParams paginationSpecParams)
        {

            var claims = _tokenService.GetClaimsFromJwt(_httpContext);
            if (claims.ContainsKey("CompanyId") && int.Parse(claims["CompanyId"]) != companyId)
            {
                return FailResponse.Error(new List<string> { StatusCodeAndErrorsMessagesStandard.ForbiddenAccess }, StatusCodeAndErrorsMessagesStandard.BadRequest);

            }

            // Check if companyUserId is present in claims
           
            int? companyUserId = null;

            Console.WriteLine("Claims:");
            if (claims.ContainsKey("CompanyUserId") && claims.ContainsKey(ClaimTypes.Role) && claims[ClaimTypes.Role].Contains("CompanyUser"))
            {
                companyUserId = int.Parse(claims["CompanyUserId"]);
            }

            // Create CruiseSpecification with or without companyUserId based on its availability
            var spec = companyUserId.HasValue
                ? new CruiseSpecification(paginationSpecParams, companyId, companyUserId)
                : new CruiseSpecification(paginationSpecParams, companyId, null);

            var countSpec = new CruisesWithFiltersForCountSpecification(paginationSpecParams, companyId);
            var totalItems = await _cruiseRepo.CountAsync(countSpec);
            var items = await _cruiseRepo.ListAsync(spec);
            if (items.Count() <= 0) return FailResponse.Error(new List<string> { StatusCodeAndErrorsMessagesStandard.NoItem }, StatusCodeAndErrorsMessagesStandard.NotFound);
           

            var data = _mapper.Map<IReadOnlyList<CruiseWithContentResponseDto>>(items);

            return SuccessPaginationResponse<CruiseWithContentResponseDto>.Success(
                    data != null,
                    StatusCodeAndErrorsMessagesStandard.OK,
                    data,
                    paginationSpecParams.PageIndex,
                    paginationSpecParams.PageSize,
                    totalItems
                );
        }



        public async Task<IResponse> CreateCruise(CruiseRequestDto requestDto, int companyId)
        {
            using (var scope = new TransactionScope(TransactionScopeAsyncFlowOption.Enabled))
            {
                try
                {
                    var request = _mapper.Map<Cruise>(requestDto);
                    var claims = _tokenService.GetClaimsFromJwt(_httpContext);
                    if (claims.ContainsKey("CompanyId") && int.Parse(claims["CompanyId"]) != companyId)
                    {
                        return FailResponse.Error(new List<string> { StatusCodeAndErrorsMessagesStandard.ForbiddenAccess }, StatusCodeAndErrorsMessagesStandard.BadRequest);
                        
                    }
                    request.CompanyId = companyId;

                    var newItem = await _cruiseRepo.CreateEntityAsync(request);
                    if (newItem == null) return FailResponse.Error(new List<string> { StatusCodeAndErrorsMessagesStandard.ItemNotCreated }, StatusCodeAndErrorsMessagesStandard.BadRequest);
                    newItem.CruiseUrl = HandleUrlsName.CreateUrlByName(newItem.CruiseNameSys);

                    await _cruiseRepo.SaveChangesAsync();

                    // For Creating Content based on the numbers of master language table
                    await _handleContent.CreateContents(newItem.Id, newItem.CruiseContents);

                    await _cruiseRepo.SaveChangesAsync();

                    var cruiseDto = _mapper.Map<BasicCruiseResponseDto>(newItem);
                    scope.Complete();
                    return SuccessSingleResponse<BasicCruiseResponseDto>.Success(cruiseDto, StatusCodeAndErrorsMessagesStandard.Created);
                }
                catch (Exception)
                {
                    return FailResponse.Error(new List<string> { "Transaction failed." }, StatusCodeAndErrorsMessagesStandard.InternalServerError);
                }
            }

        }

        public async Task<IResponse> UpdateCruise(int cruiseId,int companyId, CruiseRequestDto requestDto)
        {

            try
            {
                var spec = new CruiseSpecification(cruiseId, companyId);
                var existingItem = await _cruiseRepo.GetEntityWithSpecAsync(spec);

                if (existingItem == null)
                    return FailResponse.Error(new List<string> { StatusCodeAndErrorsMessagesStandard.NoItem }, StatusCodeAndErrorsMessagesStandard.NotFound);

                _mapper.Map(requestDto, existingItem);

                _cruiseRepo.UpdateEntity(existingItem);
                await _cruiseRepo.SaveChangesAsync();

                var updatedDto = _mapper.Map<BasicCruiseResponseDto>(existingItem);

                return SuccessSingleResponse<BasicCruiseResponseDto>.Success(updatedDto, StatusCodeAndErrorsMessagesStandard.OK);
            }
            catch (Exception)
            {
                return FailResponse.Error(new List<string> { StatusCodeAndErrorsMessagesStandard.ItemNotUpdated }, StatusCodeAndErrorsMessagesStandard.BadRequest);
            }
        }


       
        public async Task<IResponse> DeleteCruise(int cruiseId, int companyId)
        {
            using (var scope = new TransactionScope(TransactionScopeAsyncFlowOption.Enabled))
            {
                try
                {
                    var spec = new CruiseSpecification(cruiseId, companyId);
                    var existingItem = await _cruiseRepo.GetEntityWithSpecAsync(spec);

                    if (existingItem == null)
                        return FailResponse.Error(new List<string> { StatusCodeAndErrorsMessagesStandard.NoItem }, StatusCodeAndErrorsMessagesStandard.NotFound);

                    var specContent = new CruiseContentSpecification(companyId);
                    var relatedItems = await _cruiseContentRepo.ListAsync(specContent);

                    relatedItems.Select(item =>
                    {
                        _cruiseContentRepo.DeleteSoftEntity(item);
                        return item;
                    }).ToList();

                    _cruiseRepo.DeleteSoftEntity(existingItem);

                    // Use ForEach to apply soft delete to each related item

                    await _cruiseRepo.SaveChangesAsync();
                    await _cruiseContentRepo.SaveChangesAsync();

                    scope.Complete();
                    return BaseSuccessResponse.Success(StatusCodeAndErrorsMessagesStandard.OK);
                }
                catch (Exception)
                {
                    return FailResponse.Error(new List<string> { StatusCodeAndErrorsMessagesStandard.ItemNotDeleted }, StatusCodeAndErrorsMessagesStandard.BadRequest);
                }
            }

        }




        public async Task<IResponse> UpdatePatchCruise(int id, JsonPatchDocument model)
        {
            var cruise = await _cruiseRepo.GetByIdAsync(id);
            if (cruise == null) return FailResponse.Error(new List<string> { StatusCodeAndErrorsMessagesStandard.NoItem }, StatusCodeAndErrorsMessagesStandard.NotFound);

            _cruiseRepo.UpdatePatchEntity(model, cruise);

            await _cruiseRepo.SaveChangesAsync();
            return BaseSuccessResponse.Success( StatusCodeAndErrorsMessagesStandard.Created);

        }

        public async Task<IResponse> UpdatePatchCruiseContent(int id, string languageCode, JsonPatchDocument model)
        {
            var spec = new CruiseSpecification(id, languageCode, _mapper);
            var cruise = await _cruiseRepo.GetEntityWithSpecAsync(spec);
            var cruiseContent = cruise.CruiseContents.FirstOrDefault();
            if (cruise == null) return FailResponse.Error(new List<string> { StatusCodeAndErrorsMessagesStandard.NoItem }, StatusCodeAndErrorsMessagesStandard.NotFound);
            
            _cruiseContentRepo.UpdatePatchEntity(model, cruiseContent);
            await _cruiseRepo.SaveChangesAsync();
            return BaseSuccessResponse.Success( StatusCodeAndErrorsMessagesStandard.Created);

        }


        public async Task<bool> IsAvailableAsync(int cruiseId, int companyId)
        {
            var spec = new CruiseSpecification(cruiseId, companyId);
            return await  _cruiseRepo.AnyAsync(spec);
        }



        public async Task<IResponse> DeleteCruisePhotos(int cruiseId, int companyId)
        {

            try
            {
                var claims = _tokenService.GetClaimsFromJwt(_httpContext);
                if (claims.ContainsKey("CompanyId") && int.Parse(claims["CompanyId"]) != companyId)
                {
                    return FailResponse.Error(new List<string> { StatusCodeAndErrorsMessagesStandard.ForbiddenAccess }, StatusCodeAndErrorsMessagesStandard.BadRequest);

                }

                var spec = new CruiseSpecification(cruiseId, companyId);
                var existingItem = await _cruiseRepo.GetEntityWithSpecAsync(spec);



                if (existingItem == null)
                    return FailResponse.Error(new List<string> { StatusCodeAndErrorsMessagesStandard.NoItem }, StatusCodeAndErrorsMessagesStandard.NotFound);


                var specPhotos = new CruisePhotoSpecification(null, cruiseId);
                var photoItems = await _cruisePhotoRepo.ListAsync(specPhotos);
                if (photoItems.Count() <= 0) return FailResponse.Error(new List<string> { StatusCodeAndErrorsMessagesStandard.NoPhoto }, StatusCodeAndErrorsMessagesStandard.NotFound);


                _cruisePhotoRepo.DeleteSoftEntities(photoItems);

                await _cruisePhotoRepo.SaveChangesAsync();



                return BaseSuccessResponse.Success(StatusCodeAndErrorsMessagesStandard.OK);
            }
            catch (Exception)
            {
                return FailResponse.Error(new List<string> { StatusCodeAndErrorsMessagesStandard.ItemNotDeleted }, StatusCodeAndErrorsMessagesStandard.BadRequest);
            }



        }
    }
}
