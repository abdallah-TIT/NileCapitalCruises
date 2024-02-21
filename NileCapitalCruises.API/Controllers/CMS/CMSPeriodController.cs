using NileCapitalCruises.Infrastructure.Dtos.CMS.RequestDtos.CabinTypeCruiseDtos;
using NileCapitalCruises.Infrastructure.Dtos.CMS.RequestDtos.CityDtos;
using NileCapitalCruises.Infrastructure.Dtos.CMS.ResponseDtos.CityDtos;
using NileCapitalCruises.Infrastructure.Helpers.ApiResponses;
using NileCapitalCruises.Infrastructure.IServices.CMS;
using Microsoft.AspNetCore.Authorization;
using Microsoft.AspNetCore.Mvc;
using NileCapitalCruises.Infrastructure.Data.Specification.CMS;
using NileCapitalCruises.Infrastructure.Dtos.CMS.ResponseDtos.CompanyDtos;
using NileCapitalCruises.Infrastructure.Services.CMS;
using NileCapitalCruises.Infrastructure.Dtos.CMS.ResponseDtos.SeasonDtos;
using NileCapitalCruises.Infrastructure.Dtos.CMS.RequestDtos.PeriodDtos;
using NileCapitalCruises.Infrastructure.Dtos.CMS.ResponseDtos.PeriodDtos;

namespace NileCapitalCruises.API.Controllers.CMS
{
    [Route("api/cms/period")]
    [ApiController]
    public class CMSPeriodController : ControllerBase
    {
        private readonly IPeriodService _periodService;

        public CMSPeriodController(IPeriodService periodService)
        {
            _periodService = periodService;
        }


        [HttpPost("createPeriod")]
        //[Authorize(Roles = "SystemAdmin")]

        [ProducesResponseType(typeof(SuccessSingleResponse<CMSBasicPeriodResponseDto>), StatusCodeAndErrorsMessagesStandard.OK)]
        [ProducesResponseType(typeof(FailResponse), StatusCodeAndErrorsMessagesStandard.NotFound)]
        [ProducesResponseType(typeof(FailResponse), StatusCodeAndErrorsMessagesStandard.Unauthorized)] // Unauthorized
        [ProducesResponseType(typeof(FailResponse), StatusCodeAndErrorsMessagesStandard.Forbidden)] // Forbidden
        public async Task<ActionResult<IResponse>> CreatePeriod(CMSPeriodRequestDto requestDto, int seasonId, int cruiseId)
        {
            if (!ModelState.IsValid)
            {
                var errors = ModelState.Values.SelectMany(y => y.Errors).Select(e => e.ErrorMessage).ToList();
                var response = new FailResponse { ErrorMessages = errors, StatusCode = StatusCodeAndErrorsMessagesStandard.BadRequest, Status = false };
                return BadRequest(response);
            }
            var item = await _periodService.CreatePeriod(requestDto, seasonId, cruiseId);
            if (item.StatusCode == StatusCodeAndErrorsMessagesStandard.BadRequest)
                return BadRequest(item);

            return Ok(item);
        }





    }
}
