using Microsoft.AspNetCore.Hosting.Server;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace NileCapitalCruises.Infrastructure.Helpers.ApiResponses
{
    public static class StatusCodeAndErrorsMessagesStandard
    {
        // StatusCodes

        // Start Success Codes
        public const int OK = 200;
        public const int Created = 201;
        public const int NoContent = 204;

        // Start Errors Codes
        public const int BadRequest = 400;
        public const int Unauthorized = 401;
        public const int Forbidden = 403;
        public const int NotFound = 404;
        public const int InternalServerError = 500;


        // ErrorsMessages

        public static string NoItem = "Item Not Found";
        public static string NoRole = "Role Not Found";
        public static string ForbiddenAccess = "You try to access somthing that you don't have permision";
        public static string NoHaveRole = "User does not have the role";
        public static string NoItems = "Items Not Found";
        public static string InternalServerErrorMessage = "Internal Server Error";

        public static string ItemNotCreated = "Item Not Created";
        public static string ItemNotUpdated = "Item Not Updated";
        public static string ItemNotDeleted = "Item Not Deleted";

        public static string ItemAlreadyExist = "Item Already Exist";
        public static string InvalidLogin = "Invalid, Please Check your user name and password";


        public static string InvalidCruiseId = "Invalid CruiseId, Please Check CruiseId and try again";
        public static string InvalidCompanyUserId = "Invalid CompanyUserId, Please Check CompanyUserId and try again";
        public static string UserNotAssignToCruise = "User doesn't already assign to Cruise, Do you mean another user or cruise";
        public static string UserNotAssignToAnyCruise = "User doesn't assign to any Cruise, Do you mean another user?";
        public static string CruiseNoHaveAnyUserToMangeIt = "This Cruise doesn't have any User to mange it, Do you mean another cruise?";

        public static string NoPhoto = "This item doesn't have any photo";

    }
}
