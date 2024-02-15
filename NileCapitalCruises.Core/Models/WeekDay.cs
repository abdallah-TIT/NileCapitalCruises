using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;

namespace NileCapitalCruises.Core.Models
{
    [Table("tbl_Master_WeekDays")]
    public class WeekDay : BaseEntity
    {
        public WeekDay()
        {
            WeekDayContents = new HashSet<WeekDayContent>();
           
        }

        [MaxLength(20)]
        
        public int DayCode { get; set; }
        [MaxLength(150)]
        public string? WeekDayNameSys { get; set; }


        [MaxLength(150)]
        public string? WeekDayUrl { get; set; }
        public bool? IsDeleted { get; set; } = false;

        public virtual ICollection<WeekDayContent> WeekDayContents { get; set; }

    }
}
