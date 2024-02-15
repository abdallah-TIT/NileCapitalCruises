using Microsoft.EntityFrameworkCore;
using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;
using System.ComponentModel.Design;
using System.Text.Json.Serialization;
using System.Xml.Linq;

namespace NileCapitalCruises.Core.Models
{
    [Table("tbl_CruiseBooking_Itineraries_Days_Contents")]
    [Index(nameof(LanguageId), Name = "IX_tbl_CruiseBooking_Itineraries_Days_Contents_LanguageId")]
    [Index(nameof(OriginalTableId), Name = "IX_tbl_CruiseBooking_Itineraries_Days_Contents_ItineraryDayId")]
    public class ItineraryDayContent : BaseEntity
    {
        public ItineraryDayContent()
        {
        }

        [MaxLength(150)]
        public string? DayTitle { get; set; }

        [MaxLength(250)]
        public string? DayDetails { get; set; }


        public bool? ContentLangStatus { get; set; }

        public int? LanguageId { get; set; }

        [ForeignKey("ItineraryDay")]
        [Column("ItineraryDayId")]
        public int? OriginalTableId { get; set; }


        public virtual Language? Language { get; set; }

        [JsonIgnore]
        public virtual ItineraryType? ItineraryType { get; set; }
        public bool? IsDeleted { get; set; } = false;

    }
}
