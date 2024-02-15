using Microsoft.EntityFrameworkCore;
using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;
using System.Xml.Linq;

namespace NileCapitalCruises.Core.Models
{
    [Table("tbl_CruiseBooking_Cabins_Photos")]

    [Index(nameof(CabinId), Name = "IX_tbl_CruiseBooking_Cabins_Photos_CabinId")]
    public class CabinPhoto : BaseEntity
    {
        public int? CabinId { get; set; }
        [MaxLength(250)]
        public string? PhotoFile { get; set; }
        public int? PhotoPosition { get; set; }
        public bool? PhotoStatus { get; set; }
        public int? PhotoHieght { get; set; }
        public int? PhotoWidth { get; set; }

        public virtual Cabin? Cabin { get; set; }


        public bool? IsDeleted { get; set; } = false;
    }
}
