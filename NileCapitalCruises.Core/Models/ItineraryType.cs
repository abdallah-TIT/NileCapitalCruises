using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;

namespace NileCapitalCruises.Core.Models
{
    [Table("tbl_Master_Itineraries_Types")]
    public class ItineraryType : BaseEntity
    {
        public ItineraryType()
        {
            ItineraryTypeContents = new HashSet<ItineraryTypeContent>();
            Itineraries = new HashSet<Itinerary>();
            CabinTypeCruiseItineraryTypePeriodRates = new HashSet<CabinTypeCruiseItineraryTypePeriodRate>();
        }

        [MaxLength(150)]
        public string? ItineraryTypeNameSys { get; set; }
        public int? ItineraryDays { get; set; }
        public int? ItineraryNights { get; set; }

        [ForeignKey("CityFrom")]
        public int? SailFrom { get; set; }
        public virtual City? CityFrom { get; set; }

        [MaxLength(250)]
        public string? ItineraryTypeUrl { get; set; }


        [ForeignKey("CityTo")]
        public int? SailTo { get; set; }
        public virtual City? CityTo { get; set; }
        public bool? IsDeleted { get; set; } = false;
        public virtual ICollection<ItineraryTypeContent> ItineraryTypeContents { get; set; }
        public virtual ICollection<Itinerary> Itineraries { get; set; }

        [InverseProperty("ItineraryType")]
        public virtual ICollection<CabinTypeCruiseItineraryTypePeriodRate> CabinTypeCruiseItineraryTypePeriodRates { get; set; }
    }
}
