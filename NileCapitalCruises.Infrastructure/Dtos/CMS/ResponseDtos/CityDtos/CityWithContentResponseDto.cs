using System.ComponentModel.DataAnnotations;

namespace NileCapitalCruises.Infrastructure.Dtos.CMS.ResponseDtos.CityDtos
{
    public class CityWithContentResponseDto
    {
        public int CityId { get; set; }
        public string? CityNameSys { get; set; }
        public string? CityUrl { get; set; }
        public string? CityPhoto { get; set; }
        public string? CityBanner { get; set; }
        public bool? CityStatus { get; set; }
        public int? CityPhotoWidth { get; set; }
        public int? CityPhotoHeight { get; set; }
        public int? CityBannerWidth { get; set; }
        public int? CityBannerHeight { get; set; }




        /// Start Content
        public string? CityName { get; set; }

        public int? LanguageId { get; set; }
        public bool? ContentLangStatus { get; set; }

    }
}
