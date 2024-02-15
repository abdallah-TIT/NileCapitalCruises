using NileCapitalCruises.Core.Models;

namespace NileCapitalCruises.Infrastructure.Data.Specification.CMS.CabinTypeSpecification
{
    

    public class CabinTypeWithFiltersForCountSpecification : BaseSpecification<CabinType>
    {
        public CabinTypeWithFiltersForCountSpecification(PaginationSpecParams paginationSpecParams) : base(
            x => (string.IsNullOrEmpty(paginationSpecParams.Search) || x.CabinTypeNameSys.ToLower().Contains(paginationSpecParams.Search)) && (x.IsDeleted == false)
            )
        {
        }
    }
}
