

namespace NileCapitalCruises.Infrastructure.Dtos.CMS.ResponseDtos.DiningDtos
{
    public class DiningContentResponseDto
    {
        public int Id { get; set; }
        public int? OriginalTableId { get; set; }

        ////
        ///


        public int? LanguageId { get; set; }
        public bool? ContentLangStatus { get; set; }

        public string? DiningName { get; set; }

        
        public string? DiningDescription { get; set; }
    }
}
