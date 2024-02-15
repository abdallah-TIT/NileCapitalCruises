using NileCapitalCruises.Core.ApiModels;
using Microsoft.EntityFrameworkCore;
using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;
using System.Xml.Linq;

namespace NileCapitalCruises.Core.Models
{
    [Table("tbl_CruiseBooking_Itineraries")]
    [Index(nameof(CruiseId), Name = "IX_tbl_CruiseBooking_Itineraries_CruiseId")]
    [Index(nameof(CompanyId), Name = "IX_tbl_CruiseBooking_Itineraries_CompanyId")]
    public class Itinerary : BaseEntity
    {
        public Itinerary()
        {
            ItineraryContents = new HashSet<ItineraryContent>();
            OperationDates = new HashSet<OperationDate>();
            ItineraryDays = new HashSet<ItineraryDay>();
        }


        [MaxLength(150)]
        public string? ItineraryNameSys { get; set; }
        public int? DurationId { get; set; }
        public int? CompanyId { get; set; }

        [MaxLength(150)]
        public string? ItineraryUrl { get; set; }

        [MaxLength(250)]
        public string? ItineraryMap { get; set; }

        public int? CruiseId { get; set; }
        public int? ItineraryTypeId { get; set; }

        public int? WeekDayId { get; set; }

        public bool? IsDeleted { get; set; } = false;
        public bool? ItineraryStatus { get; set; } = true;


        [ForeignKey("CityFrom")]
        public int? CityFromId { get; set; }
        public virtual City? CityFrom { get; set; }


        [ForeignKey("CityTo")]
        public int? CityToId { get; set; }
        public virtual City? CityTo { get; set; }


        [MaxLength(250)]
        public string? OverviewPhoto { get; set; }
        public virtual ItineraryType? ItineraryType { get; set; }
        public virtual Cruise? Cruise { get; set; }
        public virtual WeekDay? WeekDay { get; set; }
        public virtual Duration? Duration { get; set; }
        public virtual Company? Company { get; set; }
        
        public virtual ICollection<ItineraryContent> ItineraryContents { get; set; }
        public virtual ICollection<OperationDate> OperationDates { get; set; }
        public virtual ICollection<ItineraryDay> ItineraryDays { get; set; }

    }
}
