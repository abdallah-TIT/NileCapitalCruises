using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace NileCapitalCruises.Infrastructure.Dtos.CMS.RequestDtos.CompanyDtos
{
    public class CompanyContentRequestDto
    {
        [MaxLength(150)]
        public string? CompanyName { get; set; }

        [MaxLength(250)]
        public string? CompanyAdress { get; set; }

        public bool? ContentLangStatus { get; set; }

        [MaxLength(50)]
        public string? ContactPersonName { get; set; }

    }
}
