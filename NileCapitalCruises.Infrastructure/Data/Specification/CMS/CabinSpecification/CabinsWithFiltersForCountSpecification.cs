using NileCapitalCruises.Core.Models;
using System.ComponentModel.Design;

namespace NileCapitalCruises.Infrastructure.Data.Specification.CMS.CabinSpecification
{
    public class CabinsWithFiltersForCountSpecification : BaseSpecification<Cabin>
    {
        public CabinsWithFiltersForCountSpecification(PaginationSpecParams paginationSpecParams, int cruiseId) : base(
            x => (string.IsNullOrEmpty(paginationSpecParams.Search) || x.CabinNameSys.ToLower().Contains(paginationSpecParams.Search)) && x.IsDeleted == false && x.CruiseId == cruiseId)
        {
        }
    }
}
