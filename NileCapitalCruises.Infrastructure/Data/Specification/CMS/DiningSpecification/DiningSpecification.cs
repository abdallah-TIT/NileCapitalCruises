using AutoMapper;
using NileCapitalCruises.Core.Models;
using NileCapitalCruises.Infrastructure.Dtos.CMS.ResponseDtos.CruiseDtos;

namespace NileCapitalCruises.Infrastructure.Data.Specification.CMS.DiningSpecification
{
    public class DiningSpecification : BaseSpecification<Dining>
    {
        private readonly IMapper _mapper;

        public DiningSpecification(PaginationSpecParams paginationSpecParams,int cruiseId) : base(
            x => (string.IsNullOrEmpty(paginationSpecParams.Search) || x.DiningNameSys.ToLower().Contains(paginationSpecParams.Search)) && x.IsDeleted == false && x.CruiseId == cruiseId
            )
        {
            ApplyPaging(paginationSpecParams.PageSize * (paginationSpecParams.PageIndex - 1), paginationSpecParams.PageSize);
            AddInclude(x => x.DiningContents.Where(c => c.Language.LanguageAbbreviation == paginationSpecParams.LanguageCode));

        }


        public DiningSpecification(int diningId) : base(x => x.Id == diningId && x.IsDeleted == false)
        {

        }

       
    }
}
