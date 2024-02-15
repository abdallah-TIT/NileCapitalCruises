using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace NileCapitalCruises.Infrastructure.Dtos.CMS.RequestDtos.DurationDtos
{
    public class DurationRequestDto
    {
        [Required]
        public int? Days { get; set; }

        [Required]
        public int? Nights { get; set; }

        [Required]
        public int? Code { get; set; }

    }
}
