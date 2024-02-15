using System.ComponentModel.DataAnnotations;

namespace NileCapitalCruises.Infrastructure.Dtos.CMS.RequestDtos.FacilityDtos
{
    public class FacilityRequestDto
    {
        [MaxLength(150)]
        public string? FacilityNameSys { get; set; }
    }
}
