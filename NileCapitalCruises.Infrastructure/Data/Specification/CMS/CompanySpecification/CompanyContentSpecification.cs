using NileCapitalCruises.Core.Models;
using NileCapitalCruises.Infrastructure.Data.Specification.CMS;

namespace NileCapitalCruises.Infrastructure.Data.Specification.CMS.CompanySpecification
{
    public class CompanyContentSpecification : BaseSpecification<CompanyContent>
    {
        public CompanyContentSpecification(int companyId, string languageCode) : base(
            x =>x.OriginalTableId == companyId &&
             (string.IsNullOrEmpty(languageCode) || x.Language.LanguageAbbreviation == languageCode)
            && x.IsDeleted == false
            )
            
        {
        }

        public CompanyContentSpecification(int companyId) : base(
            x => x.OriginalTableId == companyId &&
             x.IsDeleted == false
            )

        {
        }
    }
}
