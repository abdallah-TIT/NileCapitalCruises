using NileCapitalCruises.Infrastructure.IServices;
using NileCapitalCruises.Infrastructure.Data;
using Microsoft.IdentityModel.Tokens;
using System.IdentityModel.Tokens.Jwt;
using NileCapitalCruises.Infrastructure;
using Microsoft.EntityFrameworkCore;
using Microsoft.AspNetCore.Http;

namespace NileCapitalCruises.API.Middleware
{
    public class AccessTokenMiddleware
    {
        private readonly RequestDelegate _next;
        private readonly IConfiguration _configuration;

        public AccessTokenMiddleware(RequestDelegate next, IConfiguration configuration)
        {
            _next = next;
            _configuration = configuration;
        }

        public async Task Invoke(HttpContext context)
        {
            var refereshToken = context.Request.Cookies["refereshToken"];
            var accessToken = context.Request.Cookies["accessToken"];
            var dbContext = context.RequestServices.GetRequiredService<NileCapitalCruisesWSDBContext>();
            var tokenService = context.RequestServices.GetRequiredService<ITokenService>();
            var user = dbContext.Users.Include(u => u.CompanyUser).FirstOrDefault(u => u.RefreshToken == refereshToken);
            if (user != null)
            {
                if (IsTokenExpired(accessToken))
                {
                    if (!string.IsNullOrEmpty(user.RefreshToken) || user.RefreshTokenExpirationDate < DateTime.Now)
                    {
                        var tokens = await tokenService.JWTGenerator(user);

                        context.Request.Headers["Authorization"] = $"Bearer {tokens.AccessToken}";
                        context.Request.Headers["refreshToken"] = tokens.RefreshToken;

                        if(tokens.AccessToken != null)
                        {
                            context.Items["accessToken"] = tokens.AccessToken;
                            context.Response.Cookies.Append("accessToken", tokens.AccessToken,
                            new CookieOptions()
                            {
                                Expires = DateTime.Now.AddMinutes(Convert.ToInt32(_configuration["JWT:AccessTokenExpirationMinutes"]))
                                            .ToLocalTime(),
                                Secure = true,
                                HttpOnly = true,
                                SameSite = SameSiteMode.None
                            });
                        }
                        
                        if(tokens.RefreshToken != null)
                        {
                            context.Response.Cookies.Append("refereshToken", tokens.RefreshToken,
                            new CookieOptions()
                            {
                                Expires = DateTime.Now.AddDays(Convert.ToInt32(_configuration["JWT:RefreshTokenExpirationDays"]))
                                            .ToLocalTime(),
                                Secure = true,
                                HttpOnly = true,
                                SameSite = SameSiteMode.None

                            });
                        }
                    }
                }

            }
            await _next(context);

        }

        private bool IsTokenExpired(string token)
        {
            var tokenHandler = new JwtSecurityTokenHandler();
            try
            {
                if (token == null)
                    return true;
                var jsonToken = tokenHandler.ReadToken(token) as JwtSecurityToken;


                if (jsonToken == null)
                    return true; // Token is not valid, consider it as expired

                var now = DateTime.UtcNow;

                // Check if the token's expiration date is in the past
                return jsonToken.ValidTo <= now;
            }
            catch (SecurityTokenExpiredException)
            {
                return true; // Token is expired
            }
            catch (Exception)
            {
                return true; // Token is not valid, consider it as expired
            }
        }

    }


    public static class AccessTokenMiddlewareExtensions
    {
        public static IApplicationBuilder UseAccessTokenMiddleware(this IApplicationBuilder builder)
        {
            return builder.UseMiddleware<AccessTokenMiddleware>();
        }
    }
}
