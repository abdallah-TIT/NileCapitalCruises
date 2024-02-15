using NileCapitalCruises.Core.Models;

namespace NileCapitalCruises.Infrastructure.Data.Specification.CMS.AmenitySpecification
{
    public class AmenityContentSpecification : BaseSpecification<AmenityContent>
    {
        public AmenityContentSpecification(int amenityId, string languageCode) : base(
            x => x.OriginalTableId == amenityId &&
             (string.IsNullOrEmpty(languageCode) || x.Language.LanguageAbbreviation == languageCode)
            && x.IsDeleted == false
            )

        {
        }

        public AmenityContentSpecification(int amenityId) : base(
            x => x.OriginalTableId == amenityId &&
             x.IsDeleted == false
            )

        {
        }
    }
}
