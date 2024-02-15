namespace NileCapitalCruises.Infrastructure.Dtos.CMS.ResponseDtos.FacilityDtos
{
    public class FacilityWithContentResponseDto
    {
        public int FacilityId { get; set; }
        public string? FacilityNameSys { get; set; }
       
        public string? FacilityUrl { get; set; }

        ///

        public string? FacilityName { get; set; }

        public bool? ContentLangStatus { get; set; }
        public string? FacilityNote { get; set; }
        public int? LanguageId { get; set; }

    }
}
