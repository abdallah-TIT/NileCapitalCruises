using Microsoft.EntityFrameworkCore;
using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;
using System.Xml.Linq;

namespace NileCapitalCruises.Core.Models
{
    [Table("tbl_Master_Amenities_Contents")]
    [Index(nameof(LanguageId), Name = "IX_tbl_Master_Amenities_Content_LangId")]
    [Index(nameof(OriginalTableId), Name = "IX_tbl_Master_Amenities_Content_AmenityId")]
    public class AmenityContent : BaseEntity
    {
        [ForeignKey("Amenity")]
        [Column("AmenityId")]
        public int? OriginalTableId { get; set; }
        public int? LanguageId { get; set; }
        public bool? ContentLangStatus { get; set; }
        [MaxLength(150)]
        public string? AmenityName { get; set; }
        public bool? IsDeleted { get; set; } = false;
        public virtual Amenity? Amenity { get; set; }

        public virtual Language? Language { get; set; }
    }
}
