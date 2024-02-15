using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace NileCapitalCruises.Infrastructure.Dtos.CMS.RequestDtos.OperationDateDtos
{
    public class OperationDateRequestDto
    {
        [Required]
        public int? CruiseId { get; set; }

        [Required]
        public int? WeekDayId { get; set; }

        [Required]
        public int? ItineraryId { get; set; }


        [Required]
        public DateTime? Operation_Date { get; set; }

        [Required]
        public int? EmbarcationCityId { get; set; }
    }
}
