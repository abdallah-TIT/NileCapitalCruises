using NileCapitalCruises.Infrastructure.Data.Specification.CMS;
using NileCapitalCruises.Infrastructure.Dtos.CMS.RequestDtos.CruiseCategoryDtos;
using NileCapitalCruises.Infrastructure.Dtos.CMS.RequestDtos.CruiseDtos;
using NileCapitalCruises.Infrastructure.Dtos.CMS.RequestDtos.DiningDtos;
using NileCapitalCruises.Infrastructure.Dtos.CMS.ResponseDtos.CabinDtos;
using NileCapitalCruises.Infrastructure.Dtos.CMS.ResponseDtos.CompanyDtos;
using NileCapitalCruises.Infrastructure.Dtos.CMS.ResponseDtos.CruiseDtos;
using NileCapitalCruises.Infrastructure.Dtos.CMS.ResponseDtos.DiningDtos;
using NileCapitalCruises.Infrastructure.Helpers.ApiResponses;
using NileCapitalCruises.Infrastructure.IServices;
using NileCapitalCruises.Infrastructure.IServices.CMS;
using NileCapitalCruises.Infrastructure.Services.CMS;
using Microsoft.AspNetCore.Authorization;
using Microsoft.AspNetCore.Mvc;

namespace NileCapitalCruises.API.Controllers.CMS
{
    [Route("api/cms/cruise")]
    [ApiController]
    public class CMSCruiseController : ControllerBase
    {
        private readonly ICruiseService _cruiseService;
        private readonly ITokenService _tokenService;

        public CMSCruiseController(ICruiseService cruiseService, ITokenService tokenService)
        {
            _cruiseService = cruiseService;
            _tokenService = tokenService;
        }


        [HttpPost("createCruise")]
        [ProducesResponseType(typeof(SuccessSingleResponse<BasicCruiseResponseDto>), StatusCodeAndErrorsMessagesStandard.Created)]
        [ProducesResponseType(typeof(FailResponse), StatusCodeAndErrorsMessagesStandard.BadRequest)]
        [ProducesResponseType(typeof(FailResponse), StatusCodeAndErrorsMessagesStandard.Unauthorized)] // Unauthorized
        [ProducesResponseType(typeof(FailResponse), StatusCodeAndErrorsMessagesStandard.Forbidden)] // Forbidden
        [Authorize(Roles = "SystemAdmin")]
        public async Task<ActionResult<IResponse>> CreateCruise(CruiseRequestDto requestDto, [FromQuery] int companyId)
        {
            if (!ModelState.IsValid)
            {
                var errors = ModelState.Values.SelectMany(y => y.Errors).Select(e => e.ErrorMessage).ToList();
                var response = new FailResponse { ErrorMessages = errors, StatusCode = StatusCodeAndErrorsMessagesStandard.BadRequest, Status = false };
                return BadRequest(response);
            }


            var item = await _cruiseService.CreateCruise(requestDto, companyId);
            if (item.StatusCode == StatusCodeAndErrorsMessagesStandard.BadRequest)
                return BadRequest(item);

            return Ok(item);
        }


        [HttpPut("updateCruise/{cruiseId}")]
        [Authorize(Roles = "SystemAdmin")]
        [ProducesResponseType(typeof(SuccessSingleResponse<BasicCruiseResponseDto>), StatusCodeAndErrorsMessagesStandard.OK)]
        [ProducesResponseType(typeof(FailResponse), StatusCodeAndErrorsMessagesStandard.NotFound)]
        [ProducesResponseType(typeof(FailResponse), StatusCodeAndErrorsMessagesStandard.Unauthorized)]
        [ProducesResponseType(typeof(FailResponse), StatusCodeAndErrorsMessagesStandard.Forbidden)]
        public async Task<ActionResult<IResponse>> UpdateCruise([FromRoute] int cruiseId, [FromQuery] int companyId, CruiseRequestDto requestDto)
        {
            if (!ModelState.IsValid)
            {
                var errors = ModelState.Values.SelectMany(y => y.Errors).Select(e => e.ErrorMessage).ToList();
                var response = new FailResponse { ErrorMessages = errors, StatusCode = StatusCodeAndErrorsMessagesStandard.BadRequest, Status = false };
                return BadRequest(response);
            }

            var item = await _cruiseService.UpdateCruise(cruiseId, companyId, requestDto);

            if (item.StatusCode == StatusCodeAndErrorsMessagesStandard.NotFound)
                return NotFound(item);

            if (item.StatusCode == StatusCodeAndErrorsMessagesStandard.BadRequest)
                return BadRequest(item);


            return Ok(item);
        }



