using Microsoft.EntityFrameworkCore;
using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;
using System.ComponentModel.Design;
using System.Xml.Linq;

namespace NileCapitalCruises.Core.Models
{
    [Table("tbl_Master_Cities_Contents")]

    [Index(nameof(LanguageId), Name = "IX_tbl_Master_Cities_Contents_LanguageId")]
    [Index(nameof(OriginalTableId), Name = "IX_tbl_Master_Cities_Contents_CityId")]
    public class CityContent : BaseEntity
    {
        [ForeignKey("City")]
        [Column("CityId")]
        public int? OriginalTableId { get; set; }
        public int? LanguageId { get; set; }
        public bool? ContentLangStatus { get; set; }
        [MaxLength(150)]
        public string? CityName { get; set; }

        public virtual City? City { get; set; }
        public virtual Language? Language { get; set; }

        public bool? IsDeleted { get; set; } = false;
    }
}
