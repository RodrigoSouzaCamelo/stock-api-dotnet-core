using System.Collections.Generic;
using AutoMapper;
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
        private IMapper _mapper;

        public Service(IRepository<TEntity, TId> repository, IMapper mapper)
        {

            _repository = repository;
            _mapper = mapper;
        }

        public IEnumerable<TViewModel> GetAll()
        {
            IEnumerable<TEntity> entities = _repository.GetAll();
            return _mapper.Map<IEnumerable<TViewModel>>(entities);
        }

        public TViewModel GetById(TId id)
        {
            TEntity entity = _repository.GetById(id);
            return _mapper.Map<TViewModel>(entity);
        }

        public void Add(TViewModel viewModel)
        {
            TEntity entity = _mapper.Map<TEntity>(viewModel);
            _repository.Add(entity);
        }

        public void AddRange(IEnumerable<TViewModel> viewModels)
        {
            IEnumerable<TEntity> entities = _mapper.Map<IEnumerable<TEntity>>(viewModels);
            _repository.AddRange(entities);
        }

        public void Update(TViewModel viewModel)
        {
            TEntity entity = _mapper.Map<TEntity>(viewModel);
            _repository.Update(entity);
        }

        public void UpdateRange(IEnumerable<TViewModel> viewModels)
        {
            IEnumerable<TEntity> entities = _mapper.Map<IEnumerable<TEntity>>(viewModels);
            _repository.UpdateRange(entities);
        }

        public void Remove(TViewModel viewModel)
        {
            TEntity entity = _mapper.Map<TEntity>(viewModel);
            _repository.Remove(entity);
        }

        public void RemoveRange(IEnumerable<TViewModel> viewModels)
        {
            IEnumerable<TEntity> entities = _mapper.Map<IEnumerable<TEntity>>(viewModels);
            _repository.RemoveRange(entities);
        }
    }
}