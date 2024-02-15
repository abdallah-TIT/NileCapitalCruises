using NileCapitalCruises.Infrastructure.Data.Specification.CMS;
using NileCapitalCruises.Infrastructure.Dtos.CMS.RequestDtos.BrandDtos;
using NileCapitalCruises.Infrastructure.Dtos.CMS.RequestDtos.CruiseCategoryDtos;
using NileCapitalCruises.Infrastructure.Dtos.CMS.RequestDtos.CruiseDtos;
using NileCapitalCruises.Infrastructure.Dtos.CMS.RequestDtos.FacilityDtos;
using NileCapitalCruises.Infrastructure.Dtos.CMS.ResponseDtos.BrandDtos;
using NileCapitalCruises.Infrastructure.Dtos.CMS.ResponseDtos.CruisCategoryDtos;
using NileCapitalCruises.Infrastructure.Helpers.ApiResponses;
using NileCapitalCruises.Infrastructure.IServices.CMS;
using NileCapitalCruises.Infrastructure.Services.CMS;
using Microsoft.AspNetCore.Authorization;
using Microsoft.AspNetCore.JsonPatch;
using Microsoft.AspNetCore.Mvc;

namespace NileCapitalCruises.API.Controllers.CMS
{
    [Route("api/cms/cruiseCategory")]
    [ApiController]
    public class CMSCruiseCategoryController : ControllerBase
    {
        private readonly ICruiseCategoryService _cruiseCategoryService;

        public CMSCruiseCategoryController(ICruiseCategoryService cruiseCategoryService)
        {
            _cruiseCategoryService = cruiseCategoryService;
        }

        [HttpPost("createCruiseCategory")]
        //[Authorize(Roles = "SystemAdmin")]

        [ProducesResponseType(typeof(SuccessPaginationResponse<CMSBasicCruiseCategoryResponseDto>), StatusCodeAndErrorsMessagesStandard.OK)]
        [ProducesResponseType(typeof(FailResponse), StatusCodeAndErrorsMessagesStandard.NotFound)]
        [ProducesResponseType(typeof(FailResponse), StatusCodeAndErrorsMessagesStandard.Unauthorized)] // Unauthorized
        [ProducesResponseType(typeof(FailResponse), StatusCodeAndErrorsMessagesStandard.Forbidden)] // Forbidden
        public async Task<ActionResult<IResponse>> CreateCruiseCategory(CMSCruiseCategoryRequestDto requestDto)
        {
            if (!ModelState.IsValid)
            {
                var errors = ModelState.Values.SelectMany(y => y.Errors).Select(e => e.ErrorMessage).ToList();
                var response = new FailResponse { ErrorMessages = errors, StatusCode = StatusCodeAndErrorsMessagesStandard.BadRequest, Status = false };
                return BadRequest(response);
            }
            var item = await _cruiseCategoryService.CreateCruiseCategory(requestDto);
            if (item.StatusCode == StatusCodeAndErrorsMessagesStandard.BadRequest)
                return BadRequest(item);

            return Ok(item);
        }



        [HttpPut("updateCruiseCategory/{cruiseCategoryId}")]
        [Authorize(Roles = "SystemAdmin")]
        [ProducesResponseType(typeof(SuccessSingleResponse<CMSBasicCruiseCategoryResponseDto>), StatusCodeAndErrorsMessagesStandard.OK)]
        [ProducesResponseType(typeof(FailResponse), StatusCodeAndErrorsMessagesStandard.NotFound)]
        [ProducesResponseType(typeof(FailResponse), StatusCodeAndErrorsMessagesStandard.Unauthorized)]
        [ProducesResponseType(typeof(FailResponse), StatusCodeAndErrorsMessagesStandard.Forbidden)]
        public async Task<ActionResult<IResponse>> UpdateCruiseCategory([FromRoute] int cruiseCategoryId, CMSCruiseCategoryRequestDto requestDto)
        {
            if (!ModelState.IsValid)
            {
                var errors = ModelState.Values.SelectMany(y => y.Errors).Select(e => e.ErrorMessage).ToList();
                var response = new FailResponse { ErrorMessages = errors, StatusCode = StatusCodeAndErrorsMessagesStandard.BadRequest, Status = false };
                return BadRequest(response);
            }

            var item = await _cruiseCategoryService.UpdateCruiseCategory(cruiseCategoryId, requestDto);

            if (item.StatusCode == StatusCodeAndErrorsMessagesStandard.NotFound)
                return NotFound(item);

            if (item.StatusCode == StatusCodeAndErrorsMessagesStandard.BadRequest)
                return BadRequest(item);


            return Ok(item);
        }


        [HttpDelete("deleteCruiseCategory/{cruiseCategoryId}")]
        [Authorize(Roles = "SystemAdmin")]
        [ProducesResponseType(typeof(BaseSuccessResponse), StatusCodeAndErrorsMessagesStandard.OK)]
        [ProducesResponseType(typeof(FailResponse), StatusCodeAndErrorsMessagesStandard.NotFound)]
        [ProducesResponseType(typeof(FailResponse), StatusCodeAndErrorsMessagesStandard.Unauthorized)]
        [ProducesResponseType(typeof(FailResponse), StatusCodeAndErrorsMessagesStandard.Forbidden)]
        public async Task<ActionResult<IResponse>> DeleteCruiseCategory([FromRoute] int cruiseCategoryId)
        {

            var item = await _cruiseCategoryService.DeleteCruiseCategory(cruiseCategoryId);

            if (item.StatusCode == StatusCodeAndErrorsMessagesStandard.NotFound)
                return NotFound(item);

            if (item.StatusCode == StatusCodeAndErrorsMessagesStandard.BadRequest)
                return BadRequest(item);


            return Ok(item);
        }



