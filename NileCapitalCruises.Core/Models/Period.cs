using Microsoft.EntityFrameworkCore;
using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;
using System.ComponentModel.Design;
using System.Xml.Linq;

namespace NileCapitalCruises.Core.Models
{
    [Table("tbl_CruiseBooking_Periods")]
    [Index(nameof(SeasonId), Name = "IX_tbl_CruiseBooking_Periods_SeasonId")]
    [Index(nameof(CruiseId), Name = "IX_tbl_CruiseBooking_Periods_CruiseId")]
    public class Period : BaseEntity
    {
        public Period()
        {

            PeriodContents = new HashSet<PeriodContent>();
            CabinTypeCruisePeriodRates = new HashSet<CabinTypeCruisePeriodRate>();

        }

        
        

        [MaxLength(150)]
        public string? PeriodNameSys { get; set; }

        public DateTime? StartDate { get; set; }
        public DateTime? EndDate { get; set; }

        public int? CruiseId { get; set; }
        public virtual Cruise? Cruise { get; set; }
        public int? SeasonId { get; set; }
        public virtual Season? Season { get; set; }

        
        public virtual ICollection<PeriodContent> PeriodContents { get; set; }

        [InverseProperty("Period")]
        public virtual ICollection<CabinTypeCruisePeriodRate> CabinTypeCruisePeriodRates { get; set; }
        public bool? IsDeleted { get; set; } = false;
    }
}
