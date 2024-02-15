using NileCapitalCruises.Infrastructure.Data.Specification.CMS;
using NileCapitalCruises.Infrastructure.Helpers.ApiResponses;

namespace NileCapitalCruises.Infrastructure.IServices.BookingEngine
{
    public interface BEIItineraryService
    {
        Task<IResponse> GetItineraries(int? itineraryTypeId, int? maximumAdults, int? maximumChildren, int? operationDay, int? operationMonth, int? operationYear, string languageCode = "en");

    }
}
