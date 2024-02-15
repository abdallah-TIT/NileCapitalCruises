using Microsoft.EntityFrameworkCore;
using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;
using System.ComponentModel.Design;
using System.Xml.Linq;

namespace NileCapitalCruises.Core.Models
{
    [Table("tbl_CruiseBooking_Rates_Contents")]

    [Index(nameof(LanguageId), Name = "IX_tbl_CruiseBooking_Rates_Contents_LanguageId")]
    [Index(nameof(OriginalTableId), Name = "IX_tbl_CruiseBooking_Rates_Contents_RateId")]
    public class RateContent : BaseEntity
    {
        [ForeignKey("Rate")]
        [Column("RateId")]
        public int? OriginalTableId { get; set; }
        public int? LanguageId { get; set; }
        public bool? ContentLangStatus { get; set; }
       
        [MaxLength(150)]
        public string? RateName { get; set; }

       
        public virtual Rate? Rate { get; set; }
        public virtual Language? Language { get; set; }

        public bool? IsDeleted { get; set; } = false;
    }
}
