using System.ComponentModel.DataAnnotations;

namespace NileCapitalCruises.Infrastructure.Dtos.CMS.RequestDtos.FacilityDtos
{
    public class FacilityContentRequestDto
    {
        [MaxLength(150)]
        public string? FacilityName { get; set; }

        [MaxLength(250)]
        public string? FacilityNote { get; set; }
    }
}
