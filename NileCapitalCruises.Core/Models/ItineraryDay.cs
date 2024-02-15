using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;

namespace NileCapitalCruises.Core.Models
{
    [Table("tbl_CruiseBooking_Itineraries_Days")]
    public class ItineraryDay : BaseEntity
    {
        public ItineraryDay()
        {
            
        }

        public int? DayNumber { get; set; }

        public int? WeekDayId { get; set; }


      
        public int? ItineraryId { get; set; }
        public virtual Itinerary? Itinerary { get; set; }

        public virtual WeekDay? WeekDay { get; set; }


        public bool? IsDeleted { get; set; } = false;
        public bool? Status { get; set; } = true;   
    }
}
