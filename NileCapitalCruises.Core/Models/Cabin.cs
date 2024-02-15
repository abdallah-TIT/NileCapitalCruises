using Microsoft.EntityFrameworkCore;
using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;
using System.ComponentModel.Design;
using System.Xml.Linq;

namespace NileCapitalCruises.Core.Models
{
    [Table("tbl_CruiseBooking_Cabins")]
    [Index(nameof(CruiseId), Name = "IX_tbl_CruiseBooking_Cabins_CruiseId")]
    public class Cabin : BaseEntity
    {
        public Cabin()
        {
            CabinAmenities = new HashSet<CabinAmenity>();
            CabinContents = new HashSet<CabinContent>();
            CabinPhotos = new HashSet<CabinPhoto>();
            //CabinOperationDates = new HashSet<CabinOperationDate>();
        }

        public int? CruiseId { get; set; }
        public int? DeckId { get; set; }
        public int? CabinTypeId { get; set; }

        [MaxLength(150)]
        public string? CabinNameSys { get; set; }
        [MaxLength(150)]
        public string? CabinPhoto { get; set; }
        [MaxLength(150)]
        public string? CabinBanner { get; set; }
        [MaxLength(150)]
        public string? CabinUrl { get; set; }
        public bool? CabinStatus { get; set; }
        public int? CabinPosition { get; set; }
        public int? NumberOfRooms { get; set; }
        [MaxLength(150)]
        public string? CabinSize { get; set; }
        public int? CabinPhotoWidth { get; set; }
        public int? CabinPhotoHeight { get; set; }
        public int? CabinBannerWidth { get; set; }
        public int? CabinBannerHeight { get; set; }
        [MaxLength(150)]
        public string? CabinMinPax { get; set; }
        [MaxLength(150)]
        public string? CabinMaxPax { get; set; }
        public bool? IsUpperDeckCabin { get; set; }
        public bool? Status { get; set; }
        public virtual Cruise? Cruise { get; set; }
        public virtual Deck? Deck { get; set; }
        public virtual CabinType? CabinType { get; set; }

        [InverseProperty("Cabin")]
        public virtual ICollection<CabinAmenity> CabinAmenities { get; set; }
        public virtual ICollection<CabinContent> CabinContents { get; set; }
        public virtual ICollection<CabinPhoto> CabinPhotos { get; set; }


        //[InverseProperty("Cabin")]
        //public virtual ICollection<CabinOperationDate> CabinOperationDates { get; set; }

        public bool? IsDeleted { get; set; } = false;
    }
}
