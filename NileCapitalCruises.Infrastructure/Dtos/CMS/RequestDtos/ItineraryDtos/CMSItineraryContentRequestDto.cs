using System.ComponentModel.DataAnnotations;

namespace NileCapitalCruises.Infrastructure.Dtos.CMS.RequestDtos.ItineraryDtos
{
    public class CMSItineraryContentRequestDto
    {
        [MaxLength(150)]
        public string? ItineraryName { get; set; }

        [MaxLength(250)]
        public string? Intro { get; set; }

        [MaxLength(250)]
        public string? Details { get; set; }

    }
}
