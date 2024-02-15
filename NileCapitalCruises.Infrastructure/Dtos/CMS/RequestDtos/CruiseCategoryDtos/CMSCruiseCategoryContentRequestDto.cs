using System.ComponentModel.DataAnnotations;

namespace NileCapitalCruises.Infrastructure.Dtos.CMS.RequestDtos.CruiseCategoryDtos
{
    public class CMSCruiseCategoryContentRequestDto
    {
        [MaxLength(150)]
        public string? CruiseCategoryName { get; set; }
        public bool? ContentLangStatus { get; set; }

    }
}
