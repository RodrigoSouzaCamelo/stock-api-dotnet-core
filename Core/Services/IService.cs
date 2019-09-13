using System.Collections.Generic;
using Core.Entities;
using Core.Models;

namespace Core.Services
{
    public interface IService<TViewModel, TEntity, TId> 
        where TViewModel : IViewModel<TId>
        where TEntity : IEntity<TId>
        where TId : class
    {
        IEnumerable<TEntity> GetAll();
        TEntity GetById(TId id);

        void Add(TEntity entity);
        void AddRange(IEnumerable<TEntity> entities);

        void Update(TEntity entity);
        void UpdateRange(IEnumerable<TEntity> entities);

        void Remove(TEntity entity);
        void RemoveRange(IEnumerable<TEntity> entities);
    }
}