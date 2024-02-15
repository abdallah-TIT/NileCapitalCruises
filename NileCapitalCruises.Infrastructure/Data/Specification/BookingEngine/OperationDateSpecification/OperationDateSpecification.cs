using AutoMapper;
using NileCapitalCruises.Core.Models;

namespace NileCapitalCruises.Infrastructure.Data.Specification.BookingEngine.OperationDateSpecification
{
    public class OperationDateSpecification : BaseSpecification<OperationDate>
    {
        private readonly IMapper _mapper;

        public OperationDateSpecification(int itineraryTypeId) : base(
            x =>  x.IsDeleted == false && x.Itinerary.ItineraryTypeId == itineraryTypeId
            )
        {
           
            AddInclude(x => x.WeekDay);

        }

        public OperationDateSpecification() : base(
            x => x.IsDeleted == false
            )
        {

            AddInclude(x => x.WeekDay);

        }

    }
}
