using System.Text.Json.Serialization;

namespace NileCapitalCruises.Infrastructure.Dtos.CMS.RequestDtos.CompanyUserDtos
{
    public class CompanyUserResponseDto
    {
        public int? Id { get; set; }
        public int? CompanyId { get; set; }

        [JsonIgnore]
        public int? UserId { get; set; }

        public string? CompanyUserUrl { get; set; }
        public string UserName { get; set; } 
        public string? CompanyUserName { get; set; }

        public string Email { get; set; }
        public string? Photo { get; set; }

        public string? Phone { get; set; }

        public string? Address { get; set; }

        public IList<string> Roles { get; set; }


    }
}
