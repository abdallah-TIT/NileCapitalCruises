using NileCapitalCruises.Core.Models;
using NileCapitalCruises.Infrastructure.Data.Specification.CMS;
using NileCapitalCruises.Infrastructure.Dtos.CMS.RequestDtos.BrandDtos;
using NileCapitalCruises.Infrastructure.Dtos.CMS.RequestDtos.CompanyDtos;
using NileCapitalCruises.Infrastructure.Dtos.CMS.ResponseDtos.BrandDtos;
using NileCapitalCruises.Infrastructure.Dtos.CMS.ResponseDtos.CompanyDtos;
using NileCapitalCruises.Infrastructure.Dtos.CMS.ResponseDtos.CruiseDtos;
using NileCapitalCruises.Infrastructure.Helpers.ApiResponses;
using NileCapitalCruises.Infrastructure.IServices.CMS;
using NileCapitalCruises.Infrastructure.Services.CMS;
using Microsoft.AspNetCore.Authorization;
using Microsoft.AspNetCore.Mvc;

namespace NileCapitalCruises.API.Controllers.CMS
{
    [Route("api/cms/brand")]
    [ApiController]
    public class CMSBrandController : ControllerBase
    {
        private readonly IBrandService _brandService;

        public CMSBrandController(IBrandService brandService)
        {
            _brandService = brandService;
        }


        //[HttpPost("createBrand")]
        ////[Authorize(Roles = "SystemAdmin")]

        //[ProducesResponseType(typeof(SuccessPaginationResponse<CMSBasicBrandResponseDto>), StatusCodeAndErrorsMessagesStandard.OK)]
        //[ProducesResponseType(typeof(FailResponse), StatusCodeAndErrorsMessagesStandard.NotFound)]
        //[ProducesResponseType(typeof(FailResponse), StatusCodeAndErrorsMessagesStandard.Unauthorized)] // Unauthorized
        //[ProducesResponseType(typeof(FailResponse), StatusCodeAndErrorsMessagesStandard.Forbidden)] // Forbidden
        //public async Task<ActionResult<IResponse>> CreateBrand(CMSBrandRequestDto requestDto)
        //{
        //    if (!ModelState.IsValid)
        //    {
        //        var errors = ModelState.Values.SelectMany(y => y.Errors).Select(e => e.ErrorMessage).ToList();
        //        var response = new FailResponse { ErrorMessages = errors, StatusCode = StatusCodeAndErrorsMessagesStandard.BadRequest, Status = false };
        //        return BadRequest(response);
        //    }
        //    var item = await _brandService.CreateBrand(requestDto);
        //    if (item.StatusCode == StatusCodeAndErrorsMessagesStandard.BadRequest)
        //        return BadRequest(item);

        //    return Ok(item);
        //}



        //[HttpPut("updateBrand/{brandId}")]
        //[Authorize(Roles = "SystemAdmin")]
        //[ProducesResponseType(typeof(SuccessSingleResponse<CMSBasicBrandResponseDto>), StatusCodeAndErrorsMessagesStandard.OK)]
        //[ProducesResponseType(typeof(FailResponse), StatusCodeAndErrorsMessagesStandard.NotFound)]
        //[ProducesResponseType(typeof(FailResponse), StatusCodeAndErrorsMessagesStandard.Unauthorized)]
        //[ProducesResponseType(typeof(FailResponse), StatusCodeAndErrorsMessagesStandard.Forbidden)]
        //public async Task<ActionResult<IResponse>> UpdateBrand([FromRoute] int brandId, CMSBrandRequestDto requestDto)
        //{
        //    if (!ModelState.IsValid)
        //    {
        //        var errors = ModelState.Values.SelectMany(y => y.Errors).Select(e => e.ErrorMessage).ToList();
        //        var response = new FailResponse { ErrorMessages = errors, StatusCode = StatusCodeAndErrorsMessagesStandard.BadRequest, Status = false };
        //        return BadRequest(response);
        //    }

        //    var item = await _brandService.UpdateBrand(brandId, requestDto);

        //    if (item.StatusCode == StatusCodeAndErrorsMessagesStandard.NotFound)
        //        return NotFound(item);

        //    if (item.StatusCode == StatusCodeAndErrorsMessagesStandard.BadRequest)
        //        return BadRequest(item);


        //    return Ok(item);
        //}


        //[HttpDelete("deleteBrand/{brandId}")]
        //[Authorize(Roles = "SystemAdmin")]
        //[ProducesResponseType(typeof(BaseSuccessResponse), StatusCodeAndErrorsMessagesStandard.OK)]
        //[ProducesResponseType(typeof(FailResponse), StatusCodeAndErrorsMessagesStandard.NotFound)]
        //[ProducesResponseType(typeof(FailResponse), StatusCodeAndErrorsMessagesStandard.Unauthorized)]
        //[ProducesResponseType(typeof(FailResponse), StatusCodeAndErrorsMessagesStandard.Forbidden)]
        //public async Task<ActionResult<IResponse>> DeleteBrand([FromRoute] int brandId)
        //{

        //    var item = await _brandService.DeleteBrand(brandId);

