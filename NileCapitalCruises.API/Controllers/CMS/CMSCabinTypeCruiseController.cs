using NileCapitalCruises.Infrastructure.Data.Specification.CMS;
using NileCapitalCruises.Infrastructure.Dtos.CMS.RequestDtos.AmenityDtos;
using NileCapitalCruises.Infrastructure.Dtos.CMS.RequestDtos.CabinDtos;
using NileCapitalCruises.Infrastructure.Dtos.CMS.RequestDtos.CabinTypeCruiseDtos;
using NileCapitalCruises.Infrastructure.Dtos.CMS.RequestDtos.CruiseDtos;
using NileCapitalCruises.Infrastructure.Dtos.CMS.RequestDtos.DiningDtos;
using NileCapitalCruises.Infrastructure.Dtos.CMS.ResponseDtos.CabinDtos;
using NileCapitalCruises.Infrastructure.Dtos.CMS.ResponseDtos.CabinTypeCruiseDtos;
using NileCapitalCruises.Infrastructure.Dtos.CMS.ResponseDtos.CompanyDtos;
using NileCapitalCruises.Infrastructure.Dtos.CMS.ResponseDtos.CruiseDtos;
using NileCapitalCruises.Infrastructure.Dtos.CMS.ResponseDtos.DiningDtos;
using NileCapitalCruises.Infrastructure.Helpers.ApiResponses;
using NileCapitalCruises.Infrastructure.IServices.CMS;
using NileCapitalCruises.Infrastructure.Services.CMS;
using Microsoft.AspNetCore.Authorization;
using Microsoft.AspNetCore.Mvc;

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

        [HttpPost("createCabinTypeCruise")]
        [ProducesResponseType(typeof(SuccessSingleResponse<BasicCabinTypeCruiseResponseDto>), StatusCodeAndErrorsMessagesStandard.Created)]
        [ProducesResponseType(typeof(FailResponse), StatusCodeAndErrorsMessagesStandard.BadRequest)]
        [ProducesResponseType(typeof(FailResponse), StatusCodeAndErrorsMessagesStandard.Unauthorized)] // Unauthorized
        [ProducesResponseType(typeof(FailResponse), StatusCodeAndErrorsMessagesStandard.Forbidden)] // Forbidden
        [Authorize(Roles = "SystemAdmin")]
        public async Task<ActionResult<IResponse>> CreateCabinTypeCruise(CabinTypeCruiseRequestDto requestDto, [FromQuery] int companyId)
        {
            if (!ModelState.IsValid)
            {
                var errors = ModelState.Values.SelectMany(y => y.Errors).Select(e => e.ErrorMessage).ToList();
                var response = new FailResponse { ErrorMessages = errors, StatusCode = StatusCodeAndErrorsMessagesStandard.BadRequest, Status = false };
                return BadRequest(response);
            }


            var item = await _cabinTypeCruiseService.CreateCabinTypeCruise(requestDto, companyId);
            if (item.StatusCode == StatusCodeAndErrorsMessagesStandard.BadRequest)
                return BadRequest(item);

            return Ok(item);
        }


    }
}
