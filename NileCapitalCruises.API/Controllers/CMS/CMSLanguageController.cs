using NileCapitalCruises.Infrastructure.Dtos.CMS.RequestDtos.LanguageDtos;
using NileCapitalCruises.Infrastructure.Dtos.CMS.ResponseDtos.LanguageDtos;
using NileCapitalCruises.Infrastructure.Helpers.ApiResponses;
using NileCapitalCruises.Infrastructure.IServices.CMS;
using Microsoft.AspNetCore.Authorization;
using Microsoft.AspNetCore.Mvc;

namespace NileCapitalCruises.API.Controllers.CMS
{
    [Route("api/cms/language")]
    [ApiController]
    public class CMSLanguageController : ControllerBase
    {
        private readonly ILanguageService _languageService;

        public CMSLanguageController(ILanguageService languageService)
        {
            _languageService = languageService;
        }

        [HttpPost("createLanguage")]
        [ProducesResponseType(typeof(SuccessSingleResponse<CMSBasicLanguageResponseDto>), StatusCodeAndErrorsMessagesStandard.Created)]
        [ProducesResponseType(typeof(FailResponse), StatusCodeAndErrorsMessagesStandard.BadRequest)]
        [ProducesResponseType(typeof(FailResponse), StatusCodeAndErrorsMessagesStandard.Unauthorized)] // Unauthorized
        [ProducesResponseType(typeof(FailResponse), StatusCodeAndErrorsMessagesStandard.Forbidden)] // Forbidden
        //[Authorize(Roles = "SystemAdmin")]
        public async Task<ActionResult<IResponse>> CreateLanguage(CMSLanguageRequestDto requestDto)
        {
            if (!ModelState.IsValid)
            {
                var errors = ModelState.Values.SelectMany(y => y.Errors).Select(e => e.ErrorMessage).ToList();
                var response = new FailResponse { ErrorMessages = errors, StatusCode = StatusCodeAndErrorsMessagesStandard.BadRequest, Status = false };
                return BadRequest(response);
            }
            var item = await _languageService.CreateLanguage(requestDto);
            if (item.StatusCode == StatusCodeAndErrorsMessagesStandard.BadRequest)
                return BadRequest(item);

            return Ok(item);
        }


        [HttpPut("updateLanguage/{languageId}")]
        //[Authorize(Roles = "SystemAdmin")]
        [ProducesResponseType(typeof(SuccessSingleResponse<CMSBasicLanguageResponseDto>), StatusCodeAndErrorsMessagesStandard.OK)]
        [ProducesResponseType(typeof(FailResponse), StatusCodeAndErrorsMessagesStandard.NotFound)]
        [ProducesResponseType(typeof(FailResponse), StatusCodeAndErrorsMessagesStandard.Unauthorized)]
        [ProducesResponseType(typeof(FailResponse), StatusCodeAndErrorsMessagesStandard.Forbidden)]
        public async Task<ActionResult<IResponse>> UpdateLanguage([FromRoute] int languageId, CMSLanguageRequestDto requestDto)
        {
            if (!ModelState.IsValid)
            {
                var errors = ModelState.Values.SelectMany(y => y.Errors).Select(e => e.ErrorMessage).ToList();
                var response = new FailResponse { ErrorMessages = errors, StatusCode = StatusCodeAndErrorsMessagesStandard.BadRequest, Status = false };
                return BadRequest(response);
            }

            var item = await _languageService.UpdateLanguage(languageId, requestDto);

            if (item.StatusCode == StatusCodeAndErrorsMessagesStandard.NotFound)
                return NotFound(item);

            if (item.StatusCode == StatusCodeAndErrorsMessagesStandard.BadRequest)
                return BadRequest(item);


            return Ok(item);
        }


        [HttpGet("getLanguages")]
        [ProducesResponseType(typeof(SuccessPaginationResponse<IEnumerable<CMSBasicLanguageResponseDto>>), StatusCodeAndErrorsMessagesStandard.OK)]
        [ProducesResponseType(typeof(FailResponse), StatusCodeAndErrorsMessagesStandard.NotFound)]
        [ProducesResponseType(typeof(FailResponse), StatusCodeAndErrorsMessagesStandard.Unauthorized)] // Unauthorized
        [ProducesResponseType(typeof(FailResponse), StatusCodeAndErrorsMessagesStandard.Forbidden)] // Forbidden
        //[Authorize(Roles = "SystemAdmin")]

        public async Task<ActionResult<IResponse>> GetLanguages()
        {
            var item = await _languageService.GetLanguages();
            if (item.StatusCode == StatusCodeAndErrorsMessagesStandard.NotFound)
                return NotFound(item);

            return Ok(item);
        }
    }
}