        [HttpDelete("deleteCruise/{cruiseId}")]
        [Authorize(Roles = "SystemAdmin")]

        [ProducesResponseType(typeof(BaseSuccessResponse), StatusCodeAndErrorsMessagesStandard.OK)]
        [ProducesResponseType(typeof(FailResponse), StatusCodeAndErrorsMessagesStandard.NotFound)]
        [ProducesResponseType(typeof(FailResponse), StatusCodeAndErrorsMessagesStandard.Unauthorized)]
        [ProducesResponseType(typeof(FailResponse), StatusCodeAndErrorsMessagesStandard.Forbidden)]
        public async Task<ActionResult<IResponse>> DeleteCruise([FromRoute] int cruiseId, [FromQuery] int companyId)
        {

            var item = await _cruiseService.DeleteCruise(cruiseId, companyId);

            if (item.StatusCode == StatusCodeAndErrorsMessagesStandard.NotFound)
                return NotFound(item);

            if (item.StatusCode == StatusCodeAndErrorsMessagesStandard.BadRequest)
                return BadRequest(item);


            return Ok(item);
        }



        //[HttpPost("removeCruiseFromUser")]
        //[Authorize(Roles = "SystemAdmin, CompanyAdmin")]

        //[ProducesResponseType(typeof(BaseSuccessResponse), StatusCodeAndErrorsMessagesStandard.OK)]
        //[ProducesResponseType(typeof(FailResponse), StatusCodeAndErrorsMessagesStandard.NotFound)]
        //[ProducesResponseType(typeof(FailResponse), StatusCodeAndErrorsMessagesStandard.Unauthorized)] // Unauthorized
        //[ProducesResponseType(typeof(FailResponse), StatusCodeAndErrorsMessagesStandard.Forbidden)] // Forbidden
        //public async Task<ActionResult<IResponse>> RemoveCruiseFromUser([FromQuery] int companyId, [FromBody] CruiseToUserRequestDto requestDto)
        //{
        //    if (!ModelState.IsValid)
        //    {
        //        var errors = ModelState.Values.SelectMany(y => y.Errors).Select(e => e.ErrorMessage).ToList();
        //        var response = new FailResponse { ErrorMessages = errors, StatusCode = StatusCodeAndErrorsMessagesStandard.BadRequest, Status = false };
        //        return BadRequest(response);
        //    }
        //    var item = await _cruiseService.RemoveCruiseFromUser(companyId, requestDto);
        //    if (item.StatusCode == StatusCodeAndErrorsMessagesStandard.BadRequest)
        //        return BadRequest(item);

        //    return Ok(item);

        //}

        [HttpGet("getCruises")]
        [ProducesResponseType(typeof(SuccessPaginationResponse<IEnumerable<CruiseWithContentResponseDto>>), StatusCodeAndErrorsMessagesStandard.OK)]
        [ProducesResponseType(typeof(FailResponse), StatusCodeAndErrorsMessagesStandard.NotFound)]
        [ProducesResponseType(typeof(FailResponse), StatusCodeAndErrorsMessagesStandard.Unauthorized)] // Unauthorized
        [ProducesResponseType(typeof(FailResponse), StatusCodeAndErrorsMessagesStandard.Forbidden)] // Forbidden
        [Authorize(Roles = "SystemAdmin, CompanyAdmin, CompanyUser")]
        public async Task<ActionResult<IResponse>> GetCruises([FromQuery] int companyId, [FromQuery] PaginationSpecParams paginationSpecParams)
        {
            var item = await _cruiseService.GetCruises(companyId, paginationSpecParams);

            if (item.StatusCode == StatusCodeAndErrorsMessagesStandard.NotFound)
                return NotFound(item);

            return Ok(item);
        }


        [HttpGet("getCruiseById/{cruiseId}")]

        [ProducesResponseType(typeof(SuccessSingleResponse<BasicCruiseResponseDto>), StatusCodeAndErrorsMessagesStandard.OK)]
        [ProducesResponseType(typeof(FailResponse), StatusCodeAndErrorsMessagesStandard.NotFound)]
        [ProducesResponseType(typeof(FailResponse), StatusCodeAndErrorsMessagesStandard.Unauthorized)] // Unauthorized
        [ProducesResponseType(typeof(FailResponse), StatusCodeAndErrorsMessagesStandard.Forbidden)] // Forbidden
        public async Task<ActionResult<IResponse>> GetCruise([FromRoute] int cruiseId, [FromQuery] int companyId)
        {
            var item = await _cruiseService.GetCruise(cruiseId, companyId);
            if (item.StatusCode == StatusCodeAndErrorsMessagesStandard.NotFound)
                return NotFound(item);

            return Ok(item);
        }

