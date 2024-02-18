namespace NileCapitalCruises.Infrastructure.Dtos.CMS.ResponseDtos.CruiseDtos
{
    public class CMSCruiseContentResponseDto
    {
       
        public int? CruiseContentId { get; set; }
        public int? CruiseId { get; set; }
        public int? LanguageId { get; set; }
        public bool? ContentLangStatus { get; set; }


        
        public string? CruiseName { get; set; }

        public string? CruiseDetails { get; set; }
        public string? CruiseIntro { get; set; }
        public string? CruiseOverview { get; set; }
        public string? CruiseDining { get; set; }
        public string? CruiseAccommodation { get; set; }
        public string? CruiseActivities { get; set; }
        public string? CruiseNote { get; set; }
        public string? CruiseTechnicalSpecifications { get; set; }

       
    }
}
