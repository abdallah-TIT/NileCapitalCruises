using NileCapitalCruises.Core.Models;

namespace NileCapitalCruises.Infrastructure.Data.Specification.CMS.DiningSpecification
{
    public class DiningContentSpecification : BaseSpecification<DiningContent>
    {
        public DiningContentSpecification(int diningId, string languageCode) : base(
            x => x.OriginalTableId == diningId &&
             (string.IsNullOrEmpty(languageCode) || x.Language.LanguageAbbreviation == languageCode)
            && x.IsDeleted == false
            )

        {
        }

        public DiningContentSpecification(int diningId) : base(
            x => x.OriginalTableId == diningId &&
             x.IsDeleted == false
            )

        {
        }
    }
}
