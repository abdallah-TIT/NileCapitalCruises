using NileCapitalCruises.Core.Models;

namespace NileCapitalCruises.Infrastructure.Data.Specification.CMS.CitySpecification
{
    public class CityWithFiltersForCountSpecification : BaseSpecification<City>
    {
        public CityWithFiltersForCountSpecification(PaginationSpecParams paginationSpecParams) : base(
            x => (string.IsNullOrEmpty(paginationSpecParams.Search) || x.CityNameSys.ToLower().Contains(paginationSpecParams.Search)) && x.IsDeleted == false
            )
        {
        }
    }

}
