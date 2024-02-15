using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;

namespace NileCapitalCruises.Core.Models
{
    [Table("tbl_Master_Facilties")]
    public class Facility : BaseEntity
    {
        

        public Facility()
        {
            CruiseFacilities = new HashSet<CruiseFacility>();
            FacilityContents = new HashSet<FacilityContent>();
        }

       
        [MaxLength(150)]
        public string? FacilityNameSys { get; set; }
        public bool? IsDeleted { get; set; } = false;


        [MaxLength(250)]
        public string? FacilityUrl { get; set; }


        [InverseProperty("Facility")]
        public virtual ICollection<CruiseFacility> CruiseFacilities { get; set; }

        public virtual ICollection<FacilityContent> FacilityContents { get; set; }

    }
}
