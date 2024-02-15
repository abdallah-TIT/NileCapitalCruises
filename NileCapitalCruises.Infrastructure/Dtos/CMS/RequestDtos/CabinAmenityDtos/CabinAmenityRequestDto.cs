using System.ComponentModel.DataAnnotations;

namespace NileCapitalCruises.Infrastructure.Dtos.CMS.RequestDtos.CabinAmenityDtos
{
    public class CabinAmenityRequestDto
    {
        [Required]
        public int AmenityId { get; set; }


    }
}
