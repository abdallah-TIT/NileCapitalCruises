 using NileCapitalCruises.Core.ApiModels;
using NileCapitalCruises.Core.Authentication;
using NileCapitalCruises.Infrastructure.Dtos.CMS.RequestDtos.AuthenticationDtos;
using NileCapitalCruises.Infrastructure.Helpers.ApiResponses;
using NileCapitalCruises.Infrastructure.IServices;
using Microsoft.AspNetCore.Http;
using Microsoft.AspNetCore.Identity;
using Microsoft.EntityFrameworkCore;
using Microsoft.Extensions.Configuration;
using System;
using System.Collections.Generic;
using System.IdentityModel.Tokens.Jwt;
using System.Linq;
using System.Security.Claims;
using System.Text;
using System.Threading.Tasks;

namespace NileCapitalCruises.Infrastructure.Services
{
    public class AuthinticateService : IAuthinticateService
    {
        private readonly UserManager<ApplicationUser> userManager;
        private readonly RoleManager<IdentityRole<int>> roleManager;
        private readonly SignInManager<ApplicationUser> _signInManager;
        private readonly ITokenService _tokenService;
        private readonly IConfiguration _configuration;

        public AuthinticateService(
            UserManager<ApplicationUser> userManager,
            RoleManager<IdentityRole<int>> roleManager,
            SignInManager<ApplicationUser> signInManager,
            IConfiguration configuration,
            ITokenService tokenService)
        {
            this.userManager = userManager;
            this.roleManager = roleManager;
            _tokenService = tokenService;
            _configuration = configuration;
            _signInManager = signInManager;
        }
        public async Task<IResponse> Login(LoginRequestDto model)
        {
            
            var user = await userManager.Users.Include(u => u.CompanyUser).FirstOrDefaultAsync(u => u.UserName == model.Username); ;
            if (user != null && await userManager.CheckPasswordAsync(user, model.Password))
            {
                var userRoles = await userManager.GetRolesAsync(user);

                var authClaims = new List<Claim>
                {
                    new Claim(ClaimTypes.Name, user.UserName),
                    new Claim(JwtRegisteredClaimNames.Jti, Guid.NewGuid().ToString()),
                };

                foreach (var userRole in userRoles)
                {
                    authClaims.Add(new Claim(ClaimTypes.Role, userRole));
                }

                

                // Add CompanyId claim if user has CompanyUser
                if (user.CompanyUser != null)
                {
                    authClaims.Add(new Claim("CompanyId", user.CompanyUser.CompanyId.ToString()));
                    authClaims.Add(new Claim("CompanyUserId", user.CompanyUser.Id.ToString()));
                }

                var accessToken = _tokenService.GenerateAccessToken(authClaims);
                var refreshToken = _tokenService.GenerateRefreshToken();

                user.RefreshToken = refreshToken;
                user.RefreshTokenExpirationDate = DateTime.Now.AddDays(Convert.ToInt32(_configuration["JWT:RefreshTokenExpirationDays"])).ToLocalTime();


                var encryptedToken = new JwtSecurityTokenHandler().WriteToken(accessToken);

                await userManager.UpdateAsync(user);
                //


                return SuccessLoginResponse.Success(encryptedToken, refreshToken,StatusCodeAndErrorsMessagesStandard.OK);
                
            }
            return FailResponse.Error(new List<string> { StatusCodeAndErrorsMessagesStandard.InvalidLogin }, StatusCodeAndErrorsMessagesStandard.Unauthorized);
        }

        //public async Task<RegisterResponse> Register(RegisterRequestDto model)
        //{
        //    var userExists = await userManager.FindByNameAsync(model.Username);
        //    if (userExists != null)
        //        return new RegisterResponse { Status = "Error", Message = "User already exists!" };

        //    ApplicationUser user = new ApplicationUser()
        //    {
        //        Email = model.Email,
        //        SecurityStamp = Guid.NewGuid().ToString(),
        //        UserName = model.Username
        //    };
        //    var result = await userManager.CreateAsync(user, model.Password);
        //    if (!result.Succeeded)
        //        return new RegisterResponse { Status = "Error", Message = "User creation failed! Please check user details and try again." };

        //    return new RegisterResponse { Status = "Success", Message = "User created successfully!" };
        //}

        public async Task<IResponse> RegisterAdmin(RegisterRequestDto model)
        {
            var userExists = await userManager.FindByNameAsync(model.Username);
            if (userExists != null)
                return FailResponse.Error(new List<string> { StatusCodeAndErrorsMessagesStandard.ItemAlreadyExist }, StatusCodeAndErrorsMessagesStandard.BadRequest);

            ApplicationUser user = new ApplicationUser()
            {
                Email = model.Email,
                SecurityStamp = Guid.NewGuid().ToString(),
                UserName = model.Username
            };
            var result = await userManager.CreateAsync(user, model.Password);
            if (!result.Succeeded)
                return FailResponse.Error(result.Errors.Select(error => error.Description).ToList(), StatusCodeAndErrorsMessagesStandard.BadRequest);

            if (!await roleManager.RoleExistsAsync(UserRoles.SystemAdmin))
                await roleManager.CreateAsync(new IdentityRole<int>(UserRoles.SystemAdmin));
            if (!await roleManager.RoleExistsAsync(UserRoles.SystemUser))
                await roleManager.CreateAsync(new IdentityRole<int>(UserRoles.SystemUser));

            if (await roleManager.RoleExistsAsync(UserRoles.SystemAdmin))
            {
                await userManager.AddToRoleAsync(user, UserRoles.SystemAdmin);
            }
            return BaseSuccessResponse.Success(StatusCodeAndErrorsMessagesStandard.Created);
        }

        public async Task<IResponse> ChangePassword(ChangePasswordRequestDto model)
        {
            var user = await this.userManager.FindByNameAsync(model.UserName);
            if (user == null)
            {
               return FailResponse.Error(new List<string> { StatusCodeAndErrorsMessagesStandard.InvalidLogin }, StatusCodeAndErrorsMessagesStandard.Unauthorized);
            }
            var signInResult = await _signInManager.CheckPasswordSignInAsync(user, model.OldPassword, false);
            if (!signInResult.Succeeded)
            {
                return FailResponse.Error(new List<string> { StatusCodeAndErrorsMessagesStandard.InvalidLogin }, StatusCodeAndErrorsMessagesStandard.Unauthorized);
            }
            var result = await this.userManager.ChangePasswordAsync(user, model.OldPassword, model.NewPassword);

            if (result.Succeeded)
            {
                return BaseSuccessResponse.Success(StatusCodeAndErrorsMessagesStandard.NoContent);
            }

            return FailResponse.Error(result.Errors.Select(error => error.Description).ToList(), StatusCodeAndErrorsMessagesStandard.BadRequest);

        }

    }
}
