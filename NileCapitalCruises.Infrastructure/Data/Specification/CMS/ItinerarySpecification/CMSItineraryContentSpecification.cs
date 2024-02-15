using NileCapitalCruises.Core.Models;

namespace NileCapitalCruises.Infrastructure.Data.Specification.CMS.ItinerarySpecification
{
    public class CMSItineraryContentSpecification : BaseSpecification<ItineraryContent>
    {
        public CMSItineraryContentSpecification(int itineraryId, string languageCode) : base(
            x => x.OriginalTableId == itineraryId &&
             (string.IsNullOrEmpty(languageCode) || x.Language.LanguageAbbreviation == languageCode)
            && x.IsDeleted == false
            )

        {
        }

        public CMSItineraryContentSpecification(int itineraryId) : base(
            x => x.OriginalTableId == itineraryId &&
             x.IsDeleted == false
            )

        {
        }
    }
}
