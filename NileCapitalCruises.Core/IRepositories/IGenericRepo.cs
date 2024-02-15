using NileCapitalCruises.Core.Models;
using Microsoft.AspNetCore.JsonPatch;

namespace NileCapitalCruises.Core.IRepositories
{
    public interface IGenericRepo<T> where T : BaseEntity
    {
        Task<T> GetByIdAsync(int id);
        Task<IReadOnlyList<T>> ListAllAsync();
        Task<T> GetEntityWithSpecAsync(ISpecification<T> spec);
        Task<IReadOnlyList<T>> ListAsync(ISpecification<T> spec);
        Task<int> CountAsync(ISpecification<T> spec);

        Task<T> CreateEntityAsync(T entity);

        Task<IEnumerable<T>> CreateEntitiesAsync(IEnumerable<T> entities);
        void DeleteEntity(T entity);
        void DeleteEntities(IEnumerable<T> entities);

        void DeleteSoftEntity(T entity);

        void DeleteSoftEntities(IEnumerable<T> entities);

        void UpdatePatchEntity(JsonPatchDocument model, T entity);

         T UpdateEntity(T entity);
        Task SaveChangesAsync();
        void SaveChanges();
        Task<bool> AnyAsync(ISpecification<T> spec);


    }


}
