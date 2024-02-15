using NileCapitalCruises.Core.Models;
using NileCapitalCruises.Infrastructure.Data.Specification.CMS;
using System.ComponentModel.Design;

namespace NileCapitalCruises.Infrastructure.Data.Specification.CMS.CruiseSpecification
{
    public class CruisesWithFiltersForCountSpecification : BaseSpecification<Cruise>
    {
        public CruisesWithFiltersForCountSpecification(PaginationSpecParams paginationSpecParams, int companyId) : base(
            x => (string.IsNullOrEmpty(paginationSpecParams.Search) || x.CruiseNameSys.ToLower().Contains(paginationSpecParams.Search)) && x.IsDeleted == false && x.CompanyId == companyId)
        {
        }
    }
}
