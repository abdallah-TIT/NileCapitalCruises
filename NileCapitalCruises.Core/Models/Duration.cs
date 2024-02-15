using Microsoft.EntityFrameworkCore;
using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;
using System.ComponentModel.Design;
using System.Xml.Linq;

namespace NileCapitalCruises.Core.Models
{
    [Table("tbl_Master_Durations")]
   
    public class Duration : BaseEntity
    {
        public Duration()
        {
            Itineraries = new HashSet<Itinerary>();
        }

        public int? Days { get; set; }
        public int? Nights { get; set; }
        public int? Code { get; set; }
        public bool? IsDeleted { get; set; } = false;
        public virtual ICollection<Itinerary> Itineraries { get; set; }
    }
}

