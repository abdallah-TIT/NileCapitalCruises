using Microsoft.AspNetCore.Http;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace NileCapitalCruises.Infrastructure.Helpers.ApiResponses
{
    public class SuccessListResponse<T> : IResponse
    {
        public SuccessListResponse(bool status, int statusCode, IReadOnlyList<T> data)
        {
            Status = status;
            StatusCode = statusCode;
            Data = data;
        }

        public bool Status { get; set; }

        public int StatusCode { get; set; }

        public IReadOnlyList<T> Data { get; set; }

        public static SuccessListResponse<T> Success(bool status, int statusCode, IReadOnlyList<T> data)
        {
            return new SuccessListResponse<T>(status, statusCode, data);
        }
    }
}
