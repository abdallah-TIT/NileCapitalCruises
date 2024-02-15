using Microsoft.EntityFrameworkCore;
using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;
using System.Xml.Linq;

namespace NileCapitalCruises.Core.Models
{
    [Table("tbl_CruiseBooking_Seasons")]
    [Index(nameof(CruiseId), Name = "IX_tbl_CruiseBooking_Seasons_CruiseId")]
    public class Season : BaseEntity
    {
        public Season()
        {
            SeasonContents = new HashSet<SeasonContent>();
            Periods = new HashSet<Period>();
        }

        public int? CruiseId { get; set; }
        public virtual Cruise? Cruise { get; set; }
        [MaxLength(150)]
        public string? SeasonNameSys { get; set; }

        public DateTime? StartDate { get; set; }
        public DateTime? EndDate { get; set; }

        public bool? IsDeleted { get; set; } = false;
        public virtual ICollection<SeasonContent> SeasonContents { get; set; }
        public virtual ICollection<Period> Periods { get; set; }
    }
}
