using NileCapitalCruises.Core.ApiModels;
using System.ComponentModel.DataAnnotations.Schema;

namespace NileCapitalCruises.Core.Models
{
    [Table("tbl_CruiseBooking_CabinTypesCruises_OperationDates")]
    public class CabinTypeCruiseOperationDate : BaseEntity
    {
        
        public int OperationDateId { get; set; }
        public virtual OperationDate? OperationDate { get; set; }


        

        public int CabinTypeCruiseId { get; set; }
        public virtual CabinTypeCruise? CabinTypeCruise { get; set; }

        public int? Allotment { get; set; }


        //public int CabinId { get; set; }
        //public virtual Cabin? Cabin { get; set; }

        //public int CabinStatusId { get; set; }
        //public virtual CabinStatus? CabinStatus { get; set; }


        public bool? IsDeleted { get; set; } = false;
    }
}
