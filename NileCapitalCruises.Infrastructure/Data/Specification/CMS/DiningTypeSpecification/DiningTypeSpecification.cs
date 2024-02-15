using AutoMapper;
using NileCapitalCruises.Core.Models;

namespace NileCapitalCruises.Infrastructure.Data.Specification.CMS.DiningTypeSpecification
{
    public class DiningTypeSpecification : BaseSpecification<DiningType>
    {
        private readonly IMapper _mapper;

        public DiningTypeSpecification(PaginationSpecParams paginationSpecParams) : base(
            x => (string.IsNullOrEmpty(paginationSpecParams.Search) || x.DiningTypeNameSys.ToLower().Contains(paginationSpecParams.Search)) && x.IsDeleted == false
            )
        {
            ApplyPaging(paginationSpecParams.PageSize * (paginationSpecParams.PageIndex - 1), paginationSpecParams.PageSize);
            AddInclude(x => x.DiningTypeContents.Where(c => c.Language.LanguageAbbreviation == paginationSpecParams.LanguageCode));

        }


        public DiningTypeSpecification(int diningTypeId) : base(x => x.Id == diningTypeId && x.IsDeleted == false)
        {

        }

        
    }
}
