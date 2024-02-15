using Microsoft.EntityFrameworkCore;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;

namespace NileCapitalCruises.Core.Models
{
    [Table("tbl_CruiseBooking_Dinings_Contents")]
    [Index(nameof(LanguageId), Name = "IX_tbl_CruiseBooking_Dinings_Content_LangId")]
    [Index(nameof(OriginalTableId), Name = "IX_tbl_CruiseBooking_Dinings_Content_DiningId")]
    public class DiningContent : BaseEntity
    {
        [ForeignKey("Dining")]
        [Column("DiningId")]
        public int? OriginalTableId { get; set; }
        public int? LanguageId { get; set; }
        public bool? ContentLangStatus { get; set; }

        [MaxLength(150)]
        public string? DiningName { get; set; }

        [MaxLength(250)]
        public string? DiningDescription { get; set; }



        public bool? IsDeleted { get; set; } = false;

        public virtual Dining? Dining { get; set; }
        public virtual Language? Language { get; set; }
    }
}
