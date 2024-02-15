using System.ComponentModel.DataAnnotations;

namespace NileCapitalCruises.Infrastructure.Dtos.CMS.RequestDtos.CruiseCategoryDtos
{
    public class CMSCruiseCategoryRequestDto
    {
        [MaxLength(150)]
        
        public string? CruiseCategoryNameSys { get; set; }
       
    }
}
