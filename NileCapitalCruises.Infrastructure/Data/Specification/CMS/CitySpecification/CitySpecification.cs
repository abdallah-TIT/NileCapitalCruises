using AutoMapper;
using NileCapitalCruises.Core.Models;
using NileCapitalCruises.Infrastructure.Dtos.CMS.ResponseDtos.CruiseDtos;

namespace NileCapitalCruises.Infrastructure.Data.Specification.CMS.CitySpecification
{
    public class CitySpecification : BaseSpecification<City>
    {
        private readonly IMapper _mapper;

        public CitySpecification(PaginationSpecParams paginationSpecParams) : base(
            x => (string.IsNullOrEmpty(paginationSpecParams.Search) || x.CityNameSys.ToLower().Contains(paginationSpecParams.Search)) && x.IsDeleted == false
            )
        {
            ApplyPaging(paginationSpecParams.PageSize * (paginationSpecParams.PageIndex - 1), paginationSpecParams.PageSize);
            AddInclude(x => x.CityContents.Where(c => c.Language.LanguageAbbreviation == paginationSpecParams.LanguageCode));

        }


        public CitySpecification(int companyId) : base(x => x.Id == companyId && x.IsDeleted == false)
        {

        }

        //public CruiseSpecification(string cruiseUrl) : base(x => x.CruiseUrl == cruiseUrl)
        //{
        //}
    }
}
