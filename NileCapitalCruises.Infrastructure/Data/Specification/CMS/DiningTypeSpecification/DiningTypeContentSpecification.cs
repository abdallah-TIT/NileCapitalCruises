using NileCapitalCruises.Core.Models;

namespace NileCapitalCruises.Infrastructure.Data.Specification.CMS.DiningTypeSpecification
{
    public class DiningTypeContentSpecification : BaseSpecification<DiningTypeContent>
    {
        public DiningTypeContentSpecification(int diningTypeId, string languageCode) : base(
            x => x.OriginalTableId == diningTypeId &&
             (string.IsNullOrEmpty(languageCode) || x.Language.LanguageAbbreviation == languageCode)
            && x.IsDeleted == false
            )

        {
        }

        public DiningTypeContentSpecification(int diningTypeId) : base(
            x => x.OriginalTableId == diningTypeId &&
             x.IsDeleted == false
            )

        {
        }
    }
}
