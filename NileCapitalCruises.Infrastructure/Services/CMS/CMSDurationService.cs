
using AutoMapper;
using NileCapitalCruises.Core.IRepositories;
using NileCapitalCruises.Core.Models;
using NileCapitalCruises.Infrastructure.Dtos.CMS.RequestDtos.CityDtos;
using NileCapitalCruises.Infrastructure.Dtos.CMS.RequestDtos.CompanyDtos;
using NileCapitalCruises.Infrastructure.Dtos.CMS.RequestDtos.DurationDtos;
using NileCapitalCruises.Infrastructure.Dtos.CMS.RequestDtos.ItineraryDtos;
using NileCapitalCruises.Infrastructure.Dtos.CMS.ResponseDtos.CityDtos;
using NileCapitalCruises.Infrastructure.Dtos.CMS.ResponseDtos.CompanyDtos;
using NileCapitalCruises.Infrastructure.Dtos.CMS.ResponseDtos.DurationDtos;
using NileCapitalCruises.Infrastructure.Helpers.ApiResponses;
using NileCapitalCruises.Infrastructure.Helpers.Utils;
using NileCapitalCruises.Infrastructure.IServices;
using NileCapitalCruises.Infrastructure.IServices.CMS;
using Microsoft.AspNetCore.Http;
using System.Transactions;

namespace NileCapitalCruises.Infrastructure.Services.CMS
{
    public class CMSDurationService : CMSIDurationService
    {
        private readonly IGenericRepo<Duration> _durationRepo;
        
        private readonly HttpContext _httpContext;
        private readonly ITokenService _tokenService;
        private readonly IMapper _mapper;

        public CMSDurationService(
            IGenericRepo<Duration> durationRepo,
            
            IHttpContextAccessor httpContextAccessor,
             ITokenService tokenService,
            IMapper mapper
            )
        {
            _durationRepo = durationRepo;
           
            _httpContext = httpContextAccessor.HttpContext;
            _tokenService = tokenService;
            _mapper = mapper;
           
        }
        public async Task<IResponse> CreateDuration(DurationRequestDto requestDto)
        {

            using (var scope = new TransactionScope(TransactionScopeAsyncFlowOption.Enabled))
            {
                try
                {
                    var request = _mapper.Map<Duration>(requestDto);
                    var newItem = await _durationRepo.CreateEntityAsync(request);
                    if (newItem == null) return FailResponse.Error(new List<string> { StatusCodeAndErrorsMessagesStandard.ItemNotCreated }, StatusCodeAndErrorsMessagesStandard.BadRequest);

                    

                    await _durationRepo.SaveChangesAsync();

                    

                    var companyDto = _mapper.Map<BasicDurationResponseDto>(newItem);
                    scope.Complete();
                    return SuccessSingleResponse<BasicDurationResponseDto>.Success(companyDto, StatusCodeAndErrorsMessagesStandard.Created);
                }
                catch (Exception)
                {
                    return FailResponse.Error(new List<string> { StatusCodeAndErrorsMessagesStandard.ItemNotCreated }, StatusCodeAndErrorsMessagesStandard.InternalServerError);
                }
            }
        }




    }
}
