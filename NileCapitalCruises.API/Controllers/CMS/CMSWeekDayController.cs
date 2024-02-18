using NileCapitalCruises.Infrastructure.Dtos.CMS.RequestDtos.CityDtos;
using NileCapitalCruises.Infrastructure.Dtos.CMS.RequestDtos.WeekDayDtos;
using NileCapitalCruises.Infrastructure.Dtos.CMS.ResponseDtos.CityDtos;
using NileCapitalCruises.Infrastructure.Dtos.CMS.ResponseDtos.WeekDayDtos;
using NileCapitalCruises.Infrastructure.Helpers.ApiResponses;
using NileCapitalCruises.Infrastructure.IServices.CMS;
using Microsoft.AspNetCore.Authorization;
using Microsoft.AspNetCore.Mvc;
using NileCapitalCruises.Infrastructure.Data.Specification.CMS;

namespace NileCapitalCruises.API.Controllers.CMS
{
    [Route("api/cms/weekDay")]
    [ApiController]
    public class CMSWeekDayController : ControllerBase
    {
        private readonly IWeekDayService _weekDayService;

        public CMSWeekDayController(IWeekDayService weekDayService)
        {
            _weekDayService = weekDayService;
        }


        [HttpPost("createWeekDay")]
        [Authorize(Roles = "SystemAdmin")]

        [ProducesResponseType(typeof(SuccessSingleResponse<BasicWeekDayResponseDto>), StatusCodeAndErrorsMessagesStandard.OK)]
        [ProducesResponseType(typeof(FailResponse), StatusCodeAndErrorsMessagesStandard.NotFound)]
        [ProducesResponseType(typeof(FailResponse), StatusCodeAndErrorsMessagesStandard.Unauthorized)] // Unauthorized
        [ProducesResponseType(typeof(FailResponse), StatusCodeAndErrorsMessagesStandard.Forbidden)] // Forbidden
        public async Task<ActionResult<IResponse>> CreateWeekDay(WeekDayRequestDto requestDto)
        {
            if (!ModelState.IsValid)
            {
                var errors = ModelState.Values.SelectMany(y => y.Errors).Select(e => e.ErrorMessage).ToList();
                var response = new FailResponse { ErrorMessages = errors, StatusCode = StatusCodeAndErrorsMessagesStandard.BadRequest, Status = false };
                return BadRequest(response);
            }
            var item = await _weekDayService.CreateWeekDay(requestDto);
            if (item.StatusCode == StatusCodeAndErrorsMessagesStandard.BadRequest)
                return BadRequest(item);

            return Ok(item);
        }


        [HttpGet("getWeekdays")]
        //[Authorize(Roles = "SystemAdmin")]
        [ProducesResponseType(typeof(SuccessPaginationResponse<BasicWeekDayResponseDto>), StatusCodeAndErrorsMessagesStandard.OK)]
        [ProducesResponseType(typeof(FailResponse), StatusCodeAndErrorsMessagesStandard.NotFound)]
        [ProducesResponseType(typeof(FailResponse), StatusCodeAndErrorsMessagesStandard.Unauthorized)] // Unauthorized
        [ProducesResponseType(typeof(FailResponse), StatusCodeAndErrorsMessagesStandard.Forbidden)] // Forbidden
        public async Task<ActionResult<IResponse>> GetWeekDays([FromQuery] PaginationSpecParams paginationSpecParams)
        {
            var item = await _weekDayService.GetWeekdays(paginationSpecParams);

            if (item.StatusCode == StatusCodeAndErrorsMessagesStandard.NotFound)
                return NotFound(item);

            return Ok(item);
        }



    }
}
