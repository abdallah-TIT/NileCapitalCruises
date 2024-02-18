using NileCapitalCruises.Infrastructure.Data.Specification.CMS;
using NileCapitalCruises.Infrastructure.Dtos.CMS.RequestDtos.BrandDtos;
using NileCapitalCruises.Infrastructure.Dtos.CMS.RequestDtos.CompanyDtos;
using NileCapitalCruises.Infrastructure.Dtos.CMS.RequestDtos.DiningTypeDtos;
using NileCapitalCruises.Infrastructure.Dtos.CMS.ResponseDtos.BrandDtos;
using NileCapitalCruises.Infrastructure.Dtos.CMS.ResponseDtos.CompanyDtos;
using NileCapitalCruises.Infrastructure.Dtos.CMS.ResponseDtos.CruiseDtos;
using NileCapitalCruises.Infrastructure.Dtos.CMS.ResponseDtos.DiningTypeDtos;
using NileCapitalCruises.Infrastructure.Helpers.ApiResponses;
using NileCapitalCruises.Infrastructure.IServices.CMS;
using NileCapitalCruises.Infrastructure.Services.CMS;
using Microsoft.AspNetCore.Authorization;
using Microsoft.AspNetCore.Mvc;

namespace NileCapitalCruises.API.Controllers.CMS
{
    [Route("api/cms/diningType")]
    [ApiController]
    public class CMSDiningTypeController : ControllerBase
    {
        private readonly IDiningTypeService _diningTypeService;

        public CMSDiningTypeController(IDiningTypeService diningTypeService)
        {
            _diningTypeService = diningTypeService;
        }

        
        //[HttpPost("createDiningType")]
        //[Authorize(Roles = "SystemAdmin")]

        //[ProducesResponseType(typeof(SuccessPaginationResponse<BasicDiningTypeResponseDto>), StatusCodeAndErrorsMessagesStandard.OK)]
        //[ProducesResponseType(typeof(FailResponse), StatusCodeAndErrorsMessagesStandard.NotFound)]
        //[ProducesResponseType(typeof(FailResponse), StatusCodeAndErrorsMessagesStandard.Unauthorized)] // Unauthorized
        //[ProducesResponseType(typeof(FailResponse), StatusCodeAndErrorsMessagesStandard.Forbidden)] // Forbidden
        //public async Task<ActionResult<IResponse>> CreateDiningType(DiningTypeRequestDto requestDto)
        //{
        //    if (!ModelState.IsValid)
        //    {
        //        var errors = ModelState.Values.SelectMany(y => y.Errors).Select(e => e.ErrorMessage).ToList();
        //        var response = new FailResponse { ErrorMessages = errors, StatusCode = StatusCodeAndErrorsMessagesStandard.BadRequest, Status = false };
        //        return BadRequest(response);
        //    }
        //    var item = await _diningTypeService.CreateDiningType(requestDto);
        //    if (item.StatusCode == StatusCodeAndErrorsMessagesStandard.BadRequest)
        //        return BadRequest(item);

        //    return Ok(item);
        //}


        //[HttpPut("updateDiningType/{diningTypeId}")]
        //[Authorize(Roles = "SystemAdmin")]
        //[ProducesResponseType(typeof(SuccessSingleResponse<BasicDiningTypeResponseDto>), StatusCodeAndErrorsMessagesStandard.OK)]
        //[ProducesResponseType(typeof(FailResponse), StatusCodeAndErrorsMessagesStandard.NotFound)]
        //[ProducesResponseType(typeof(FailResponse), StatusCodeAndErrorsMessagesStandard.Unauthorized)]
        //[ProducesResponseType(typeof(FailResponse), StatusCodeAndErrorsMessagesStandard.Forbidden)]
        //public async Task<ActionResult<IResponse>> UpdateDiningType([FromRoute] int diningTypeId, DiningTypeRequestDto requestDto)
        //{
        //    if (!ModelState.IsValid)
        //    {
        //        var errors = ModelState.Values.SelectMany(y => y.Errors).Select(e => e.ErrorMessage).ToList();
        //        var response = new FailResponse { ErrorMessages = errors, StatusCode = StatusCodeAndErrorsMessagesStandard.BadRequest, Status = false };
        //        return BadRequest(response);
        //    }

        //    var item = await _diningTypeService.UpdateDiningType(diningTypeId, requestDto);

        //    if (item.StatusCode == StatusCodeAndErrorsMessagesStandard.NotFound)
        //        return NotFound(item);

        //    if (item.StatusCode == StatusCodeAndErrorsMessagesStandard.BadRequest)
        //        return BadRequest(item);


        //    return Ok(item);
        //}


        //[HttpDelete("deleteDiningType/{diningTypeId}")]
        //[Authorize(Roles = "SystemAdmin")]
        //[ProducesResponseType(typeof(BaseSuccessResponse), StatusCodeAndErrorsMessagesStandard.OK)]
        //[ProducesResponseType(typeof(FailResponse), StatusCodeAndErrorsMessagesStandard.NotFound)]
        //[ProducesResponseType(typeof(FailResponse), StatusCodeAndErrorsMessagesStandard.Unauthorized)]
        //[ProducesResponseType(typeof(FailResponse), StatusCodeAndErrorsMessagesStandard.Forbidden)]
        //public async Task<ActionResult<IResponse>> DeleteDiningType([FromRoute] int diningTypeId)
        //{

