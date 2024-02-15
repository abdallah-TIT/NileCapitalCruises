using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;

namespace NileCapitalCruises.Core.Models
{
    [Table("tbl_CruiseBooking_Dinings")]
    public class Dining : BaseEntity
    {
        public Dining()
        {
            DiningPhotos = new HashSet<DiningPhoto>();
            DiningContents = new HashSet<DiningContent>();
        }

        public int? CruiseId { get; set; }
        [MaxLength(150)]
        public string? DiningNameSys { get; set; }
        [MaxLength(150)]
        public string? DiningHours { get; set; }
        
        public bool? IsDeleted { get; set; } = false;
        [MaxLength(250)]
        public string? DressCode { get; set; }
        [MaxLength(250)]
        public string? DiningCuisine { get; set; }
        [MaxLength(250)]
        public string? DiningOpenFor { get; set; }
        [MaxLength(250)]
        public string? DiningMenu { get; set; }
        [MaxLength(250)]
        public string? DiningFolderName { get; set; }
        [MaxLength(250)]
        public string? DiningPhoto { get; set; }
        public bool? Status { get; set; }
        public int? DiningTypeId { get; set; }
        [MaxLength(250)]
        public string? DiningUrl { get; set; }

        public virtual Cruise? Cruise { get; set; }
        public virtual DiningType? DiningType { get; set; }
        public virtual ICollection<DiningPhoto> DiningPhotos { get; set; }

        public virtual ICollection<DiningContent> DiningContents { get; set; }
    }
}
