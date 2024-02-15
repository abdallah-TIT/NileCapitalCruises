using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace NileCapitalCruises.Infrastructure.Dtos.CMS.RequestDtos.CompanyDtos
{
    public class CompanyRequestDto
    {
        [MaxLength(150)]
        public string? CompanyNameSys { get; set; }

        [EmailAddress(ErrorMessage = "Invalid email address.")]
        public string? Email { get; set; }

        

        [MaxLength(250)]
        public string? Logo { get; set; }

        public DateTime? StartDate { get; set; }
        public DateTime? SubscriptionStartDate { get; set; }
        public DateTime? SubscriptionEndDate { get; set; }
        [MaxLength(50)]
        public string? ContactPersonEmail { get; set; }

        [MaxLength(50)]
        public string? ContactPersonPhone { get; set; }

        public bool? Status { get; set; }

    }
}
