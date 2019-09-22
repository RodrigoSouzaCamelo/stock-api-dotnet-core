using System.Collections.Generic;
using Core.Entities;
using Core.Entities.Interfaces;

namespace Core.Repositories.Interfaces
{
    public interface IRepositoryCore<TEntity, in TId>
        where TEntity : IEntity<TId>
        where TId : struct
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