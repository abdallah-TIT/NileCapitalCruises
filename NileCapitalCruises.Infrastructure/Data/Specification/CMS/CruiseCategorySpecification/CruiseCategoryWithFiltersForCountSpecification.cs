using NileCapitalCruises.Core.Models;

namespace NileCapitalCruises.Infrastructure.Data.Specification.CMS.CruiseCategorySpecification
{
    public class CruiseCategoryWithFiltersForCountSpecification : BaseSpecification<CruiseCategory>
    {
        public CruiseCategoryWithFiltersForCountSpecification(PaginationSpecParams paginationSpecParams) : base(
            x => (string.IsNullOrEmpty(paginationSpecParams.Search) || x.CruiseCategoryNameSys.ToLower().Contains(paginationSpecParams.Search)) && x.IsDeleted == false
            )
        {
        }
    }
}
