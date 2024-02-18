using NileCapitalCruises.Infrastructure.Data.Specification.CMS;
using NileCapitalCruises.Infrastructure.Dtos.CMS.RequestDtos.CompanyUserCruiseDtos;
using NileCapitalCruises.Infrastructure.Dtos.CMS.RequestDtos.CompanyUserDtos;
using NileCapitalCruises.Infrastructure.Dtos.CMS.ResponseDtos.CruiseDtos;
using NileCapitalCruises.Infrastructure.Helpers.ApiResponses;
using NileCapitalCruises.Infrastructure.IServices.CMS;
using Microsoft.AspNetCore.Authorization;
using Microsoft.AspNetCore.Mvc;

namespace NileCapitalCruises.API.Controllers.CMS
{
    //[Route("api/cms/companyUserCruise")]
    [ApiController]
    public class CMSCompanyUserCruiseController : ControllerBase
    {
        private readonly ICompanyUserCruiseService _companyUserCruiseService;

        public CMSCompanyUserCruiseController(ICompanyUserCruiseService companyUserCruiseService)
        {
            _companyUserCruiseService = companyUserCruiseService;
        }


        //[HttpPost("assignCruiseToUser")]
        //[Authorize(Roles = "SystemAdmin, CompanyAdmin")]

        //[ProducesResponseType(typeof(BaseSuccessResponse), StatusCodeAndErrorsMessagesStandard.OK)]
        //[ProducesResponseType(typeof(FailResponse), StatusCodeAndErrorsMessagesStandard.NotFound)]
        //[ProducesResponseType(typeof(FailResponse), StatusCodeAndErrorsMessagesStandard.Unauthorized)] // Unauthorized
        //[ProducesResponseType(typeof(FailResponse), StatusCodeAndErrorsMessagesStandard.Forbidden)] // Forbidden
        //public async Task<ActionResult<IResponse>> AssignCruiseToUser([FromQuery] int companyId, [FromBody] CompanyUserCruiseRequestDto requestDto)
        //{
        //    if (!ModelState.IsValid)
        //    {
        //        var errors = ModelState.Values.SelectMany(y => y.Errors).Select(e => e.ErrorMessage).ToList();
        //        var response = new FailResponse { ErrorMessages = errors, StatusCode = StatusCodeAndErrorsMessagesStandard.BadRequest, Status = false };
        //        return BadRequest(response);
        //    }
        //    var item = await _companyUserCruiseService.AssignCruiseToUser(companyId, requestDto);
        //    if (item.StatusCode == StatusCodeAndErrorsMessagesStandard.BadRequest)
        //        return BadRequest(item);

        //    return Ok(item);

        //}

        //[HttpPost("removeCruiseFromUser")]
        //[Authorize(Roles = "SystemAdmin, CompanyAdmin")]

        //[ProducesResponseType(typeof(BaseSuccessResponse), StatusCodeAndErrorsMessagesStandard.OK)]
        //[ProducesResponseType(typeof(FailResponse), StatusCodeAndErrorsMessagesStandard.NotFound)]
        //[ProducesResponseType(typeof(FailResponse), StatusCodeAndErrorsMessagesStandard.Unauthorized)] // Unauthorized
        //[ProducesResponseType(typeof(FailResponse), StatusCodeAndErrorsMessagesStandard.Forbidden)] // Forbidden
        //public async Task<ActionResult<IResponse>> RemoveCruiseFromUser([FromQuery] int companyId, [FromBody] CompanyUserCruiseRequestDto requestDto)
        //{
        //    if (!ModelState.IsValid)
        //    {
        //        var errors = ModelState.Values.SelectMany(y => y.Errors).Select(e => e.ErrorMessage).ToList();
        //        var response = new FailResponse { ErrorMessages = errors, StatusCode = StatusCodeAndErrorsMessagesStandard.BadRequest, Status = false };
        //        return BadRequest(response);
        //    }
        //    var item = await _companyUserCruiseService.RemoveCruiseFromUser(companyId, requestDto);
        //    if (item.StatusCode == StatusCodeAndErrorsMessagesStandard.BadRequest)
        //        return BadRequest(item);

        //    return Ok(item);

        //}


        //[HttpPost("getCruisesForUser")]
        //[Authorize(Roles = "SystemAdmin, CompanyAdmin")]

