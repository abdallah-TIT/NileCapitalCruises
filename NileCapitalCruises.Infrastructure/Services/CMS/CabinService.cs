
using AutoMapper;
using NileCapitalCruises.Core.IRepositories;
using NileCapitalCruises.Core.Models;
using NileCapitalCruises.Infrastructure.Data.Specification.CMS;
using NileCapitalCruises.Infrastructure.Data.Specification.CMS.CabinSpecification;
using NileCapitalCruises.Infrastructure.Data.Specification.CMS.DiningSpecification;
using NileCapitalCruises.Infrastructure.Dtos.CMS.RequestDtos.AmenityDtos;
using NileCapitalCruises.Infrastructure.Dtos.CMS.RequestDtos.CabinDtos;
using NileCapitalCruises.Infrastructure.Dtos.CMS.ResponseDtos.CabinDtos;
using NileCapitalCruises.Infrastructure.Dtos.CMS.ResponseDtos.CabinTypeCruiseDtos;
using NileCapitalCruises.Infrastructure.Helpers.ApiResponses;
using NileCapitalCruises.Infrastructure.Helpers.Utils;
using NileCapitalCruises.Infrastructure.IServices;
using NileCapitalCruises.Infrastructure.IServices.CMS;
using Microsoft.AspNetCore.Http;
using System.Transactions;

namespace NileCapitalCruises.Infrastructure.Services.CMS
{
    public class CabinService : ICabinService
    {
        private readonly IGenericRepo<Cabin> _cabinRepo;
        private readonly IHandleContents<CabinContent> _handleContent;
        private readonly IGenericRepo<CabinContent> _cabinContentRepo;
        private readonly HttpContext _httpContext;
        private readonly ITokenService _tokenService;
        private readonly IMapper _mapper;
        private readonly IGenericRepo<CabinPhoto> _cabinPhotoRepo;

        public CabinService(
            IGenericRepo<Cabin> cabinRepo,
            IGenericRepo<CabinContent> cabinContentRepo,
            IHandleContents<CabinContent> handleContent,
            IHttpContextAccessor httpContextAccessor,
             ITokenService tokenService,
            IMapper mapper,
            IGenericRepo<CabinPhoto> cabinPhotoRepo)
        {
            _cabinRepo = cabinRepo;
            _cabinContentRepo = cabinContentRepo;
            _handleContent = handleContent;
            _httpContext = httpContextAccessor.HttpContext;
            _tokenService = tokenService;
            _mapper = mapper;
            _cabinPhotoRepo = cabinPhotoRepo;
        }


        public async Task<IResponse> CreateCabin(CabinRequestDto requestDto, int companyId)
        {
            using (var scope = new TransactionScope(TransactionScopeAsyncFlowOption.Enabled))
            {
                try
                {
                    var request = _mapper.Map<Cabin>(requestDto);
                    var claims = _tokenService.GetClaimsFromJwt(_httpContext);
                    if (claims.ContainsKey("CompanyId") && int.Parse(claims["CompanyId"]) != companyId)
                    {
                        return FailResponse.Error(new List<string> { StatusCodeAndErrorsMessagesStandard.ForbiddenAccess }, StatusCodeAndErrorsMessagesStandard.BadRequest);

                    }
                    

                    var newItem = await _cabinRepo.CreateEntityAsync(request);
                    if (newItem == null) return FailResponse.Error(new List<string> { StatusCodeAndErrorsMessagesStandard.ItemNotCreated }, StatusCodeAndErrorsMessagesStandard.BadRequest);
                    newItem.CabinUrl = HandleUrlsName.CreateUrlByName(newItem.CabinNameSys);

                    await _cabinRepo.SaveChangesAsync();

                    // For Creating Content based on the numbers of master language table
                    await _handleContent.CreateContents(newItem.Id, newItem.CabinContents);

                    await _cabinRepo.SaveChangesAsync();

                    var cabinDto = _mapper.Map<BasicCabinResponseDto>(newItem);
                    scope.Complete();
                    return SuccessSingleResponse<BasicCabinResponseDto>.Success(cabinDto, StatusCodeAndErrorsMessagesStandard.Created);
                }
                catch (Exception)
                {
                    return FailResponse.Error(new List<string> { "Transaction failed." }, StatusCodeAndErrorsMessagesStandard.InternalServerError);
                }
            }

        }


