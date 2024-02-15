using System.ComponentModel.DataAnnotations;

namespace NileCapitalCruises.Infrastructure.Dtos.CMS.ResponseDtos.CruisCategoryDtos
{
    public class CMSCruiseCategoryContentResponseDto
    {
        public int CruiseCategoryContentId { get; set; }
        public int CruiseCategoryId { get; set; }


        //

        public string? CruiseCategoryName { get; set; }
        public bool? ContentLangStatus { get; set; }

    }
}
