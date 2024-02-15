using NileCapitalCruises.Core.ApiModels;
using NileCapitalCruises.Infrastructure.Dtos.CMS.RequestDtos.AuthenticationDtos;
using NileCapitalCruises.Infrastructure.Helpers.ApiResponses;
namespace NileCapitalCruises.Infrastructure.IServices
{
    public interface IAuthinticateService
    {
        Task<IResponse> Login(LoginRequestDto model);
        //Task<RegisterResponse> Register(RegisterRequestDto model);
        Task<IResponse> RegisterAdmin(RegisterRequestDto model);
        Task<IResponse> ChangePassword(ChangePasswordRequestDto model);
    }
}
