using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;
using System.Diagnostics.Metrics;

namespace NileCapitalCruises.Core.Models
{
    [Table("tbl_CruiseBooking_Destinations")]
    public class Destination : BaseEntity
    {
        public Destination()
        {
            DestinationContents = new HashSet<DestinationContent>();
        }

        public int? CountryId { get; set; }
        [MaxLength(150)]
        public string? DestinationNameSys { get; set; }
        [MaxLength(150)]
        public string? SejourCode { get; set; }
        public int? LocationId { get; set; }
        public bool? IsMainMenu { get; set; }
        public bool? IsTravelGuide { get; set; }
        [MaxLength(250)]
        public string? DestinationMainVideo { get; set; }
        public bool? IntroIsVideo { get; set; }
        [MaxLength(250)]
        public string? DestinationUrl { get; set; }
        [MaxLength(250)]
        public string? DestinationMainPhoto { get; set; }
        [MaxLength(250)]
        public string? DestinationMainBanner { get; set; }
        public bool? IsPort { get; set; }
        public bool? IsEmbarkationCruise { get; set; }
        public bool? IsDeleted { get; set; }
        public bool? DestinationStatus { get; set; }
        public int? DestinationMainPhotoWidth { get; set; }
        public int? DestinationMainPhotoHeight { get; set; }
        public int? DestinationMainBannerWidth { get; set; }
        public int? DestinationMainBannerHeight { get; set; }
        public bool? IsFetaure { get; set; }
        [MaxLength(250)]
        public string? DestinationMainPhotoPackages { get; set; }
        [MaxLength(250)]
        public string? DestinationMainPhotoCruises { get; set; }
        [MaxLength(250)]
        public string? DestinationMainPhotoExcursions { get; set; }
        [MaxLength(250)]
        public string? DestinationMainPhotoShore { get; set; }
        [MaxLength(250)]
        public string? DestinationMainPhotoTransfers { get; set; }
        [MaxLength(250)]
        public string? DestinationMainPhotoHotels { get; set; }
        public int? DestinationMainPhotoPackagesWidth { get; set; }
        public int? DestinationMainPhotoCruisesWidth { get; set; }
        public int? DestinationMainPhotoExcursionsWidth { get; set; }
        public int? DestinationMainPhotoShoreWidth { get; set; }
        public int? DestinationMainPhotoTransfersWidth { get; set; }
        public int? DestinationMainPhotoHotelsWidth { get; set; }
        public int? DestinationMainPhotoPackagesHeight { get; set; }
        public int? DestinationMainPhotoCruisesHeight { get; set; }
        public int? DestinationMainPhotoExcursionsHeight { get; set; }
        public int? DestinationMainPhotoShoreHeight { get; set; }
        public int? DestinationMainPhotoTransfersHeight { get; set; }
        public int? DestinationMainPhotoHotelsHeight { get; set; }
        [MaxLength(250)]
        public string? DestinationMainBannerPackages { get; set; }
        [MaxLength(250)]
        public string? DestinationMainBannerCruises { get; set; }
        [MaxLength(250)]
        public string? DestinationMainBannerExcursions { get; set; }
        [MaxLength(250)]
        public string? DestinationMainBannerShore { get; set; }
        [MaxLength(250)]
        public string? DestinationMainBannerTransfers { get; set; }
        [MaxLength(250)]
        public string? DestinationMainBannerHotels { get; set; }

        public int? DestinationMainBannerPackagesWidth { get; set; }
        public int? DestinationMainBannerCruisesWidth { get; set; }
        public int? DestinationMainBannerExcursionsWidth { get; set; }
        public int? DestinationMainBannerShoreWidth { get; set; }
        public int? DestinationMainBannerTransfersWidth { get; set; }
        public int? DestinationMainBannerHotelsWidth { get; set; }
        public int? DestinationMainBannerPackagesHeight { get; set; }
        public int? DestinationMainBannerCruisesHeight { get; set; }
        public int? DestinationMainBannerExcursionsHeight { get; set; }
        public int? DestinationMainBannerShoreHeight { get; set; }
        public int? DestinationMainBannerTransfersHeight { get; set; }
        public int? DestinationMainBannerHotelsHeight { get; set; }
        public virtual Country? Country { get; set; }
        public virtual ICollection<DestinationContent> DestinationContents { get; set; }

        
    }
}
