using NileCapitalCruises.Core.Models;

namespace NileCapitalCruises.Infrastructure.Data.Specification.CMS.SeasonSpecification
{
    public class SeasonWithFiltersForCountSpecification : BaseSpecification<Season>
    {
        public SeasonWithFiltersForCountSpecification(PaginationSpecParams paginationSpecParams) : base(
            x => (string.IsNullOrEmpty(paginationSpecParams.Search) || x.SeasonNameSys.ToLower().Contains(paginationSpecParams.Search)) && x.IsDeleted == false
            )
        {
        }
    }

}
