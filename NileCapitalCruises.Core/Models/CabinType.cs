using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;

namespace NileCapitalCruises.Core.Models
{
    [Table("tbl_Master_Cabins_Types")]
    public class CabinType : BaseEntity
    {
        public CabinType()
        {
            CabinTypeContents = new HashSet<CabinTypeContent>();
            CabinTypeCruises = new HashSet<CabinTypeCruise>();

        }

        [MaxLength(250)]
        public string? CabinTypeUrl { get; set; }
        [MaxLength(150)]
        public string? CabinTypeNameSys { get; set; }

        public virtual ICollection<CabinTypeContent> CabinTypeContents { get; set; }

        public bool? IsDeleted { get; set; } = false;

        


        [InverseProperty("CabinType")]
        public virtual ICollection<CabinTypeCruise> CabinTypeCruises { get; set; }
    }
}
