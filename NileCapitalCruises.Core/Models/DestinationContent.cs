using Microsoft.EntityFrameworkCore;
using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;
using System.Xml.Linq;

namespace NileCapitalCruises.Core.Models
{
    [Table("tbl_CruiseBooking_Destinations_Contents")]
    [Index(nameof(LanguageId), Name = "IX_tbl_CruiseBooking_Destinations_Content_LangId")]
    [Index(nameof(OriginalTableId), Name = "IX_tbl_CruiseBooking_Destinations_Content_DestinationId")]
    public class DestinationContent : BaseEntity
    {
        [ForeignKey("Destination")]
        [Column("DestinationId")]
        public int? OriginalTableId { get; set; }
        public int? LanguageId { get; set; }
        [MaxLength(150)]
        public string? DestinationName { get; set; }
        [MaxLength(250)]
        public string? DestinationIntro { get; set; }
        [MaxLength(250)]
        public string? DestinationDetails { get; set; }
        public bool? LangStatus { get; set; }
        [MaxLength(250)]
        public string? DestinationMetatagTitle { get; set; }
        [MaxLength(250)]
        public string? DestinationMetatagDescription { get; set; }

        public bool? IsDeleted { get; set; } = false;

        public virtual Destination? Destination { get; set; }

        public virtual Language? Language { get; set; }
    }
}
