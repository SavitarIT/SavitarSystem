using Microsoft.EntityFrameworkCore;
using Savitar.Domain.Shared;
using Savitar.Infrastructure.Repository.Shared;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Savitar.Infrastructure.Repository.EFCore
{
    public class Repository<TEntity, TContext> : IRepository<TEntity>
        where TEntity : class, IEntity
        where TContext : DbContext
    {
        private readonly TContext _context;
        
        public Repository(TContext context)
        {
            _context = context;
        }

        public async Task<TEntity> AddAsync(TEntity entity)
        {
            _context.Set<TEntity>().Add(entity);
            await _context.SaveChangesAsync();
            return entity;
        }

        public async Task<TEntity> DeleteAsync(int id)
        {
            var entity = await _context.Set<TEntity>().FindAsync(id);
            if (entity == null)
                return null;

            _context.Set<TEntity>().Remove(entity);
            await _context.SaveChangesAsync();

            return entity;
        }

        public async Task<TEntity> GetAsync(int id)
        {
            return await _context.Set<TEntity>().FindAsync(id);
        }

        protected virtual IQueryable<TEntity> ConfigureGetAll(IQueryable<TEntity> data)
        {
            return data;
        }

        public async virtual Task<IEnumerable<TEntity>> GetAllAsync()
        {
            var data = ConfigureGetAll(_context.Set<TEntity>());            
            return await data.ToListAsync();
        }

        public async Task<TEntity> UpdateAsync(TEntity entity)
        {
            _context.Entry(entity).State = EntityState.Modified;
            await _context.SaveChangesAsync();
            return entity;
        }
    }
}
