using NileCapitalCruises.Core.Models;

namespace NileCapitalCruises.Infrastructure.Data.Specification.CMS.LanguageSpecification
{
    public class LanguageSpecs : BaseSpecification<Language>
    {
        public LanguageSpecs(string languageCode) : base(x => x.LanguageAbbreviation == languageCode) { }
        public LanguageSpecs()
        {

        }
    }
}