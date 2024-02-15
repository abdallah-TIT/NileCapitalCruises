
using Microsoft.AspNetCore.Http;

namespace NileCapitalCruises.Infrastructure.Helpers.ApiResponses
{
    public class SuccessLoginResponse : IResponse
    {
        public bool Status { get; set; }
        public int StatusCode { get; set; }

        public string AccessToken { get; set; }
        public string RefreshToken { get; set; }


        public static SuccessLoginResponse Success(string accessToken, string refreshToken, int statusCode)
        {
            return new SuccessLoginResponse { AccessToken = accessToken, RefreshToken = refreshToken, StatusCode = statusCode, Status = true };
        }

    }
}
