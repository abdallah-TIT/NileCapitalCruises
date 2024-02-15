using System.ComponentModel.DataAnnotations;

namespace NileCapitalCruises.Infrastructure.Dtos.CMS.ResponseDtos.BrandDtos
{
    public class CMSBrandContentResponseDto
    {
        public int BrandContentId { get; set; }
        public int BrandId { get; set; }
        public int LanguageId { get; set; }
        public bool? ContentLangStatus { get; set; }
        public string? BrandName { get; set; }
        public string? BrandIntro { get; set; }
        public string? MetatagTitleBrand { get; set; }
        public string? MetatagTitleDescription { get; set; }
        public string? BrandDetails { get; set; }

    }
}
