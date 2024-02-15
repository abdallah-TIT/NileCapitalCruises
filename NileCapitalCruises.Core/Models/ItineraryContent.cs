using Microsoft.EntityFrameworkCore;
using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;
using System.ComponentModel.Design;
using System.Xml.Linq;

namespace NileCapitalCruises.Core.Models
{
    [Table("tbl_CruiseBooking_Itineraries_Contents")]
    [Index(nameof(LanguageId), Name = "IX_tbl_CruiseBooking_Itineraries_Contents_LanguageId")]
    [Index(nameof(OriginalTableId), Name = "IX_tbl_CruiseBooking_Itineraries_Contents_ItineraryId")]
    public class ItineraryContent : BaseEntity
    {
        public ItineraryContent()
        {
        }

        [MaxLength(150)]
        public string? ItineraryName { get; set; }

        public int? LanguageId { get; set; }

        [ForeignKey("Itinerary")]
        [Column("ItineraryId")]
        public int? OriginalTableId { get; set; }


        public virtual Language? Language { get; set; }

        public virtual Itinerary? Itinerary { get; set; }
        public bool? IsDeleted { get; set; } = false;

        [MaxLength(250)]
        public string? Intro { get; set; }

        [MaxLength(250)]
        public string? Details { get; set; }


    }
}