        [HttpGet("getCruiseContent/{cruiseId}")]
        [ProducesResponseType(typeof(SuccessSingleResponse<CruiseContentResponseDto>), StatusCodeAndErrorsMessagesStandard.OK)]
        [ProducesResponseType(typeof(FailResponse), StatusCodeAndErrorsMessagesStandard.NotFound)]
        [ProducesResponseType(typeof(FailResponse), StatusCodeAndErrorsMessagesStandard.Unauthorized)] // Unauthorized
        [ProducesResponseType(typeof(FailResponse), StatusCodeAndErrorsMessagesStandard.Forbidden)] // Forbidden
        [Authorize(Roles = "SystemAdmin, CompanyAdmin, CompanyUser")]
        public async Task<ActionResult<IResponse>> GetCruiseContent([FromRoute] int cruiseId, [FromQuery] int companyId, [FromQuery] string languageCode = "en")
        {
            var item = await _cruiseService.GetCruiseContent(cruiseId, companyId, languageCode);
            if (item.StatusCode == StatusCodeAndErrorsMessagesStandard.NotFound)
                return NotFound(item);

            return Ok(item);
        }

        [HttpPut("updateCruiseContent/{cruiseId}")]
        [ProducesResponseType(typeof(SuccessSingleResponse<BasicCompanyResponseDto>), StatusCodeAndErrorsMessagesStandard.OK)]
        [ProducesResponseType(typeof(FailResponse), StatusCodeAndErrorsMessagesStandard.NotFound)]
        [ProducesResponseType(typeof(FailResponse), StatusCodeAndErrorsMessagesStandard.Unauthorized)]
        [ProducesResponseType(typeof(FailResponse), StatusCodeAndErrorsMessagesStandard.Forbidden)]
        [Authorize(Roles = "SystemAdmin, CompanyAdmin, CompanyUser")]
        public async Task<ActionResult<IResponse>> UpdateCruiseContent([FromRoute] int cruiseId, [FromQuery] int companyId, CruiseContentRequestDto requestDto, [FromQuery] string languageCode = "en")
        {
            if (!ModelState.IsValid)
            {
                var errors = ModelState.Values.SelectMany(y => y.Errors).Select(e => e.ErrorMessage).ToList();
                var response = new FailResponse { ErrorMessages = errors, StatusCode = StatusCodeAndErrorsMessagesStandard.BadRequest, Status = false };
                return BadRequest(response);
            }

            var item = await _cruiseService.UpdateCruiseContent(cruiseId, companyId, requestDto, languageCode);

            if (item.StatusCode == StatusCodeAndErrorsMessagesStandard.NotFound)
                return NotFound(item);

            if (item.StatusCode == StatusCodeAndErrorsMessagesStandard.BadRequest)
                return BadRequest(item);


            return Ok(item);
        }


        [HttpPost("createCruisePhotos/{cruiseId}")]
        [ProducesResponseType(typeof(SuccessSingleResponse<IEnumerable<CruisePhotoResponseDto>>), StatusCodeAndErrorsMessagesStandard.OK)]
        [ProducesResponseType(typeof(FailResponse), StatusCodeAndErrorsMessagesStandard.NotFound)]
        [ProducesResponseType(typeof(FailResponse), StatusCodeAndErrorsMessagesStandard.Unauthorized)]
        [ProducesResponseType(typeof(FailResponse), StatusCodeAndErrorsMessagesStandard.Forbidden)]
        [Authorize(Roles = "SystemAdmin, CompanyAdmin, CompanyUser")]
        public async Task<ActionResult<IResponse>> CreateCruisePhotos([FromRoute] int cruiseId, [FromQuery] int companyId, IEnumerable<CruisePhotoRequestDto> requestDto)
        {
            if (!ModelState.IsValid)
            {
                var errors = ModelState.Values.SelectMany(y => y.Errors).Select(e => e.ErrorMessage).ToList();
                var response = new FailResponse { ErrorMessages = errors, StatusCode = StatusCodeAndErrorsMessagesStandard.BadRequest, Status = false };
                return BadRequest(response);
            }

            var item = await _cruiseService.CreateCruisePhotos(cruiseId, companyId, requestDto);

            if (item.StatusCode == StatusCodeAndErrorsMessagesStandard.NotFound)
                return NotFound(item);

            if (item.StatusCode == StatusCodeAndErrorsMessagesStandard.BadRequest)
                return BadRequest(item);


            return Ok(item);
        }

