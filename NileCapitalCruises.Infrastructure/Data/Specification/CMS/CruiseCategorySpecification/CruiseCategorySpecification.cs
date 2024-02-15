using NileCapitalCruises.Core.Models;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace NileCapitalCruises.Infrastructure.Data.Specification.CMS.CruiseCategorySpecification
{
    public class CruiseCategorySpecification : BaseSpecification<CruiseCategory>
    {
        public CruiseCategorySpecification(PaginationSpecParams paginationSpecParams) : base(
           x => (string.IsNullOrEmpty(paginationSpecParams.Search) || x.CruiseCategoryNameSys.ToLower().Contains(paginationSpecParams.Search)) && (x.IsDeleted == false)
           )
        {
            ApplyPaging(paginationSpecParams.PageSize * (paginationSpecParams.PageIndex - 1), paginationSpecParams.PageSize);
            AddInclude(x => x.CruiseCategoryContents.Where(c => c.Language.LanguageAbbreviation == paginationSpecParams.LanguageCode));

        }


        public CruiseCategorySpecification(int cruiseCategoryId) : base(x => x.Id == cruiseCategoryId && x.IsDeleted == false)
        {

        }
    }
}
