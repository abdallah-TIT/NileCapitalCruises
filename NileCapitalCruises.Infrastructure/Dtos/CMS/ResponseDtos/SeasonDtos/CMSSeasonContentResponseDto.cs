namespace NileCapitalCruises.Infrastructure.Dtos.CMS.ResponseDtos.SeasonDtos
{
    public class CMSSeasonContentResponseDto
    {

        /// Start Content

        public int SeasonContentId { get; set; }
        public int? SeasonId { get; set; }


        public string? SeasonName { get; set; }
        public int? LanguageId { get; set; }

        public bool? ContentLangStatus { get; set; }

    }
}
