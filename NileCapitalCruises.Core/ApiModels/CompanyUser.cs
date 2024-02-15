using NileCapitalCruises.Core.Models;
using Microsoft.AspNetCore.Identity;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;


namespace NileCapitalCruises.Core.ApiModels
{
    [Table("tbl_CruiseBooking_Companies_Users")]
    public class CompanyUser : BaseEntity
    {
        public CompanyUser()
        {
            CompanyUserCruises = new HashSet<CompanyUserCruise>();
        }

        public bool? IsDeleted { get; set; } = false;
        public int? CompanyId { get; set; }


        [MaxLength(150)]
        public string? CompanyUserUrl { get; set; }

        [MaxLength(70)]
        public string? CompanyUserName { get; set; }

        [MaxLength(150)]
        public string? Photo { get; set; }

        [MaxLength(100)]
        public string? Email { get; set; }

        [MaxLength(50)]
        public string? Phone { get; set; }

        [MaxLength(100)]
        public string? Address { get; set; }
        public virtual Company? Company { get; set; }

        [ForeignKey("User")]
        public int? UserId { get; set; }
        public virtual ApplicationUser? User { get; set; }


        [InverseProperty("CompanyUser")]
        public virtual ICollection<CompanyUserCruise> CompanyUserCruises { get; set; }


    }
}
