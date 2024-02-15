using System.ComponentModel.DataAnnotations;

namespace NileCapitalCruises.Infrastructure.Dtos.CMS.RequestDtos.CabinDtos
{
    public class AmenityRequestDto
    {
        [MaxLength(150)]
        public string? AmenityNameSys { get; set; }
        [MaxLength(150)]
        public string? AmenityIcon { get; set; }
        public int? AmenityPosition { get; set; }
        public int? AmenityIconWidth { get; set; }
        public int? AmenityIconHeight { get; set; }
        public bool? Status { get; set; }

    }
}
