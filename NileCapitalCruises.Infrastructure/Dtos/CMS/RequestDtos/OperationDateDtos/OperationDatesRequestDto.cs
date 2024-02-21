using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace NileCapitalCruises.Infrastructure.Dtos.CMS.RequestDtos.OperationDateDtos
{
    public class OperationDatesRequestDto
    {
        [Required]
        public int? CruiseId { get; set; }

        [Required]
        public int? WeekDayId { get; set; }

        [Required]
        public int? ItineraryId { get; set; }

        [Required]
        public string StartDate { get; set; }
        [Required]
        public string EndDate { get; set; }

        public int? EmbarcationCityId { get; set; }


        [Required]
        public Dictionary<int, int?> CabinAllotments { get; set; }
    }
}
