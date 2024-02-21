
using AutoMapper;
using NileCapitalCruises.Core.IRepositories;
using NileCapitalCruises.Core.Models;
using NileCapitalCruises.Infrastructure.Helpers.Utils;
using NileCapitalCruises.Infrastructure.IServices;
using NileCapitalCruises.Infrastructure.IServices.CMS;
using Microsoft.AspNetCore.Http;
using NileCapitalCruises.Infrastructure.Dtos.CMS.RequestDtos.CityDtos;
using NileCapitalCruises.Infrastructure.Dtos.CMS.ResponseDtos.CityDtos;
using NileCapitalCruises.Infrastructure.Helpers.ApiResponses;
using System.Transactions;
using NileCapitalCruises.Infrastructure.Dtos.CMS.RequestDtos.PeriodDtos;
using NileCapitalCruises.Infrastructure.Dtos.CMS.ResponseDtos.PeriodDtos;

namespace NileCapitalCruises.Infrastructure.Services.CMS
{
    public class PeriodService : IPeriodService
    {
        private readonly IGenericRepo<Period> _periodRepo;
        private readonly IHandleContents<PeriodContent> _handleContent;
        private readonly IGenericRepo<PeriodContent> _periodContentRepo;
        private readonly HttpContext _httpContext;
        private readonly ITokenService _tokenService;
        private readonly IMapper _mapper;

        public PeriodService(
            IGenericRepo<Period> periodRepo,
            IGenericRepo<PeriodContent> periodContentRepo,
            IHandleContents<PeriodContent> handleContent,
            IHttpContextAccessor httpContextAccessor,
             ITokenService tokenService,
            IMapper mapper
            )
        {
            _periodRepo = periodRepo;
            _periodContentRepo = periodContentRepo;
            _handleContent = handleContent;
            _httpContext = httpContextAccessor.HttpContext;
            _tokenService = tokenService;
            _mapper = mapper;
           
        }


        public async Task<IResponse> CreatePeriod(CMSPeriodRequestDto requestDto,int seasonId,int cruiseId)
        {

            using (var scope = new TransactionScope(TransactionScopeAsyncFlowOption.Enabled))
            {
                try
                {
                    var request = _mapper.Map<Period>(requestDto);
                    request.SeasonId = seasonId;
                    request.CruiseId = cruiseId;
                    var newItem = await _periodRepo.CreateEntityAsync(request);
                    if (newItem == null) return FailResponse.Error(new List<string> { StatusCodeAndErrorsMessagesStandard.ItemNotCreated }, StatusCodeAndErrorsMessagesStandard.BadRequest);

                    newItem.PeriodUrl = HandleUrlsName.CreateUrlByName(newItem.PeriodNameSys);

                    await _periodRepo.SaveChangesAsync();

                    // For Creating Content based on the numbers of master language table
                    await _handleContent.CreateContents(newItem.Id, newItem.PeriodContents);

                    await _periodRepo.SaveChangesAsync();

                    var companyDto = _mapper.Map<CMSBasicPeriodResponseDto>(newItem);
                    scope.Complete();
                    return SuccessSingleResponse<CMSBasicPeriodResponseDto>.Success(companyDto, StatusCodeAndErrorsMessagesStandard.Created);
                }
                catch (Exception)
                {
                    return FailResponse.Error(new List<string> { StatusCodeAndErrorsMessagesStandard.ItemNotCreated }, StatusCodeAndErrorsMessagesStandard.InternalServerError);
                }
            }
        }


    }
}
