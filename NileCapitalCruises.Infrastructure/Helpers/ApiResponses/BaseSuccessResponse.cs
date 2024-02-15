﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace NileCapitalCruises.Infrastructure.Helpers.ApiResponses
{
    public class BaseSuccessResponse : IResponse
    {
        public bool Status { get; set; }
        public int StatusCode { get; set; }

        

        public static BaseSuccessResponse Success( int statusCode)
        {
            return new BaseSuccessResponse { StatusCode = statusCode, Status = true};
        }

    }
}
