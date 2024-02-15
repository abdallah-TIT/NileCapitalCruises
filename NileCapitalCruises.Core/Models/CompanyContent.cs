using Microsoft.EntityFrameworkCore;
using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;

namespace NileCapitalCruises.Core.Models
{
    [Table("tbl_CruiseBooking_Companies_Contents")]

    [Index(nameof(LanguageId), Name = "IX_tbl_CruiseBooking_Companies_Content_LanguageId")]
    [Index(nameof(OriginalTableId), Name = "IX_tbl_CruiseBooking_Companies_Content_CompanyId")]
    public class CompanyContent : BaseEntity
    {

        [ForeignKey("Company")]
        [Column("CompanyId")]
        public int? OriginalTableId { get; set; }

        [MaxLength(150)]
        public string? CompanyName { get; set; }

        [MaxLength(250)]
        public string? CompanyAdress { get; set; }

        public bool? ContentLangStatus { get; set; }

        [MaxLength(50)]
        public string? ContactPersonName { get; set; }
        public int? LanguageId { get; set; }

        public bool? IsDeleted { get; set; } = false;

        public virtual Language? Language { get; set; }
        public virtual Company? Company { get; set; }
    }
}
