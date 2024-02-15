using AutoMapper;
using NileCapitalCruises.Core.IRepositories;
using NileCapitalCruises.Core.Models;
using NileCapitalCruises.Infrastructure.Data.Specification.CMS;
using NileCapitalCruises.Infrastructure.Data.Specification.CMS.DiningSpecification;
using NileCapitalCruises.Infrastructure.Dtos.BookingEngine.ResponseDtos.ItineraryTypeDtos;
using NileCapitalCruises.Infrastructure.Dtos.CMS.RequestDtos.DiningDtos;
using NileCapitalCruises.Infrastructure.Dtos.CMS.ResponseDtos.DiningDtos;
using NileCapitalCruises.Infrastructure.Dtos.CMS.ResponseDtos.DurationDtos;
using NileCapitalCruises.Infrastructure.Helpers.ApiResponses;
using NileCapitalCruises.Infrastructure.Helpers.Utils;
using NileCapitalCruises.Infrastructure.IServices;
using NileCapitalCruises.Infrastructure.IServices.CMS;
using Microsoft.AspNetCore.Http;
using System.Transactions;


namespace NileCapitalCruises.Infrastructure.Services.CMS
{
    public class DiningService : IDiningService
    {
        private readonly IGenericRepo<Dining> _diningRepo;
        private readonly IGenericRepo<DiningContent> _diningContentRepo;
        private readonly IMapper _mapper;
        private readonly IHandleContents<DiningContent> _handleContent;
        private readonly ITokenService _tokenService;
        private readonly HttpContext _httpContext;

        private readonly IGenericRepo<DiningPhoto> _diningPhotoRepo;

        public DiningService(
            IGenericRepo<Dining> diningRepo,
            IGenericRepo<DiningContent> diningContentRepo,
             ITokenService tokenService,
             IHttpContextAccessor httpContextAccessor,
              IGenericRepo<DiningPhoto> diningPhotoRepo,
            IMapper mapper,
            IHandleContents<DiningContent> handleContent)
        {
            _tokenService = tokenService;
            _httpContext = httpContextAccessor.HttpContext;
            _diningRepo = diningRepo;
            _mapper = mapper;
            _handleContent = handleContent;
            _diningContentRepo = diningContentRepo;
            _diningPhotoRepo = diningPhotoRepo;
        }

        public async Task<IResponse> CreateDining(int companyId, CreateDiningRequestDto requestDto)
        {
            var claims = _tokenService.GetClaimsFromJwt(_httpContext);
            if (claims.ContainsKey("CompanyId") && int.Parse(claims["CompanyId"]) != companyId)
            {
                return FailResponse.Error(new List<string> { StatusCodeAndErrorsMessagesStandard.ForbiddenAccess }, StatusCodeAndErrorsMessagesStandard.BadRequest);

            }
            using (var scope = new TransactionScope(TransactionScopeAsyncFlowOption.Enabled))
            {
                try
                {
                    var request = _mapper.Map<Dining>(requestDto);
                    var newItem = await _diningRepo.CreateEntityAsync(request);
                    if (newItem == null) return FailResponse.Error(new List<string> { StatusCodeAndErrorsMessagesStandard.ItemNotCreated }, StatusCodeAndErrorsMessagesStandard.BadRequest);

                    newItem.DiningUrl = HandleUrlsName.CreateUrlByName(newItem.DiningNameSys);

                    await _diningRepo.SaveChangesAsync();

                    // For Creating Content based on the numbers of master language table
                    await _handleContent.CreateContents(newItem.Id, newItem.DiningContents);

                    await _diningRepo.SaveChangesAsync();

                    var diningDto = _mapper.Map<BasicDiningResponseDto>(newItem);
                    scope.Complete();
                    return SuccessSingleResponse<BasicDiningResponseDto>.Success(diningDto, StatusCodeAndErrorsMessagesStandard.Created);
                }
                catch (Exception)
                {
                    return FailResponse.Error(new List<string> { StatusCodeAndErrorsMessagesStandard.ItemNotCreated }, StatusCodeAndErrorsMessagesStandard.InternalServerError);
                }
            }
        }

