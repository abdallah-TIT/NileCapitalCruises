using Microsoft.EntityFrameworkCore;
using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;
using System.Xml.Linq;

namespace NileCapitalCruises.Core.Models
{
    [Table("tbl_CruiseBooking_Brands_Contents")]
    [Index(nameof(LanguageId), Name = "IX_tbl_CruiseBooking_Brands_Content_LangId")]
    [Index(nameof(OriginalTableId), Name = "IX_tbl_CruiseBooking_Brands_Content_BrandId")]
    public class BrandContent : BaseEntity
    {
        [ForeignKey("Brand")]
        [Column("BrandId")]
        public int OriginalTableId { get; set; }
        public int LanguageId { get; set; }
        public bool? ContentLangStatus { get; set; } = false;
        [MaxLength(150)]
        public string? BrandName { get; set; } = "Empty String please change it";
        [MaxLength(250)]
        public string? BrandIntro { get; set; } = "Empty String please change it";
        [MaxLength(250)]
        public string? MetatagTitleBrand { get; set; } = "Empty String please change it";
        [MaxLength(250)]
        public string? MetatagTitleDescription { get; set; } = "Empty String please change it";
        [MaxLength(250)]
        public string? BrandDetails { get; set; } = "Empty String please change it";

        public virtual Brand? Brand { get; set; }

        public bool? IsDeleted { get; set; } = false;
        public virtual Language? Language { get; set; }
    }
}
