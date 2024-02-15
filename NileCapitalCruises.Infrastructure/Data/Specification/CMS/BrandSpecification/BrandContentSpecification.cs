using NileCapitalCruises.Core.Models;

namespace NileCapitalCruises.Infrastructure.Data.Specification.CMS.BrandSpecification
{
    public class BrandContentSpecification : BaseSpecification<BrandContent>
    {
        public BrandContentSpecification(int brandId, string languageCode) : base(
            x => x.OriginalTableId == brandId &&
             (string.IsNullOrEmpty(languageCode) || x.Language.LanguageAbbreviation == languageCode)
            && x.IsDeleted == false
            )

        {
        }

        public BrandContentSpecification(int brandId) : base(
            x => x.OriginalTableId == brandId &&
             x.IsDeleted == false
            )

        {
        }
    }
}
