using NileCapitalCruises.Infrastructure.Data.Specification.CMS;
using NileCapitalCruises.Infrastructure.Dtos.CMS.RequestDtos.AmenityDtos;
using NileCapitalCruises.Infrastructure.Dtos.CMS.RequestDtos.CabinDtos;
using NileCapitalCruises.Infrastructure.Dtos.CMS.ResponseDtos.AmenityDtos;
using NileCapitalCruises.Infrastructure.Helpers.ApiResponses;
using NileCapitalCruises.Infrastructure.IServices.CMS;
using Microsoft.AspNetCore.Authorization;
using Microsoft.AspNetCore.Mvc;

namespace NileCapitalCruises.API.Controllers.CMS
{
    [Route("api/cms/amenity")]
    [ApiController]
    public class CMSAmenityController : ControllerBase
    {
        private readonly IAmenityService _amenityService;

        public CMSAmenityController(IAmenityService amenityService)
        {
            _amenityService = amenityService;
        }


        //[HttpPost("createAmenity")]
        //[Authorize(Roles = "SystemAdmin")]

        //[ProducesResponseType(typeof(SuccessPaginationResponse<BasicAmenityResponseDto>), StatusCodeAndErrorsMessagesStandard.OK)]
        //[ProducesResponseType(typeof(FailResponse), StatusCodeAndErrorsMessagesStandard.NotFound)]
        //[ProducesResponseType(typeof(FailResponse), StatusCodeAndErrorsMessagesStandard.Unauthorized)] // Unauthorized
        //[ProducesResponseType(typeof(FailResponse), StatusCodeAndErrorsMessagesStandard.Forbidden)] // Forbidden
        //public async Task<ActionResult<IResponse>> CreateAmenity(AmenityRequestDto requestDto)
        //{
        //    if (!ModelState.IsValid)
        //    {
        //        var errors = ModelState.Values.SelectMany(y => y.Errors).Select(e => e.ErrorMessage).ToList();
        //        var response = new FailResponse { ErrorMessages = errors, StatusCode = StatusCodeAndErrorsMessagesStandard.BadRequest, Status = false };
        //        return BadRequest(response);
        //    }
        //    var item = await _amenityService.CreateAmenity(requestDto);
        //    if (item.StatusCode == StatusCodeAndErrorsMessagesStandard.BadRequest)
        //        return BadRequest(item);

        //    return Ok(item);
        //}


        //[HttpPut("updateAmenity/{amenityId}")]
        //[Authorize(Roles = "SystemAdmin")]
        //[ProducesResponseType(typeof(SuccessSingleResponse<BasicAmenityResponseDto>), StatusCodeAndErrorsMessagesStandard.OK)]
        //[ProducesResponseType(typeof(FailResponse), StatusCodeAndErrorsMessagesStandard.NotFound)]
        //[ProducesResponseType(typeof(FailResponse), StatusCodeAndErrorsMessagesStandard.Unauthorized)]
        //[ProducesResponseType(typeof(FailResponse), StatusCodeAndErrorsMessagesStandard.Forbidden)]
        //public async Task<ActionResult<IResponse>> UpdateAmenity([FromRoute] int amenityId, AmenityRequestDto requestDto)
        //{
        //    if (!ModelState.IsValid)
        //    {
        //        var errors = ModelState.Values.SelectMany(y => y.Errors).Select(e => e.ErrorMessage).ToList();
        //        var response = new FailResponse { ErrorMessages = errors, StatusCode = StatusCodeAndErrorsMessagesStandard.BadRequest, Status = false };
        //        return BadRequest(response);
        //    }

        //    var item = await _amenityService.UpdateAmenity(amenityId, requestDto);

        //    if (item.StatusCode == StatusCodeAndErrorsMessagesStandard.NotFound)
        //        return NotFound(item);

        //    if (item.StatusCode == StatusCodeAndErrorsMessagesStandard.BadRequest)
        //        return BadRequest(item);


        //    return Ok(item);
        //}

        //[HttpDelete("deleteAmenity/{amenityId}")]
        //[Authorize(Roles = "SystemAdmin")]
        //[ProducesResponseType(typeof(BaseSuccessResponse), StatusCodeAndErrorsMessagesStandard.OK)]
        //[ProducesResponseType(typeof(FailResponse), StatusCodeAndErrorsMessagesStandard.NotFound)]
        //[ProducesResponseType(typeof(FailResponse), StatusCodeAndErrorsMessagesStandard.Unauthorized)]
        //[ProducesResponseType(typeof(FailResponse), StatusCodeAndErrorsMessagesStandard.Forbidden)]
        //public async Task<ActionResult<IResponse>> DeleteAmenity([FromRoute] int amenityId)
        //{

        //    var item = await _amenityService.DeleteAmenity(amenityId);

        //    if (item.StatusCode == StatusCodeAndErrorsMessagesStandard.NotFound)
        //        return NotFound(item);

