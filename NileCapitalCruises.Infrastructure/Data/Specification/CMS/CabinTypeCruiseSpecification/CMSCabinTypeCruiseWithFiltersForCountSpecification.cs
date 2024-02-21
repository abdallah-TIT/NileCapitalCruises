using NileCapitalCruises.Core.Models;

namespace NileCapitalCruises.Infrastructure.Data.Specification.CMS.CabinTypeCruiseSpecification
{
    public class CMSCabinTypeCruiseWithFiltersForCountSpecification : BaseSpecification<CabinTypeCruise>
    {
        public CMSCabinTypeCruiseWithFiltersForCountSpecification(PaginationSpecParams paginationSpecParams, int cruiseId) : base(
            x => x.CruiseId == cruiseId && x.IsDeleted == false
            )
        {
        }
    }

}
