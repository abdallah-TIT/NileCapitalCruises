using AutoMapper;
using NileCapitalCruises.Core.IRepositories;
using NileCapitalCruises.Core.Models;
using NileCapitalCruises.Infrastructure.Data.Specification.CMS.CompanySpecification;
using NileCapitalCruises.Infrastructure.Data.Specification.CMS;
using NileCapitalCruises.Infrastructure.Data.Specification.CMS.CruiseCategorySpecification;
using NileCapitalCruises.Infrastructure.Dtos.CMS.RequestDtos.CompanyDtos;
using NileCapitalCruises.Infrastructure.Dtos.CMS.RequestDtos.CruiseCategoryDtos;
using NileCapitalCruises.Infrastructure.Dtos.CMS.RequestDtos.CruiseDtos;
using NileCapitalCruises.Infrastructure.Dtos.CMS.ResponseDtos.CompanyDtos;
using NileCapitalCruises.Infrastructure.Dtos.CMS.ResponseDtos.CruisCategoryDtos;
using NileCapitalCruises.Infrastructure.Helpers.ApiResponses;
using NileCapitalCruises.Infrastructure.Helpers.Utils;
using NileCapitalCruises.Infrastructure.IServices.CMS;
using Microsoft.AspNetCore.JsonPatch;
using System.Transactions;
using NileCapitalCruises.Infrastructure.Dtos.CMS.RequestDtos.FacilityDtos;

namespace NileCapitalCruises.Infrastructure.Services.CMS
{
    public class CruiseCategoryService : ICruiseCategoryService
    {
        private readonly IGenericRepo<CruiseCategory> _cruiseCategoryRepo;
        private readonly IGenericRepo<CruiseCategoryContent> _cruiseCategoryContentRepo;
        private readonly IHandleContents<CruiseCategoryContent> _handleContent;
        private readonly IMapper _mapper;

        public CruiseCategoryService(
            IGenericRepo<CruiseCategory> cruiseCategoryRepo,
            IGenericRepo<CruiseCategoryContent> cruiseCategoryContentRepo,
            IHandleContents<CruiseCategoryContent> handleContent,
            IMapper mapper)
        {
            _cruiseCategoryRepo = cruiseCategoryRepo;
            _cruiseCategoryContentRepo = cruiseCategoryContentRepo;
            _handleContent = handleContent;
            _mapper = mapper;
        }


        public async Task<IResponse> CreateCruiseCategory(CMSCruiseCategoryRequestDto requestDto)
        {

            using (var scope = new TransactionScope(TransactionScopeAsyncFlowOption.Enabled))
            {
                try
                {
                    var request = _mapper.Map<CruiseCategory>(requestDto);
                    var newItem = await _cruiseCategoryRepo.CreateEntityAsync(request);
                    if (newItem == null) return FailResponse.Error(new List<string> { StatusCodeAndErrorsMessagesStandard.ItemNotCreated }, StatusCodeAndErrorsMessagesStandard.BadRequest);

                    newItem.CruiseCategoryUrl = HandleUrlsName.CreateUrlByName(newItem.CruiseCategoryNameSys);

                    await _cruiseCategoryRepo.SaveChangesAsync();

                    // For Creating Content based on the numbers of master language table
                    await _handleContent.CreateContents(newItem.Id, newItem.CruiseCategoryContents);

                    await _cruiseCategoryRepo.SaveChangesAsync();

                    var companyDto = _mapper.Map<CMSBasicCruiseCategoryResponseDto>(newItem);
                    scope.Complete();
                    return SuccessSingleResponse<CMSBasicCruiseCategoryResponseDto>.Success(companyDto, StatusCodeAndErrorsMessagesStandard.Created);
                }
                catch (Exception)
                {
                    return FailResponse.Error(new List<string> { StatusCodeAndErrorsMessagesStandard.ItemNotCreated }, StatusCodeAndErrorsMessagesStandard.InternalServerError);
                }
            }
        }

        public async Task<IResponse> UpdateCruiseCategory(int cruiseCategoryId, CMSCruiseCategoryRequestDto requestDto)
        {

            try
            {
                var existingItem = await _cruiseCategoryRepo.GetByIdAsync(cruiseCategoryId);

                if (existingItem == null)
                    return FailResponse.Error(new List<string> { StatusCodeAndErrorsMessagesStandard.NoItem }, StatusCodeAndErrorsMessagesStandard.NotFound);

                _mapper.Map(requestDto, existingItem);

                _cruiseCategoryRepo.UpdateEntity(existingItem);
                await _cruiseCategoryRepo.SaveChangesAsync();

                var updatedDto = _mapper.Map<CMSBasicCruiseCategoryResponseDto>(existingItem);

                return SuccessSingleResponse<CMSBasicCruiseCategoryResponseDto>.Success(updatedDto, StatusCodeAndErrorsMessagesStandard.OK);
            }
            catch (Exception)
            {
                return FailResponse.Error(new List<string> { StatusCodeAndErrorsMessagesStandard.ItemNotUpdated }, StatusCodeAndErrorsMessagesStandard.BadRequest);
            }
        }

