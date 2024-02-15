using Microsoft.EntityFrameworkCore;
using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;
using System.ComponentModel.Design;
using System.Xml.Linq;

namespace NileCapitalCruises.Core.Models
{
    [Table("tbl_CruiseBooking_Cabins_Contents")]

    [Index(nameof(LanguageId), Name = "IX_tbl_CruiseBooking_Cabins_Content_LangId")]
    [Index(nameof(OriginalTableId), Name = "IX_tbl_CruiseBooking_Cabins_Content_CabinId")]
    public partial class CabinContent : BaseEntity
    {
        [ForeignKey("Cabin")]
        [Column("CabinId")]
        public int? OriginalTableId { get; set; }
        public int? LanguageId { get; set; }
        public bool? ContentLangStatus { get; set; }
        [MaxLength(150)]
        public string? CabinName { get; set; }
        [MaxLength(250)]

        public string? CabinDetails { get; set; }
        [MaxLength(250)]
        public string? CabinIntro { get; set; }

        public virtual Cabin? Cabin { get; set; }
        public virtual Language? Language { get; set; }


        public bool? IsDeleted { get; set; } = false;
    }
}
