using System.ComponentModel.DataAnnotations;

namespace NileCapitalCruises.Infrastructure.Dtos.CMS.ResponseDtos.BrandDtos
{
    public class CMSBasicBrandResponseDto
    {
        public int BrandId { get; set; }

        public string? BrandNameSys { get; set; }

        public string? BrandUrl { get; set; }
        public string? BrandPhoto { get; set; }
        public int? BrandPhotoWidth { get; set; }
        public int? BrandPhotoHeight { get; set; }

        public string? BrandBanner { get; set; }
        public int? BrandBannerWidth { get; set; }
        public int? BrandBannerHeight { get; set; }

      
        public bool? Status { get; set; }

    }
}
