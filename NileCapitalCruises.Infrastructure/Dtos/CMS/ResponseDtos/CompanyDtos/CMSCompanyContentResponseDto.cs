namespace NileCapitalCruises.Infrastructure.Dtos.CMS.ResponseDtos.CompanyDtos
{
    public class CMSCompanyContentResponseDto
    {

        /// Start Content
        
        public int Id { get; set; }
        public int? OriginalTableId { get; set; }

        public string? CompanyName { get; set; }

        public string? CompanyAdress { get; set; }

        public bool? ContentLangStatus { get; set; }

        public string? ContactPersonName { get; set; }
        public int? LanguageId { get; set; }



    }
}
