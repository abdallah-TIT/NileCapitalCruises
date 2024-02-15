using NileCapitalCruises.Core.IRepositories;
using NileCapitalCruises.Core.Models;
using NileCapitalCruises.Infrastructure.Data.Specification.CMS.LanguageSpecification;

namespace NileCapitalCruises.Infrastructure.Helpers.Utils
{
    public class HandleContents<T> : IHandleContents<T> where T : class
    {
        private readonly IGenericRepo<Language> _languageRepo;

        public HandleContents(IGenericRepo<Language> languageRepo) {
            _languageRepo = languageRepo;
        }
        public async Task CreateContents(int masterEntityId, ICollection<T> entity)
        {   
            var spec = new LanguageSpecs();
            var languages = await _languageRepo.ListAsync(spec);
            foreach(var language in languages)
            {
                var newEntity = Activator.CreateInstance<T>();
                var langIdProperty = typeof(T).GetProperty("LanguageId");
                var IdProperty = typeof(T).GetProperty("OriginalTableId");

                if (langIdProperty != null && langIdProperty.CanWrite)
                {
                    langIdProperty.SetValue(newEntity, language.Id);
                    IdProperty.SetValue(newEntity, masterEntityId);
                    entity.Add(newEntity);
                }
            }
        }


        
    }
}
