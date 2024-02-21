using AutoMapper;
using NileCapitalCruises.Core.Models;
using NileCapitalCruises.Infrastructure.Dtos.CMS.ResponseDtos.CruiseDtos;

namespace NileCapitalCruises.Infrastructure.Data.Specification.CMS.SeasonSpecification
{
    public class SeasonSpecification : BaseSpecification<Season>
    {
        private readonly IMapper _mapper;

        public SeasonSpecification(PaginationSpecParams paginationSpecParams) : base(
            x => (string.IsNullOrEmpty(paginationSpecParams.Search) || x.SeasonNameSys.ToLower().Contains(paginationSpecParams.Search)) && x.IsDeleted == false
            )
        {
            ApplyPaging(paginationSpecParams.PageSize * (paginationSpecParams.PageIndex - 1), paginationSpecParams.PageSize);
            AddInclude(x => x.SeasonContents.Where(c => c.Language.LanguageAbbreviation == paginationSpecParams.LanguageCode));

        }


        public SeasonSpecification(int seasonId) : base(x => x.Id == seasonId && x.IsDeleted == false)
        {

        }

        //public CruiseSpecification(string cruiseUrl) : base(x => x.CruiseUrl == cruiseUrl)
        //{
        //}
    }
}
