using System.ComponentModel.DataAnnotations;

namespace NileCapitalCruises.Infrastructure.Dtos.CMS.RequestDtos.AmenityDtos
{
    public class AmenityContentRequestDto
    {
        public bool? ContentLangStatus { get; set; }
        [MaxLength(150)]
        public string? AmenityName { get; set; }

    }
}
