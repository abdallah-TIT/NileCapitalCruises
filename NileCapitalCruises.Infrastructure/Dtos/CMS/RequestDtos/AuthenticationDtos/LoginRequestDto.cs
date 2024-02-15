using System.ComponentModel.DataAnnotations;
namespace NileCapitalCruises.Infrastructure.Dtos.CMS.RequestDtos.AuthenticationDtos
{
    public class LoginRequestDto
    {
        [Required(ErrorMessage = "User Name is required")]
        public string Username { get; set; } = null!;

        [Required(ErrorMessage = "Password is required")]
        public string Password { get; set; } = null!;
    }
}
