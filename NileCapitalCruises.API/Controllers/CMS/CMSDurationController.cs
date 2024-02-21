using NileCapitalCruises.Infrastructure.Dtos.CMS.RequestDtos.DurationDtos;
using NileCapitalCruises.Infrastructure.Dtos.CMS.ResponseDtos.DurationDtos;
using NileCapitalCruises.Infrastructure.Helpers.ApiResponses;
using NileCapitalCruises.Infrastructure.IServices.CMS;
using Microsoft.AspNetCore.Authorization;
using Microsoft.AspNetCore.Mvc;
using NileCapitalCruises.Infrastructure.Data.Specification.CMS;
using NileCapitalCruises.Infrastructure.Dtos.CMS.ResponseDtos.CityDtos;
using NileCapitalCruises.Infrastructure.Services.CMS;
using NileCapitalCruises.Infrastructure.Dtos.CMS.ResponseDtos.SeasonDtos;

namespace NileCapitalCruises.API.Controllers.CMS
{
    [Route("api/cms/duration")]
    [ApiController]
    public class CMSDurationController : ControllerBase
    {
        private readonly CMSIDurationService _durationService;

        public CMSDurationController(CMSIDurationService durationService)
        {
            _durationService = durationService;
        }


        [HttpPost("createDuration")]
        [Authorize(Roles = "SystemAdmin")]

        [ProducesResponseType(typeof(SuccessSingleResponse<BasicDurationResponseDto>), StatusCodeAndErrorsMessagesStandard.OK)]
        [ProducesResponseType(typeof(FailResponse), StatusCodeAndErrorsMessagesStandard.NotFound)]
        [ProducesResponseType(typeof(FailResponse), StatusCodeAndErrorsMessagesStandard.Unauthorized)] // Unauthorized
        [ProducesResponseType(typeof(FailResponse), StatusCodeAndErrorsMessagesStandard.Forbidden)] // Forbidden
        public async Task<ActionResult<IResponse>> CreateDuration(DurationRequestDto requestDto)
        {
            if (!ModelState.IsValid)
            {
                var errors = ModelState.Values.SelectMany(y => y.Errors).Select(e => e.ErrorMessage).ToList();
                var response = new FailResponse { ErrorMessages = errors, StatusCode = StatusCodeAndErrorsMessagesStandard.BadRequest, Status = false };
                return BadRequest(response);
            }
            var item = await _durationService.CreateDuration(requestDto);
            if (item.StatusCode == StatusCodeAndErrorsMessagesStandard.BadRequest)
                return BadRequest(item);

            return Ok(item);
        }


        [HttpGet("getDurations")]
        //[Authorize(Roles = "SystemAdmin")]
        [ProducesResponseType(typeof(SuccessPaginationResponse<CityWithContentResponseDto>), StatusCodeAndErrorsMessagesStandard.OK)]
        [ProducesResponseType(typeof(FailResponse), StatusCodeAndErrorsMessagesStandard.NotFound)]
        [ProducesResponseType(typeof(FailResponse), StatusCodeAndErrorsMessagesStandard.Unauthorized)] // Unauthorized
        [ProducesResponseType(typeof(FailResponse), StatusCodeAndErrorsMessagesStandard.Forbidden)] // Forbidden
        public async Task<ActionResult<IResponse>> GetCities([FromQuery] PaginationSpecParams paginationSpecParams)
        {
            var item = await _durationService.GetDurations(paginationSpecParams);

            if (item.StatusCode == StatusCodeAndErrorsMessagesStandard.NotFound)
                return NotFound(item);

            return Ok(item);
        }



    }
}