        //    if (item.StatusCode == StatusCodeAndErrorsMessagesStandard.BadRequest)
        //        return BadRequest(item);


        //    return Ok(item);
        //}


        //[HttpGet("getAmenities")]
        //[Authorize(Roles = "SystemAdmin")]
        //[ProducesResponseType(typeof(SuccessPaginationResponse<IEnumerable<AmenityWithContentResponseDto>>), StatusCodeAndErrorsMessagesStandard.OK)]
        //[ProducesResponseType(typeof(FailResponse), StatusCodeAndErrorsMessagesStandard.NotFound)]
        //[ProducesResponseType(typeof(FailResponse), StatusCodeAndErrorsMessagesStandard.Unauthorized)] // Unauthorized
        //[ProducesResponseType(typeof(FailResponse), StatusCodeAndErrorsMessagesStandard.Forbidden)] // Forbidden
        //public async Task<ActionResult<IResponse>> GetAmenities([FromQuery] PaginationSpecParams paginationSpecParams)
        //{
        //    var item = await _amenityService.GetAmenities(paginationSpecParams);

        //    if (item.StatusCode == StatusCodeAndErrorsMessagesStandard.NotFound)
        //        return NotFound(item);

        //    return Ok(item);
        //}


        //[HttpGet("getAmenityById/{amenityId}")]
        //[Authorize(Roles = "SystemAdmin")]
        //[ProducesResponseType(typeof(SuccessSingleResponse<BasicAmenityResponseDto>), StatusCodeAndErrorsMessagesStandard.OK)]
        //[ProducesResponseType(typeof(FailResponse), StatusCodeAndErrorsMessagesStandard.NotFound)]
        //[ProducesResponseType(typeof(FailResponse), StatusCodeAndErrorsMessagesStandard.Unauthorized)] // Unauthorized
        //[ProducesResponseType(typeof(FailResponse), StatusCodeAndErrorsMessagesStandard.Forbidden)] // Forbidden
        //public async Task<ActionResult<IResponse>> GetAmenity([FromRoute] int amenityId)
        //{
        //    var item = await _amenityService.GetAmenity(amenityId);
        //    if (item.StatusCode == StatusCodeAndErrorsMessagesStandard.NotFound)
        //        return NotFound(item);

        //    return Ok(item);
        //}


        //[HttpGet("getAmenityContent/{amenityId}")]
        //[Authorize(Roles = "SystemAdmin")]
        //[ProducesResponseType(typeof(SuccessSingleResponse<AmenityContentResponseDto>), StatusCodeAndErrorsMessagesStandard.OK)]
        //[ProducesResponseType(typeof(FailResponse), StatusCodeAndErrorsMessagesStandard.NotFound)]
        //[ProducesResponseType(typeof(FailResponse), StatusCodeAndErrorsMessagesStandard.Unauthorized)] // Unauthorized
        //[ProducesResponseType(typeof(FailResponse), StatusCodeAndErrorsMessagesStandard.Forbidden)] // Forbidden
        //public async Task<ActionResult<IResponse>> GetAmenityContent([FromRoute] int amenityId, [FromQuery] string languageCode = "en")
        //{
        //    var item = await _amenityService.GetAmenityContent(amenityId, languageCode);
        //    if (item.StatusCode == StatusCodeAndErrorsMessagesStandard.NotFound)
        //        return NotFound(item);

        //    return Ok(item);
        //}

        //[HttpPut("updateAmenityContent/{amenityId}")]
        //[Authorize(Roles = "SystemAdmin")]
        //[ProducesResponseType(typeof(SuccessSingleResponse<AmenityContentResponseDto>), StatusCodeAndErrorsMessagesStandard.OK)]
        //[ProducesResponseType(typeof(FailResponse), StatusCodeAndErrorsMessagesStandard.NotFound)]
        //[ProducesResponseType(typeof(FailResponse), StatusCodeAndErrorsMessagesStandard.Unauthorized)]
        //[ProducesResponseType(typeof(FailResponse), StatusCodeAndErrorsMessagesStandard.Forbidden)]
        //public async Task<ActionResult<IResponse>> UpdateAmenityContent([FromRoute] int amenityId, AmenityContentRequestDto requestDto, [FromQuery] string languageCode = "en")
        //{
        //    if (!ModelState.IsValid)
        //    {
        //        var errors = ModelState.Values.SelectMany(y => y.Errors).Select(e => e.ErrorMessage).ToList();
        //        var response = new FailResponse { ErrorMessages = errors, StatusCode = StatusCodeAndErrorsMessagesStandard.BadRequest, Status = false };
        //        return BadRequest(response);
        //    }

        //    var item = await _amenityService.UpdateAmenityContent(amenityId, requestDto, languageCode);

        //    if (item.StatusCode == StatusCodeAndErrorsMessagesStandard.NotFound)
        //        return NotFound(item);

        //    if (item.StatusCode == StatusCodeAndErrorsMessagesStandard.BadRequest)
        //        return BadRequest(item);


        //    return Ok(item);
        //}

    }
}
