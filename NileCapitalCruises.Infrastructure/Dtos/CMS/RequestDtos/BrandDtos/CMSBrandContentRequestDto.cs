using System.ComponentModel.DataAnnotations;

namespace NileCapitalCruises.Infrastructure.Dtos.CMS.RequestDtos.BrandDtos
{
    public class CMSBrandContentRequestDto
    {
        public bool? ContentLangStatus { get; set; }
        [MaxLength(150)]
        public string? BrandName { get; set; }
        [MaxLength(250)]
        public string? BrandIntro { get; set; }
        [MaxLength(250)]
        public string? MetatagTitleBrand { get; set; }
        [MaxLength(250)]
        public string? MetatagTitleDescription { get; set; }
        [MaxLength(250)]
        public string? BrandDetails { get; set; }





    }
}
