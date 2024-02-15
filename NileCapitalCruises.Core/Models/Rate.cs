using Microsoft.EntityFrameworkCore;
using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;
using System.Xml.Linq;

namespace NileCapitalCruises.Core.Models
{
    [Table("tbl_CruiseBooking_Rates")]
    [Index(nameof(CruiseId), Name = "IX_tbl_CruiseBooking_Rates_CruiseId")]
    
    public class Rate : BaseEntity
    {
        public Rate()
        {
            RateContents = new HashSet<RateContent>();
            CabinTypeCruisePeriodRates = new HashSet<CabinTypeCruisePeriodRate>();
        }


       

        [MaxLength(150)]
        public string? RateNameSys { get; set; }
       

        public int? CruiseId { get; set; }
        public virtual Cruise? Cruise { get; set; }



        public float? Value { get; set; }
        public float? Percentage { get; set; }
        public bool? IsPercentage { get; set; }
        public bool? IsPositiveSign { get; set; }



        public int? ParentRateId { get; set; }

        [ForeignKey("ParentRateId")]
        public virtual Rate? ParentRate { get; set; }


        public bool? IsDeleted { get; set; } = false;
        public virtual ICollection<RateContent> RateContents { get; set; }


        [InverseProperty("Rate")]
        public virtual ICollection<CabinTypeCruisePeriodRate> CabinTypeCruisePeriodRates { get; set; }
    }
}
