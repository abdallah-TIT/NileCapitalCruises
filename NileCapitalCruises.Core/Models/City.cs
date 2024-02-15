using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;

namespace NileCapitalCruises.Core.Models
{
    [Table("tbl_Master_Cities")]
    public class City : BaseEntity
    {
        public City()
        {
            CityContents = new HashSet<CityContent>();
        }
        [MaxLength(150)]
        public string? CityNameSys { get; set; }
        [MaxLength(250)]
        public string? CityUrl { get; set; }
        [MaxLength(250)]
        public string? CityPhoto { get; set; }
        [MaxLength(250)]
        public string? CityBanner { get; set; }
        public bool? CityStatus { get; set; }
        public int? CityPhotoWidth { get; set; }
        public int? CityPhotoHeight { get; set; }
        public int? CityBannerWidth { get; set; }
        public int? CityBannerHeight { get; set; }

        public bool? IsDeleted { get; set; } = false;
        public virtual ICollection<CityContent> CityContents { get; set; }
    }
}
