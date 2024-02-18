using NileCapitalCruises.Core.ApiModels;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;

namespace NileCapitalCruises.Core.Models
{
    [Table("tbl_CruiseBooking_Companies")]
    public class Company : BaseEntity
    {
        public Company()
        {
            CompanyContents = new HashSet<CompanyContent>();
            CompanyUsers = new HashSet<CompanyUser>();
            Cruises = new HashSet<Cruise>();
            Itineraries = new HashSet<Itinerary>();
            OperationDates = new HashSet<OperationDate>();
        }

        [MaxLength(150)]
        public string? CompanyNameSys { get; set; }
        [EmailAddress(ErrorMessage = "Invalid email address.")]
        public string? Email { get; set; }

        [MaxLength(150)]
        public string? CompanyUrl { get; set; }

        [MaxLength(250)]
        public string? Logo { get; set; } = "none.jpg";

        public DateTime? StartDate { get; set; } = DateTime.Now;
        public DateTime? SubscriptionStartDate { get; set; }
        public DateTime? SubscriptionEndDate { get; set; }
        [MaxLength(50)]
        public string? ContactPersonEmail { get; set; } = "example@example.com";

        [MaxLength(50)]
        public string? ContactPersonPhone { get; set; } = "011";
        public bool? IsDeleted { get; set; } = false;

        public bool? Status { get; set; } = false;
        public virtual ICollection<CompanyContent> CompanyContents { get; set; }
        public virtual ICollection<CompanyUser> CompanyUsers { get; set; }
        public virtual ICollection<Cruise> Cruises { get; set; }
        public virtual ICollection<Itinerary> Itineraries { get; set; }
        public virtual ICollection<OperationDate> OperationDates { get; set; }
    }
}
