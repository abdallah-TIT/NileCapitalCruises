using Microsoft.EntityFrameworkCore;
using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;
using System.Xml.Linq;

namespace NileCapitalCruises.Core.Models
{
    [Table("tbl_Master_WeekDays_Contents")]
    [Index(nameof(LanguageId), Name = "IX_tbl_Master_WeekDays_Contents_LanguageId")]
    [Index(nameof(OriginalTableId), Name = "IX_tbl_Master_WeekDays_Contents_WeekDayId")]
    public class WeekDayContent : BaseEntity
    {
        [MaxLength(20)]
        
        public string? WeekDayName { get; set; }

        [MaxLength(10)]
        public string? WeekDayNameShort { get; set; }


        public int? LanguageId { get; set; }

        [ForeignKey("WeekDay")]
        [Column("WeekDayId")]
        public int? OriginalTableId { get; set; }


        public virtual Language? Language { get; set; }

        public virtual WeekDay? WeekDay { get; set; }

        public bool? IsDeleted { get; set; } = false;
    }
}
