using NileCapitalCruises.Core.Models;

namespace NileCapitalCruises.Infrastructure.Data.Specification.CMS.WeekDaySpecification
{
    public class WeekDayWithFiltersForCountSpecification : BaseSpecification<WeekDay>
    {
        public WeekDayWithFiltersForCountSpecification(PaginationSpecParams paginationSpecParams) : base(
            x =>  x.IsDeleted == false
            )
        {
        }
    }

}
