using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;

namespace NileCapitalCruises.Core.Models
{
    [Table("tbl_Master_CabinStatuses")]
    public class CabinStatus : BaseEntity
    {
        public CabinStatus()
        {
            CabinStatusContents = new HashSet<CabinStatusContent>();
            //CabinOperationDates = new HashSet<CabinOperationDate>();
        }
        [MaxLength(150)]
        public string? CabinStatusNameSys { get; set; }

        public bool? IsDeleted { get; set; } = false;
        public virtual ICollection<CabinStatusContent> CabinStatusContents { get; set; }
        //public virtual ICollection<CabinOperationDate> CabinOperationDates { get; set; }
    }
}
