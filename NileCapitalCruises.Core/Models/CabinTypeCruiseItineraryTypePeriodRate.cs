﻿using NileCapitalCruises.Core.ApiModels;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;

namespace NileCapitalCruises.Core.Models
{
    [Table("tbl_CruiseBooking_CabinTypesCruises_ItineraryType_Periods_Rates")]
    public class CabinTypeCruiseItineraryTypePeriodRate : BaseEntity
    {



        public int? RateId { get; set; }

        [ForeignKey(nameof(RateId))]
        public virtual Rate? Rate { get; set; }




        public int? PeriodId { get; set; }
        [ForeignKey(nameof(PeriodId))]
        public virtual Period? Period { get; set; }


        public int? CabinTypeCruiseId { get; set; }
        [ForeignKey(nameof(CabinTypeCruiseId))]
        public virtual CabinTypeCruise? CabinTypeCruise { get; set; }




        public int? ItineraryTypeId { get; set; }
        [ForeignKey(nameof(ItineraryTypeId))]
        public virtual ItineraryType? ItineraryType { get; set; }





        public float? Price { get; set; }
       
        public bool? IsDeleted { get; set; } = false;
    }
}
