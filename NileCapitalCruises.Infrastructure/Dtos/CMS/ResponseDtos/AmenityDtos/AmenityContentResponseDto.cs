
namespace NileCapitalCruises.Infrastructure.Dtos.CMS.ResponseDtos.AmenityDtos
{
    public class AmenityContentResponseDto
    {
        public int Id { get; set; }
        public int? OriginalTableId { get; set; }
        public int? LanguageId { get; set; }
        public bool? ContentLangStatus { get; set; }
        //

        public string? AmenityName { get; set; }
    }
}
