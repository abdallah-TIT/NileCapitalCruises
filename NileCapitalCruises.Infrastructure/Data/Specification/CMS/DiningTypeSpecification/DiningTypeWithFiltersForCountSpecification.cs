using NileCapitalCruises.Core.Models;

namespace NileCapitalCruises.Infrastructure.Data.Specification.CMS.DiningTypeSpecification
{
    public class DiningTypeWithFiltersForCountSpecification : BaseSpecification<DiningType>
    {
        public DiningTypeWithFiltersForCountSpecification(PaginationSpecParams paginationSpecParams) : base(
            x => (string.IsNullOrEmpty(paginationSpecParams.Search) || x.DiningTypeNameSys.ToLower().Contains(paginationSpecParams.Search)) && x.IsDeleted == false
            )
        {
        }
    }
}
