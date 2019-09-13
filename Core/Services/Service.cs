using System.Collections.Generic;
using Core.Entities;
using Core.Models;
using Core.Repositories;

namespace Core.Services
{
    public class Service<TViewModel, TEntity, TId> : IService<TViewModel, TEntity, TId>
        where TViewModel : ViewModel<TId>
        where TEntity : Entity<TId>
        where TId : class
    {
        private IRepository<TEntity, TId> _repository;

        public Service(IRepository<TEntity, TId> repository) => _repository = repository;

        public IEnumerable<TEntity> GetAll() => _repository.GetAll();

        public TEntity GetById(TId id) => _repository.GetById(id);

        public void Add(TEntity entity) => _repository.Add(entity);

        public void AddRange(IEnumerable<TEntity> entities) => _repository.AddRange(entities);

        public void Update(TEntity entity) => _repository.Update(entity);

        public void UpdateRange(IEnumerable<TEntity> entities) => _repository.UpdateRange(entities);

        public void Remove(TEntity entity) => _repository.Remove(entity);

        public void RemoveRange(IEnumerable<TEntity> entities) => _repository.RemoveRange(entities);
    }
}