using NileCapitalCruises.Infrastructure.Dtos.BookingEngine.ResponseDtos.CabinTypeCruiseDtos;
using NileCapitalCruises.Infrastructure.Dtos.BookingEngine.ResponseDtos.ItineraryDtos;
using NileCapitalCruises.Infrastructure.Dtos.BookingEngine.ResponseDtos.ItineraryTypeDtos;
using NileCapitalCruises.Infrastructure.Dtos.BookingEngine.ResponseDtos.OperationDateDtos;
using NileCapitalCruises.Infrastructure.Helpers.ApiResponses;
using NileCapitalCruises.Infrastructure.IServices.BookingEngine;
using Microsoft.AspNetCore.Mvc;

namespace NileCapitalCruises.API.Controllers.BookingEngine
{
    [Route("api/bookingEngine/itinerary")]
    [ApiController]
    public class BEItineraryController : ControllerBase
    {
        private readonly BEIItineraryService _itineraryService;

        public BEItineraryController(BEIItineraryService itineraryService)
        {
            _itineraryService = itineraryService;
        }







        [HttpGet("getItineraries")]
        [ProducesResponseType(typeof(SuccessListResponse<ItineraryWithContentResponseDto>), StatusCodeAndErrorsMessagesStandard.OK)]
        [ProducesResponseType(typeof(FailResponse), StatusCodeAndErrorsMessagesStandard.NotFound)]
        [ProducesResponseType(typeof(FailResponse), StatusCodeAndErrorsMessagesStandard.Unauthorized)] // Unauthorized
        [ProducesResponseType(typeof(FailResponse), StatusCodeAndErrorsMessagesStandard.Forbidden)] // Forbidden
        public async Task<ActionResult<IResponse>> GetItineraryies([FromQuery] int? itineraryTypeId,int? maximumAdults,int? maximumChildren, int? operationDay, int? operationMonth, int? operationYear, string languageCode = "en")
        {
            var item = await _itineraryService.GetItineraries(itineraryTypeId,maximumAdults , maximumChildren, operationDay, operationMonth, operationYear,languageCode);

            if (item.StatusCode == StatusCodeAndErrorsMessagesStandard.NotFound)
                return NotFound(item);

            return Ok(item);
        }

        


    }
}