        [HttpGet("getCruisePhotos/{cruiseId}")]
        [ProducesResponseType(typeof(SuccessSingleResponse<IEnumerable<CruisePhotoResponseDto>>), StatusCodeAndErrorsMessagesStandard.OK)]
        [ProducesResponseType(typeof(FailResponse), StatusCodeAndErrorsMessagesStandard.NotFound)]
        [ProducesResponseType(typeof(FailResponse), StatusCodeAndErrorsMessagesStandard.Unauthorized)] // Unauthorized
        [ProducesResponseType(typeof(FailResponse), StatusCodeAndErrorsMessagesStandard.Forbidden)] // Forbidden
        [Authorize(Roles = "SystemAdmin, CompanyAdmin, CompanyUser")]
        public async Task<ActionResult<IResponse>> GetCruisePhotos([FromRoute] int cruiseId, [FromQuery] int companyId)
        {
            var item = await _cruiseService.GetCruisePhotos(cruiseId, companyId);
            if (item.StatusCode == StatusCodeAndErrorsMessagesStandard.NotFound)
                return NotFound(item);

            return Ok(item);
        }


        [HttpDelete("deleteCruisePhoto/{photoId}")]
        [ProducesResponseType(typeof(BaseSuccessResponse), StatusCodeAndErrorsMessagesStandard.OK)]
        [ProducesResponseType(typeof(FailResponse), StatusCodeAndErrorsMessagesStandard.NotFound)]
        [ProducesResponseType(typeof(FailResponse), StatusCodeAndErrorsMessagesStandard.Unauthorized)] // Unauthorized
        [ProducesResponseType(typeof(FailResponse), StatusCodeAndErrorsMessagesStandard.Forbidden)] // Forbidden
        [Authorize(Roles = "SystemAdmin, CompanyAdmin, CompanyUser")]
        public async Task<ActionResult<IResponse>> DeleteCruisePhoto([FromRoute] int photoId, [FromQuery] int companyId)
        {
            var item = await _cruiseService.DeleteCruisePhoto(photoId, companyId);
            if (item.StatusCode == StatusCodeAndErrorsMessagesStandard.NotFound)
                return NotFound(item);

            return Ok(item);
        }



        [HttpDelete("deleteCruisePhotos/{cruiseId}")]
        [ProducesResponseType(typeof(BaseSuccessResponse), StatusCodeAndErrorsMessagesStandard.OK)]
        [ProducesResponseType(typeof(FailResponse), StatusCodeAndErrorsMessagesStandard.NotFound)]
        [ProducesResponseType(typeof(FailResponse), StatusCodeAndErrorsMessagesStandard.Unauthorized)] // Unauthorized
        [ProducesResponseType(typeof(FailResponse), StatusCodeAndErrorsMessagesStandard.Forbidden)] // Forbidden
        [Authorize(Roles = "SystemAdmin, CompanyAdmin, CompanyUser")]
        public async Task<ActionResult<IResponse>> DeleteCruisePhotos([FromRoute] int cruiseId, [FromQuery] int companyId)
        {
            var item = await _cruiseService.DeleteCruisePhotos(cruiseId, companyId);
            if (item.StatusCode == StatusCodeAndErrorsMessagesStandard.NotFound)
                return NotFound(item);

            return Ok(item);
        }

        //[HttpGet]
        //[ProducesResponseType(typeof(SuccessPaginationResponse<BasicCruisesResponseDto>), StatusCodeAndErrorsMessagesStandard.OK)]
        //[ProducesResponseType(typeof(FailResponse), StatusCodeAndErrorsMessagesStandard.NotFound)]
        //[ProducesResponseType(typeof(FailResponse), StatusCodeAndErrorsMessagesStandard.Unauthorized)] // Unauthorized
        //[ProducesResponseType(typeof(FailResponse), StatusCodeAndErrorsMessagesStandard.Forbidden)] // Forbidden
        //[Authorize(Roles = "CompanyAdmin")]
        //public async Task<ActionResult<IResponse>> GetCruises([FromQuery] PaginationSpecParams cruiseParam)
        //{
        //    var item = await _cruiseService.GetCruises(cruiseParam);

        //    if (item.StatusCode == StatusCodeAndErrorsMessagesStandard.NotFound)
        //        return NotFound(item);

        //    return Ok(item);
        //}


