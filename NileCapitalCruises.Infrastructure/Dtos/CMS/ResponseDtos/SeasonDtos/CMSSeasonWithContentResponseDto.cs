


namespace NileCapitalCruises.Infrastructure.Dtos.CMS.ResponseDtos.SeasonDtos
{
    public class CMSSeasonWithContentResponseDto
    {
        public int SeasonId { get; set; }

        public int? CruiseId { get; set; }
       
        public string? SeasonNameSys { get; set; }

        public DateTime? StartDate { get; set; }
        public DateTime? EndDate { get; set; }



        /// Start Content

        public int? LanguageId { get; set; }
        public bool? ContentLangStatus { get; set; }
       
        public string? SeasonName { get; set; }
    }
}
