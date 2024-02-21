using NileCapitalCruises.Infrastructure.Data.Specification.CMS;
using NileCapitalCruises.Infrastructure.Helpers.ApiResponses;

namespace NileCapitalCruises.Infrastructure.IServices.BookingEngine
{
    public interface BEIItineraryService
    {
        Task<IResponse> GetItineraries(int? itineraryTypeId, string operationDate, int maximumAdults, int maximumChildren, string languageCode = "en");
    }
}
