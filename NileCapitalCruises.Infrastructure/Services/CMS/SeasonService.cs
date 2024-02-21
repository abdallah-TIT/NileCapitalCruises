using AutoMapper;
using NileCapitalCruises.Core.IRepositories;
using NileCapitalCruises.Core.Models;
using NileCapitalCruises.Infrastructure.Data.Specification.CMS;
using NileCapitalCruises.Infrastructure.Data.Specification.CMS.CompanySpecification;
using NileCapitalCruises.Infrastructure.Data.Specification.CMS.ItineraryTypeSpecification;
using NileCapitalCruises.Infrastructure.Data.Specification.CMS.SeasonSpecification;
using NileCapitalCruises.Infrastructure.Dtos.CMS.RequestDtos.CompanyDtos;
using NileCapitalCruises.Infrastructure.Dtos.CMS.RequestDtos.SeasonDtos;
using NileCapitalCruises.Infrastructure.Dtos.CMS.ResponseDtos.CompanyDtos;
using NileCapitalCruises.Infrastructure.Dtos.CMS.ResponseDtos.ItineraryTypeDtos;
using NileCapitalCruises.Infrastructure.Dtos.CMS.ResponseDtos.SeasonDtos;
using NileCapitalCruises.Infrastructure.Helpers.ApiResponses;
using NileCapitalCruises.Infrastructure.Helpers.Utils;
using NileCapitalCruises.Infrastructure.IServices.CMS;
using System.Transactions;


namespace NileCapitalCruises.Infrastructure.Services.CMS
{
    public class SeasonService : ISeasonService
    {
        private readonly IGenericRepo<Season> _seasonRepo;
        private readonly IGenericRepo<SeasonContent> _seasonContentRepo;
        private readonly IMapper _mapper;
        private readonly IHandleContents<SeasonContent> _handleContent;

        public SeasonService(
            IGenericRepo<Season> seasonRepo,
            IGenericRepo<SeasonContent> seasonContentRepo,
            IMapper mapper,
            IHandleContents<SeasonContent> handleContent)
        {
            _seasonRepo = seasonRepo;
            _mapper = mapper;
            _handleContent = handleContent;
            _seasonContentRepo = seasonContentRepo;
        }

        public async Task<IResponse> CreateSeason(CMSSeasonRequestDto requestDto)
        {

            using (var scope = new TransactionScope(TransactionScopeAsyncFlowOption.Enabled))
            {
                try
                {
                    var request = _mapper.Map<Season>(requestDto);
                    var newItem = await _seasonRepo.CreateEntityAsync(request);
                    if (newItem == null) return FailResponse.Error(new List<string> { StatusCodeAndErrorsMessagesStandard.ItemNotCreated }, StatusCodeAndErrorsMessagesStandard.BadRequest);

                    newItem.SeasonUrl = HandleUrlsName.CreateUrlByName(newItem.SeasonNameSys);

                    await _seasonRepo.SaveChangesAsync();

                    // For Creating Content based on the numbers of master language table
                    await _handleContent.CreateContents(newItem.Id, newItem.SeasonContents);

                    await _seasonRepo.SaveChangesAsync();

                    var seasonDto = _mapper.Map<CMSBasicSeasonResponseDto>(newItem);
                    scope.Complete();
                    return SuccessSingleResponse<CMSBasicSeasonResponseDto>.Success(seasonDto, StatusCodeAndErrorsMessagesStandard.Created);
                }
                catch (Exception)
                {
                    return FailResponse.Error(new List<string> { StatusCodeAndErrorsMessagesStandard.ItemNotCreated }, StatusCodeAndErrorsMessagesStandard.InternalServerError);
                }
            }
        }

        public async Task<IResponse> UpdateSeason(int seasonId, CMSSeasonRequestDto requestDto)
        {

            try
            {
                var existingItem = await _seasonRepo.GetByIdAsync(seasonId);

                if (existingItem == null)
                    return FailResponse.Error(new List<string> { StatusCodeAndErrorsMessagesStandard.NoItem }, StatusCodeAndErrorsMessagesStandard.NotFound);

                _mapper.Map(requestDto, existingItem);

                _seasonRepo.UpdateEntity(existingItem);
                await _seasonRepo.SaveChangesAsync();

                var updatedDto = _mapper.Map<CMSBasicSeasonResponseDto>(existingItem);

                return SuccessSingleResponse<CMSBasicSeasonResponseDto>.Success(updatedDto, StatusCodeAndErrorsMessagesStandard.OK);
            }
            catch (Exception)
            {
                return FailResponse.Error(new List<string> { StatusCodeAndErrorsMessagesStandard.ItemNotUpdated }, StatusCodeAndErrorsMessagesStandard.BadRequest);
            }
        }

