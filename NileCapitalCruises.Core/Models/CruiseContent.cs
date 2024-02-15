using Microsoft.EntityFrameworkCore;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;

namespace NileCapitalCruises.Core.Models
{
    [Table("tbl_CruiseBooking_Cruises_Contents")]
    [Index(nameof(LanguageId), Name = "IX_tbl_CruiseBooking_Cruises_Content_LangId")]
    [Index(nameof(OriginalTableId), Name = "IX_tbl_CruiseBooking_Cruises_Content_CruiseId")]
    public class CruiseContent : BaseEntity
    {
        [ForeignKey("Cruise")]
        [Column("CruiseId")]
        public int? OriginalTableId { get; set; }
        public int? LanguageId { get; set; }
        public bool? ContentLangStatus { get; set; }


        [MaxLength(150)]
        public string? CruiseName { get; set; }

        [MaxLength(150)]
        public string? CruiseDetails { get; set; }
        [MaxLength(150)]
        public string? CruiseIntro { get; set; }
        [MaxLength(150)]
        public string? CruiseOverview { get; set; }
        [MaxLength(150)]
        public string? CruiseDining { get; set; }
        [MaxLength(150)]
        public string? CruiseAccommodation { get; set; }
        [MaxLength(150)]
        public string? CruiseActivities { get; set; }
        [MaxLength(150)]
        public string? CruiseNote { get; set; }
        [MaxLength(150)]
        public string? CruiseTechnicalSpecifications { get; set; }

        public bool? IsDeleted { get; set; } = false;

        public virtual Cruise? Cruise { get; set; }
        public virtual Language? Language { get; set; }
    }
}
