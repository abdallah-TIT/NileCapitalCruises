
using Microsoft.EntityFrameworkCore;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;
using System.Xml.Linq;

namespace NileCapitalCruises.Core.Models
{
    [Table("tbl_CruiseBooking_Cruises_Categories_Contents")]
    [Index(nameof(LanguageId), Name = "IX_tbl_CruiseBooking_Cruises_Categories_Content_LangId")]
    [Index(nameof(OriginalTableId), Name = "IX_tbl_CruiseBooking_Cruises_Categories_Content_CruiseId")]
    public class CruiseCategoryContent : BaseEntity
    {
        [ForeignKey("CruiseCategory")]
        [Column("CruiseCategoryId")]
        public int OriginalTableId { get; set; }
        public int LanguageId { get; set; }
        [MaxLength(150)]
        public string? CruiseCategoryName { get; set; } = "Empty String please change it";
        public bool? ContentLangStatus { get; set; } = false;

        public virtual CruiseCategory? CruiseCategory { get; set; }
        public virtual Language? Language { get; set; }
        public bool? IsDeleted { get; set; } = false;

    }
}
