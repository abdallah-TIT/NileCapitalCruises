using NileCapitalCruises.Core.Models;

namespace NileCapitalCruises.Infrastructure.Data.Specification.CMS.CruiseCategorySpecification
{
    public class CruiseCategoryContentSpecification : BaseSpecification<CruiseCategoryContent>
    {
        public CruiseCategoryContentSpecification(int cruiseCategoryId, string languageCode) : base(
            x => x.OriginalTableId == cruiseCategoryId &&
             (string.IsNullOrEmpty(languageCode) || x.Language.LanguageAbbreviation == languageCode)
            && x.IsDeleted == false
            )

        {
        }

        public CruiseCategoryContentSpecification(int cruiseCategoryId) : base(
            x => x.OriginalTableId == cruiseCategoryId &&
             x.IsDeleted == false
            )

        {
        }
    }
}
