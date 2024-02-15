using Microsoft.EntityFrameworkCore;
using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;
using System.ComponentModel.Design;
using System.Xml.Linq;

namespace NileCapitalCruises.Core.Models
{
    [Table("tbl_Master_CabinStatuses_Contents")]

    [Index(nameof(LanguageId), Name = "IX_tbl_Master_CabinStatuses_Contents_LanguageId")]
    [Index(nameof(OriginalTableId), Name = "IX_tbl_Master_CabinStatuses_Contents_CabinStatusId")]
    public class CabinStatusContent : BaseEntity
    {
        [ForeignKey("CabinStatus")]
        [Column("CabinStatusId")]
        public int? OriginalTableId { get; set; }
        public int? LanguageId { get; set; }
        public bool? ContentLangStatus { get; set; }
        [MaxLength(250)]
        public string? CabinStatusName { get; set; }

        public virtual CabinStatus? CabinStatus { get; set; }
        public virtual Language? Language { get; set; }

        public bool? IsDeleted { get; set; } = false;
    }
}
