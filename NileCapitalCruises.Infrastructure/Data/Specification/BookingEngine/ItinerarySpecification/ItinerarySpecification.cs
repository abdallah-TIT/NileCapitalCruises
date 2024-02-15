using AutoMapper;
using NileCapitalCruises.Core.Models;
using NileCapitalCruises.Infrastructure.Data.Specification.CMS;

namespace NileCapitalCruises.Infrastructure.Data.Specification.BookingEngine.ItinerarySpecification
{
    public class ItinerarySpecification : BaseSpecification<Itinerary>
    {
        private readonly IMapper _mapper;

        public ItinerarySpecification(int? itineraryTypeId,int? maximumAdults,int? maximumChildren, int? operationDay, int? operationMonth, int? operationYear,string languageCode) : base(
            x => x.IsDeleted == false
            && x.OperationDates.Any(op => op.OperationDay == operationDay && op.OperationMonth == operationMonth && op.OperationYear == operationYear)
            && x.ItineraryTypeId == itineraryTypeId
            && x.Cruise.CabinTypeCruises.Any(cc => cc.Occupancy >= maximumAdults + maximumChildren && cc.MaximumAdults >= maximumAdults && cc.MaximumChildren >= maximumChildren)
            )
        {

            AddInclude(x => x.ItineraryContents.Where(c => c.Language.LanguageAbbreviation == languageCode));
            AddInclude(x => x.Cruise.CruiseContents.Where(c => c.Language.LanguageAbbreviation == languageCode));
            AddInclude(x => x.Cruise.CruisePhotos);

        }





    }
}
