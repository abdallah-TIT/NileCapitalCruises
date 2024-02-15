using System.ComponentModel.DataAnnotations;

namespace NileCapitalCruises.Infrastructure.Dtos.CMS.RequestDtos.CruiseFacilityDtos
{
    public class CruiseFacilityRequestDto
    {
        [Required]
        public int FacilityId { get; set; }

      
    }
}
