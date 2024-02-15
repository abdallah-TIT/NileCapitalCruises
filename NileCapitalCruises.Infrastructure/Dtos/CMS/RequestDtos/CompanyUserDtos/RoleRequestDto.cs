using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace NileCapitalCruises.Infrastructure.Dtos.CMS.RequestDtos.CompanyUserDtos
{
    public class RoleRequestDto
    {
        [Required(ErrorMessage = "CompanyId is required")]
        public int CompanyId { get; set; }
        [Required(ErrorMessage = "CompanyUserId is required")]
        public int CompanyUserId { get; set; }

        [Required(ErrorMessage = "RoleName is required")]
        public string RoleName { get; set; }



    }
}
