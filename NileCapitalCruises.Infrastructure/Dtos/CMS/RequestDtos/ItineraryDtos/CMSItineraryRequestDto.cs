

using NileCapitalCruises.Core.Models;
using System.ComponentModel.DataAnnotations.Schema;
using System.ComponentModel.DataAnnotations;

namespace NileCapitalCruises.Infrastructure.Dtos.CMS.RequestDtos.ItineraryDtos
{
    public class CMSItineraryRequestDto
    {
        [Required]
        [MaxLength(150)]
        public string? ItineraryNameSys { get; set; }

        [Required]
        public int? DurationId { get; set; }

        [Required]
        public int? CruiseId { get; set; }

        [Required]
        public int? ItineraryTypeId { get; set; }

        [Required]
        public int? WeekDayId { get; set; }

        [MaxLength(250)]
        public string? ItineraryMap { get; set; }




        [Required]
        public int? CityFromId { get; set; }
        [Required]
        public int? CityToId { get; set; }
        


        [MaxLength(250)]
        public string? OverviewPhoto { get; set; }
    }
}
