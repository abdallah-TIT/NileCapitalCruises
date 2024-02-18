using NileCapitalCruises.Infrastructure.Data.Specification.CMS;
using NileCapitalCruises.Infrastructure.Dtos.CMS.RequestDtos.FacilityDtos;
using NileCapitalCruises.Infrastructure.Dtos.CMS.ResponseDtos.FacilityDtos;
using NileCapitalCruises.Infrastructure.Dtos.CMS.ResponseDtos.ItineraryDtos;
using NileCapitalCruises.Infrastructure.Helpers.ApiResponses;
using NileCapitalCruises.Infrastructure.IServices.CMS;
using Microsoft.AspNetCore.Authorization;
using Microsoft.AspNetCore.Mvc;

namespace NileCapitalCruises.API.Controllers.CMS
{
    [Route("api/cms/facility")]
    [ApiController]
    public class CMSFacilityController : ControllerBase
    {
        private readonly IFacilityService _facilityService;

        public CMSFacilityController(IFacilityService facilityService)
        {
            _facilityService = facilityService;
        }


        //[HttpPost("createFacility")]
        //[Authorize(Roles = "SystemAdmin")]

        //[ProducesResponseType(typeof(SuccessPaginationResponse<BasicFacilityResponseDto>), StatusCodeAndErrorsMessagesStandard.OK)]
        //[ProducesResponseType(typeof(FailResponse), StatusCodeAndErrorsMessagesStandard.NotFound)]
        //[ProducesResponseType(typeof(FailResponse), StatusCodeAndErrorsMessagesStandard.Unauthorized)] // Unauthorized
        //[ProducesResponseType(typeof(FailResponse), StatusCodeAndErrorsMessagesStandard.Forbidden)] // Forbidden
        //public async Task<ActionResult<IResponse>> CreateFacility(FacilityRequestDto requestDto)
        //{
        //    if (!ModelState.IsValid)
        //    {
        //        var errors = ModelState.Values.SelectMany(y => y.Errors).Select(e => e.ErrorMessage).ToList();
        //        var response = new FailResponse { ErrorMessages = errors, StatusCode = StatusCodeAndErrorsMessagesStandard.BadRequest, Status = false };
        //        return BadRequest(response);
        //    }
        //    var item = await _facilityService.CreateFacility(requestDto);
        //    if (item.StatusCode == StatusCodeAndErrorsMessagesStandard.BadRequest)
        //        return BadRequest(item);

        //    return Ok(item);
        //}



        //[HttpPut("updateFacility/{facilityId}")]
        //[Authorize(Roles = "SystemAdmin")]
        //[ProducesResponseType(typeof(SuccessSingleResponse<BasicFacilityResponseDto>), StatusCodeAndErrorsMessagesStandard.OK)]
        //[ProducesResponseType(typeof(FailResponse), StatusCodeAndErrorsMessagesStandard.NotFound)]
        //[ProducesResponseType(typeof(FailResponse), StatusCodeAndErrorsMessagesStandard.Unauthorized)]
        //[ProducesResponseType(typeof(FailResponse), StatusCodeAndErrorsMessagesStandard.Forbidden)]
        //public async Task<ActionResult<IResponse>> UpdateFacility([FromRoute] int facilityId, FacilityRequestDto requestDto)
        //{
        //    if (!ModelState.IsValid)
        //    {
        //        var errors = ModelState.Values.SelectMany(y => y.Errors).Select(e => e.ErrorMessage).ToList();
        //        var response = new FailResponse { ErrorMessages = errors, StatusCode = StatusCodeAndErrorsMessagesStandard.BadRequest, Status = false };
        //        return BadRequest(response);
        //    }

        //    var item = await _facilityService.UpdateFacility(facilityId, requestDto);

        //    if (item.StatusCode == StatusCodeAndErrorsMessagesStandard.NotFound)
        //        return NotFound(item);

        //    if (item.StatusCode == StatusCodeAndErrorsMessagesStandard.BadRequest)
        //        return BadRequest(item);


        //    return Ok(item);
        //}


        //[HttpDelete("deleteFacility/{facilityId}")]
        //[Authorize(Roles = "SystemAdmin")]
        //[ProducesResponseType(typeof(BaseSuccessResponse), StatusCodeAndErrorsMessagesStandard.OK)]
        //[ProducesResponseType(typeof(FailResponse), StatusCodeAndErrorsMessagesStandard.NotFound)]
        //[ProducesResponseType(typeof(FailResponse), StatusCodeAndErrorsMessagesStandard.Unauthorized)]
        //[ProducesResponseType(typeof(FailResponse), StatusCodeAndErrorsMessagesStandard.Forbidden)]
        //public async Task<ActionResult<IResponse>> DeleteFacility([FromRoute] int facilityId)
        //{

        //    var item = await _facilityService.DeleteFacility(facilityId);

        //    if (item.StatusCode == StatusCodeAndErrorsMessagesStandard.NotFound)
        //        return NotFound(item);

