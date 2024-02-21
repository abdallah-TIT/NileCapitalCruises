using NileCapitalCruises.Infrastructure.Dtos.CMS.RequestDtos.CityDtos;
using NileCapitalCruises.Infrastructure.Dtos.CMS.RequestDtos.CompanyDtos;
using NileCapitalCruises.Infrastructure.Dtos.CMS.RequestDtos.OperationDateDtos;
using NileCapitalCruises.Infrastructure.Dtos.CMS.ResponseDtos.CityDtos;
using NileCapitalCruises.Infrastructure.Dtos.CMS.ResponseDtos.OperationDateDtos;
using NileCapitalCruises.Infrastructure.Helpers.ApiResponses;
using NileCapitalCruises.Infrastructure.IServices.CMS;
using Microsoft.AspNetCore.Authorization;
using Microsoft.AspNetCore.Mvc;
using NileCapitalCruises.Infrastructure.Data.Specification.CMS;
using NileCapitalCruises.Infrastructure.Services.CMS;
using NileCapitalCruises.Infrastructure.Dtos.CMS.ResponseDtos.CabinTypeCruiseOperationDateDtos;

namespace NileCapitalCruises.API.Controllers.CMS
{
    [Route("api/cms/operationDate")]
    [ApiController]
    public class CMSOperationDateController : ControllerBase
    {
        private readonly IOperationDateService _operationDateService;

        public CMSOperationDateController(IOperationDateService operationDateService)
        {
            _operationDateService = operationDateService;
        }


        [HttpPost("createOperationDate")]
        //[Authorize(Roles = "SystemAdmin")]

        [ProducesResponseType(typeof(SuccessSingleResponse<BasicOperationDateResponseDto>), StatusCodeAndErrorsMessagesStandard.OK)]
        [ProducesResponseType(typeof(FailResponse), StatusCodeAndErrorsMessagesStandard.NotFound)]
        [ProducesResponseType(typeof(FailResponse), StatusCodeAndErrorsMessagesStandard.Unauthorized)] // Unauthorized
        [ProducesResponseType(typeof(FailResponse), StatusCodeAndErrorsMessagesStandard.Forbidden)] // Forbidden
        public async Task<ActionResult<IResponse>> CreateOperationDate(OperationDateRequestDto requestDto, [FromQuery] int companyId)
        {
            if (!ModelState.IsValid)
            {
                var errors = ModelState.Values.SelectMany(y => y.Errors).Select(e => e.ErrorMessage).ToList();
                var response = new FailResponse { ErrorMessages = errors, StatusCode = StatusCodeAndErrorsMessagesStandard.BadRequest, Status = false };
                return BadRequest(response);
            }
            var item = await _operationDateService.CreateOperationDate(companyId,requestDto);
            if (item.StatusCode == StatusCodeAndErrorsMessagesStandard.BadRequest)
                return BadRequest(item);

            return Ok(item);
        }



        [HttpPost("createOperationDates")]
        //[Authorize(Roles = "SystemAdmin")]

        [ProducesResponseType(typeof(SuccessSingleResponse<IEnumerable<BasicOperationDateResponseDto>>), StatusCodeAndErrorsMessagesStandard.OK)]
        [ProducesResponseType(typeof(FailResponse), StatusCodeAndErrorsMessagesStandard.NotFound)]
        [ProducesResponseType(typeof(FailResponse), StatusCodeAndErrorsMessagesStandard.Unauthorized)] // Unauthorized
        [ProducesResponseType(typeof(FailResponse), StatusCodeAndErrorsMessagesStandard.Forbidden)] // Forbidden
        public async Task<ActionResult<IResponse>> CreateOperationDates(OperationDatesRequestDto requestDto, [FromQuery] int companyId)
        {
            if (!ModelState.IsValid)
            {
                var errors = ModelState.Values.SelectMany(y => y.Errors).Select(e => e.ErrorMessage).ToList();
                var response = new FailResponse { ErrorMessages = errors, StatusCode = StatusCodeAndErrorsMessagesStandard.BadRequest, Status = false };
                return BadRequest(response);
            }
            var item = await _operationDateService.CreateOperationDates(companyId, requestDto);
            if (item.StatusCode == StatusCodeAndErrorsMessagesStandard.BadRequest)
                return BadRequest(item);

            return Ok(item);
        }



        [HttpGet("getOperationDates")]
        //[Authorize(Roles = "SystemAdmin")]
        [ProducesResponseType(typeof(SuccessPaginationResponse<BasicOperationDateResponseDto>), StatusCodeAndErrorsMessagesStandard.OK)]
        [ProducesResponseType(typeof(FailResponse), StatusCodeAndErrorsMessagesStandard.NotFound)]
        [ProducesResponseType(typeof(FailResponse), StatusCodeAndErrorsMessagesStandard.Unauthorized)] // Unauthorized
        [ProducesResponseType(typeof(FailResponse), StatusCodeAndErrorsMessagesStandard.Forbidden)] // Forbidden
        public async Task<ActionResult<IResponse>> GetOperationDates([FromQuery] PaginationSpecParams paginationSpecParams, int itineraryId)
        {
            var item = await _operationDateService.GetOperationDates(itineraryId,paginationSpecParams);

            if (item.StatusCode == StatusCodeAndErrorsMessagesStandard.NotFound)
                return NotFound(item);

            return Ok(item);
        }


    }
}
