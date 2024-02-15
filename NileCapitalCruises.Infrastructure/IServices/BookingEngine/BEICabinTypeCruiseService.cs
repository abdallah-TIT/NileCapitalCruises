using NileCapitalCruises.Infrastructure.Data.Specification.CMS;
using NileCapitalCruises.Infrastructure.Helpers.ApiResponses;

namespace NileCapitalCruises.Infrastructure.IServices.BookingEngine
{
    public interface BEICabinTypeCruiseService
    {
        //Task<IResponse> GetCabinTypeCruises(int? cruiseId, int? maximumAdults, int? maximumChildren, int? operationDay, int? operationMonth, int? operationYear, string languageCode = "en");
        Task<IResponse> GetCabinTypeCruises(string operationDate, int maximumAdults, int maximumChildren, string languageCode = "en");
    }
}
