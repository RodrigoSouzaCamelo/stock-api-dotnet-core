using System.Collections.Generic;
using Core.Entities;

namespace Core.Repositories
{
    public interface IRepository<TEntity, TId>
        where TEntity : IEntity<TId>
        where TId : class
    {
        IEnumerable<TEntity> GetAll();
        TEntity GetById(TId id);
        
        IEnumerable<TEntity> GetAllAsNoTracking();
        TEntity GetByIdAsNoTracking(TId id);

        void Add(TEntity entity);
        void AddRange(IEnumerable<TEntity> entities);

        void Update(TEntity entity);
        void UpdateRange(IEnumerable<TEntity> entities);

        void Remove(TEntity entity);
        void RemoveRange(IEnumerable<TEntity> entities);
    }
}