        public async Task<IResponse> UpdateDining(int diningId,int companyId, UpdateDiningRequestDto requestDto)
        {
            var claims = _tokenService.GetClaimsFromJwt(_httpContext);
            if (claims.ContainsKey("CompanyId") && int.Parse(claims["CompanyId"]) != companyId)
            {
                return FailResponse.Error(new List<string> { StatusCodeAndErrorsMessagesStandard.ForbiddenAccess }, StatusCodeAndErrorsMessagesStandard.BadRequest);

            }

            try
            {
                var existingItem = await _diningRepo.GetByIdAsync(diningId);

                if (existingItem == null)
                    return FailResponse.Error(new List<string> { StatusCodeAndErrorsMessagesStandard.NoItem }, StatusCodeAndErrorsMessagesStandard.NotFound);

                _mapper.Map(requestDto, existingItem);

                _diningRepo.UpdateEntity(existingItem);
                await _diningRepo.SaveChangesAsync();

                var updatedDto = _mapper.Map<BasicDiningResponseDto>(existingItem);

                return SuccessSingleResponse<BasicDiningResponseDto>.Success(updatedDto, StatusCodeAndErrorsMessagesStandard.OK);
            }
            catch (Exception)
            {
                return FailResponse.Error(new List<string> { StatusCodeAndErrorsMessagesStandard.ItemNotUpdated }, StatusCodeAndErrorsMessagesStandard.BadRequest);
            }
        }

        public async Task<IResponse> DeleteDining(int companyId, int diningId)
        {

            var claims = _tokenService.GetClaimsFromJwt(_httpContext);
            if (claims.ContainsKey("CompanyId") && int.Parse(claims["CompanyId"]) != companyId)
            {
                return FailResponse.Error(new List<string> { StatusCodeAndErrorsMessagesStandard.ForbiddenAccess }, StatusCodeAndErrorsMessagesStandard.BadRequest);

            }

            using (var scope = new TransactionScope(TransactionScopeAsyncFlowOption.Enabled))
            {
                try
                {
                    var existingItem = await _diningRepo.GetByIdAsync(diningId);

                    if (existingItem == null)
                        return FailResponse.Error(new List<string> { StatusCodeAndErrorsMessagesStandard.NoItem }, StatusCodeAndErrorsMessagesStandard.NotFound);

                    var spec = new DiningContentSpecification(diningId);
                    var relatedItems = await _diningContentRepo.ListAsync(spec);

                    relatedItems.Select(item =>
                    {
                        _diningContentRepo.DeleteSoftEntity(item);
                        return item;
                    }).ToList();
                    _diningRepo.DeleteSoftEntity(existingItem);

                    // Use ForEach to apply soft delete to each related item

                    await _diningRepo.SaveChangesAsync();
                    await _diningContentRepo.SaveChangesAsync();

                    scope.Complete();
                    return BaseSuccessResponse.Success(StatusCodeAndErrorsMessagesStandard.OK);
                }
                catch (Exception)
                {
                    return FailResponse.Error(new List<string> { StatusCodeAndErrorsMessagesStandard.ItemNotDeleted }, StatusCodeAndErrorsMessagesStandard.BadRequest);
                }
            }


        }



        public async Task<IResponse> GetDinings(PaginationSpecParams paginationSpecParams,int cruiseId, int companyId)
        {
            var claims = _tokenService.GetClaimsFromJwt(_httpContext);
            if (claims.ContainsKey("CompanyId") && int.Parse(claims["CompanyId"]) != companyId)
            {
                return FailResponse.Error(new List<string> { StatusCodeAndErrorsMessagesStandard.ForbiddenAccess }, StatusCodeAndErrorsMessagesStandard.BadRequest);

            }


            var spec = new DiningSpecification(paginationSpecParams, cruiseId);
            var countSpec = new DiningWithFiltersForCountSpecification(paginationSpecParams,cruiseId);
            var totalItems = await _diningRepo.CountAsync(countSpec);
            var items = await _diningRepo.ListAsync(spec);
            if (items.Count() <= 0) return FailResponse.Error(new List<string> { StatusCodeAndErrorsMessagesStandard.NoItem }, StatusCodeAndErrorsMessagesStandard.NotFound);


            var data = _mapper.Map<IReadOnlyList<DiningWithContentResponseDto>>(items);

            return SuccessPaginationResponse<DiningWithContentResponseDto>.Success(
                    data != null,
                    StatusCodeAndErrorsMessagesStandard.OK,
                    data,
                    paginationSpecParams.PageIndex,
                    paginationSpecParams.PageSize,
                    totalItems
                );
        }


