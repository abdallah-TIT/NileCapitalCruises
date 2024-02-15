
using NileCapitalCruises.Infrastructure.Data.Specification.CMS;
using NileCapitalCruises.Infrastructure.Dtos.CMS.RequestDtos.CruiseCategoryDtos;
using NileCapitalCruises.Infrastructure.Dtos.CMS.RequestDtos.FacilityDtos;
using NileCapitalCruises.Infrastructure.Helpers.ApiResponses;
using Microsoft.AspNetCore.JsonPatch;

namespace NileCapitalCruises.Infrastructure.IServices.CMS
{
    public interface ICruiseCategoryService
    {
        Task<IResponse> CreateCruiseCategory(CMSCruiseCategoryRequestDto requestDto);
        Task<IResponse> UpdateCruiseCategory(int cruiseCategoryId, CMSCruiseCategoryRequestDto requestDto);

        Task<IResponse> GetCruiseCategories(PaginationSpecParams paginationSpecParams);

        Task<IResponse> GetCruiseCategory(int cruiseCategoryId);

        Task<IResponse> DeleteCruiseCategory(int cruiseCategoryId);

        Task<IResponse> GetCruiseCategoryContent(int cruiseCategoryId, string languageCode = "en");

        Task<IResponse> UpdateCruiseCategoryContent(int cruiseCategoryId, CMSCruiseCategoryContentRequestDto requestDto, string languageCode = "en");
    }
}
