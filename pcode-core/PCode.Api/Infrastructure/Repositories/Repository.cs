using System;
using System.Collections;
using System.Collections.Generic;
using System.Linq;
using System.Linq.Expressions;
using System.Threading.Tasks;
using Microsoft.EntityFrameworkCore;
using PCode.Domain;
using PCode.Domain.Interfaces.Repositories;

namespace PCode.Api.Infrastructure.Repositories
{
    public class Repository<TEntity> : IRepository<TEntity> where TEntity : BaseEntity
    {
        protected readonly PcodeContext Context;
        private readonly DbSet<TEntity> _entities;

        public Repository(PcodeContext context)
        {
            Context = context;
            _entities = Context.Set<TEntity>();
        }

        public async Task<TEntity> GetAsync(Guid guid)
        {
            return await _entities.FindAsync(guid);
        }

        public async Task<IEnumerable<TEntity>> FindAsync(Expression<Func<TEntity, bool>> predicate)
        {
            return await _entities.Where(predicate).ToListAsync();
        }

        public async Task<TEntity> SingleOrDefaultAsync(Expression<Func<TEntity, bool>> predicate)
        {
            return await _entities.SingleOrDefaultAsync(predicate);
        }

        public void Add(TEntity entity)
        {
            _entities.AddAsync(entity);
        }

        public void AddRange(IEnumerable<TEntity> entities)
        {
            _entities.AddRange(entities);
        }

        public void Remove(TEntity entity)
        {
            _entities.Remove(entity);
        }

        public void RemoveRange(IEnumerable<TEntity> entities)
        {
            _entities.RemoveRange(entities);
        }
    }
}
