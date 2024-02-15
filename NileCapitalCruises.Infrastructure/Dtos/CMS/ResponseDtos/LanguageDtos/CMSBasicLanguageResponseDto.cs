

namespace NileCapitalCruises.Infrastructure.Dtos.CMS.ResponseDtos.LanguageDtos
{
    public class CMSBasicLanguageResponseDto
    {
        public int LanguageId { get; set; }
        public string LanguageName { get; set; }
        public string LanguageFlag { get; set; }
        public string LanguageAbbreviation { get; set; }
        public bool? LangStatus { get; set; }
        public string LanguageClass { get; set; }
    }
}