        public async Task<IResponse> GetCruiseCategories(PaginationSpecParams paginationSpecParams)
        {
            var spec = new CruiseCategorySpecification(paginationSpecParams);
            var countSpec = new CruiseCategoryWithFiltersForCountSpecification(paginationSpecParams);
            var totalItems = await _cruiseCategoryRepo.CountAsync(countSpec);
            var items = await _cruiseCategoryRepo.ListAsync(spec);
            if (items.Count() <= 0) return FailResponse.Error(new List<string> { StatusCodeAndErrorsMessagesStandard.NoItem }, StatusCodeAndErrorsMessagesStandard.NotFound);


            var data = _mapper.Map<IReadOnlyList<CMSCruiseCategoryWithContentResponseDto>>(items);

            return SuccessPaginationResponse<CMSCruiseCategoryWithContentResponseDto>.Success(
                    data != null,
                    StatusCodeAndErrorsMessagesStandard.OK,
                    data,
                    paginationSpecParams.PageIndex,
                    paginationSpecParams.PageSize,
                    totalItems
                );
        }


        public async Task<IResponse> GetCruiseCategory(int cruiseCategoryId)
        {
            var spec = new CruiseCategorySpecification(cruiseCategoryId);
            var item = await _cruiseCategoryRepo.GetEntityWithSpecAsync(spec);
            if (item == null) return FailResponse.Error(new List<string> { StatusCodeAndErrorsMessagesStandard.NoItem }, StatusCodeAndErrorsMessagesStandard.NotFound);
            var itemDto = _mapper.Map<CMSBasicCruiseCategoryResponseDto>(item);
            return SuccessSingleResponse<CMSBasicCruiseCategoryResponseDto>.Success(itemDto, StatusCodeAndErrorsMessagesStandard.OK);
        }

        public async Task<IResponse> DeleteCruiseCategory(int cruiseCategoryId)
        {
            using (var scope = new TransactionScope(TransactionScopeAsyncFlowOption.Enabled))
            {
                try
                {
                    var existingItem = await _cruiseCategoryRepo.GetByIdAsync(cruiseCategoryId);

                    if (existingItem == null)
                        return FailResponse.Error(new List<string> { StatusCodeAndErrorsMessagesStandard.NoItem }, StatusCodeAndErrorsMessagesStandard.NotFound);

                    var spec = new CruiseCategoryContentSpecification(cruiseCategoryId);
                    var relatedItems = await _cruiseCategoryContentRepo.ListAsync(spec);

                    relatedItems.Select(item =>
                    {
                        _cruiseCategoryContentRepo.DeleteSoftEntity(item);
                        return item;
                    }).ToList();
                    _cruiseCategoryRepo.DeleteSoftEntity(existingItem);

                    // Use ForEach to apply soft delete to each related item

                    await _cruiseCategoryRepo.SaveChangesAsync();
                    await _cruiseCategoryContentRepo.SaveChangesAsync();

                    scope.Complete();
                    return BaseSuccessResponse.Success(StatusCodeAndErrorsMessagesStandard.OK);
                }
                catch (Exception)
                {
                    return FailResponse.Error(new List<string> { StatusCodeAndErrorsMessagesStandard.ItemNotDeleted }, StatusCodeAndErrorsMessagesStandard.BadRequest);
                }
            }


        }


        public async Task<IResponse> GetCruiseCategoryContent(int cruiseCategoryId, string languageCode = "en")
        {
            var spec = new CruiseCategoryContentSpecification(cruiseCategoryId, languageCode);
            var item = await _cruiseCategoryContentRepo.GetEntityWithSpecAsync(spec);
            if (item == null) return FailResponse.Error(new List<string> { StatusCodeAndErrorsMessagesStandard.NoItem }, StatusCodeAndErrorsMessagesStandard.NotFound);
            var itemDto = _mapper.Map<CMSCruiseCategoryContentResponseDto>(item);
            return SuccessSingleResponse<CMSCruiseCategoryContentResponseDto>.Success(itemDto, StatusCodeAndErrorsMessagesStandard.OK);
        }


        public async Task<IResponse> UpdateCruiseCategoryContent(int cruiseCategoryId, CMSCruiseCategoryContentRequestDto requestDto, string languageCode = "en")
        {
            var spec = new CruiseCategoryContentSpecification(cruiseCategoryId, languageCode);
            var item = await _cruiseCategoryContentRepo.GetEntityWithSpecAsync(spec);
            if (item == null) return FailResponse.Error(new List<string> { StatusCodeAndErrorsMessagesStandard.NoItem }, StatusCodeAndErrorsMessagesStandard.NotFound);
            _mapper.Map(requestDto, item);

            try
            {

                _cruiseCategoryContentRepo.UpdateEntity(item);
                await _cruiseCategoryContentRepo.SaveChangesAsync();

                var updatedDto = _mapper.Map<CMSCruiseCategoryContentResponseDto>(item);

                return SuccessSingleResponse<CMSCruiseCategoryContentResponseDto>.Success(updatedDto, StatusCodeAndErrorsMessagesStandard.OK);
            }
            catch (Exception)
            {
                return FailResponse.Error(new List<string> { StatusCodeAndErrorsMessagesStandard.ItemNotUpdated }, StatusCodeAndErrorsMessagesStandard.BadRequest);
            }


        }



    }
}
