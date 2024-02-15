namespace NileCapitalCruises.Infrastructure.Dtos.CMS.ResponseDtos.ItineraryTypeDtos
{
    public class CMSItineraryTypeContentResponseDto
    {

        /// Start Content

        public int ItineraryTypeContentId { get; set; }
        public int? ItineraryTypeId { get; set; }

        public string? ItineraryTypeName { get; set; }
        public int? LanguageId { get; set; }

        public bool? ContentLangStatus { get; set; }

    }
}