        [HttpGet("getCruiseCategories")]
        [Authorize(Roles = "SystemAdmin")]
        [ProducesResponseType(typeof(SuccessPaginationResponse<IEnumerable<CMSCruiseCategoryWithContentResponseDto>>), StatusCodeAndErrorsMessagesStandard.OK)]
        [ProducesResponseType(typeof(FailResponse), StatusCodeAndErrorsMessagesStandard.NotFound)]
        [ProducesResponseType(typeof(FailResponse), StatusCodeAndErrorsMessagesStandard.Unauthorized)] // Unauthorized
        [ProducesResponseType(typeof(FailResponse), StatusCodeAndErrorsMessagesStandard.Forbidden)] // Forbidden
        public async Task<ActionResult<IResponse>> GetCruiseCategories([FromQuery] PaginationSpecParams paginationSpecParams)
        {
            var item = await _cruiseCategoryService.GetCruiseCategories(paginationSpecParams);

            if (item.StatusCode == StatusCodeAndErrorsMessagesStandard.NotFound)
                return NotFound(item);

            return Ok(item);
        }

        [HttpGet("getCruiseCategoryById/{cruiseCategoryId}")]
        [Authorize(Roles = "SystemAdmin")]
        [ProducesResponseType(typeof(SuccessSingleResponse<CMSBasicCruiseCategoryResponseDto>), StatusCodeAndErrorsMessagesStandard.OK)]
        [ProducesResponseType(typeof(FailResponse), StatusCodeAndErrorsMessagesStandard.NotFound)]
        [ProducesResponseType(typeof(FailResponse), StatusCodeAndErrorsMessagesStandard.Unauthorized)] // Unauthorized
        [ProducesResponseType(typeof(FailResponse), StatusCodeAndErrorsMessagesStandard.Forbidden)] // Forbidden
        public async Task<ActionResult<IResponse>> GetCruiseCategoryById([FromRoute] int cruiseCategoryId)
        {
            var item = await _cruiseCategoryService.GetCruiseCategory(cruiseCategoryId);
            if (item.StatusCode == StatusCodeAndErrorsMessagesStandard.NotFound)
                return NotFound(item);

            return Ok(item);
        }

        [HttpGet("getCruiseCategoryContent/{cruiseCategoryId}")]
        [Authorize(Roles = "SystemAdmin")]
        [ProducesResponseType(typeof(SuccessSingleResponse<CMSBrandContentResponseDto>), StatusCodeAndErrorsMessagesStandard.OK)]
        [ProducesResponseType(typeof(FailResponse), StatusCodeAndErrorsMessagesStandard.NotFound)]
        [ProducesResponseType(typeof(FailResponse), StatusCodeAndErrorsMessagesStandard.Unauthorized)] // Unauthorized
        [ProducesResponseType(typeof(FailResponse), StatusCodeAndErrorsMessagesStandard.Forbidden)] // Forbidden
        public async Task<ActionResult<IResponse>> GetCruiseCategoryContent([FromRoute] int cruiseCategoryId, [FromQuery] string languageCode = "en")
        {
            var item = await _cruiseCategoryService.GetCruiseCategoryContent(cruiseCategoryId, languageCode);
            if (item.StatusCode == StatusCodeAndErrorsMessagesStandard.NotFound)
                return NotFound(item);

            return Ok(item);
        }

        [HttpPut("updateCruiseCategoryContent/{cruiseCategoryId}")]
        [Authorize(Roles = "SystemAdmin")]
        [ProducesResponseType(typeof(SuccessSingleResponse<CMSCruiseCategoryContentResponseDto>), StatusCodeAndErrorsMessagesStandard.OK)]
        [ProducesResponseType(typeof(FailResponse), StatusCodeAndErrorsMessagesStandard.NotFound)]
        [ProducesResponseType(typeof(FailResponse), StatusCodeAndErrorsMessagesStandard.Unauthorized)]
        [ProducesResponseType(typeof(FailResponse), StatusCodeAndErrorsMessagesStandard.Forbidden)]
        public async Task<ActionResult<IResponse>> UpdateCruiseCategoryContent([FromRoute] int cruiseCategoryId, CMSCruiseCategoryContentRequestDto requestDto, [FromQuery] string languageCode = "en")
        {
            if (!ModelState.IsValid)
            {
                var errors = ModelState.Values.SelectMany(y => y.Errors).Select(e => e.ErrorMessage).ToList();
                var response = new FailResponse { ErrorMessages = errors, StatusCode = StatusCodeAndErrorsMessagesStandard.BadRequest, Status = false };
                return BadRequest(response);
            }

            var item = await _cruiseCategoryService.UpdateCruiseCategoryContent(cruiseCategoryId, requestDto, languageCode);

            if (item.StatusCode == StatusCodeAndErrorsMessagesStandard.NotFound)
                return NotFound(item);

            if (item.StatusCode == StatusCodeAndErrorsMessagesStandard.BadRequest)
                return BadRequest(item);


            return Ok(item);
        }


    }
}
