using NileCapitalCruises.Core.Models;
using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace NileCapitalCruises.Infrastructure.Dtos.CMS.RequestDtos.CruiseDtos
{
    public class CruiseContentRequestDto
    {
       
        public bool? ContentLangStatus { get; set; }


        [MaxLength(150)]
        public string? CruiseName { get; set; }

        [MaxLength(150)]
        public string? CruiseDetails { get; set; }
        [MaxLength(150)]
        public string? CruiseIntro { get; set; }
        [MaxLength(150)]
        public string? CruiseOverview { get; set; }
        [MaxLength(150)]
        public string? CruiseDining { get; set; }
        [MaxLength(150)]
        public string? CruiseAccommodation { get; set; }
        [MaxLength(150)]
        public string? CruiseActivities { get; set; }
        [MaxLength(150)]
        public string? CruiseNote { get; set; }
        [MaxLength(150)]
        public string? CruiseTechnicalSpecifications { get; set; }

       

    }
}
