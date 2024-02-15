using NileCapitalCruises.Core.Models;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace NileCapitalCruises.Infrastructure.Data.Specification.CMS.CabinTypeSpecification
{
    public class CabinTypeSpecification : BaseSpecification<CabinType>
    {
        public CabinTypeSpecification(PaginationSpecParams paginationSpecParams) : base(
            x => (string.IsNullOrEmpty(paginationSpecParams.Search) || x.CabinTypeNameSys.ToLower().Contains(paginationSpecParams.Search)) && (x.IsDeleted == false)
            )
        {
            ApplyPaging(paginationSpecParams.PageSize * (paginationSpecParams.PageIndex - 1), paginationSpecParams.PageSize);
            AddInclude(x => x.CabinTypeContents.Where(c => c.Language.LanguageAbbreviation == paginationSpecParams.LanguageCode));

        }


        public CabinTypeSpecification(int cabinTypeId) : base(x => x.Id == cabinTypeId && x.IsDeleted == false)
        {

        }
    }
}
