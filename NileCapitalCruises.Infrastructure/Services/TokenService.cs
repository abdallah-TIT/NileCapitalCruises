using NileCapitalCruises.Core.ApiModels;
using NileCapitalCruises.Infrastructure.IServices;
using Microsoft.AspNetCore.Http;
using Microsoft.AspNetCore.Identity;
using Microsoft.Extensions.Configuration;
using Microsoft.IdentityModel.Tokens;
using System.IdentityModel.Tokens.Jwt;
using System.Net.Http;
using System.Security.Claims;
using System.Security.Cryptography;
using System.Text;

namespace NileCapitalCruises.Infrastructure.Services
{
    public class TokenService : ITokenService
    {
        private readonly IConfiguration _configuration;
        private readonly UserManager<ApplicationUser> _userManager;
        public TokenService(IConfiguration configuration, UserManager<ApplicationUser> userManager)
        {
            _configuration = configuration;
            _userManager = userManager;
        }
        public JwtSecurityToken GenerateAccessToken(IEnumerable<Claim> claims)
        {
            var secretKey = new SymmetricSecurityKey(Encoding.UTF8.GetBytes(_configuration["JWT:Secret"]));
            var signinCredentials = new SigningCredentials(secretKey, SecurityAlgorithms.HmacSha256);
            var token = new JwtSecurityToken(
                issuer: _configuration["JWT:ValidIssuer"],
                audience: _configuration["JWT:ValidAudience"],
                claims: claims,
                expires: DateTime.Now.AddMinutes(Convert.ToInt32(_configuration["JWT:AccessTokenExpirationMinutes"])).ToLocalTime(),
                signingCredentials: signinCredentials
            );
            //var tokenString = new JwtSecurityTokenHandler().WriteToken(tokeOptions);
            return token;
        }

        public string GenerateRefreshToken()
        {
            var randomNumber = new byte[32];
            using (var rng = RandomNumberGenerator.Create())
            {
                rng.GetBytes(randomNumber);
                return Convert.ToBase64String(randomNumber);
            }
        }

        public ClaimsPrincipal GetPrincipalFromExpiredToken(string token)
        {
            var tokenValidationParameters = new TokenValidationParameters
            {
                ValidateAudience = false, //you might want to validate the audience and issuer depending on your use case
                ValidateIssuer = false,
                ValidateIssuerSigningKey = true,
                IssuerSigningKey = new SymmetricSecurityKey(Encoding.UTF8.GetBytes(_configuration["JWT:Secret"])),
                ValidateLifetime = false //here we are saying that we don't care about the token's expiration date
            };
            var tokenHandler = new JwtSecurityTokenHandler();
            SecurityToken securityToken;
            var principal = tokenHandler.ValidateToken(token, tokenValidationParameters, out securityToken);
            var jwtSecurityToken = securityToken as JwtSecurityToken;
            if (jwtSecurityToken == null || !jwtSecurityToken.Header.Alg.Equals(SecurityAlgorithms.HmacSha256, StringComparison.InvariantCultureIgnoreCase))
                throw new SecurityTokenException("Invalid token");
            return principal;
        }

        public async Task<TokenApiModel> JWTGenerator(ApplicationUser user)
        {
            var userRoles = await _userManager.GetRolesAsync(user);
            var authClaims = new List<Claim>
            {
                //new Claim("userId", user.Id),
                new Claim(ClaimTypes.Name, user.UserName),
                new Claim(JwtRegisteredClaimNames.Jti, Guid.NewGuid().ToString()),
            };

            if (user.CompanyUser != null)
            {
                authClaims.Add(new Claim("CompanyId", user.CompanyUser.CompanyId.ToString()));
            }

            foreach (var userRole in userRoles)
            {
                authClaims.Add(new Claim(ClaimTypes.Role, userRole));
            }



            var accessToken = GenerateAccessToken(authClaims);
            var refreshToken = GenerateRefreshToken();

            var encryptedToken = new JwtSecurityTokenHandler().WriteToken(accessToken);

            user.RefreshToken = refreshToken;
            user.RefreshTokenExpirationDate = DateTime.Now.AddMinutes(Convert.ToInt32(_configuration["JWT:RefreshTokenExpirationDays"])).ToLocalTime();
            await _userManager.UpdateAsync(user);

            return new TokenApiModel() { AccessToken = encryptedToken, RefreshToken = refreshToken };
        }


        public Dictionary<string, string> GetClaimsFromJwt(HttpContext httpContext)
        {
            var jwtToken = GetAccessTokenFromCookie(httpContext);
            if(jwtToken == null)
            {
                jwtToken = httpContext.Items["accessToken"] as string;
            }
            var handler = new JwtSecurityTokenHandler();
            var jsonToken = handler.ReadToken(jwtToken) as JwtSecurityToken;

            var claims = new Dictionary<string, string>();

            if (jsonToken != null)
            {
                foreach (var claim in jsonToken.Claims)
                {
                    claims.Add(claim.Type, claim.Value);
                }
            }

            return claims;
        }

        public string GetAccessTokenFromCookie(HttpContext httpContext)
        {
           
            string accessToken = httpContext.Request.Cookies["accessToken"];

            return accessToken;
        }

    }
}
