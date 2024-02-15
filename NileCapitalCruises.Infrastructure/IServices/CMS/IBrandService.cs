using NileCapitalCruises.Infrastructure.Data.Specification.CMS;
using NileCapitalCruises.Infrastructure.Dtos.CMS.RequestDtos.BrandDtos;
using NileCapitalCruises.Infrastructure.Helpers.ApiResponses;

namespace NileCapitalCruises.Infrastructure.IServices.CMS
{
    public interface IBrandService
    {

         Task<IResponse> CreateBrand(CMSBrandRequestDto requestDto);

        Task<IResponse> UpdateBrand(int brandId, CMSBrandRequestDto requestDto);

        Task<IResponse> GetBrands(PaginationSpecParams paginationSpecParams);

        Task<IResponse> GetBrand(int brandId);

        Task<IResponse> DeleteBrand(int brandId);
        Task<IResponse> GetBrandContent(int brandId, string languageCode = "en");

        Task<IResponse> UpdateBrandContent(int brandId, CMSBrandContentRequestDto requestDto, string languageCode = "en");
    }
}
