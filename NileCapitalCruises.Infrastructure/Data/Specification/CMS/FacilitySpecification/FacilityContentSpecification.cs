using NileCapitalCruises.Core.Models;

namespace NileCapitalCruises.Infrastructure.Data.Specification.CMS.FacilitySpecification
{
    public class FacilityContentSpecification : BaseSpecification<FacilityContent>
    {
        public FacilityContentSpecification(int facilityId, string languageCode) : base(
            x => x.OriginalTableId == facilityId &&
             (string.IsNullOrEmpty(languageCode) || x.Language.LanguageAbbreviation == languageCode)
            && x.IsDeleted == false
            )

        {
        }

        public FacilityContentSpecification(int facilityId) : base(
            x => x.OriginalTableId == facilityId &&
             x.IsDeleted == false
            )

        {
        }
    }
}
