using System.Collections.Generic;
using System.Linq;
using Core.Entities;
using Microsoft.EntityFrameworkCore;

namespace Core.Repositories
{
    public class RepositoryCore<TEntity, TId>  : IRepositoryCore<TEntity, TId> 
        where TEntity : class, IEntity<TId>
    {
        private readonly DbContext _context;

        public RepositoryCore(DbContext context) => _context = context;

        public IEnumerable<TEntity> GetAll() => _context.Set<TEntity>();

        public TEntity GetById(TId id) => _context.Set<TEntity>()
            .SingleOrDefault(x => x.Id.Equals(id));

        public IEnumerable<TEntity> GetAllAsNoTracking() => _context.Set<TEntity>()
            .AsNoTracking();

        public TEntity GetByIdAsNoTracking(TId id) => _context.Set<TEntity>()
            .AsNoTracking()
            .SingleOrDefault(x => x.Id.Equals(id));

        public void Add(TEntity entity)
        {
            _context.Set<TEntity>().Add(entity);
            _context.SaveChanges();
        }

        public void AddRange(IEnumerable<TEntity> entities)
        {
            _context.Set<TEntity>().AddRange(entities);
            _context.SaveChanges();
        }

        public void Update(TEntity entity)
        {
            _context.Set<TEntity>().Update(entity);
            _context.SaveChanges();
        }

        public void UpdateRange(IEnumerable<TEntity> entities)
        {
            _context.Set<TEntity>().UpdateRange(entities);
            _context.SaveChanges();
        }

        public void Remove(TEntity entity)
        {
            _context.Set<TEntity>().Remove(entity);
            _context.SaveChanges();
        }

        public void RemoveRange(IEnumerable<TEntity> entities)
        {
            _context.Set<TEntity>().RemoveRange(entities);
            _context.SaveChanges();
        }
    }
}