using AutoMapper;
using NileCapitalCruises.Core.Models;
using NileCapitalCruises.Infrastructure.Data.Specification.CMS;
using NileCapitalCruises.Infrastructure.Dtos.CMS.ResponseDtos.CruiseDtos;

namespace NileCapitalCruises.Infrastructure.Data.Specification.CMS.CompanySpecification
{
    public class CompanySpecification : BaseSpecification<Company>
    {
        private readonly IMapper _mapper;

        public CompanySpecification(PaginationSpecParams paginationSpecParams) : base(
            x => (string.IsNullOrEmpty(paginationSpecParams.Search) || x.CompanyNameSys.ToLower().Contains(paginationSpecParams.Search))&&(x.IsDeleted == false)
            )
        {
            ApplyPaging(paginationSpecParams.PageSize * (paginationSpecParams.PageIndex - 1), paginationSpecParams.PageSize);
            AddInclude(x => x.CompanyContents.Where(c => c.Language.LanguageAbbreviation == paginationSpecParams.LanguageCode));
            
        }


        public CompanySpecification(int companyId) : base(x => x.Id == companyId && x.IsDeleted == false)
        {
            
        }

        //public CruiseSpecification(string cruiseUrl) : base(x => x.CruiseUrl == cruiseUrl)
        //{
        //}
    }
}
