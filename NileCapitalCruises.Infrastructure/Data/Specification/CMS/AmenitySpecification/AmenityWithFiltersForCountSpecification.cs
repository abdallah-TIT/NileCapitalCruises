using NileCapitalCruises.Core.Models;

namespace NileCapitalCruises.Infrastructure.Data.Specification.CMS.AmenitySpecification
{
    public class AmenityWithFiltersForCountSpecification : BaseSpecification<Amenity>
    {
        public AmenityWithFiltersForCountSpecification(PaginationSpecParams paginationSpecParams) : base(
            x => (string.IsNullOrEmpty(paginationSpecParams.Search) || x.AmenityNameSys.ToLower().Contains(paginationSpecParams.Search)) && x.IsDeleted == false
            )
        {
        }
    }
}
