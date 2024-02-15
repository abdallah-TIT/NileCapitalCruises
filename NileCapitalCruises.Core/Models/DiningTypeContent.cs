using Microsoft.EntityFrameworkCore;
using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;
using System.ComponentModel.Design;
using System.Xml.Linq;

namespace NileCapitalCruises.Core.Models
{
    [Table("tbl_Master_DiningTypes_Contents")]
    [Index(nameof(LanguageId), Name = "IX_tbl_Master_DiningTypes_Contents_LanguageId")]
    [Index(nameof(OriginalTableId), Name = "IX_tbl_Master_DiningTypes_Contents_DiningTypeId")]

    public class DiningTypeContent : BaseEntity
    {
        public DiningTypeContent()
        {
        }

        [MaxLength(150)]
        public string? DiningTypeName { get; set; }

        public int? LanguageId { get; set; }


        [ForeignKey("DiningType")]
        [Column("DiningTypeId")]
        public int? OriginalTableId { get; set; }

        public bool? ContentLangStatus { get; set; }
        public virtual Language? Language { get; set; }

        public virtual DiningType? DiningType { get; set; }
        public bool? IsDeleted { get; set; } = false;

       

    }
}
