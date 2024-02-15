using Microsoft.EntityFrameworkCore;
using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;
using System.ComponentModel.Design;
using System.Xml.Linq;

namespace NileCapitalCruises.Core.Models
{
    [Table("tbl_CruiseBooking_Countries_Contents")]

    [Index(nameof(LanguageId), Name = "IX_tbl_CruiseBooking_Countries_Contents_LanguageId")]
    [Index(nameof(OriginalTableId), Name = "IX_tbl_CruiseBooking_Countries_Contents_CountryId")]
    public class CountryContent : BaseEntity
    {
        [ForeignKey("Country")]
        [Column("CountryId")]
        public int? OriginalTableId { get; set; }
        public int? LanguageId { get; set; }
        public bool? ContentLangStatus { get; set; }
        [MaxLength(150)]
        public string? CountryName { get; set; }

        public virtual Country? Country { get; set; }
        public virtual Language? Language { get; set; }
        public bool? IsDeleted { get; set; } = false;
    }
}
