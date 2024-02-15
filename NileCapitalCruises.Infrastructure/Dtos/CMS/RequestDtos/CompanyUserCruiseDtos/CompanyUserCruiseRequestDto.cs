using NileCapitalCruises.Core.ApiModels;
using NileCapitalCruises.Core.Models;
using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace NileCapitalCruises.Infrastructure.Dtos.CMS.RequestDtos.CompanyUserCruiseDtos
{
    public class CompanyUserCruiseRequestDto
    {
        [Required]
        public int CompanyUserId { get; set; }

        [Required]
        public int CruiseId { get; set; }
    }
}