        public async Task<IResponse> GetSeasons(PaginationSpecParams paginationSpecParams)
        {
            var spec = new SeasonSpecification(paginationSpecParams);
            var countSpec = new SeasonWithFiltersForCountSpecification(paginationSpecParams);
            var totalItems = await _seasonRepo.CountAsync(countSpec);
            var items = await _seasonRepo.ListAsync(spec);
            if (items.Count() <= 0) return FailResponse.Error(new List<string> { StatusCodeAndErrorsMessagesStandard.NoItem }, StatusCodeAndErrorsMessagesStandard.NotFound);


            var data = _mapper.Map<IReadOnlyList<CMSSeasonWithContentResponseDto>>(items);

            return SuccessPaginationResponse<CMSSeasonWithContentResponseDto>.Success(
                    data != null,
                    StatusCodeAndErrorsMessagesStandard.OK,
                    data,
                    paginationSpecParams.PageIndex,
                    paginationSpecParams.PageSize,
                    totalItems
                );
        }

        public async Task<IResponse> GetSeason(int seasonId)
        {
            var spec = new SeasonSpecification(seasonId);
            var item = await _seasonRepo.GetEntityWithSpecAsync(spec);
            if (item == null) return FailResponse.Error(new List<string> { StatusCodeAndErrorsMessagesStandard.NoItem }, StatusCodeAndErrorsMessagesStandard.NotFound);
            var itemDto = _mapper.Map<CMSBasicSeasonResponseDto>(item);
            return SuccessSingleResponse<CMSBasicSeasonResponseDto>.Success(itemDto, StatusCodeAndErrorsMessagesStandard.OK);
        }



        public async Task<IResponse> DeleteSeason(int seasonId)
        {
            using (var scope = new TransactionScope(TransactionScopeAsyncFlowOption.Enabled))
            {
                try
                {
                    var existingItem = await _seasonRepo.GetByIdAsync(seasonId);

                    if (existingItem == null)
                        return FailResponse.Error(new List<string> { StatusCodeAndErrorsMessagesStandard.NoItem }, StatusCodeAndErrorsMessagesStandard.NotFound);

                    var spec = new SeasonContentSpecification(seasonId);
                    var relatedItems = await _seasonContentRepo.ListAsync(spec);

                    relatedItems.Select(item =>
                    {
                        _seasonContentRepo.DeleteSoftEntity(item);
                        return item;
                    }).ToList();
                    _seasonRepo.DeleteSoftEntity(existingItem);

                    // Use ForEach to apply soft delete to each related item

                    await _seasonRepo.SaveChangesAsync();
                    await _seasonContentRepo.SaveChangesAsync();

                    scope.Complete();
                    return BaseSuccessResponse.Success(StatusCodeAndErrorsMessagesStandard.OK);
                }
                catch (Exception)
                {
                    return FailResponse.Error(new List<string> { StatusCodeAndErrorsMessagesStandard.ItemNotDeleted }, StatusCodeAndErrorsMessagesStandard.BadRequest);
                }
            }


        }


        public async Task<IResponse> GetSeasonContent(int seasonId, string languageCode = "en")
        {
            var spec = new SeasonContentSpecification(seasonId, languageCode);
            var item = await _seasonContentRepo.GetEntityWithSpecAsync(spec);
            if (item == null) return FailResponse.Error(new List<string> { StatusCodeAndErrorsMessagesStandard.NoItem }, StatusCodeAndErrorsMessagesStandard.NotFound);
            var itemDto = _mapper.Map<CMSSeasonContentResponseDto>(item);
            return SuccessSingleResponse<CMSSeasonContentResponseDto>.Success(itemDto, StatusCodeAndErrorsMessagesStandard.OK);
        }


        public async Task<IResponse> GetSeasonContents(int seasonId)
        {
            var spec = new SeasonContentSpecification(seasonId);

            var items = await _seasonContentRepo.ListAsync(spec);
            if (items.Count() <= 0) return FailResponse.Error(new List<string> { StatusCodeAndErrorsMessagesStandard.NoItem }, StatusCodeAndErrorsMessagesStandard.NotFound);


            var data = _mapper.Map<IReadOnlyList<CMSSeasonContentResponseDto>>(items);

            return SuccessListResponse<CMSSeasonContentResponseDto>.Success(
                    data != null,
                    StatusCodeAndErrorsMessagesStandard.OK,
                    data

                );




        }


        public async Task<IResponse> UpdateSeasonContent(int seasonId, CMSSeasonContentRequestDto requestDto, string languageCode = "en")
        {
            var spec = new SeasonContentSpecification(seasonId, languageCode);
            var item = await _seasonContentRepo.GetEntityWithSpecAsync(spec);
            if (item == null) return FailResponse.Error(new List<string> { StatusCodeAndErrorsMessagesStandard.NoItem }, StatusCodeAndErrorsMessagesStandard.NotFound);
            _mapper.Map(requestDto, item);

            try
            {

                _seasonContentRepo.UpdateEntity(item);
                await _seasonRepo.SaveChangesAsync();

                var updatedDto = _mapper.Map<CMSSeasonContentResponseDto>(item);

                return SuccessSingleResponse<CMSSeasonContentResponseDto>.Success(updatedDto, StatusCodeAndErrorsMessagesStandard.OK);
            }
            catch (Exception)
            {
                return FailResponse.Error(new List<string> { StatusCodeAndErrorsMessagesStandard.ItemNotUpdated }, StatusCodeAndErrorsMessagesStandard.BadRequest);
            }


        }


    }
}
