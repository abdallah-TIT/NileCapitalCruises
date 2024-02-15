using NileCapitalCruises.Core.Models;

namespace NileCapitalCruises.Infrastructure.Data.Specification.CMS.CruiseSpecification
{
    public class CruiseContentSpecification : BaseSpecification<CruiseContent>
    {
        public CruiseContentSpecification(int cruiseId, string languageCode) : base(
            x => x.OriginalTableId == cruiseId &&
             (string.IsNullOrEmpty(languageCode) || x.Language.LanguageAbbreviation == languageCode)
            && x.IsDeleted == false
            )

        {
        }

        public CruiseContentSpecification(int cruiseId) : base(
            x => x.OriginalTableId == cruiseId &&
             x.IsDeleted == false
            )

        {
        }
    }
}
