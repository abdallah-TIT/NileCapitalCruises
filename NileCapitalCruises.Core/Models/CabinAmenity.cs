using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations.Schema;

namespace NileCapitalCruises.Core.Models
{
    [Table("tbl_CruiseBooking_Cabins_Amenities")]
    public class CabinAmenity : BaseEntity
    {
        public int? CabinId { get; set; }
        public int? AmenityId { get; set; }

        public virtual Cabin? Cabin { get; set; }
        public virtual Amenity? Amenity { get; set; }

        public bool? IsDeleted { get; set; } = false;
    }
}
