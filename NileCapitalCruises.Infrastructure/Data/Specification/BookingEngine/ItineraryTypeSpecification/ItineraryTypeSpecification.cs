using AutoMapper;
using NileCapitalCruises.Core.Models;
using NileCapitalCruises.Infrastructure.Data.Specification.CMS;

namespace NileCapitalCruises.Infrastructure.Data.Specification.BookingEngine.ItineraryTypeSpecification
{
    public class ItineraryTypeSpecification : BaseSpecification<ItineraryType>
    {
        private readonly IMapper _mapper;

      

        public ItineraryTypeSpecification(string languageCode) : base(
            x => x.IsDeleted == false
            )
        {
            
            AddInclude(x => x.ItineraryTypeContents.Where(c => c.Language.LanguageAbbreviation == languageCode));
            //AddInclude(x => x.Itineraries.SelectMany(it => it.OperationDates.Where(op => op.Itinerary.ItineraryTypeId == x.Id)));
            AddInclude(x => x.Itineraries);
            //AddThenInclude(it => it.Itineraries.Se);

        }

        



    }
}
