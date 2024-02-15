using NileCapitalCruises.Core.Models;

namespace NileCapitalCruises.Infrastructure.Data.Specification.CMS.CabinSpecification
{
    public class CabinContentSpecification : BaseSpecification<CabinContent>
    {
        public CabinContentSpecification(int cabinId, string languageCode) : base(
            x => x.OriginalTableId == cabinId &&
             (string.IsNullOrEmpty(languageCode) || x.Language.LanguageAbbreviation == languageCode)
            && x.IsDeleted == false
            )

        {
        }

        public CabinContentSpecification(int cabinId) : base(
            x => x.OriginalTableId == cabinId &&
             x.IsDeleted == false
            )

        {
        }
    }
}
