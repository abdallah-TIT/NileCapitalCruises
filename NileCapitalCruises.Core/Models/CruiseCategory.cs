using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;

namespace NileCapitalCruises.Core.Models
{
    [Table("tbl_CruiseBooking_Cruises_Categories")]
    public class CruiseCategory : BaseEntity
    {
        public CruiseCategory()
        {
            CruiseCategoryContents = new HashSet<CruiseCategoryContent>();
            Cruises = new HashSet<Cruise>();
        }
        [MaxLength(150)]
        public string? CruiseCategoryNameSys { get; set; }
        [MaxLength(250)]
        public string? ClassIcon { get; set; } = "Empty String please change it";

        [MaxLength(250)]
        public string? CruiseCategoryUrl { get; set; }
        public bool? IsDeleted { get; set; } = false;
        public virtual ICollection<CruiseCategoryContent> CruiseCategoryContents { get; set; }
        public virtual ICollection<Cruise> Cruises { get; set; }
    }
}