        public async Task<IResponse> GetDining(int diningId,int companyId)
        {

            var claims = _tokenService.GetClaimsFromJwt(_httpContext);
            if (claims.ContainsKey("CompanyId") && int.Parse(claims["CompanyId"]) != companyId)
            {
                return FailResponse.Error(new List<string> { StatusCodeAndErrorsMessagesStandard.ForbiddenAccess }, StatusCodeAndErrorsMessagesStandard.BadRequest);

            }


            var spec = new DiningSpecification(diningId);
            var item = await _diningRepo.GetEntityWithSpecAsync(spec);
            if (item == null) return FailResponse.Error(new List<string> { StatusCodeAndErrorsMessagesStandard.NoItem }, StatusCodeAndErrorsMessagesStandard.NotFound);
            var itemDto = _mapper.Map<BasicDiningResponseDto>(item);
            return SuccessSingleResponse<BasicDiningResponseDto>.Success(itemDto, StatusCodeAndErrorsMessagesStandard.OK);
        }


        public async Task<IResponse> GetDiningContent(int diningId, int companyId, string languageCode = "en")
        {
            var claims = _tokenService.GetClaimsFromJwt(_httpContext);
            if (claims.ContainsKey("CompanyId") && int.Parse(claims["CompanyId"]) != companyId)
            {
                return FailResponse.Error(new List<string> { StatusCodeAndErrorsMessagesStandard.ForbiddenAccess }, StatusCodeAndErrorsMessagesStandard.BadRequest);

            }

            var spec = new DiningContentSpecification(diningId, languageCode);
            var item = await _diningContentRepo.GetEntityWithSpecAsync(spec);
            if (item == null) return FailResponse.Error(new List<string> { StatusCodeAndErrorsMessagesStandard.NoItem }, StatusCodeAndErrorsMessagesStandard.NotFound);
            var itemDto = _mapper.Map<DiningContentResponseDto>(item);
            return SuccessSingleResponse<DiningContentResponseDto>.Success(itemDto, StatusCodeAndErrorsMessagesStandard.OK);
        }


        public async Task<IResponse> UpdateDiningContent(int diningId, int companyId, DiningContentRequestDto requestDto, string languageCode = "en")
        {
            var claims = _tokenService.GetClaimsFromJwt(_httpContext);
            if (claims.ContainsKey("CompanyId") && int.Parse(claims["CompanyId"]) != companyId)
            {
                return FailResponse.Error(new List<string> { StatusCodeAndErrorsMessagesStandard.ForbiddenAccess }, StatusCodeAndErrorsMessagesStandard.BadRequest);

            }
            var spec = new DiningContentSpecification(diningId, languageCode);
            var item = await _diningContentRepo.GetEntityWithSpecAsync(spec);
            if (item == null) return FailResponse.Error(new List<string> { StatusCodeAndErrorsMessagesStandard.NoItem }, StatusCodeAndErrorsMessagesStandard.NotFound);
            _mapper.Map(requestDto, item);

            try
            {

                _diningContentRepo.UpdateEntity(item);
                await _diningContentRepo.SaveChangesAsync();

                var updatedDto = _mapper.Map<DiningContentResponseDto>(item);

                return SuccessSingleResponse<DiningContentResponseDto>.Success(updatedDto, StatusCodeAndErrorsMessagesStandard.OK);
            }
            catch (Exception)
            {
                return FailResponse.Error(new List<string> { StatusCodeAndErrorsMessagesStandard.ItemNotUpdated }, StatusCodeAndErrorsMessagesStandard.BadRequest);
            }


        }

        public async Task<IResponse> GetDiningPhotos(int diningId, int companyId)
        {
            var claims = _tokenService.GetClaimsFromJwt(_httpContext);
            if (claims.ContainsKey("CompanyId") && int.Parse(claims["CompanyId"]) != companyId)
            {
                return FailResponse.Error(new List<string> { StatusCodeAndErrorsMessagesStandard.ForbiddenAccess }, StatusCodeAndErrorsMessagesStandard.BadRequest);

            }

            var spec = new DiningPhotoSpecification(null, diningId);
            var items = await _diningPhotoRepo.ListAsync(spec);
            if (items.Count() <= 0) return FailResponse.Error(new List<string> { StatusCodeAndErrorsMessagesStandard.NoItem }, StatusCodeAndErrorsMessagesStandard.NotFound);
            var itemsDto = _mapper.Map<IEnumerable<DiningPhotoResponseDto>>(items);
            return SuccessSingleResponse<IEnumerable<DiningPhotoResponseDto>>.Success(itemsDto, StatusCodeAndErrorsMessagesStandard.OK);
        }


