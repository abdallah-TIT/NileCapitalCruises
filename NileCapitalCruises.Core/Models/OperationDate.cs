using Microsoft.EntityFrameworkCore;
using Microsoft.VisualBasic;
using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;
using System.Xml.Linq;

namespace NileCapitalCruises.Core.Models
{
    [Table("tbl_CruiseBooking_OperationDates")]
    [Index(nameof(CruiseId), Name = "IX_tbl_CruiseBooking_OperationDates_CruiseId")]
    [Index(nameof(WeekDayId), Name = "IX_tbl_CruiseBooking_OperationDates_WeekDayId")]
    [Index(nameof(ItineraryId), Name = "IX_tbl_CruiseBooking_OperationDates_ItineraryId")]
    public class OperationDate : BaseEntity
    {
        public OperationDate()
        {
            CabinTypeCruiseOperationDates = new HashSet<CabinTypeCruiseOperationDate>();
        }

        // just for searching, i don't want any relation between cruise and OperationDate because the Itinerary table already has CruiseId
        public int? CruiseId { get; set; }
        public int? CompanyId { get; set; }
        public int? WeekDayId { get; set; }
        public int? ItineraryId { get; set; }

        [MaxLength(150)]
        public string? OperationDateUrl { get; set; }

        private DateTime? operation_Date;
        public DateTime? Operation_Date
        {
            get { return operation_Date; }
            set
            {
                operation_Date = value;

                // Set OperationDay, OperationMonth, and OperationYear based on Operation_Date
                if (value != null)
                {
                    OperationDay = value.Value.Day;
                    OperationMonth = value.Value.Month;
                    OperationYear = value.Value.Year;
                }
                else
                {
                    OperationDay = null;
                    OperationMonth = null;
                    OperationYear = null;
                }
            }
        }
        public int? OperationDay { get; set; }
        public int? OperationMonth { get; set; }
        public int? OperationYear { get; set; }
        public virtual Company? Company { get; set; }
        public virtual Cruise? Cruise { get; set; }
        public virtual WeekDay? WeekDay { get; set; }
        public virtual Itinerary? Itinerary { get; set; }

        [ForeignKey("City")]
        public int? EmbarcationCityId { get; set; }
        public virtual City? City { get; set; }


        public bool? OperationDateStatus { get; set; } = true;

        public bool? IsDeleted { get; set; } = false;

        [InverseProperty("OperationDate")]
        public virtual ICollection<CabinTypeCruiseOperationDate> CabinTypeCruiseOperationDates { get; set; }

    }


}
