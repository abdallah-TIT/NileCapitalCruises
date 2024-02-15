using NileCapitalCruises.Infrastructure.Dtos.BookingEngine.ResponseDtos.ItineraryDtos;
using NileCapitalCruises.Infrastructure.Dtos.BookingEngine.ResponseDtos.ItineraryTypeDtos;
using NileCapitalCruises.Infrastructure.Dtos.BookingEngine.ResponseDtos.OperationDateDtos;
using NileCapitalCruises.Infrastructure.Helpers.ApiResponses;
using NileCapitalCruises.Infrastructure.IServices.BookingEngine;
using Microsoft.AspNetCore.Mvc;

namespace NileCapitalCruises.API.Controllers.BookingEngine
{
    [Route("api/bookingEngine/itineraryType")]
    [ApiController]
    public class BEItineraryTypeController : ControllerBase
    {
        private readonly BEIItineraryTypeService _itineraryTypeService;

        public BEItineraryTypeController(BEIItineraryTypeService itineraryTypeService)
        {
            _itineraryTypeService = itineraryTypeService;
        }


        




        [HttpGet("getItineraryTypes")]
        [ProducesResponseType(typeof(SuccessListResponse<ItineraryTypeWithContentResponseDto>), StatusCodeAndErrorsMessagesStandard.OK)]
        [ProducesResponseType(typeof(FailResponse), StatusCodeAndErrorsMessagesStandard.NotFound)]
        [ProducesResponseType(typeof(FailResponse), StatusCodeAndErrorsMessagesStandard.Unauthorized)] // Unauthorized
        [ProducesResponseType(typeof(FailResponse), StatusCodeAndErrorsMessagesStandard.Forbidden)] // Forbidden
        public async Task<ActionResult<IResponse>> GetItineraryTypes([FromQuery] string languageCode = "en")
        {
            var item = await _itineraryTypeService.GetItineraryTypes(languageCode);

            if (item.StatusCode == StatusCodeAndErrorsMessagesStandard.NotFound)
                return NotFound(item);

            return Ok(item);
        }

        


    }
}
