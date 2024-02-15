using NileCapitalCruises.Infrastructure.Dtos.BookingEngine.ResponseDtos.ItineraryDtos;
using NileCapitalCruises.Infrastructure.Dtos.BookingEngine.ResponseDtos.ItineraryTypeDtos;
using NileCapitalCruises.Infrastructure.Dtos.BookingEngine.ResponseDtos.OperationDateDtos;
using NileCapitalCruises.Infrastructure.Helpers.ApiResponses;
using NileCapitalCruises.Infrastructure.IServices.BookingEngine;
using Microsoft.AspNetCore.Mvc;

namespace NileCapitalCruises.API.Controllers.BookingEngine
{
    [Route("api/bookingEngine/operationDate")]
    [ApiController]
    public class BEOperationDateController : ControllerBase
    {
        private readonly BEIOperationDateService _operationDateService;

        public BEOperationDateController(BEIOperationDateService operationDateService)
        {
            _operationDateService = operationDateService;
        }







        [HttpGet("getOperationDates")]
        [ProducesResponseType(typeof(SuccessListResponse<ItineraryTypeWithContentResponseDto>), StatusCodeAndErrorsMessagesStandard.OK)]
        [ProducesResponseType(typeof(FailResponse), StatusCodeAndErrorsMessagesStandard.NotFound)]
        [ProducesResponseType(typeof(FailResponse), StatusCodeAndErrorsMessagesStandard.Unauthorized)] // Unauthorized
        [ProducesResponseType(typeof(FailResponse), StatusCodeAndErrorsMessagesStandard.Forbidden)] // Forbidden
        public async Task<ActionResult<IResponse>> GetOperationDates([FromQuery] int itineraryTypeId)
        {
            var item = await _operationDateService.GetOperationDates(itineraryTypeId);

            if (item.StatusCode == StatusCodeAndErrorsMessagesStandard.NotFound)
                return NotFound(item);

            return Ok(item);
        }

        


    }
}
