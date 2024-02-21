using NileCapitalCruises.Core.Models;
using System.ComponentModel.DataAnnotations;

namespace NileCapitalCruises.Infrastructure.Dtos.CMS.RequestDtos.SeasonDtos
{
    public class CMSSeasonRequestDto
    {
        [Required]
        public int? CruiseId { get; set; }
        [Required]
        [MaxLength(150)]
        public string? SeasonNameSys { get; set; }
        [Required]
        public DateTime? StartDate { get; set; }
        [Required]
        public DateTime? EndDate { get; set; }

        
    }
}
