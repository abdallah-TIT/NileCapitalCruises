using System.ComponentModel.DataAnnotations;
namespace NileCapitalCruises.Infrastructure.Dtos.CMS.RequestDtos.AuthenticationDtos
{
    public class ChangePasswordRequestDto
    {
        [Required(ErrorMessage = "User Name is required")]
        public string UserName { get; set; } = null!;

        [Required(ErrorMessage = "Old Password is required")]
        public string OldPassword { get; set; } = null!;

        [Required(ErrorMessage = "New Password is required")]
        public string NewPassword { get; set; } = null!;
       
    }
}
