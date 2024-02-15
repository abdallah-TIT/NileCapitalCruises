using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;

namespace NileCapitalCruises.Core.Models
{
    [Table("tbl_Master_Amenities")]
    public class Amenity : BaseEntity
    {
        public Amenity()
        {
            CabinAmenities = new HashSet<CabinAmenity>();
            AmenityContents = new HashSet<AmenityContent>();
        }

        [MaxLength(150)]
        public string? AmenityNameSys { get; set; }
        [MaxLength(150)]
        public string? AmenityIcon { get; set; }
        public int? AmenityPosition { get; set; }
        public int? AmenityIconWidth { get; set; }
        public int? AmenityIconHeight { get; set; }
        public bool? IsDeleted { get; set; } = false;
        [MaxLength(250)]
        public string? AmenityUrl { get; set; }
        public bool? Status { get; set; }
        public virtual ICollection<AmenityContent> AmenityContents { get; set; }

        [InverseProperty("Amenity")]
        public virtual ICollection<CabinAmenity> CabinAmenities { get; set; }
    }
}
