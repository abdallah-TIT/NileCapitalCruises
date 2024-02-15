using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;

namespace NileCapitalCruises.Core.Models
{
    [Table("tbl_CruiseBooking_Brands")]
    public class Brand : BaseEntity
    {
        public Brand()
        {
            BrandContents = new HashSet<BrandContent>();
        }
        [MaxLength(150)]
        public string? BrandNameSys { get; set; }

        [MaxLength(250)]
        public string? BrandUrl { get; set; }
        public bool? IsDeleted { get; set; } = false;
        [MaxLength(250)]
        public string? BrandPhoto { get; set; } = "none.jpg";
        public int? BrandPhotoWidth { get; set; } = 0;
        public int? BrandPhotoHeight { get; set; } = 0;

        [MaxLength(250)]
        public string? BrandBanner { get; set; } = "none.jpg";
        public int? BrandBannerWidth { get; set; } = 0;
        public int? BrandBannerHeight { get; set; } = 0;
        
        public bool? Status { get; set; } = false;
        public virtual ICollection<BrandContent> BrandContents { get; set; }
       
    }
}
