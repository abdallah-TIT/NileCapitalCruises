using NileCapitalCruises.Core.Models;

namespace NileCapitalCruises.Infrastructure.Data.Specification.CMS.DiningSpecification
{
    public class DiningWithFiltersForCountSpecification : BaseSpecification<Dining>
    {
        public DiningWithFiltersForCountSpecification(PaginationSpecParams paginationSpecParams,int cruiseId) : base(
            x => (string.IsNullOrEmpty(paginationSpecParams.Search) || x.DiningNameSys.ToLower().Contains(paginationSpecParams.Search)) && x.IsDeleted == false && x.CruiseId == cruiseId
            )
        {
        }
    }
}
