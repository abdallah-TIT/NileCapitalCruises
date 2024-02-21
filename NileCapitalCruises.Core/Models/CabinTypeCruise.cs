using NileCapitalCruises.Core.ApiModels;
using System.ComponentModel.DataAnnotations.Schema;

namespace NileCapitalCruises.Core.Models
{
    [Table("tbl_CruiseBooking_CabinTypes_Cruises")]
    public class CabinTypeCruise : BaseEntity
    {
        public CabinTypeCruise()
        {

            CabinTypeCruiseItineraryTypePeriodRates = new HashSet<CabinTypeCruiseItineraryTypePeriodRate>();
            CabinTypeCruiseOperationDates = new HashSet<CabinTypeCruiseOperationDate>();
            CabinTypeCruisePhotos = new HashSet<CabinTypeCruisePhoto>();
        }
        public int? CabinTypeId { get; set; }
        public virtual CabinType? CabinType { get; set; }


        public int? CruiseId { get; set; }
        public virtual Cruise? Cruise { get; set; }


        public int? NumberOfRooms { get; set; }
        public int? MaximumAdults { get; set; }
        public int? MaximumChildren { get; set; }
        public int? Occupancy { get; set; }

        public bool? IsDeleted { get; set; } = false;

        [InverseProperty("CabinTypeCruise")]
        public virtual ICollection<CabinTypeCruiseItineraryTypePeriodRate> CabinTypeCruiseItineraryTypePeriodRates { get; set; }

        [InverseProperty("CabinTypeCruise")]
        public virtual ICollection<CabinTypeCruiseOperationDate> CabinTypeCruiseOperationDates { get; set; }
        public virtual ICollection<CabinTypeCruisePhoto> CabinTypeCruisePhotos { get; set; }
    }
}
