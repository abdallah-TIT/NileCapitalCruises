using AutoMapper;
using NileCapitalCruises.Core.Models;
using NileCapitalCruises.Infrastructure.Data.Specification.CMS;

namespace NileCapitalCruises.Infrastructure.Data.Specification.BookingEngine.CabinTypeCruiseSpecification
{
    public class CabinTypeCruiseSpecification : BaseSpecification<CabinTypeCruise>
    {
        private readonly IMapper _mapper;

        public CabinTypeCruiseSpecification(int cruiseId, int maximumAdults, int maximumChildren, int operationDay, int operationMonth, int operationYear, string languageCode) : base(
            x => x.IsDeleted == false

            && x.CabinTypeCruiseOperationDates.Any(op => op.OperationDate.OperationDay == operationDay && op.OperationDate.OperationMonth == operationMonth && op.OperationDate.OperationYear == operationYear && op.Allotment > 0)
            && x.CruiseId == cruiseId
            && x.Occupancy >= maximumAdults + maximumChildren 
            && x.MaximumAdults >= maximumAdults 
            && x.MaximumChildren >= maximumChildren
            )
        {

            AddInclude(x => x.CabinType.CabinTypeContents.Where(c => c.Language.LanguageAbbreviation == languageCode));
            AddInclude(x => x.CabinTypeCruisePhotos);
            AddInclude(x => x.CabinTypeCruiseOperationDates);

        }





    }
}
