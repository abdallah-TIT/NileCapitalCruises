using System.ComponentModel.DataAnnotations;

namespace NileCapitalCruises.Infrastructure.Dtos.CMS.ResponseDtos.BrandDtos
{
    public class CMSBrandWithContentResponseDto
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


        // start Brand content

       
        public int LanguageId { get; set; }
        public bool? ContentLangStatus { get; set; }
        public string? BrandName { get; set; }
        public string? BrandIntro { get; set; }
        public string? MetatagTitleBrand { get; set; }
        public string? MetatagTitleDescription { get; set; }
        public string? BrandDetails { get; set; }

    }
}
