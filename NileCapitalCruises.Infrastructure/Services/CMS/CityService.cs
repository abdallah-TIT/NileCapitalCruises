
using AutoMapper;
using NileCapitalCruises.Core.IRepositories;
using NileCapitalCruises.Core.Models;
using NileCapitalCruises.Infrastructure.Dtos.CMS.RequestDtos.CabinTypeCruiseDtos;
using NileCapitalCruises.Infrastructure.Dtos.CMS.RequestDtos.CityDtos;
using NileCapitalCruises.Infrastructure.Dtos.CMS.RequestDtos.CompanyDtos;
using NileCapitalCruises.Infrastructure.Dtos.CMS.RequestDtos.DurationDtos;
using NileCapitalCruises.Infrastructure.Dtos.CMS.RequestDtos.ItineraryDtos;
using NileCapitalCruises.Infrastructure.Dtos.CMS.ResponseDtos.CityDtos;
using NileCapitalCruises.Infrastructure.Dtos.CMS.ResponseDtos.CompanyDtos;
using NileCapitalCruises.Infrastructure.Helpers.ApiResponses;
using NileCapitalCruises.Infrastructure.Helpers.Utils;
using NileCapitalCruises.Infrastructure.IServices;
using NileCapitalCruises.Infrastructure.IServices.CMS;
using Microsoft.AspNetCore.Http;
using System.Transactions;
using NileCapitalCruises.Infrastructure.Data.Specification.CMS.CompanySpecification;
using NileCapitalCruises.Infrastructure.Data.Specification.CMS;
using NileCapitalCruises.Infrastructure.Data.Specification.CMS.CitySpecification;
using NileCapitalCruises.Infrastructure.Dtos.CMS.ResponseDtos.SeasonDtos;

namespace NileCapitalCruises.Infrastructure.Services.CMS
{
    public class CityService : ICityService
    {
        private readonly IGenericRepo<City> _cityRepo;
        private readonly IHandleContents<CityContent> _handleContent;
        private readonly IGenericRepo<CityContent> _cityContentRepo;
        private readonly HttpContext _httpContext;
        private readonly ITokenService _tokenService;
        private readonly IMapper _mapper;

        public CityService(
            IGenericRepo<City> cityRepo,
            IGenericRepo<CityContent> cityContentRepo,
            IHandleContents<CityContent> handleContent,
            IHttpContextAccessor httpContextAccessor,
             ITokenService tokenService,
            IMapper mapper
            )
        {
            _cityRepo = cityRepo;
            _cityContentRepo = cityContentRepo;
            _handleContent = handleContent;
            _httpContext = httpContextAccessor.HttpContext;
            _tokenService = tokenService;
            _mapper = mapper;
           
        }
        public async Task<IResponse> CreateCity(CityRequestDto requestDto)
        {

            using (var scope = new TransactionScope(TransactionScopeAsyncFlowOption.Enabled))
            {
                try
                {
                    var request = _mapper.Map<City>(requestDto);
                    var newItem = await _cityRepo.CreateEntityAsync(request);
                    if (newItem == null) return FailResponse.Error(new List<string> { StatusCodeAndErrorsMessagesStandard.ItemNotCreated }, StatusCodeAndErrorsMessagesStandard.BadRequest);

                    newItem.CityUrl = HandleUrlsName.CreateUrlByName(newItem.CityNameSys);

                    await _cityRepo.SaveChangesAsync();

                    // For Creating Content based on the numbers of master language table
                    await _handleContent.CreateContents(newItem.Id, newItem.CityContents);

                    await _cityRepo.SaveChangesAsync();

                    var companyDto = _mapper.Map<BasicCityResponseDto>(newItem);
                    scope.Complete();
                    return SuccessSingleResponse<BasicCityResponseDto>.Success(companyDto, StatusCodeAndErrorsMessagesStandard.Created);
                }
                catch (Exception)
                {
                    return FailResponse.Error(new List<string> { StatusCodeAndErrorsMessagesStandard.ItemNotCreated }, StatusCodeAndErrorsMessagesStandard.InternalServerError);
                }
            }
        }

        public async Task<IResponse> GetCities(PaginationSpecParams paginationSpecParams)
        {
            var spec = new CitySpecification(paginationSpecParams);
            var countSpec = new CityWithFiltersForCountSpecification(paginationSpecParams);
            var totalItems = await _cityRepo.CountAsync(countSpec);
            var items = await _cityRepo.ListAsync(spec);
            if (items.Count() <= 0) return FailResponse.Error(new List<string> { StatusCodeAndErrorsMessagesStandard.NoItem }, StatusCodeAndErrorsMessagesStandard.NotFound);


            var data = _mapper.Map<IReadOnlyList<CityWithContentResponseDto>>(items);

            return SuccessPaginationResponse<CityWithContentResponseDto>.Success(
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
