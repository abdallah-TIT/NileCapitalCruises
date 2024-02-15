
using Microsoft.AspNetCore.Http;

namespace NileCapitalCruises.Infrastructure.Helpers.ApiResponses
{
    public class SuccessSingleResponse<T> :IResponse
    {
        public bool Status { get; set; }
        public int StatusCode { get; set; }

        public T Data { get; set; }


        public static SuccessSingleResponse<T> Success(T data,int statusCode)
        {
            return new SuccessSingleResponse<T> { StatusCode = statusCode, Status = true, Data = data };
        }

    }
}
