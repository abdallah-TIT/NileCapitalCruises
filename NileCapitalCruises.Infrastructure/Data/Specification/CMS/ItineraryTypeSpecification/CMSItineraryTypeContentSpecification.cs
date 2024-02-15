using NileCapitalCruises.Core.Models;

namespace NileCapitalCruises.Infrastructure.Data.Specification.CMS.ItineraryTypeSpecification
{
    public class CMSItineraryTypeContentSpecification : BaseSpecification<ItineraryTypeContent>
    {
        public CMSItineraryTypeContentSpecification(int itineraryTypeId, string languageCode) : base(
            x => x.OriginalTableId == itineraryTypeId &&
             (string.IsNullOrEmpty(languageCode) || x.Language.LanguageAbbreviation == languageCode)
            && x.IsDeleted == false
            )

        {
        }

        public CMSItineraryTypeContentSpecification(int itineraryTypeId) : base(
            x => x.OriginalTableId == itineraryTypeId &&
             x.IsDeleted == false
            )

        {
        }
    }
}
