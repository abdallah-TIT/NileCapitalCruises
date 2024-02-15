using AutoMapper;
using NileCapitalCruises.Core.IRepositories;
using NileCapitalCruises.Core.Models;
using NileCapitalCruises.Infrastructure.Dtos.CMS.ResponseDtos.CompanyDtos;
using NileCapitalCruises.Infrastructure.Helpers.ApiResponses;
using NileCapitalCruises.Infrastructure.Helpers.Utils;
using NileCapitalCruises.Infrastructure.IServices.CMS;
using System.Transactions;
using NileCapitalCruises.Infrastructure.Dtos.CMS.RequestDtos.BrandDtos;
using NileCapitalCruises.Infrastructure.Dtos.CMS.ResponseDtos.BrandDtos;
using NileCapitalCruises.Infrastructure.Dtos.CMS.RequestDtos.CompanyDtos;
using NileCapitalCruises.Infrastructure.Data.Specification.CMS.CompanySpecification;
using NileCapitalCruises.Infrastructure.Data.Specification.CMS;
using NileCapitalCruises.Infrastructure.Data.Specification.CMS.BrandSpecification;

namespace NileCapitalCruises.Infrastructure.Services.CMS
{
    public class BrandService : IBrandService
    {
        private readonly IGenericRepo<Brand> _brandRepo;
        private readonly IHandleContents<BrandContent> _handleContent;
        private readonly IGenericRepo<BrandContent> _brandContentRepo;
        private readonly IMapper _mapper;

        public BrandService(
            IGenericRepo<Brand> brandRepo,
            IGenericRepo<BrandContent> brandContentRepo,
            IHandleContents<BrandContent> handleContent,
            IMapper mapper)
        {
            _brandRepo = brandRepo;
            _brandContentRepo = brandContentRepo;
            _handleContent = handleContent;
            _mapper = mapper;
        }

        public async Task<IResponse> CreateBrand(CMSBrandRequestDto requestDto)
        {

            using (var scope = new TransactionScope(TransactionScopeAsyncFlowOption.Enabled))
            {
                try
                {
                    var request = _mapper.Map<Brand>(requestDto);
                    var newItem = await _brandRepo.CreateEntityAsync(request);
                    if (newItem == null) return FailResponse.Error(new List<string> { StatusCodeAndErrorsMessagesStandard.ItemNotCreated }, StatusCodeAndErrorsMessagesStandard.BadRequest);

                    newItem.BrandUrl = HandleUrlsName.CreateUrlByName(newItem.BrandNameSys);

                    await _brandRepo.SaveChangesAsync();

                    // For Creating Content based on the numbers of master language table
                    await _handleContent.CreateContents(newItem.Id, newItem.BrandContents);

                    await _brandRepo.SaveChangesAsync();

                    var brandDto = _mapper.Map<CMSBasicBrandResponseDto>(newItem);
                    scope.Complete();
                    return SuccessSingleResponse<CMSBasicBrandResponseDto>.Success(brandDto, StatusCodeAndErrorsMessagesStandard.Created);
                }
                catch (Exception)
                {
                    return FailResponse.Error(new List<string> { StatusCodeAndErrorsMessagesStandard.ItemNotCreated }, StatusCodeAndErrorsMessagesStandard.InternalServerError);
                }
            }
        }


        public async Task<IResponse> UpdateBrand(int brandId, CMSBrandRequestDto requestDto)
        {

            try
            {
                var existingItem = await _brandRepo.GetByIdAsync(brandId);

                if (existingItem == null)
                    return FailResponse.Error(new List<string> { StatusCodeAndErrorsMessagesStandard.NoItem }, StatusCodeAndErrorsMessagesStandard.NotFound);

                _mapper.Map(requestDto, existingItem);

                _brandRepo.UpdateEntity(existingItem);
                await _brandRepo.SaveChangesAsync();

                var updatedDto = _mapper.Map<CMSBasicBrandResponseDto>(existingItem);

                return SuccessSingleResponse<CMSBasicBrandResponseDto>.Success(updatedDto, StatusCodeAndErrorsMessagesStandard.OK);
            }
            catch (Exception)
            {
                return FailResponse.Error(new List<string> { StatusCodeAndErrorsMessagesStandard.ItemNotUpdated }, StatusCodeAndErrorsMessagesStandard.BadRequest);
            }
        }



