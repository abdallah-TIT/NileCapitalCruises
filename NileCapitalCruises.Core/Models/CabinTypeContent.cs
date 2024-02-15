using Microsoft.EntityFrameworkCore;
using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;
using System.ComponentModel.Design;
using System.Xml.Linq;

namespace NileCapitalCruises.Core.Models
{
    [Table("tbl_Master_Cabins_Types_Contents")]

    [Index(nameof(LanguageId), Name = "IX_tbl_Master_Cabins_Types_Contents_LanguageId")]
    [Index(nameof(OriginalTableId), Name = "IX_tbl_Master_Cabins_Types_Contents_CabinTypeId")]
    public class CabinTypeContent : BaseEntity
    {
        public int? LanguageId { get; set; }

        [ForeignKey("CabinType")]
        [Column("CabinTypeId")]
        public int? OriginalTableId { get; set; }

        [MaxLength(150)]
        public string? CabinTypeName { get; set; }

        public virtual Language? Language { get; set; }

        public bool? IsDeleted { get; set; } = false;
    }
}