        public async Task<IResponse> UpdateCabin(int cabinId, int companyId, CabinRequestDto requestDto)
        {

            try
            {
               
                var claims = _tokenService.GetClaimsFromJwt(_httpContext);
                if (claims.ContainsKey("CompanyId") && int.Parse(claims["CompanyId"]) != companyId)
                {
                    return FailResponse.Error(new List<string> { StatusCodeAndErrorsMessagesStandard.ForbiddenAccess }, StatusCodeAndErrorsMessagesStandard.BadRequest);

                }

                var spec = new CabinSpecification(cabinId);
                var existingItem = await _cabinRepo.GetEntityWithSpecAsync(spec);

                if (existingItem == null)
                    return FailResponse.Error(new List<string> { StatusCodeAndErrorsMessagesStandard.NoItem }, StatusCodeAndErrorsMessagesStandard.NotFound);

                _mapper.Map(requestDto, existingItem);

                _cabinRepo.UpdateEntity(existingItem);
                await _cabinRepo.SaveChangesAsync();

                var updatedDto = _mapper.Map<BasicCabinResponseDto>(existingItem);

                return SuccessSingleResponse<BasicCabinResponseDto>.Success(updatedDto, StatusCodeAndErrorsMessagesStandard.OK);
            }
            catch (Exception)
            {
                return FailResponse.Error(new List<string> { StatusCodeAndErrorsMessagesStandard.ItemNotUpdated }, StatusCodeAndErrorsMessagesStandard.BadRequest);
            }
        }

        public async Task<IResponse> DeleteCabin(int cabinId, int companyId)
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

                    var spec = new CabinSpecification(cabinId);
                    var existingItem = await _cabinRepo.GetEntityWithSpecAsync(spec);

                    if (existingItem == null)
                        return FailResponse.Error(new List<string> { StatusCodeAndErrorsMessagesStandard.NoItem }, StatusCodeAndErrorsMessagesStandard.NotFound);

                    var specContent = new CabinContentSpecification(cabinId);
                    var relatedItems = await _cabinContentRepo.ListAsync(specContent);

                    relatedItems.Select(item =>
                    {
                        _cabinContentRepo.DeleteSoftEntity(item);
                        return item;
                    }).ToList();

                    _cabinRepo.DeleteSoftEntity(existingItem);

                    // Use ForEach to apply soft delete to each related item

                    await _cabinRepo.SaveChangesAsync();
                    await _cabinContentRepo.SaveChangesAsync();

