using Microsoft.EntityFrameworkCore;
using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;
using System.ComponentModel.Design;
using System.Xml.Linq;

namespace NileCapitalCruises.Core.Models
{
    [Table("tbl_Master_Facilties_Contents")]
    [Index(nameof(LanguageId), Name = "IX_tbl_Master_Facilties_Contents_LanguageId")]
    [Index(nameof(OriginalTableId), Name = "IX_tbl_Master_Facilties_Contents_FacilityId")]
    public class FacilityContent : BaseEntity
    {
        public FacilityContent()
        {
        }

        [MaxLength(150)]
        public string? FacilityName { get; set; }

        [MaxLength(250)]
        public string? FacilityNote { get; set; }
        public int? LanguageId { get; set; }

        [ForeignKey("Facility")]
        [Column("FacilityId")]
        public int? OriginalTableId { get; set; }


        public virtual Language? Language { get; set; }

        public virtual Facility? Facility { get; set; }
        public bool? IsDeleted { get; set; } = false;

        


    }
}