        public async Task<IResponse> GetBrands(PaginationSpecParams paginationSpecParams)
        {
            var spec = new BrandSpecification(paginationSpecParams);
            var countSpec = new BrandWithFiltersForCountSpecification(paginationSpecParams);
            var totalItems = await _brandRepo.CountAsync(countSpec);
            var items = await _brandRepo.ListAsync(spec);
            if (items.Count() <= 0) return FailResponse.Error(new List<string> { StatusCodeAndErrorsMessagesStandard.NoItem }, StatusCodeAndErrorsMessagesStandard.NotFound);


            var data = _mapper.Map<IReadOnlyList<CMSBrandWithContentResponseDto>>(items);

            return SuccessPaginationResponse<CMSBrandWithContentResponseDto>.Success(
                    data != null,
                    StatusCodeAndErrorsMessagesStandard.OK,
                    data,
                    paginationSpecParams.PageIndex,
                    paginationSpecParams.PageSize,
                    totalItems
                );
        }


        public async Task<IResponse> GetBrand(int brandId)
        {
            var spec = new BrandSpecification(brandId);
            var item = await _brandRepo.GetEntityWithSpecAsync(spec);
            if (item == null) return FailResponse.Error(new List<string> { StatusCodeAndErrorsMessagesStandard.NoItem }, StatusCodeAndErrorsMessagesStandard.NotFound);
            var itemDto = _mapper.Map<CMSBasicBrandResponseDto>(item);
            return SuccessSingleResponse<CMSBasicBrandResponseDto>.Success(itemDto, StatusCodeAndErrorsMessagesStandard.OK);
        }

        public async Task<IResponse> DeleteBrand(int brandId)
        {
            using (var scope = new TransactionScope(TransactionScopeAsyncFlowOption.Enabled))
            {
                try
                {
                    var existingItem = await _brandRepo.GetByIdAsync(brandId);

                    if (existingItem == null)
                        return FailResponse.Error(new List<string> { StatusCodeAndErrorsMessagesStandard.NoItem }, StatusCodeAndErrorsMessagesStandard.NotFound);

                    var spec = new BrandContentSpecification(brandId);
                    var relatedItems = await _brandContentRepo.ListAsync(spec);

                    relatedItems.Select(item =>
                    {
                        _brandContentRepo.DeleteSoftEntity(item);
                        return item;
                    }).ToList();
                    _brandRepo.DeleteSoftEntity(existingItem);

                    // Use ForEach to apply soft delete to each related item

                    await _brandRepo.SaveChangesAsync();
                    await _brandContentRepo.SaveChangesAsync();

                    scope.Complete();
                    return BaseSuccessResponse.Success(StatusCodeAndErrorsMessagesStandard.OK);
                }
                catch (Exception)
                {
                    return FailResponse.Error(new List<string> { StatusCodeAndErrorsMessagesStandard.ItemNotDeleted }, StatusCodeAndErrorsMessagesStandard.BadRequest);
                }
            }


        }


        public async Task<IResponse> GetBrandContent(int brandId, string languageCode = "en")
        {
            var spec = new BrandContentSpecification(brandId, languageCode);
            var item = await _brandContentRepo.GetEntityWithSpecAsync(spec);
            if (item == null) return FailResponse.Error(new List<string> { StatusCodeAndErrorsMessagesStandard.NoItem }, StatusCodeAndErrorsMessagesStandard.NotFound);
            var itemDto = _mapper.Map<CMSBrandContentResponseDto>(item);
            return SuccessSingleResponse<CMSBrandContentResponseDto>.Success(itemDto, StatusCodeAndErrorsMessagesStandard.OK);
        }


        public async Task<IResponse> UpdateBrandContent(int brandId, CMSBrandContentRequestDto requestDto, string languageCode = "en")
        {
            var spec = new BrandContentSpecification(brandId, languageCode);
            var item = await _brandContentRepo.GetEntityWithSpecAsync(spec);
            if (item == null) return FailResponse.Error(new List<string> { StatusCodeAndErrorsMessagesStandard.NoItem }, StatusCodeAndErrorsMessagesStandard.NotFound);
            _mapper.Map(requestDto, item);

            try
            {

                _brandContentRepo.UpdateEntity(item);
                await _brandRepo.SaveChangesAsync();

                var updatedDto = _mapper.Map<CMSBrandContentResponseDto>(item);

                return SuccessSingleResponse<CMSBrandContentResponseDto>.Success(updatedDto, StatusCodeAndErrorsMessagesStandard.OK);
            }
            catch (Exception)
            {
                return FailResponse.Error(new List<string> { StatusCodeAndErrorsMessagesStandard.ItemNotUpdated }, StatusCodeAndErrorsMessagesStandard.BadRequest);
            }


        }


    }
}
