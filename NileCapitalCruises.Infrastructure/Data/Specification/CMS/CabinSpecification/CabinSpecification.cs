using NileCapitalCruises.Core.Models;
using NileCapitalCruises.Infrastructure.Data.Specification.CMS;

namespace NileCapitalCruises.Infrastructure.Data.Specification.CMS.CabinSpecification
{
    public class CabinSpecification : BaseSpecification<Cabin>
    {


        public CabinSpecification(PaginationSpecParams paginationSpecParams,int cruiseId) : base(
            x => (string.IsNullOrEmpty(paginationSpecParams.Search) || x.CabinNameSys.ToLower().Contains(paginationSpecParams.Search)) && (x.IsDeleted == false) && x.CruiseId == cruiseId
            )
        {
            ApplyPaging(paginationSpecParams.PageSize * (paginationSpecParams.PageIndex - 1), paginationSpecParams.PageSize);
            AddInclude(x => x.CabinContents.Where(c => c.Language.LanguageAbbreviation == paginationSpecParams.LanguageCode));

        }


        public CabinSpecification(int cabinId) : base(x => x.Id == cabinId && x.IsDeleted == false)
        {

        }
    }
}
