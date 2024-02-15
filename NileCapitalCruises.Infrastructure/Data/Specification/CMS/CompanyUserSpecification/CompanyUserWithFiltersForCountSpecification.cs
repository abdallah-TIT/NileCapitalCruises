using NileCapitalCruises.Core.ApiModels;
using NileCapitalCruises.Core.Models;

namespace NileCapitalCruises.Infrastructure.Data.Specification.CMS.CompanyUserSpecification
{
    public class CompanyUserWithFiltersForCountSpecification : BaseSpecification<CompanyUser>
    {
        public CompanyUserWithFiltersForCountSpecification(PaginationSpecParams paginationSpecParams, int companyId) : base(
           x => (string.IsNullOrEmpty(paginationSpecParams.Search) || x.CompanyUserName.ToLower().Contains(paginationSpecParams.Search)) && x.IsDeleted == false && x.CompanyId == companyId
           )
        {


        }
    }
}
