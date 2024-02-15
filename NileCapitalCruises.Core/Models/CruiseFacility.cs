using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations.Schema;

namespace NileCapitalCruises.Core.Models
{
    [Table("tbl_CruiseBooking_Cruises_Facilties")]
    public class CruiseFacility : BaseEntity
    {
        public int? FacilityId { get; set; }
        public int? CruiseId { get; set; }
       

        public virtual Cruise? Cruise { get; set; }

       
        public virtual Facility? Facility { get; set; }

        public bool? IsDeleted { get; set; } = false;
    }
}
