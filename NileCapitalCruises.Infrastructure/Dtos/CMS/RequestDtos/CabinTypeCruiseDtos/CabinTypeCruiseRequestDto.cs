using NileCapitalCruises.Core.Models;
using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace NileCapitalCruises.Infrastructure.Dtos.CMS.RequestDtos.CabinTypeCruiseDtos
{
    public class CabinTypeCruiseRequestDto
    {
        [Required]
        public int? CabinTypeId { get; set; }

        [Required]
        public int? CruiseId { get; set; }


        [Required]
        public int? NumberOfRooms { get; set; }

        [Required]
        public int? Occupancy { get; set; }

    }
}
