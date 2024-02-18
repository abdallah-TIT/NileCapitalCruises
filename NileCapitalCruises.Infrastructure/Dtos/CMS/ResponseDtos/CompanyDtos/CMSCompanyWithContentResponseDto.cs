namespace NileCapitalCruises.Infrastructure.Dtos.CMS.ResponseDtos.CompanyDtos
{
    public class CMSCompanyWithContentResponseDto
    {
        public int CompanyId { get; set; }

        public string? CompanyNameSys { get; set; }
        public string? Email { get; set; }

        public string? CompanyUrl { get; set; }

        public string? Logo { get; set; }

        public DateTime? StartDate { get; set; }
        public DateTime? SubscriptionStartDate { get; set; }
        public DateTime? SubscriptionEndDate { get; set; }
        public string? ContactPersonEmail { get; set; }

        public string? ContactPersonPhone { get; set; }

        public bool? Status { get; set; }

      

        /// Start Content

        public string? CompanyName { get; set; }

        public string? CompanyAdress { get; set; }

        public bool? ContentLangStatus { get; set; }

        public string? ContactPersonName { get; set; }
        public int? LanguageId { get; set; }


    }
}
