using System.ComponentModel.DataAnnotations;

namespace NileCapitalCruises.Infrastructure.Dtos.CMS.RequestDtos.CabinDtos
{
    public class CabinContentRequestDto
    {
        public bool? ContentLangStatus { get; set; }
        [MaxLength(150)]
        public string? CabinName { get; set; }
        [MaxLength(250)]

        public string? CabinDetails { get; set; }
        [MaxLength(250)]
        public string? CabinIntro { get; set; }

    }
}