        //    if (item.StatusCode == StatusCodeAndErrorsMessagesStandard.BadRequest)
        //        return BadRequest(item);


        //    return Ok(item);
        //}



        //[HttpGet("getFacilities")]
        //[Authorize(Roles = "SystemAdmin")]
        //[ProducesResponseType(typeof(SuccessPaginationResponse<IEnumerable<FacilityWithContentResponseDto>>), StatusCodeAndErrorsMessagesStandard.OK)]
        //[ProducesResponseType(typeof(FailResponse), StatusCodeAndErrorsMessagesStandard.NotFound)]
        //[ProducesResponseType(typeof(FailResponse), StatusCodeAndErrorsMessagesStandard.Unauthorized)] // Unauthorized
        //[ProducesResponseType(typeof(FailResponse), StatusCodeAndErrorsMessagesStandard.Forbidden)] // Forbidden
        //public async Task<ActionResult<IResponse>> GetFacilities([FromQuery] PaginationSpecParams paginationSpecParams)
        //{
        //    var item = await _facilityService.GetFacilities(paginationSpecParams);

        //    if (item.StatusCode == StatusCodeAndErrorsMessagesStandard.NotFound)
        //        return NotFound(item);

        //    return Ok(item);
        //}

        //[HttpGet("getFacilityById/{facilityId}")]
        //[Authorize(Roles = "SystemAdmin")]
        //[ProducesResponseType(typeof(SuccessSingleResponse<BasicFacilityResponseDto>), StatusCodeAndErrorsMessagesStandard.OK)]
        //[ProducesResponseType(typeof(FailResponse), StatusCodeAndErrorsMessagesStandard.NotFound)]
        //[ProducesResponseType(typeof(FailResponse), StatusCodeAndErrorsMessagesStandard.Unauthorized)] // Unauthorized
        //[ProducesResponseType(typeof(FailResponse), StatusCodeAndErrorsMessagesStandard.Forbidden)] // Forbidden
        //public async Task<ActionResult<IResponse>> GetFacility([FromRoute] int facilityId)
        //{
        //    var item = await _facilityService.GetFacility(facilityId);
        //    if (item.StatusCode == StatusCodeAndErrorsMessagesStandard.NotFound)
        //        return NotFound(item);

        //    return Ok(item);
        //}

        //[HttpGet("getFacilityContent/{facilityId}")]
        //[Authorize(Roles = "SystemAdmin")]
        //[ProducesResponseType(typeof(SuccessSingleResponse<FacilityContentResponseDto>), StatusCodeAndErrorsMessagesStandard.OK)]
        //[ProducesResponseType(typeof(FailResponse), StatusCodeAndErrorsMessagesStandard.NotFound)]
        //[ProducesResponseType(typeof(FailResponse), StatusCodeAndErrorsMessagesStandard.Unauthorized)] // Unauthorized
        //[ProducesResponseType(typeof(FailResponse), StatusCodeAndErrorsMessagesStandard.Forbidden)] // Forbidden
        //public async Task<ActionResult<IResponse>> GetFacilityContent([FromRoute] int facilityId, [FromQuery] string languageCode = "en")
        //{
        //    var item = await _facilityService.GetFacilityContent(facilityId, languageCode);
        //    if (item.StatusCode == StatusCodeAndErrorsMessagesStandard.NotFound)
        //        return NotFound(item);

        //    return Ok(item);
        //}

        //[HttpPut("updateFacilityContent/{facilityId}")]
        //[Authorize(Roles = "SystemAdmin")]
        //[ProducesResponseType(typeof(SuccessSingleResponse<FacilityContentResponseDto>), StatusCodeAndErrorsMessagesStandard.OK)]
        //[ProducesResponseType(typeof(FailResponse), StatusCodeAndErrorsMessagesStandard.NotFound)]
        //[ProducesResponseType(typeof(FailResponse), StatusCodeAndErrorsMessagesStandard.Unauthorized)]
        //[ProducesResponseType(typeof(FailResponse), StatusCodeAndErrorsMessagesStandard.Forbidden)]
        //public async Task<ActionResult<IResponse>> UpdateFacilityContent([FromRoute] int facilityId, FacilityContentRequestDto requestDto, [FromQuery] string languageCode = "en")
        //{
        //    if (!ModelState.IsValid)
        //    {
        //        var errors = ModelState.Values.SelectMany(y => y.Errors).Select(e => e.ErrorMessage).ToList();
        //        var response = new FailResponse { ErrorMessages = errors, StatusCode = StatusCodeAndErrorsMessagesStandard.BadRequest, Status = false };
        //        return BadRequest(response);
        //    }

        //    var item = await _facilityService.UpdateFacilityContent(facilityId, requestDto, languageCode);

        //    if (item.StatusCode == StatusCodeAndErrorsMessagesStandard.NotFound)
        //        return NotFound(item);

        //    if (item.StatusCode == StatusCodeAndErrorsMessagesStandard.BadRequest)
        //        return BadRequest(item);


        //    return Ok(item);
        //}




    }
}
