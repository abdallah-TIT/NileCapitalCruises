using NileCapitalCruises.Core.Models;

namespace NileCapitalCruises.Infrastructure.Data.Specification.CMS.OperationDateSpecification
{
    public class CMSOperationDateWithFiltersForCountSpecification : BaseSpecification<OperationDate>
    {
        public CMSOperationDateWithFiltersForCountSpecification(PaginationSpecParams paginationSpecParams, int itineraryId) : base(
            x => x.ItineraryId == itineraryId && x.IsDeleted == false
            )
        {
        }
    }

}
