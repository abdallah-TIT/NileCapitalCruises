using NileCapitalCruises.Infrastructure.Data.Specification.CMS;
using NileCapitalCruises.Infrastructure.Dtos.CMS.RequestDtos.AmenityDtos;
using NileCapitalCruises.Infrastructure.Dtos.CMS.RequestDtos.CabinDtos;
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
    [Route("api/cms/cabin")]
    [ApiController]
    public class CMSCabinController : ControllerBase
    {
        private readonly ICabinService _cabinService;

        public CMSCabinController(ICabinService cabinService)
        {
            _cabinService = cabinService;
        }

        [HttpPost("createCabin")]
        [ProducesResponseType(typeof(SuccessSingleResponse<BasicCabinResponseDto>), StatusCodeAndErrorsMessagesStandard.Created)]
        [ProducesResponseType(typeof(FailResponse), StatusCodeAndErrorsMessagesStandard.BadRequest)]
        [ProducesResponseType(typeof(FailResponse), StatusCodeAndErrorsMessagesStandard.Unauthorized)] // Unauthorized
        [ProducesResponseType(typeof(FailResponse), StatusCodeAndErrorsMessagesStandard.Forbidden)] // Forbidden
        [Authorize(Roles = "SystemAdmin")]
        public async Task<ActionResult<IResponse>> CreateCabin(CabinRequestDto requestDto, [FromQuery] int companyId)
        {
            if (!ModelState.IsValid)
            {
                var errors = ModelState.Values.SelectMany(y => y.Errors).Select(e => e.ErrorMessage).ToList();
                var response = new FailResponse { ErrorMessages = errors, StatusCode = StatusCodeAndErrorsMessagesStandard.BadRequest, Status = false };
                return BadRequest(response);
            }


            var item = await _cabinService.CreateCabin(requestDto, companyId);
            if (item.StatusCode == StatusCodeAndErrorsMessagesStandard.BadRequest)
                return BadRequest(item);

            return Ok(item);
        }


        [HttpPut("updateCabin/{cabinId}")]
        [Authorize(Roles = "SystemAdmin")]
        [ProducesResponseType(typeof(SuccessSingleResponse<BasicCabinResponseDto>), StatusCodeAndErrorsMessagesStandard.OK)]
        [ProducesResponseType(typeof(FailResponse), StatusCodeAndErrorsMessagesStandard.NotFound)]
        [ProducesResponseType(typeof(FailResponse), StatusCodeAndErrorsMessagesStandard.Unauthorized)]
        [ProducesResponseType(typeof(FailResponse), StatusCodeAndErrorsMessagesStandard.Forbidden)]
        public async Task<ActionResult<IResponse>> UpdateCabin([FromRoute] int cabinId, [FromQuery] int companyId, CabinRequestDto requestDto)
        {
            if (!ModelState.IsValid)
            {
                var errors = ModelState.Values.SelectMany(y => y.Errors).Select(e => e.ErrorMessage).ToList();
                var response = new FailResponse { ErrorMessages = errors, StatusCode = StatusCodeAndErrorsMessagesStandard.BadRequest, Status = false };
                return BadRequest(response);
            }

            var item = await _cabinService.UpdateCabin(cabinId, companyId, requestDto);

            if (item.StatusCode == StatusCodeAndErrorsMessagesStandard.NotFound)
                return NotFound(item);

            if (item.StatusCode == StatusCodeAndErrorsMessagesStandard.BadRequest)
                return BadRequest(item);


            return Ok(item);
        }

        [HttpDelete("deleteCabin/{cabinId}")]
        [Authorize(Roles = "SystemAdmin")]

        [ProducesResponseType(typeof(BaseSuccessResponse), StatusCodeAndErrorsMessagesStandard.OK)]
        [ProducesResponseType(typeof(FailResponse), StatusCodeAndErrorsMessagesStandard.NotFound)]
        [ProducesResponseType(typeof(FailResponse), StatusCodeAndErrorsMessagesStandard.Unauthorized)]
        [ProducesResponseType(typeof(FailResponse), StatusCodeAndErrorsMessagesStandard.Forbidden)]
        public async Task<ActionResult<IResponse>> DeleteCabin([FromRoute] int cabinId, [FromQuery] int companyId)
        {

            var item = await _cabinService.DeleteCabin(cabinId, companyId);

            if (item.StatusCode == StatusCodeAndErrorsMessagesStandard.NotFound)
                return NotFound(item);

            if (item.StatusCode == StatusCodeAndErrorsMessagesStandard.BadRequest)
                return BadRequest(item);


            return Ok(item);
        }


        [HttpGet("getCabins")]
        [ProducesResponseType(typeof(SuccessPaginationResponse<IEnumerable<CabinWithContentResponseDto>>), StatusCodeAndErrorsMessagesStandard.OK)]
        [ProducesResponseType(typeof(FailResponse), StatusCodeAndErrorsMessagesStandard.NotFound)]
        [ProducesResponseType(typeof(FailResponse), StatusCodeAndErrorsMessagesStandard.Unauthorized)] // Unauthorized
        [ProducesResponseType(typeof(FailResponse), StatusCodeAndErrorsMessagesStandard.Forbidden)] // Forbidden
        [Authorize(Roles = "SystemAdmin, CompanyAdmin, CompanyUser")]
        public async Task<ActionResult<IResponse>> GetCabins([FromQuery] int cruiseId, int companyId,[FromQuery] PaginationSpecParams paginationSpecParams)
        {
            var item = await _cabinService.GetCabins(cruiseId, companyId, paginationSpecParams);

            if (item.StatusCode == StatusCodeAndErrorsMessagesStandard.NotFound)
                return NotFound(item);

            return Ok(item);
        }

        [HttpGet("getCabinById/{cabinId}")]

        [ProducesResponseType(typeof(SuccessSingleResponse<BasicCabinResponseDto>), StatusCodeAndErrorsMessagesStandard.OK)]
        [ProducesResponseType(typeof(FailResponse), StatusCodeAndErrorsMessagesStandard.NotFound)]
        [ProducesResponseType(typeof(FailResponse), StatusCodeAndErrorsMessagesStandard.Unauthorized)] // Unauthorized
        [ProducesResponseType(typeof(FailResponse), StatusCodeAndErrorsMessagesStandard.Forbidden)] // Forbidden
        public async Task<ActionResult<IResponse>> GetCabin([FromRoute] int cabinId, [FromQuery] int companyId)
        {
            var item = await _cabinService.GetCabin(cabinId, companyId);
            if (item.StatusCode == StatusCodeAndErrorsMessagesStandard.NotFound)
                return NotFound(item);

            return Ok(item);
        }

        [HttpGet("getCabinContent/{cabinId}")]
        [ProducesResponseType(typeof(SuccessSingleResponse<CabinContentResponseDto>), StatusCodeAndErrorsMessagesStandard.OK)]
        [ProducesResponseType(typeof(FailResponse), StatusCodeAndErrorsMessagesStandard.NotFound)]
        [ProducesResponseType(typeof(FailResponse), StatusCodeAndErrorsMessagesStandard.Unauthorized)] // Unauthorized
        [ProducesResponseType(typeof(FailResponse), StatusCodeAndErrorsMessagesStandard.Forbidden)] // Forbidden
        [Authorize(Roles = "SystemAdmin, CompanyAdmin, CompanyUser")]
        public async Task<ActionResult<IResponse>> GetCabinContent([FromRoute] int cabinId, [FromQuery] int companyId, [FromQuery] string languageCode = "en")
        {
            var item = await _cabinService.GetCabinContent(cabinId, companyId, languageCode);
            if (item.StatusCode == StatusCodeAndErrorsMessagesStandard.NotFound)
                return NotFound(item);

            return Ok(item);
        }


        [HttpPut("updateCabinContent/{cabinId}")]
        [ProducesResponseType(typeof(SuccessSingleResponse<BasicCabinResponseDto>), StatusCodeAndErrorsMessagesStandard.OK)]
        [ProducesResponseType(typeof(FailResponse), StatusCodeAndErrorsMessagesStandard.NotFound)]
        [ProducesResponseType(typeof(FailResponse), StatusCodeAndErrorsMessagesStandard.Unauthorized)]
        [ProducesResponseType(typeof(FailResponse), StatusCodeAndErrorsMessagesStandard.Forbidden)]
        [Authorize(Roles = "SystemAdmin, CompanyAdmin, CompanyUser")]
        public async Task<ActionResult<IResponse>> UpdateCabinContent([FromRoute] int cabinId, [FromQuery] int companyId, CabinContentRequestDto requestDto, [FromQuery] string languageCode = "en")
        {
            if (!ModelState.IsValid)
            {
                var errors = ModelState.Values.SelectMany(y => y.Errors).Select(e => e.ErrorMessage).ToList();
                var response = new FailResponse { ErrorMessages = errors, StatusCode = StatusCodeAndErrorsMessagesStandard.BadRequest, Status = false };
                return BadRequest(response);
            }

            var item = await _cabinService.UpdateCabinContent(cabinId, companyId, requestDto, languageCode);

            if (item.StatusCode == StatusCodeAndErrorsMessagesStandard.NotFound)
                return NotFound(item);

            if (item.StatusCode == StatusCodeAndErrorsMessagesStandard.BadRequest)
                return BadRequest(item);


            return Ok(item);
        }


        [HttpPost("createCabinPhotos/{cabinId}")]
        [ProducesResponseType(typeof(SuccessSingleResponse<IEnumerable<CabinPhotoResponseDto>>), StatusCodeAndErrorsMessagesStandard.OK)]
        [ProducesResponseType(typeof(FailResponse), StatusCodeAndErrorsMessagesStandard.NotFound)]
        [ProducesResponseType(typeof(FailResponse), StatusCodeAndErrorsMessagesStandard.Unauthorized)]
        [ProducesResponseType(typeof(FailResponse), StatusCodeAndErrorsMessagesStandard.Forbidden)]
        [Authorize(Roles = "SystemAdmin, CompanyAdmin, CompanyUser")]
        public async Task<ActionResult<IResponse>> CreateCabinPhotos([FromRoute] int cabinId, [FromQuery] int companyId, IEnumerable<CabinPhotoRequestDto> requestDto)
        {
            if (!ModelState.IsValid)
            {
                var errors = ModelState.Values.SelectMany(y => y.Errors).Select(e => e.ErrorMessage).ToList();
                var response = new FailResponse { ErrorMessages = errors, StatusCode = StatusCodeAndErrorsMessagesStandard.BadRequest, Status = false };
                return BadRequest(response);
            }

            var item = await _cabinService.CreateCabinPhotos(cabinId, companyId, requestDto);

            if (item.StatusCode == StatusCodeAndErrorsMessagesStandard.NotFound)
                return NotFound(item);

            if (item.StatusCode == StatusCodeAndErrorsMessagesStandard.BadRequest)
                return BadRequest(item);


            return Ok(item);
        }




        [HttpGet("getCabinPhotos/{cabinId}")]
        [ProducesResponseType(typeof(SuccessSingleResponse<IEnumerable<CabinPhotoResponseDto>>), StatusCodeAndErrorsMessagesStandard.OK)]
        [ProducesResponseType(typeof(FailResponse), StatusCodeAndErrorsMessagesStandard.NotFound)]
        [ProducesResponseType(typeof(FailResponse), StatusCodeAndErrorsMessagesStandard.Unauthorized)] // Unauthorized
        [ProducesResponseType(typeof(FailResponse), StatusCodeAndErrorsMessagesStandard.Forbidden)] // Forbidden
        [Authorize(Roles = "SystemAdmin, CompanyAdmin, CompanyUser")]
        public async Task<ActionResult<IResponse>> GetCabinPhotos([FromRoute] int cabinId, [FromQuery] int companyId)
        {
            var item = await _cabinService.GetCabinPhotos(cabinId, companyId);
            if (item.StatusCode == StatusCodeAndErrorsMessagesStandard.NotFound)
                return NotFound(item);

            return Ok(item);
        }


        [HttpDelete("deleteCabinPhoto/{photoId}")]
        [ProducesResponseType(typeof(BaseSuccessResponse), StatusCodeAndErrorsMessagesStandard.OK)]
        [ProducesResponseType(typeof(FailResponse), StatusCodeAndErrorsMessagesStandard.NotFound)]
        [ProducesResponseType(typeof(FailResponse), StatusCodeAndErrorsMessagesStandard.Unauthorized)] // Unauthorized
        [ProducesResponseType(typeof(FailResponse), StatusCodeAndErrorsMessagesStandard.Forbidden)] // Forbidden
        [Authorize(Roles = "SystemAdmin, CompanyAdmin, CompanyUser")]
        public async Task<ActionResult<IResponse>> DeleteCabinPhoto([FromRoute] int photoId, [FromQuery] int companyId)
        {
            var item = await _cabinService.DeleteCabinPhoto(photoId, companyId);
            if (item.StatusCode == StatusCodeAndErrorsMessagesStandard.NotFound)
                return NotFound(item);

            return Ok(item);
        }

        [HttpDelete("deleteCabingPhotos/{cabinId}")]
        [ProducesResponseType(typeof(BaseSuccessResponse), StatusCodeAndErrorsMessagesStandard.OK)]
        [ProducesResponseType(typeof(FailResponse), StatusCodeAndErrorsMessagesStandard.NotFound)]
        [ProducesResponseType(typeof(FailResponse), StatusCodeAndErrorsMessagesStandard.Unauthorized)] // Unauthorized
        [ProducesResponseType(typeof(FailResponse), StatusCodeAndErrorsMessagesStandard.Forbidden)] // Forbidden
        [Authorize(Roles = "SystemAdmin, CompanyAdmin, CompanyUser")]
        public async Task<ActionResult<IResponse>> DeleteCabinPhotos([FromRoute] int cabinId, [FromQuery] int companyId)
        {
            var item = await _cabinService.DeleteCabinPhotos(cabinId, companyId);
            if (item.StatusCode == StatusCodeAndErrorsMessagesStandard.NotFound)
                return NotFound(item);

            return Ok(item);
        }


    }
}
