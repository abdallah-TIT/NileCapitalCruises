namespace NileCapitalCruises.Infrastructure.Dtos.CMS.ResponseDtos.FacilityDtos
{
    public class FacilityContentResponseDto
    {
        public int Id { get; set; }
        public int? OriginalTableId { get; set; }


        public string? FacilityName { get; set; }

        public bool? ContentLangStatus { get; set; }
        public string? FacilityNote { get; set; }
        public int? LanguageId { get; set; }

    }
}
