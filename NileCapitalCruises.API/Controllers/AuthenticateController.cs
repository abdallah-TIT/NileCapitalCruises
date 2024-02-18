
using NileCapitalCruises.Core.ApiModels;
using NileCapitalCruises.Core.Authentication;
using NileCapitalCruises.Infrastructure.Dtos.CMS.RequestDtos.AuthenticationDtos;
using NileCapitalCruises.Infrastructure.Dtos.CMS.ResponseDtos.CruiseDtos;
using NileCapitalCruises.Infrastructure.Helpers.ApiResponses;
using NileCapitalCruises.Infrastructure.IServices;
using NileCapitalCruises.Infrastructure.Services;
using Microsoft.AspNetCore.Identity;
using Microsoft.AspNetCore.Mvc;
using System.IdentityModel.Tokens.Jwt;
using System.Security.Claims;

namespace NileCapitalCruises.API.Controllers
{
    public class AuthenticateController : BaseApiController
    {
        private readonly UserManager<ApplicationUser> userManager;
        private readonly RoleManager<IdentityRole<int>> roleManager;
        private readonly ITokenService _tokenService;
        private readonly IConfiguration _configuration;
        private readonly IAuthinticateService _authinticateService;

        public AuthenticateController(
            UserManager<ApplicationUser> userManager,
            RoleManager<IdentityRole<int>> roleManager,
            IConfiguration configuration,
            ITokenService tokenService,
            IAuthinticateService authinticateService)
        {
            this.userManager = userManager;
            this.roleManager = roleManager;
            _tokenService = tokenService;
            _configuration = configuration;
            _authinticateService = authinticateService;
        }


        [HttpPost]
        [Route("login")]
        [ProducesResponseType(typeof(SuccessLoginResponse), StatusCodeAndErrorsMessagesStandard.OK)]
        [ProducesResponseType(typeof(FailResponse), StatusCodeAndErrorsMessagesStandard.Unauthorized)] // Unauthorized
        public async Task<ActionResult<IResponse>> Login([FromBody] LoginRequestDto model)
        {
            var item = await _authinticateService.Login(model);
            if (item.StatusCode == StatusCodeAndErrorsMessagesStandard.Unauthorized)
                return Unauthorized(item);
            if (item is SuccessLoginResponse loginResponse)
            {
                HttpContext.Response.Cookies.Append("accessToken", loginResponse.AccessToken,
                   new CookieOptions()
                   {
                       Expires = DateTime.Now.AddDays(Convert.ToInt32(_configuration["JWT:AccessTokenExpirationDays"]))
                                   .ToLocalTime(),
                       Secure = true,
                       HttpOnly = true,
                       SameSite = SameSiteMode.None
                   });
                HttpContext.Response.Cookies.Append("refereshToken", loginResponse.RefreshToken,
                    new CookieOptions()
                    {
                        Expires = DateTime.Now.AddDays(Convert.ToInt32(_configuration["JWT:RefreshTokenExpirationDays"]))
                                    .ToLocalTime(),
                        Secure = true,
                        HttpOnly = true,
                        SameSite = SameSiteMode.None

                    });
            }

            return Ok(item);


        }

        //[HttpPost]
        //[Route("register")]

        //public async Task<IActionResult> Register([FromBody] RegisterModel model)
        //{
        //    return Ok(await _authinticateService.Register(model));
        //}

        [HttpPost]
        [Route("register-admin")]
        [ProducesResponseType(typeof(BaseSuccessResponse), StatusCodeAndErrorsMessagesStandard.Created)]
        [ProducesResponseType(typeof(FailResponse), StatusCodeAndErrorsMessagesStandard.BadRequest)]
        [ProducesResponseType(typeof(FailResponse), StatusCodeAndErrorsMessagesStandard.Unauthorized)] // Unauthorized
        [ProducesResponseType(typeof(FailResponse), StatusCodeAndErrorsMessagesStandard.Forbidden)] // Forbidden
        public async Task<ActionResult<IResponse>> RegisterAdmin([FromBody] RegisterRequestDto model)
        {
            if (!ModelState.IsValid)
            {
                var errors = ModelState.Values.SelectMany(y => y.Errors).Select(e => e.ErrorMessage).ToList();
                var response = new FailResponse { ErrorMessages = errors, StatusCode = StatusCodeAndErrorsMessagesStandard.BadRequest, Status = false };
                return BadRequest(response);
            }
            var item = await _authinticateService.RegisterAdmin(model);
            if (item.StatusCode == StatusCodeAndErrorsMessagesStandard.BadRequest)
                return BadRequest(item);

            return Ok(item);

        }



        [HttpPost]
        [Route("changePassword")]
        [ProducesResponseType(typeof(SuccessLoginResponse), StatusCodeAndErrorsMessagesStandard.OK)]
        [ProducesResponseType(typeof(FailResponse), StatusCodeAndErrorsMessagesStandard.Unauthorized)] // Unauthorized
        public async Task<ActionResult<IResponse>> ChangePassword([FromBody] ChangePasswordRequestDto model)
        {
            var item = await _authinticateService.ChangePassword(model);
            if (item.StatusCode == StatusCodeAndErrorsMessagesStandard.Unauthorized)
                return Unauthorized(item);

            return Ok(item);
        }
    }
}
