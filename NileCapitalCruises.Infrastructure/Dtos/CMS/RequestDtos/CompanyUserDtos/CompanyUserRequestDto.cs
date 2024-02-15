using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace NileCapitalCruises.Infrastructure.Dtos.CMS.RequestDtos.CompanyUserDtos
{
    public class CompanyUserRequestDto
    {
        [Required]
        public int CompanyId { get; set; }

        [MaxLength(70)]
        [Required(ErrorMessage = "Name is required")]
        public string CompanyUserName { get; set; } = null!;

        [Required(ErrorMessage = "User Name is required")]
        public string Username { get; set; } = null!;

        [EmailAddress]
        [Required(ErrorMessage = "Email is required")]
        public string Email { get; set; } = null!;

        [Required(ErrorMessage = "Password is required")]
        public string Password { get; set; } = null!;
        
        [MaxLength(150)]
        public string? Photo { get; set; }

        [MaxLength(50)]
        public string? Phone { get; set; }

        [MaxLength(100)]
        public string? Address { get; set; }

    }
}