                    scope.Complete();
                    return BaseSuccessResponse.Success(StatusCodeAndErrorsMessagesStandard.OK);
                }
                catch (Exception)
                {
                    return FailResponse.Error(new List<string> { StatusCodeAndErrorsMessagesStandard.ItemNotDeleted }, StatusCodeAndErrorsMessagesStandard.BadRequest);
                }
            }

        }


        public async Task<IResponse> GetCabins(int cruiseId,int companyId, PaginationSpecParams paginationSpecParams)
        {

            var claims = _tokenService.GetClaimsFromJwt(_httpContext);
            if (claims.ContainsKey("CompanyId") && int.Parse(claims["CompanyId"]) != companyId)
            {
                return FailResponse.Error(new List<string> { StatusCodeAndErrorsMessagesStandard.ForbiddenAccess }, StatusCodeAndErrorsMessagesStandard.BadRequest);

            }

           

            var spec = new CabinSpecification(paginationSpecParams, cruiseId);

            var countSpec = new CabinsWithFiltersForCountSpecification(paginationSpecParams, companyId);
            var totalItems = await _cabinRepo.CountAsync(countSpec);
            var items = await _cabinRepo.ListAsync(spec);
            if (items.Count() <= 0) return FailResponse.Error(new List<string> { StatusCodeAndErrorsMessagesStandard.NoItem }, StatusCodeAndErrorsMessagesStandard.NotFound);


            var data = _mapper.Map<IReadOnlyList<CabinWithContentResponseDto>>(items);

            return SuccessPaginationResponse<CabinWithContentResponseDto>.Success(
                    data != null,
                    StatusCodeAndErrorsMessagesStandard.OK,
                    data,
                    paginationSpecParams.PageIndex,
                    paginationSpecParams.PageSize,
                    totalItems
                );
        }

        public async Task<IResponse> GetCabin(int cabinId, int companyId)
        {
            var claims = _tokenService.GetClaimsFromJwt(_httpContext);
            if (claims.ContainsKey("CompanyId") && int.Parse(claims["CompanyId"]) != companyId)
            {
                return FailResponse.Error(new List<string> { StatusCodeAndErrorsMessagesStandard.ForbiddenAccess }, StatusCodeAndErrorsMessagesStandard.BadRequest);

            }

            var spec = new CabinSpecification(cabinId);
            var item = await _cabinRepo.GetEntityWithSpecAsync(spec);
            if (item == null) return FailResponse.Error(new List<string> { StatusCodeAndErrorsMessagesStandard.NoItem }, StatusCodeAndErrorsMessagesStandard.NotFound);
            var itemDto = _mapper.Map<BasicCabinResponseDto>(item);
            return SuccessSingleResponse<BasicCabinResponseDto>.Success(itemDto, StatusCodeAndErrorsMessagesStandard.OK);
        }

        public async Task<IResponse> GetCabinContent(int cabinId, int companyId, string languageCode = "en")
        {
            var claims = _tokenService.GetClaimsFromJwt(_httpContext);
            if (claims.ContainsKey("CompanyId") && int.Parse(claims["CompanyId"]) != companyId)
            {
                return FailResponse.Error(new List<string> { StatusCodeAndErrorsMessagesStandard.ForbiddenAccess }, StatusCodeAndErrorsMessagesStandard.BadRequest);

            }

            var spec = new CabinContentSpecification(cabinId, languageCode);
            var item = await _cabinContentRepo.GetEntityWithSpecAsync(spec);
            if (item == null) return FailResponse.Error(new List<string> { StatusCodeAndErrorsMessagesStandard.NoItem }, StatusCodeAndErrorsMessagesStandard.NotFound);
            var itemDto = _mapper.Map<CabinContentResponseDto>(item);
            return SuccessSingleResponse<CabinContentResponseDto>.Success(itemDto, StatusCodeAndErrorsMessagesStandard.OK);
        }


        public async Task<IResponse> UpdateCabinContent(int cabinId, int companyId, CabinContentRequestDto requestDto, string languageCode = "en")
        {
            var claims = _tokenService.GetClaimsFromJwt(_httpContext);
            if (claims.ContainsKey("CompanyId") && int.Parse(claims["CompanyId"]) != companyId)
            {
                return FailResponse.Error(new List<string> { StatusCodeAndErrorsMessagesStandard.ForbiddenAccess }, StatusCodeAndErrorsMessagesStandard.BadRequest);

            }
            var spec = new CabinContentSpecification(cabinId, languageCode);
            var item = await _cabinContentRepo.GetEntityWithSpecAsync(spec);
            if (item == null) return FailResponse.Error(new List<string> { StatusCodeAndErrorsMessagesStandard.NoItem }, StatusCodeAndErrorsMessagesStandard.NotFound);
            _mapper.Map(requestDto, item);

            try
            {

                _cabinContentRepo.UpdateEntity(item);
                await _cabinContentRepo.SaveChangesAsync();

                var updatedDto = _mapper.Map<CabinContentResponseDto>(item);

                return SuccessSingleResponse<CabinContentResponseDto>.Success(updatedDto, StatusCodeAndErrorsMessagesStandard.OK);
            }
            catch (Exception)
            {
                return FailResponse.Error(new List<string> { StatusCodeAndErrorsMessagesStandard.ItemNotUpdated }, StatusCodeAndErrorsMessagesStandard.BadRequest);
            }


        }

        public async Task<IResponse> GetCabinPhotos(int cabinId, int companyId)
        {
            var claims = _tokenService.GetClaimsFromJwt(_httpContext);
            if (claims.ContainsKey("CompanyId") && int.Parse(claims["CompanyId"]) != companyId)
            {
                return FailResponse.Error(new List<string> { StatusCodeAndErrorsMessagesStandard.ForbiddenAccess }, StatusCodeAndErrorsMessagesStandard.BadRequest);

            }

            var spec = new CabinPhotoSpecification(null, cabinId);
            var items = await _cabinPhotoRepo.ListAsync(spec);
            if (items.Count() <= 0) return FailResponse.Error(new List<string> { StatusCodeAndErrorsMessagesStandard.NoItem }, StatusCodeAndErrorsMessagesStandard.NotFound);
            var itemsDto = _mapper.Map<IEnumerable<CabinPhotoResponseDto>>(items);
            return SuccessSingleResponse<IEnumerable<CabinPhotoResponseDto>>.Success(itemsDto, StatusCodeAndErrorsMessagesStandard.OK);
        }


        public async Task<IResponse> CreateCabinPhotos(int cabinId, int companyId, IEnumerable<CabinPhotoRequestDto> requestDto)
        {
            var claims = _tokenService.GetClaimsFromJwt(_httpContext);
            if (claims.ContainsKey("CompanyId") && int.Parse(claims["CompanyId"]) != companyId)
            {
                return FailResponse.Error(new List<string> { StatusCodeAndErrorsMessagesStandard.ForbiddenAccess }, StatusCodeAndErrorsMessagesStandard.BadRequest);

            }



            var newItems = _mapper.Map<IEnumerable<CabinPhoto>>(requestDto);

            try
            {

                await _cabinPhotoRepo.CreateEntitiesAsync(newItems);
                await _cabinPhotoRepo.SaveChangesAsync();

                var createdDto = _mapper.Map<IEnumerable<CabinPhotoResponseDto>>(newItems);

                return SuccessSingleResponse<IEnumerable<CabinPhotoResponseDto>>.Success(createdDto, StatusCodeAndErrorsMessagesStandard.OK);
            }
            catch (Exception)
            {
                return FailResponse.Error(new List<string> { StatusCodeAndErrorsMessagesStandard.ItemNotUpdated }, StatusCodeAndErrorsMessagesStandard.BadRequest);
            }


        }

        public async Task<IResponse> DeleteCabinPhoto(int photoId, int companyId)
        {

            try
            {
                var claims = _tokenService.GetClaimsFromJwt(_httpContext);
                if (claims.ContainsKey("CompanyId") && int.Parse(claims["CompanyId"]) != companyId)
                {
                    return FailResponse.Error(new List<string> { StatusCodeAndErrorsMessagesStandard.ForbiddenAccess }, StatusCodeAndErrorsMessagesStandard.BadRequest);

                }

                var spec = new CabinPhotoSpecification(photoId, null);
                var existingItem = await _cabinPhotoRepo.GetEntityWithSpecAsync(spec);



                if (existingItem == null)
                    return FailResponse.Error(new List<string> { StatusCodeAndErrorsMessagesStandard.NoItem }, StatusCodeAndErrorsMessagesStandard.NotFound);


                _cabinPhotoRepo.DeleteSoftEntity(existingItem);

                await _cabinPhotoRepo.SaveChangesAsync();



                return BaseSuccessResponse.Success(StatusCodeAndErrorsMessagesStandard.OK);
            }
            catch (Exception)
            {
                return FailResponse.Error(new List<string> { StatusCodeAndErrorsMessagesStandard.ItemNotDeleted }, StatusCodeAndErrorsMessagesStandard.BadRequest);
            }



        }


        public async Task<IResponse> DeleteCabinPhotos(int cabinId, int companyId)
        {

            try
            {
                var claims = _tokenService.GetClaimsFromJwt(_httpContext);
                if (claims.ContainsKey("CompanyId") && int.Parse(claims["CompanyId"]) != companyId)
                {
                    return FailResponse.Error(new List<string> { StatusCodeAndErrorsMessagesStandard.ForbiddenAccess }, StatusCodeAndErrorsMessagesStandard.BadRequest);

                }

                var spec = new CabinSpecification(cabinId);
                var existingItem = await _cabinRepo.GetEntityWithSpecAsync(spec);



                if (existingItem == null)
                    return FailResponse.Error(new List<string> { StatusCodeAndErrorsMessagesStandard.NoItem }, StatusCodeAndErrorsMessagesStandard.NotFound);


                var specPhotos = new CabinPhotoSpecification(null, cabinId);
                var photoItems = await _cabinPhotoRepo.ListAsync(specPhotos);
                if (photoItems.Count() <= 0) return FailResponse.Error(new List<string> { StatusCodeAndErrorsMessagesStandard.NoPhoto }, StatusCodeAndErrorsMessagesStandard.NotFound);


                _cabinPhotoRepo.DeleteSoftEntities(photoItems);

                await _cabinPhotoRepo.SaveChangesAsync();



                return BaseSuccessResponse.Success(StatusCodeAndErrorsMessagesStandard.OK);
            }
            catch (Exception)
            {
                return FailResponse.Error(new List<string> { StatusCodeAndErrorsMessagesStandard.ItemNotDeleted }, StatusCodeAndErrorsMessagesStandard.BadRequest);
            }



        }




    }
}
