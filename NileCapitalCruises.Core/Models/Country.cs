using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;

namespace NileCapitalCruises.Core.Models
{
    [Table("tbl_CruiseBooking_Countries")]
    public class Country : BaseEntity
    {
        public Country()
        {
            CountryContents = new HashSet<CountryContent>();
            Destinations = new HashSet<Destination>();
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
        public virtual ICollection<CountryContent> CountryContents { get; set; }

        public virtual ICollection<Destination> Destinations { get; set; }
    }
}
