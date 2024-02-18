using NileCapitalCruises.Infrastructure.Dtos.CMS.RequestDtos.CabinAmenityDtos;
using NileCapitalCruises.Infrastructure.Dtos.CMS.RequestDtos.CruiseFacilityDtos;
using NileCapitalCruises.Infrastructure.Dtos.CMS.ResponseDtos.CabinAmenityDtos;
using NileCapitalCruises.Infrastructure.Dtos.CMS.ResponseDtos.CruiseFacilityDtos;
using NileCapitalCruises.Infrastructure.Helpers.ApiResponses;
using NileCapitalCruises.Infrastructure.IServices.CMS;
using Microsoft.AspNetCore.Authorization;
using Microsoft.AspNetCore.Mvc;

namespace NileCapitalCruises.API.Controllers.CMS
{
    [Route("api/cms/cabinAmenity")]
    [ApiController]
    public class CMSCabinAmenityController : ControllerBase
    {
        private readonly ICabinAmenityService _cabinAmenityService;

        public CMSCabinAmenityController(ICabinAmenityService cabinAmenityService)
        {
            _cabinAmenityService = cabinAmenityService;
        }


        //[HttpPost("updateAmenitiesToCabin")]
        //[Authorize(Roles = "SystemAdmin")]

        //[ProducesResponseType(typeof(BaseSuccessResponse), StatusCodeAndErrorsMessagesStandard.OK)]
        //[ProducesResponseType(typeof(FailResponse), StatusCodeAndErrorsMessagesStandard.NotFound)]
        //[ProducesResponseType(typeof(FailResponse), StatusCodeAndErrorsMessagesStandard.Unauthorized)] // Unauthorized
        //[ProducesResponseType(typeof(FailResponse), StatusCodeAndErrorsMessagesStandard.Forbidden)] // Forbidden
        //public async Task<ActionResult<IResponse>> UpdateAmenitiesToCabin([FromQuery]int cabinId, int companyId, IEnumerable<CabinAmenityRequestDto> requestDto)
        //{
        //    if (!ModelState.IsValid)
        //    {
        //        var errors = ModelState.Values.SelectMany(y => y.Errors).Select(e => e.ErrorMessage).ToList();
        //        var response = new FailResponse { ErrorMessages = errors, StatusCode = StatusCodeAndErrorsMessagesStandard.BadRequest, Status = false };
        //        return BadRequest(response);
        //    }
        //    var item = await _cabinAmenityService.UpdateAmenitiesToCabin(cabinId, companyId,requestDto);
        //    if (item.StatusCode == StatusCodeAndErrorsMessagesStandard.BadRequest)
        //        return BadRequest(item);

        //    return Ok(item);
        //}

        //[HttpGet("getAmenities")]
        //[Authorize(Roles = "SystemAdmin")]
        //[ProducesResponseType(typeof(SuccessPaginationResponse<IEnumerable<AmenityResponseDto>>), StatusCodeAndErrorsMessagesStandard.OK)]
        //[ProducesResponseType(typeof(FailResponse), StatusCodeAndErrorsMessagesStandard.NotFound)]
        //[ProducesResponseType(typeof(FailResponse), StatusCodeAndErrorsMessagesStandard.Unauthorized)] // Unauthorized
        //[ProducesResponseType(typeof(FailResponse), StatusCodeAndErrorsMessagesStandard.Forbidden)] // Forbidden
        //public async Task<ActionResult<IResponse>> GetAmenities([FromQuery] int cruiseId, string languageCode = "en")
        //{
        //    var item = await _cabinAmenityService.GetAmenities(cruiseId, languageCode);

        //    if (item.StatusCode == StatusCodeAndErrorsMessagesStandard.NotFound)
        //        return NotFound(item);

        //    return Ok(item);
        //}


    }
}
