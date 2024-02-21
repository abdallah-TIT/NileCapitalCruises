using Microsoft.EntityFrameworkCore;
using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;
using System.ComponentModel.Design;
using System.Xml.Linq;

namespace NileCapitalCruises.Core.Models
{
    [Table("tbl_CruiseBooking_Periods_Contents")]

    [Index(nameof(LanguageId), Name = "IX_tbl_CruiseBooking_Periods_Contents_LanguageId")]
    [Index(nameof(OriginalTableId), Name = "IX_tbl_CruiseBooking_Periods_Contents_PeriodId")]
    public class PeriodContent : BaseEntity
    {
        public int? LanguageId { get; set; }

        [ForeignKey("Period")]
        [Column("PeriodId")]
        public int? OriginalTableId { get; set; }

        [MaxLength(150)]
        public string? PeriodName { get; set; } = "Empty String please change it";

        public bool? ContentLangStatus { get; set; } = false;

        public virtual Language? Language { get; set; }

        public bool? IsDeleted { get; set; } = false;
    }
}
