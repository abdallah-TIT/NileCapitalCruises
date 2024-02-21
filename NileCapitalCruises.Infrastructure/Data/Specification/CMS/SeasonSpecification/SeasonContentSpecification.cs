using NileCapitalCruises.Core.Models;

namespace NileCapitalCruises.Infrastructure.Data.Specification.CMS.SeasonSpecification
{
    public class SeasonContentSpecification : BaseSpecification<SeasonContent>
    {
        public SeasonContentSpecification(int seasonId, string languageCode) : base(
            x => x.OriginalTableId == seasonId &&
             (string.IsNullOrEmpty(languageCode) || x.Language.LanguageAbbreviation == languageCode)
            && x.IsDeleted == false
            )

        {
        }

        public SeasonContentSpecification(int seasonId) : base(
            x => x.OriginalTableId == seasonId &&
             x.IsDeleted == false
            )

        {
        }
    }
}
