using NileCapitalCruises.Infrastructure.Dtos.CMS.ResponseDtos.CityDtos;
using NileCapitalCruises.Infrastructure.Helpers.ApiResponses;
using NileCapitalCruises.Infrastructure.IServices.CMS;
using Microsoft.AspNetCore.Mvc;
using NileCapitalCruises.Infrastructure.Data.Specification.CMS;
using NileCapitalCruises.Infrastructure.Dtos.CMS.ResponseDtos.SeasonDtos;
using NileCapitalCruises.Infrastructure.Dtos.CMS.RequestDtos.SeasonDtos;
using NileCapitalCruises.Infrastructure.Services.CMS;
using NileCapitalCruises.Infrastructure.Dtos.CMS.ResponseDtos.ItineraryTypeDtos;
using NileCapitalCruises.Infrastructure.Services.BookingEngine;

namespace NileCapitalCruises.API.Controllers.CMS
{
    [Route("api/cms/season")]
    [ApiController]
    public class CMSSeasonController : ControllerBase
    {
        private readonly ISeasonService _seasonService;

        public CMSSeasonController(ISeasonService seasonService)
        {
            _seasonService = seasonService;
        }


        [HttpPost("createSeason")]
        //[Authorize(Roles = "SystemAdmin")]

        [ProducesResponseType(typeof(SuccessPaginationResponse<CMSBasicSeasonResponseDto>), StatusCodeAndErrorsMessagesStandard.OK)]
        [ProducesResponseType(typeof(FailResponse), StatusCodeAndErrorsMessagesStandard.NotFound)]
        [ProducesResponseType(typeof(FailResponse), StatusCodeAndErrorsMessagesStandard.Unauthorized)] // Unauthorized
        [ProducesResponseType(typeof(FailResponse), StatusCodeAndErrorsMessagesStandard.Forbidden)] // Forbidden
        public async Task<ActionResult<IResponse>> CreateSeason(CMSSeasonRequestDto requestDto)
        {
            if (!ModelState.IsValid)
            {
                var errors = ModelState.Values.SelectMany(y => y.Errors).Select(e => e.ErrorMessage).ToList();
                var response = new FailResponse { ErrorMessages = errors, StatusCode = StatusCodeAndErrorsMessagesStandard.BadRequest, Status = false };
                return BadRequest(response);
            }
            var item = await _seasonService.CreateSeason(requestDto);
            if (item.StatusCode == StatusCodeAndErrorsMessagesStandard.BadRequest)
                return BadRequest(item);

            return Ok(item);
        }



        [HttpPost("updateSeason/{seasonId}")]
        //[Authorize(Roles = "SystemAdmin")]
        [ProducesResponseType(typeof(SuccessSingleResponse<CMSBasicSeasonResponseDto>), StatusCodeAndErrorsMessagesStandard.OK)]
        [ProducesResponseType(typeof(FailResponse), StatusCodeAndErrorsMessagesStandard.NotFound)]
        [ProducesResponseType(typeof(FailResponse), StatusCodeAndErrorsMessagesStandard.Unauthorized)]
        [ProducesResponseType(typeof(FailResponse), StatusCodeAndErrorsMessagesStandard.Forbidden)]
        public async Task<ActionResult<IResponse>> UpdateSeason([FromRoute] int seasonId, CMSSeasonRequestDto requestDto)
        {
            if (!ModelState.IsValid)
            {
                var errors = ModelState.Values.SelectMany(y => y.Errors).Select(e => e.ErrorMessage).ToList();
                var response = new FailResponse { ErrorMessages = errors, StatusCode = StatusCodeAndErrorsMessagesStandard.BadRequest, Status = false };
                return BadRequest(response);
            }

            var item = await _seasonService.UpdateSeason(seasonId, requestDto);

            if (item.StatusCode == StatusCodeAndErrorsMessagesStandard.NotFound)
                return NotFound(item);

            if (item.StatusCode == StatusCodeAndErrorsMessagesStandard.BadRequest)
                return BadRequest(item);


            return Ok(item);
        }


        [HttpPost("deleteSeason/{seasonId}")]
        //[Authorize(Roles = "SystemAdmin")]
        [ProducesResponseType(typeof(BaseSuccessResponse), StatusCodeAndErrorsMessagesStandard.OK)]
        [ProducesResponseType(typeof(FailResponse), StatusCodeAndErrorsMessagesStandard.NotFound)]
        [ProducesResponseType(typeof(FailResponse), StatusCodeAndErrorsMessagesStandard.Unauthorized)]
        [ProducesResponseType(typeof(FailResponse), StatusCodeAndErrorsMessagesStandard.Forbidden)]
        public async Task<ActionResult<IResponse>> DeleteSeason([FromRoute] int seasonId)
        {

            var item = await _seasonService.DeleteSeason(seasonId);

            if (item.StatusCode == StatusCodeAndErrorsMessagesStandard.NotFound)
                return NotFound(item);

            if (item.StatusCode == StatusCodeAndErrorsMessagesStandard.BadRequest)
                return BadRequest(item);


            return Ok(item);
        }


