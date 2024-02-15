using NileCapitalCruises.Core.Models;

namespace NileCapitalCruises.Infrastructure.Data.Specification.CMS.CabinTypeSpecification
{
    public class CabinTypeContentSpecification : BaseSpecification<CabinTypeContent>
    {
        public CabinTypeContentSpecification(int cabinTypeId, string languageCode) : base(
            x => x.OriginalTableId == cabinTypeId &&
             (string.IsNullOrEmpty(languageCode) || x.Language.LanguageAbbreviation == languageCode)
            && x.IsDeleted == false
            )

        {
        }

        public CabinTypeContentSpecification(int cabinTypeId) : base(
            x => x.OriginalTableId == cabinTypeId &&
             x.IsDeleted == false
            )

        {
        }
    }
}
