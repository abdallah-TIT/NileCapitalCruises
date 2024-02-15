using NileCapitalCruises.Infrastructure.Data.Specification.CMS;
using NileCapitalCruises.Infrastructure.Helpers.ApiResponses;

namespace NileCapitalCruises.Infrastructure.IServices.BookingEngine
{
    public interface BEIItineraryTypeService
    {
        Task<IResponse> GetItineraryTypes(string languageCode = "en");

    }
}
