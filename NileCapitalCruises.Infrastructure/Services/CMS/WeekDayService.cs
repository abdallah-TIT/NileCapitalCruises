
using AutoMapper;
using NileCapitalCruises.Core.IRepositories;
using NileCapitalCruises.Core.Models;
using NileCapitalCruises.Infrastructure.Dtos.CMS.RequestDtos.WeekDayDtos;
using NileCapitalCruises.Infrastructure.Dtos.CMS.ResponseDtos.WeekDayDtos;
using NileCapitalCruises.Infrastructure.Helpers.ApiResponses;
using NileCapitalCruises.Infrastructure.Helpers.Utils;
using NileCapitalCruises.Infrastructure.IServices;
using NileCapitalCruises.Infrastructure.IServices.CMS;
using Microsoft.AspNetCore.Http;
using System.Transactions;

namespace NileCapitalCruises.Infrastructure.Services.CMS
{
    public class WeekDayService : IWeekDayService
    {
        private readonly IGenericRepo<WeekDay> _weekDayRepo;
        private readonly IHandleContents<WeekDayContent> _handleContent;
        private readonly IGenericRepo<WeekDayContent> _weekDayContentRepo;
        private readonly HttpContext _httpContext;
        private readonly ITokenService _tokenService;
        private readonly IMapper _mapper;

        public WeekDayService(
            IGenericRepo<WeekDay> weekDayRepo,
            IGenericRepo<WeekDayContent> weekDayContentRepo,
            IHandleContents<WeekDayContent> handleContent,
            IHttpContextAccessor httpContextAccessor,
             ITokenService tokenService,
            IMapper mapper
            )
        {
            _weekDayRepo = weekDayRepo;
            _weekDayContentRepo = weekDayContentRepo;
            _handleContent = handleContent;
            _httpContext = httpContextAccessor.HttpContext;
            _tokenService = tokenService;
            _mapper = mapper;
           
        }
        public async Task<IResponse> CreateWeekDay(WeekDayRequestDto requestDto)
        {

            using (var scope = new TransactionScope(TransactionScopeAsyncFlowOption.Enabled))
            {
                try
                {
                    var request = _mapper.Map<WeekDay>(requestDto);
                    var newItem = await _weekDayRepo.CreateEntityAsync(request);
                    if (newItem == null) return FailResponse.Error(new List<string> { StatusCodeAndErrorsMessagesStandard.ItemNotCreated }, StatusCodeAndErrorsMessagesStandard.BadRequest);

                    newItem.WeekDayUrl = HandleUrlsName.CreateUrlByName(newItem.WeekDayNameSys);

                    await _weekDayRepo.SaveChangesAsync();

                    // For Creating Content based on the numbers of master language table
                    await _handleContent.CreateContents(newItem.Id, newItem.WeekDayContents);

                    await _weekDayRepo.SaveChangesAsync();

                    var companyDto = _mapper.Map<BasicWeekDayResponseDto>(newItem);
                    scope.Complete();
                    return SuccessSingleResponse<BasicWeekDayResponseDto>.Success(companyDto, StatusCodeAndErrorsMessagesStandard.Created);
                }
                catch (Exception)
                {
                    return FailResponse.Error(new List<string> { StatusCodeAndErrorsMessagesStandard.ItemNotCreated }, StatusCodeAndErrorsMessagesStandard.InternalServerError);
                }
            }
        }




    }
}
