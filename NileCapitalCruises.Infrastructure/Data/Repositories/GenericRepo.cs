using NileCapitalCruises.Core;
using NileCapitalCruises.Core.IRepositories;
using NileCapitalCruises.Core.Models;
using Microsoft.AspNetCore.JsonPatch;
using Microsoft.EntityFrameworkCore;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Reflection;
using System.Text;
using System.Threading.Tasks;

namespace NileCapitalCruises.Infrastructure.Data.Repositories
{
    public class GenericRepo<T> : IGenericRepo<T> where T : BaseEntity
    {
        private readonly NileCapitalCruisesWSDBContext _context;
        public GenericRepo(NileCapitalCruisesWSDBContext context)
        {
            _context = context;
        }


        public async Task<T> GetByIdAsync(int id)
        {
            return await _context.Set<T>().FindAsync(id);
        }

        public async Task<T> GetEntityWithSpecAsync(ISpecification<T> spec)
        {
            return await ApplySpecification(spec).FirstOrDefaultAsync();
        }

        public async Task<IReadOnlyList<T>> ListAllAsync()
        {
            return await _context.Set<T>().ToListAsync();
        }

        public async Task<IReadOnlyList<T>> ListAsync(ISpecification<T> spec)
        {
            var query = ApplySpecification(spec);
            return await query.ToListAsync();
        }


        public async Task<int> CountAsync(ISpecification<T> spec)
        {
            return await ApplySpecification(spec).CountAsync();
        }



        private IQueryable<T> ApplySpecification(ISpecification<T> spec)
        {
            return SpecificationEvaluator<T>.GetQuery(_context.Set<T>().AsQueryable(), spec);
        }

        public async Task<T> CreateEntityAsync(T entity)
        {
            await _context.Set<T>().AddAsync(entity);
            return entity;
        }

        public async Task<IEnumerable<T>> CreateEntitiesAsync(IEnumerable<T> entities)
        {
            await _context.Set<T>().AddRangeAsync(entities);
            return entities;
        }

        public T UpdateEntity(T entity)
        {
            _context.Set<T>().Update(entity);
            return entity;
        }

        public void DeleteEntity(T entity)
        {
            _context.Set<T>().Remove(entity);
        }
        public void DeleteEntities(IEnumerable<T> entities)
        {
            _context.Set<T>().RemoveRange(entities);
            
        }
        public void DeleteSoftEntity(T entity)
        {
            PropertyInfo isDeletedProperty = entity.GetType().GetProperty("IsDeleted");

            if (isDeletedProperty != null && isDeletedProperty.PropertyType == typeof(bool?))
            {
                isDeletedProperty.SetValue(entity, true);
                _context.Entry(entity).State = EntityState.Modified;
            }
        }

        public void DeleteSoftEntities(IEnumerable<T> entities)
        {
            PropertyInfo isDeletedProperty = typeof(T).GetProperty("IsDeleted");

            if (isDeletedProperty != null && isDeletedProperty.PropertyType == typeof(bool?))
            {
                entities.Select(entity =>
                {
                    isDeletedProperty.SetValue(entity, true);
                    _context.Entry(entity).State = EntityState.Modified;
                    return entity; // This is just to satisfy the Select syntax, but it doesn't affect the result.
                }).ToList();
            }
        }

        public async Task SaveChangesAsync()
        {
            await _context.SaveChangesAsync();
        }

        public void SaveChanges()
        {
            _context.SaveChanges();
        }

        public void UpdatePatchEntity(JsonPatchDocument model, T entity)
        {
            model.ApplyTo(entity);
        }

        public async Task<bool> AnyAsync(ISpecification<T> spec)
        {
            return await ApplySpecification(spec).AnyAsync();
        }


    }
}
