using NileCapitalCruises.Infrastructure.Dtos.CMS.RequestDtos.CabinTypeCruiseDtos;
using NileCapitalCruises.Infrastructure.Dtos.CMS.ResponseDtos.CabinTypeCruiseDtos;
using NileCapitalCruises.Infrastructure.Helpers.ApiResponses;
using NileCapitalCruises.Infrastructure.IServices.CMS;
using Microsoft.AspNetCore.Authorization;
using Microsoft.AspNetCore.Mvc;
using NileCapitalCruises.Infrastructure.Data.Specification.CMS;
using NileCapitalCruises.Infrastructure.Dtos.CMS.ResponseDtos.CityDtos;
using NileCapitalCruises.Infrastructure.Services.CMS;

namespace NileCapitalCruises.API.Controllers.CMS
{
    [Route("api/cms/cabinTypeCruise")]
    [ApiController]
    public class CMSCabinTypeCruiseController : ControllerBase
    {
        private readonly ICabinTypeCruiseService _cabinTypeCruiseService;

        public CMSCabinTypeCruiseController(ICabinTypeCruiseService cabinTypeCruiseService)
        {
            _cabinTypeCruiseService = cabinTypeCruiseService;
        }

        //[HttpPost("createCabinTypeCruise")]
        //[ProducesResponseType(typeof(SuccessSingleResponse<BasicCabinTypeCruiseResponseDto>), StatusCodeAndErrorsMessagesStandard.Created)]
        //[ProducesResponseType(typeof(FailResponse), StatusCodeAndErrorsMessagesStandard.BadRequest)]
        //[ProducesResponseType(typeof(FailResponse), StatusCodeAndErrorsMessagesStandard.Unauthorized)] // Unauthorized
        //[ProducesResponseType(typeof(FailResponse), StatusCodeAndErrorsMessagesStandard.Forbidden)] // Forbidden
        //[Authorize(Roles = "SystemAdmin")]
        //public async Task<ActionResult<IResponse>> CreateCabinTypeCruise(CabinTypeCruiseRequestDto requestDto, [FromQuery] int companyId)
        //{
        //    if (!ModelState.IsValid)
        //    {
        //        var errors = ModelState.Values.SelectMany(y => y.Errors).Select(e => e.ErrorMessage).ToList();
        //        var response = new FailResponse { ErrorMessages = errors, StatusCode = StatusCodeAndErrorsMessagesStandard.BadRequest, Status = false };
        //        return BadRequest(response);
        //    }


        //    var item = await _cabinTypeCruiseService.CreateCabinTypeCruise(requestDto, companyId);
        //    if (item.StatusCode == StatusCodeAndErrorsMessagesStandard.BadRequest)
        //        return BadRequest(item);

        //    return Ok(item);
        //}

        [HttpGet("getCabinTypeCruises")]
        //[Authorize(Roles = "SystemAdmin")]
        [ProducesResponseType(typeof(SuccessPaginationResponse<CMSCabinTypeCruiseWithContentResponseDto>), StatusCodeAndErrorsMessagesStandard.OK)]
        [ProducesResponseType(typeof(FailResponse), StatusCodeAndErrorsMessagesStandard.NotFound)]
        [ProducesResponseType(typeof(FailResponse), StatusCodeAndErrorsMessagesStandard.Unauthorized)] // Unauthorized
        [ProducesResponseType(typeof(FailResponse), StatusCodeAndErrorsMessagesStandard.Forbidden)] // Forbidden
        public async Task<ActionResult<IResponse>> GetCabinTypeCruises([FromQuery] PaginationSpecParams paginationSpecParams, int cruiseId, int companyId)
        {
            var item = await _cabinTypeCruiseService.GetCabinTypeCruises(cruiseId, companyId, paginationSpecParams);

            if (item.StatusCode == StatusCodeAndErrorsMessagesStandard.NotFound)
                return NotFound(item);

            return Ok(item);
        }
    }
}
