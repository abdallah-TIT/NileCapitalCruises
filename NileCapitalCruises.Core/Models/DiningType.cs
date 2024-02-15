using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;

namespace NileCapitalCruises.Core.Models
{
    [Table("tbl_Master_Dinings_Types")]
    public class DiningType : BaseEntity
    {
        public DiningType()
        {
            DiningTypeContents = new HashSet<DiningTypeContent>();
           
        }

        [MaxLength(150)]
        public string? DiningTypeNameSys { get; set; }

        [MaxLength(250)]
        public string? DiningTypeUrl { get; set; }
        public bool? IsDeleted { get; set; } = false;
        public virtual ICollection<DiningTypeContent> DiningTypeContents { get; set; }
    }
}