        [HttpGet("getSeasons")]
        //[Authorize(Roles = "SystemAdmin")]
        [ProducesResponseType(typeof(SuccessPaginationResponse<CMSSeasonWithContentResponseDto>), StatusCodeAndErrorsMessagesStandard.OK)]
        [ProducesResponseType(typeof(FailResponse), StatusCodeAndErrorsMessagesStandard.NotFound)]
        [ProducesResponseType(typeof(FailResponse), StatusCodeAndErrorsMessagesStandard.Unauthorized)] // Unauthorized
        [ProducesResponseType(typeof(FailResponse), StatusCodeAndErrorsMessagesStandard.Forbidden)] // Forbidden
        public async Task<ActionResult<IResponse>> GetSeasons([FromQuery] PaginationSpecParams paginationSpecParams)
        {
            var item = await _seasonService.GetSeasons(paginationSpecParams);

            if (item.StatusCode == StatusCodeAndErrorsMessagesStandard.NotFound)
                return NotFound(item);

            return Ok(item);
        }



        [HttpGet("getSeasonById/{seasonId}")]
        //[Authorize(Roles = "SystemAdmin")]
        [ProducesResponseType(typeof(SuccessSingleResponse<CMSBasicSeasonResponseDto>), StatusCodeAndErrorsMessagesStandard.OK)]
        [ProducesResponseType(typeof(FailResponse), StatusCodeAndErrorsMessagesStandard.NotFound)]
        [ProducesResponseType(typeof(FailResponse), StatusCodeAndErrorsMessagesStandard.Unauthorized)] // Unauthorized
        [ProducesResponseType(typeof(FailResponse), StatusCodeAndErrorsMessagesStandard.Forbidden)] // Forbidden
        public async Task<ActionResult<IResponse>> GetSeason([FromRoute] int seasonId)
        {
            var item = await _seasonService.GetSeason(seasonId);
            if (item.StatusCode == StatusCodeAndErrorsMessagesStandard.NotFound)
                return NotFound(item);

            return Ok(item);
        }


        [HttpGet("getSeasonContent/{seasonId}")]
        //[Authorize(Roles = "SystemAdmin")]
        [ProducesResponseType(typeof(SuccessSingleResponse<CMSBasicSeasonResponseDto>), StatusCodeAndErrorsMessagesStandard.OK)]
        [ProducesResponseType(typeof(FailResponse), StatusCodeAndErrorsMessagesStandard.NotFound)]
        [ProducesResponseType(typeof(FailResponse), StatusCodeAndErrorsMessagesStandard.Unauthorized)] // Unauthorized
        [ProducesResponseType(typeof(FailResponse), StatusCodeAndErrorsMessagesStandard.Forbidden)] // Forbidden
        public async Task<ActionResult<IResponse>> GetSeasonContent([FromRoute] int seasonId, [FromQuery] string languageCode = "en")
        {
            var item = await _seasonService.GetSeasonContent(seasonId, languageCode);
            if (item.StatusCode == StatusCodeAndErrorsMessagesStandard.NotFound)
                return NotFound(item);

            return Ok(item);
        }


        [HttpGet("getSeasonContents/{seasonId}")]
        //[Authorize(Roles = "SystemAdmin")]
        [ProducesResponseType(typeof(SuccessListResponse<CMSSeasonContentResponseDto>), StatusCodeAndErrorsMessagesStandard.OK)]
        [ProducesResponseType(typeof(FailResponse), StatusCodeAndErrorsMessagesStandard.NotFound)]
        [ProducesResponseType(typeof(FailResponse), StatusCodeAndErrorsMessagesStandard.Unauthorized)] // Unauthorized
        [ProducesResponseType(typeof(FailResponse), StatusCodeAndErrorsMessagesStandard.Forbidden)] // Forbidden
        public async Task<ActionResult<IResponse>> GetSeasonContents([FromRoute] int seasonId)
        {
            var item = await _seasonService.GetSeasonContents(seasonId);
            if (item.StatusCode == StatusCodeAndErrorsMessagesStandard.NotFound)
                return NotFound(item);

            return Ok(item);
        }

        [HttpPost("updateSeasonContent/{seasonId}")]
        //[Authorize(Roles = "SystemAdmin")]
        [ProducesResponseType(typeof(SuccessSingleResponse<CMSBasicSeasonResponseDto>), StatusCodeAndErrorsMessagesStandard.OK)]
        [ProducesResponseType(typeof(FailResponse), StatusCodeAndErrorsMessagesStandard.NotFound)]
        [ProducesResponseType(typeof(FailResponse), StatusCodeAndErrorsMessagesStandard.Unauthorized)]
        [ProducesResponseType(typeof(FailResponse), StatusCodeAndErrorsMessagesStandard.Forbidden)]
        public async Task<ActionResult<IResponse>> UpdateSeasonContent([FromRoute] int seasonId, CMSSeasonContentRequestDto requestDto, [FromQuery] string languageCode = "en")
        {
            if (!ModelState.IsValid)
            {
                var errors = ModelState.Values.SelectMany(y => y.Errors).Select(e => e.ErrorMessage).ToList();
                var response = new FailResponse { ErrorMessages = errors, StatusCode = StatusCodeAndErrorsMessagesStandard.BadRequest, Status = false };
                return BadRequest(response);
            }

            var item = await _seasonService.UpdateSeasonContent(seasonId, requestDto, languageCode);

            if (item.StatusCode == StatusCodeAndErrorsMessagesStandard.NotFound)
                return NotFound(item);

            if (item.StatusCode == StatusCodeAndErrorsMessagesStandard.BadRequest)
                return BadRequest(item);


            return Ok(item);
        }

    }
}