        //    var item = await _diningTypeService.DeleteDiningType(diningTypeId);

        //    if (item.StatusCode == StatusCodeAndErrorsMessagesStandard.NotFound)
        //        return NotFound(item);

        //    if (item.StatusCode == StatusCodeAndErrorsMessagesStandard.BadRequest)
        //        return BadRequest(item);


        //    return Ok(item);
        //}


        //[HttpGet("getDiningTypes")]
        //[Authorize(Roles = "SystemAdmin")]
        //[ProducesResponseType(typeof(SuccessPaginationResponse<IEnumerable<DiningTypeWithContentResponseDto>>), StatusCodeAndErrorsMessagesStandard.OK)]
        //[ProducesResponseType(typeof(FailResponse), StatusCodeAndErrorsMessagesStandard.NotFound)]
        //[ProducesResponseType(typeof(FailResponse), StatusCodeAndErrorsMessagesStandard.Unauthorized)] // Unauthorized
        //[ProducesResponseType(typeof(FailResponse), StatusCodeAndErrorsMessagesStandard.Forbidden)] // Forbidden
        //public async Task<ActionResult<IResponse>> GetDiningTypes([FromQuery] PaginationSpecParams paginationSpecParams)
        //{
        //    var item = await _diningTypeService.GetDiningTypes(paginationSpecParams);

        //    if (item.StatusCode == StatusCodeAndErrorsMessagesStandard.NotFound)
        //        return NotFound(item);

        //    return Ok(item);
        //}


        //[HttpGet("getDiningTypeById/{diningTypeId}")]
        //[Authorize(Roles = "SystemAdmin")]
        //[ProducesResponseType(typeof(SuccessSingleResponse<BasicDiningTypeResponseDto>), StatusCodeAndErrorsMessagesStandard.OK)]
        //[ProducesResponseType(typeof(FailResponse), StatusCodeAndErrorsMessagesStandard.NotFound)]
        //[ProducesResponseType(typeof(FailResponse), StatusCodeAndErrorsMessagesStandard.Unauthorized)] // Unauthorized
        //[ProducesResponseType(typeof(FailResponse), StatusCodeAndErrorsMessagesStandard.Forbidden)] // Forbidden
        //public async Task<ActionResult<IResponse>> GetDiningType([FromRoute] int diningTypeId)
        //{
        //    var item = await _diningTypeService.GetDiningType(diningTypeId);
        //    if (item.StatusCode == StatusCodeAndErrorsMessagesStandard.NotFound)
        //        return NotFound(item);

        //    return Ok(item);
        //}


        //[HttpGet("getDiningTypeContent/{diningTypeId}")]
        //[Authorize(Roles = "SystemAdmin")]
        //[ProducesResponseType(typeof(SuccessSingleResponse<DiningTypeContentResponseDto>), StatusCodeAndErrorsMessagesStandard.OK)]
        //[ProducesResponseType(typeof(FailResponse), StatusCodeAndErrorsMessagesStandard.NotFound)]
        //[ProducesResponseType(typeof(FailResponse), StatusCodeAndErrorsMessagesStandard.Unauthorized)] // Unauthorized
        //[ProducesResponseType(typeof(FailResponse), StatusCodeAndErrorsMessagesStandard.Forbidden)] // Forbidden
        //public async Task<ActionResult<IResponse>> GetDiningTypeContent([FromRoute] int diningTypeId, [FromQuery] string languageCode = "en")
        //{
        //    var item = await _diningTypeService.GetDiningTypeContent(diningTypeId, languageCode);
        //    if (item.StatusCode == StatusCodeAndErrorsMessagesStandard.NotFound)
        //        return NotFound(item);

        //    return Ok(item);
        //}


        //[HttpPut("updateDiningTypeContent/{diningTypeId}")]
        //[Authorize(Roles = "SystemAdmin")]
        //[ProducesResponseType(typeof(SuccessSingleResponse<DiningTypeContentResponseDto>), StatusCodeAndErrorsMessagesStandard.OK)]
        //[ProducesResponseType(typeof(FailResponse), StatusCodeAndErrorsMessagesStandard.NotFound)]
        //[ProducesResponseType(typeof(FailResponse), StatusCodeAndErrorsMessagesStandard.Unauthorized)]
        //[ProducesResponseType(typeof(FailResponse), StatusCodeAndErrorsMessagesStandard.Forbidden)]
        //public async Task<ActionResult<IResponse>> UpdateDiningTypeContent([FromRoute] int diningTypeId, DiningTypeContentRequestDto requestDto, [FromQuery] string languageCode = "en")
        //{
        //    if (!ModelState.IsValid)
        //    {
        //        var errors = ModelState.Values.SelectMany(y => y.Errors).Select(e => e.ErrorMessage).ToList();
        //        var response = new FailResponse { ErrorMessages = errors, StatusCode = StatusCodeAndErrorsMessagesStandard.BadRequest, Status = false };
        //        return BadRequest(response);
        //    }

        //    var item = await _diningTypeService.UpdateDiningTypeContent(diningTypeId, requestDto, languageCode);

        //    if (item.StatusCode == StatusCodeAndErrorsMessagesStandard.NotFound)
        //        return NotFound(item);

        //    if (item.StatusCode == StatusCodeAndErrorsMessagesStandard.BadRequest)
        //        return BadRequest(item);


        //    return Ok(item);
        //}



    }
}
