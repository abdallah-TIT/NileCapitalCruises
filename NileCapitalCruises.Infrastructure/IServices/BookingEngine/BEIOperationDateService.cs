using NileCapitalCruises.Infrastructure.Data.Specification.CMS;
using NileCapitalCruises.Infrastructure.Helpers.ApiResponses;

namespace NileCapitalCruises.Infrastructure.IServices.BookingEngine
{
    public interface BEIOperationDateService
    {
        Task<IResponse>  GetOperationDates(int itineraryTypeId);

    }
}