        //[ProducesResponseType(typeof(SuccessPaginationResponse<IEnumerable<CMSCruiseWithContentResponseDto>>), StatusCodeAndErrorsMessagesStandard.OK)]
        //[ProducesResponseType(typeof(FailResponse), StatusCodeAndErrorsMessagesStandard.NotFound)]
        //[ProducesResponseType(typeof(FailResponse), StatusCodeAndErrorsMessagesStandard.Unauthorized)] // Unauthorized
        //[ProducesResponseType(typeof(FailResponse), StatusCodeAndErrorsMessagesStandard.Forbidden)] // Forbidden
        //public async Task<ActionResult<IResponse>> GetCruisesForUser([FromQuery] int companyUserId, [FromQuery] int companyId, [FromQuery] PaginationSpecParams requestDto)
        //{
        //    if (!ModelState.IsValid)
        //    {
        //        var errors = ModelState.Values.SelectMany(y => y.Errors).Select(e => e.ErrorMessage).ToList();
        //        var response = new FailResponse { ErrorMessages = errors, StatusCode = StatusCodeAndErrorsMessagesStandard.BadRequest, Status = false };
        //        return BadRequest(response);
        //    }
        //    var item = await _companyUserCruiseService.GetCruisesForUser(companyUserId, companyId, requestDto);
        //    if (item.StatusCode == StatusCodeAndErrorsMessagesStandard.BadRequest)
        //        return BadRequest(item);

        //    else if (item.StatusCode == StatusCodeAndErrorsMessagesStandard.NotFound)
        //        return NotFound(item);


        //    return Ok(item);

        //}


        //[HttpPost("getUsersForCruise")]
        //[Authorize(Roles = "SystemAdmin, CompanyAdmin")]

        //[ProducesResponseType(typeof(SuccessPaginationResponse<IEnumerable<CompanyUserResponseDto>>), StatusCodeAndErrorsMessagesStandard.OK)]
        //[ProducesResponseType(typeof(FailResponse), StatusCodeAndErrorsMessagesStandard.NotFound)]
        //[ProducesResponseType(typeof(FailResponse), StatusCodeAndErrorsMessagesStandard.Unauthorized)] // Unauthorized
        //[ProducesResponseType(typeof(FailResponse), StatusCodeAndErrorsMessagesStandard.Forbidden)] // Forbidden
        //public async Task<ActionResult<IResponse>> GetUsersForCruise([FromQuery] int cruiseId, [FromQuery] int companyId, [FromQuery] PaginationSpecParams requestDto)
        //{
        //    if (!ModelState.IsValid)
        //    {
        //        var errors = ModelState.Values.SelectMany(y => y.Errors).Select(e => e.ErrorMessage).ToList();
        //        var response = new FailResponse { ErrorMessages = errors, StatusCode = StatusCodeAndErrorsMessagesStandard.BadRequest, Status = false };
        //        return BadRequest(response);
        //    }
        //    var item = await _companyUserCruiseService.GetUsersForCruise(cruiseId, companyId, requestDto);
        //    if (item.StatusCode == StatusCodeAndErrorsMessagesStandard.BadRequest)
        //        return BadRequest(item);

        //    else if (item.StatusCode == StatusCodeAndErrorsMessagesStandard.NotFound)
        //        return NotFound(item);


        //    return Ok(item);

        //}


        //[HttpPost("assignCruiseToUserTest")]
        //[Authorize(Roles = "SystemAdmin, CompanyAdmin")]

        //[ProducesResponseType(typeof(BaseSuccessResponse), StatusCodeAndErrorsMessagesStandard.OK)]
        //[ProducesResponseType(typeof(FailResponse), StatusCodeAndErrorsMessagesStandard.NotFound)]
        //[ProducesResponseType(typeof(FailResponse), StatusCodeAndErrorsMessagesStandard.Unauthorized)] // Unauthorized
        //[ProducesResponseType(typeof(FailResponse), StatusCodeAndErrorsMessagesStandard.Forbidden)] // Forbidden
        //public async Task<IActionResult> AssignCruiseToUserTest([FromBody] IEnumerable<CompanyUserCruiseRequestDto> requestDto)
        //{
        //    if (!ModelState.IsValid)
        //    {
        //        var errors = ModelState.Values.SelectMany(y => y.Errors).Select(e => e.ErrorMessage).ToList();
        //        var response = new FailResponse { ErrorMessages = errors, StatusCode = StatusCodeAndErrorsMessagesStandard.BadRequest, Status = false };
        //        return BadRequest(response);
        //    }
        //    var item = await _companyUserCruiseService.AssignCruiseToUserTest(requestDto);


        //    return Ok(item);

        //}

    }
}
