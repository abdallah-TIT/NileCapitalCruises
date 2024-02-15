using NileCapitalCruises.Core.Models;
using Microsoft.AspNetCore.Identity;
using System.ComponentModel.DataAnnotations.Schema;


namespace NileCapitalCruises.Core.ApiModels
{
    public class ApplicationUser : IdentityUser<int>
    {
        public string? RefreshToken { get; set; }
        public DateTime? RefreshTokenExpirationDate { get; set; }

        public virtual CompanyUser? CompanyUser { get; set; }
    }
}
