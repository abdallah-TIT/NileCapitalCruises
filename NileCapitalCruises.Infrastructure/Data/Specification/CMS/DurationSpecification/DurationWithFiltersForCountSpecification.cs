using NileCapitalCruises.Core.Models;

namespace NileCapitalCruises.Infrastructure.Data.Specification.CMS.DurationSpecification
{
    public class DurationWithFiltersForCountSpecification : BaseSpecification<Duration>
    {
        public DurationWithFiltersForCountSpecification(PaginationSpecParams paginationSpecParams) : base(
            x =>  x.IsDeleted == false
            )
        {
        }
    }

}