        public async Task<IResponse> CreateDiningPhotos(int diningId, int companyId, IEnumerable<DiningPhotoRequestDto> requestDto)
        {
            var claims = _tokenService.GetClaimsFromJwt(_httpContext);
            if (claims.ContainsKey("CompanyId") && int.Parse(claims["CompanyId"]) != companyId)
            {
                return FailResponse.Error(new List<string> { StatusCodeAndErrorsMessagesStandard.ForbiddenAccess }, StatusCodeAndErrorsMessagesStandard.BadRequest);

            }



            var newItems = _mapper.Map<IEnumerable<DiningPhoto>>(requestDto);

            try
            {

                await _diningPhotoRepo.CreateEntitiesAsync(newItems);
                await _diningPhotoRepo.SaveChangesAsync();

                var createdDto = _mapper.Map<IEnumerable<DiningPhotoResponseDto>>(newItems);

                return SuccessSingleResponse<IEnumerable<DiningPhotoResponseDto>>.Success(createdDto, StatusCodeAndErrorsMessagesStandard.OK);
            }
            catch (Exception)
            {
                return FailResponse.Error(new List<string> { StatusCodeAndErrorsMessagesStandard.ItemNotUpdated }, StatusCodeAndErrorsMessagesStandard.BadRequest);
            }


        }


        public async Task<IResponse> DeleteDiningPhoto(int photoId, int companyId)
        {

            try
            {
                var claims = _tokenService.GetClaimsFromJwt(_httpContext);
                if (claims.ContainsKey("CompanyId") && int.Parse(claims["CompanyId"]) != companyId)
                {
                    return FailResponse.Error(new List<string> { StatusCodeAndErrorsMessagesStandard.ForbiddenAccess }, StatusCodeAndErrorsMessagesStandard.BadRequest);

                }

                var spec = new DiningPhotoSpecification(photoId, null);
                var existingItem = await _diningPhotoRepo.GetEntityWithSpecAsync(spec);



                if (existingItem == null)
                    return FailResponse.Error(new List<string> { StatusCodeAndErrorsMessagesStandard.NoItem }, StatusCodeAndErrorsMessagesStandard.NotFound);


                _diningPhotoRepo.DeleteSoftEntity(existingItem);

                await _diningPhotoRepo.SaveChangesAsync();



                return BaseSuccessResponse.Success(StatusCodeAndErrorsMessagesStandard.OK);
            }
            catch (Exception)
            {
                return FailResponse.Error(new List<string> { StatusCodeAndErrorsMessagesStandard.ItemNotDeleted }, StatusCodeAndErrorsMessagesStandard.BadRequest);
            }



        }


        public async Task<IResponse> DeleteDiningPhotos(int diningId, int companyId)
        {

            try
            {
                var claims = _tokenService.GetClaimsFromJwt(_httpContext);
                if (claims.ContainsKey("CompanyId") && int.Parse(claims["CompanyId"]) != companyId)
                {
                    return FailResponse.Error(new List<string> { StatusCodeAndErrorsMessagesStandard.ForbiddenAccess }, StatusCodeAndErrorsMessagesStandard.BadRequest);

                }

                var spec = new DiningSpecification(diningId);
                var existingItem = await _diningRepo.GetEntityWithSpecAsync(spec);



                if (existingItem == null)
                    return FailResponse.Error(new List<string> { StatusCodeAndErrorsMessagesStandard.NoItem }, StatusCodeAndErrorsMessagesStandard.NotFound);


                var specPhotos = new DiningPhotoSpecification(null, diningId);
                var photoItems = await _diningPhotoRepo.ListAsync(specPhotos);
                if (photoItems.Count() <= 0) return FailResponse.Error(new List<string> { StatusCodeAndErrorsMessagesStandard.NoPhoto }, StatusCodeAndErrorsMessagesStandard.NotFound);

               
                _diningPhotoRepo.DeleteSoftEntities(photoItems);

                await _diningPhotoRepo.SaveChangesAsync();



                return BaseSuccessResponse.Success(StatusCodeAndErrorsMessagesStandard.OK);
            }
            catch (Exception)
            {
                return FailResponse.Error(new List<string> { StatusCodeAndErrorsMessagesStandard.ItemNotDeleted }, StatusCodeAndErrorsMessagesStandard.BadRequest);
            }



        }


    }
}
