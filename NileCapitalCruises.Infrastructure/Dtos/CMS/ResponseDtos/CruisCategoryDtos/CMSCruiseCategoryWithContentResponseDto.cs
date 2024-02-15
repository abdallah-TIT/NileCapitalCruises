using System.ComponentModel.DataAnnotations;

namespace NileCapitalCruises.Infrastructure.Dtos.CMS.ResponseDtos.CruisCategoryDtos
{
    public class CMSCruiseCategoryWithContentResponseDto
    {
        public int CruiseCategoryId { get; set; }
        public string? CruiseCategoryNameSys { get; set; }
        public string? ClassIcon { get; set; }
        public string? CruiseCategoryUrl { get; set; }


        //
        
        public string? CruiseCategoryName { get; set; }
        public bool? ContentLangStatus { get; set; }

    }
}