        //    if (item.StatusCode == StatusCodeAndErrorsMessagesStandard.NotFound)
        //        return NotFound(item);

        //    if (item.StatusCode == StatusCodeAndErrorsMessagesStandard.BadRequest)
        //        return BadRequest(item);


        //    return Ok(item);
        //}



        //[HttpGet("getBrands")]
        ////[Authorize(Roles = "SystemAdmin")]
        //[ProducesResponseType(typeof(SuccessPaginationResponse<IEnumerable<CMSBrandWithContentResponseDto>>), StatusCodeAndErrorsMessagesStandard.OK)]
        //[ProducesResponseType(typeof(FailResponse), StatusCodeAndErrorsMessagesStandard.NotFound)]
        //[ProducesResponseType(typeof(FailResponse), StatusCodeAndErrorsMessagesStandard.Unauthorized)] // Unauthorized
        //[ProducesResponseType(typeof(FailResponse), StatusCodeAndErrorsMessagesStandard.Forbidden)] // Forbidden
        //public async Task<ActionResult<IResponse>> GetBrands([FromQuery] PaginationSpecParams paginationSpecParams)
        //{
        //    var item = await _brandService.GetBrands(paginationSpecParams);

        //    if (item.StatusCode == StatusCodeAndErrorsMessagesStandard.NotFound)
        //        return NotFound(item);

        //    return Ok(item);
        //}

        //[HttpGet("getBrandById/{brandId}")]
        //[Authorize(Roles = "SystemAdmin")]
        //[ProducesResponseType(typeof(SuccessSingleResponse<CMSBasicBrandResponseDto>), StatusCodeAndErrorsMessagesStandard.OK)]
        //[ProducesResponseType(typeof(FailResponse), StatusCodeAndErrorsMessagesStandard.NotFound)]
        //[ProducesResponseType(typeof(FailResponse), StatusCodeAndErrorsMessagesStandard.Unauthorized)] // Unauthorized
        //[ProducesResponseType(typeof(FailResponse), StatusCodeAndErrorsMessagesStandard.Forbidden)] // Forbidden
        //public async Task<ActionResult<IResponse>> GetBrand([FromRoute] int brandId)
        //{
        //    var item = await _brandService.GetBrand(brandId);
        //    if (item.StatusCode == StatusCodeAndErrorsMessagesStandard.NotFound)
        //        return NotFound(item);

        //    return Ok(item);
        //}

        //[HttpGet("getBrandContent/{brandId}")]
        //[Authorize(Roles = "SystemAdmin")]
        //[ProducesResponseType(typeof(SuccessSingleResponse<CMSBrandContentResponseDto>), StatusCodeAndErrorsMessagesStandard.OK)]
        //[ProducesResponseType(typeof(FailResponse), StatusCodeAndErrorsMessagesStandard.NotFound)]
        //[ProducesResponseType(typeof(FailResponse), StatusCodeAndErrorsMessagesStandard.Unauthorized)] // Unauthorized
        //[ProducesResponseType(typeof(FailResponse), StatusCodeAndErrorsMessagesStandard.Forbidden)] // Forbidden
        //public async Task<ActionResult<IResponse>> GetBrandContent([FromRoute] int brandId, [FromQuery] string languageCode = "en")
        //{
        //    var item = await _brandService.GetBrandContent(brandId, languageCode);
        //    if (item.StatusCode == StatusCodeAndErrorsMessagesStandard.NotFound)
        //        return NotFound(item);

        //    return Ok(item);
        //}

        //[HttpPut("updateBrandContent/{brandId}")]
        //[Authorize(Roles = "SystemAdmin")]
        //[ProducesResponseType(typeof(SuccessSingleResponse<CMSBrandContentResponseDto>), StatusCodeAndErrorsMessagesStandard.OK)]
        //[ProducesResponseType(typeof(FailResponse), StatusCodeAndErrorsMessagesStandard.NotFound)]
        //[ProducesResponseType(typeof(FailResponse), StatusCodeAndErrorsMessagesStandard.Unauthorized)]
        //[ProducesResponseType(typeof(FailResponse), StatusCodeAndErrorsMessagesStandard.Forbidden)]
        //public async Task<ActionResult<IResponse>> UpdateBrandContent([FromRoute] int brandId, CMSBrandContentRequestDto requestDto, [FromQuery] string languageCode = "en")
        //{
        //    if (!ModelState.IsValid)
        //    {
        //        var errors = ModelState.Values.SelectMany(y => y.Errors).Select(e => e.ErrorMessage).ToList();
        //        var response = new FailResponse { ErrorMessages = errors, StatusCode = StatusCodeAndErrorsMessagesStandard.BadRequest, Status = false };
        //        return BadRequest(response);
        //    }

        //    var item = await _brandService.UpdateBrandContent(brandId, requestDto, languageCode);

        //    if (item.StatusCode == StatusCodeAndErrorsMessagesStandard.NotFound)
        //        return NotFound(item);

        //    if (item.StatusCode == StatusCodeAndErrorsMessagesStandard.BadRequest)
        //        return BadRequest(item);


        //    return Ok(item);
        //}




    }
}
