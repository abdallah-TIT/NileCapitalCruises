using NileCapitalCruises.Core.ApiModels;
using Microsoft.AspNetCore.Http;
using System.IdentityModel.Tokens.Jwt;
using System.Security.Claims;

namespace NileCapitalCruises.Infrastructure.IServices
{
    public interface ITokenService
    {
        Task<TokenApiModel> JWTGenerator(ApplicationUser user);
        JwtSecurityToken GenerateAccessToken(IEnumerable<Claim> claims);
        string GenerateRefreshToken();
        ClaimsPrincipal GetPrincipalFromExpiredToken(string token);

        Dictionary<string, string> GetClaimsFromJwt(HttpContext httpContext);

        string GetAccessTokenFromCookie(HttpContext httpContext);
    }
}