        //[HttpGet("{id}")]
        //[ProducesResponseType(typeof(SuccessSingleResponse<BasicCruisesResponseDto>), StatusCodeAndErrorsMessagesStandard.OK)]
        //[ProducesResponseType(typeof(FailResponse), StatusCodeAndErrorsMessagesStandard.NotFound)]
        //[ProducesResponseType(typeof(FailResponse), StatusCodeAndErrorsMessagesStandard.Unauthorized)] // Unauthorized
        //[ProducesResponseType(typeof(FailResponse), StatusCodeAndErrorsMessagesStandard.Forbidden)] // Forbidden

        //public async Task<ActionResult<IResponse>> GetCruise([FromRoute] int id, [FromQuery] string languageCode = "en")
        //{
        //    var item = await _cruiseService.GetCruise(id, languageCode);
        //    if (item.StatusCode == StatusCodeAndErrorsMessagesStandard.NotFound)
        //        return NotFound(item);

        //    return Ok(item);
        //}

        //[HttpGet("name/{cruiseUrl}")]
        //public async Task<ActionResult<IResponse>> GetCruiseByUrlName([FromRoute] string cruiseUrl, [FromQuery] string languageCode = "en")
        //{
        //    var item = await _cruiseService.GetCruiseByUrlName(cruiseUrl, languageCode);
        //    if (item.StatusCode == StatusCodeAndErrorsMessagesStandard.NotFound)
        //        return NotFound(item);

        //    return Ok(item);
        //}


        //[HttpPatch("content/{cruiseId}")]
        //[ProducesResponseType(typeof(SuccessSingleResponse<CruisesResponseDto>), StatusCodeAndErrorsMessagesStandard.NoContent)]
        //[ProducesResponseType(typeof(FailResponse), StatusCodeAndErrorsMessagesStandard.BadRequest)]
        //[ProducesResponseType(typeof(FailResponse), StatusCodeAndErrorsMessagesStandard.Unauthorized)] // Unauthorized
        //[ProducesResponseType(typeof(FailResponse), StatusCodeAndErrorsMessagesStandard.Forbidden)] // Forbidden
        //public async Task<ActionResult<IResponse>> UpdatePatchCruiseContent([FromRoute] int cruiseId, [FromBody] JsonPatchDocument model, [FromQuery] string languageCode = "en")
        //{
        //    var item = await _cruiseService.UpdatePatchCruiseContent(cruiseId, languageCode, model);
        //    if (item.StatusCode == StatusCodeAndErrorsMessagesStandard.NotFound)
        //        return NotFound(item);

        //    return Ok(item);
        //}





        //[HttpDelete("{id}")]
        //[ProducesResponseType(typeof(SuccessSingleResponse<CruisesResponseDto>), StatusCodeAndErrorsMessagesStandard.NoContent)]
        //[ProducesResponseType(typeof(FailResponse), StatusCodeAndErrorsMessagesStandard.BadRequest)]
        //[ProducesResponseType(typeof(FailResponse), StatusCodeAndErrorsMessagesStandard.Unauthorized)] // Unauthorized
        //[ProducesResponseType(typeof(FailResponse), StatusCodeAndErrorsMessagesStandard.Forbidden)] // Forbidden
        //public async Task<ActionResult<IResponse>> DeleteCruise(int id)
        //{
        //    var item = await _cruiseService.DeleteCruise(id);
        //        if (item.StatusCode == StatusCodeAndErrorsMessagesStandard.NotFound)
        //            return NotFound(item);

        //    return Ok(item);
        //}

        //[HttpPatch("{id}")]
        //[ProducesResponseType(typeof(SuccessSingleResponse<CruisesResponseDto>), StatusCodeAndErrorsMessagesStandard.NoContent)]
        //[ProducesResponseType(typeof(FailResponse), StatusCodeAndErrorsMessagesStandard.BadRequest)]
        //[ProducesResponseType(typeof(FailResponse), StatusCodeAndErrorsMessagesStandard.Unauthorized)] // Unauthorized
        //[ProducesResponseType(typeof(FailResponse), StatusCodeAndErrorsMessagesStandard.Forbidden)] // Forbidden
        //public async Task<ActionResult<IResponse>> UpdatePatchCruise([FromRoute] int id, [FromBody] JsonPatchDocument model)
        //{
        //    var item = await _cruiseService.UpdatePatchCruise(id, model);
        //    if (item.StatusCode == StatusCodeAndErrorsMessagesStandard.NotFound)
        //        return NotFound(item);

        //    return Ok(item);
        //}
    }
}
