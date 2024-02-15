using NileCapitalCruises.Core.Models;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;

namespace NileCapitalCruises.Infrastructure.Dtos.CMS.RequestDtos.ItineraryTypeDtos
{
    public class CMSItineraryTypeRequestDto
    {
        [MaxLength(150)]
        public string? ItineraryTypeNameSys { get; set; }
        public int? ItineraryDays { get; set; }
        public int? ItineraryNights { get; set; }

        public int? SailFrom { get; set; }
        public int? SailTo { get; set; }
      
    }
}
