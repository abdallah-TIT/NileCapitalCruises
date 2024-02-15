using NileCapitalCruises.Core.ApiModels;
using System.ComponentModel.DataAnnotations.Schema;

namespace NileCapitalCruises.Core.Models
{
    [Table("tbl_CruiseBooking_CompanyUsers_Cruises")]
    public class CompanyUserCruise : BaseEntity
    {
        
        public int? CompanyUserId { get; set; }

        [ForeignKey(nameof(CompanyUserId))]
        public virtual CompanyUser? CompanyUser { get; set; }


        public int? CruiseId { get; set; }
        public virtual Cruise? Cruise { get; set; }




        public bool? IsDeleted { get; set; } = false;
    }
}
