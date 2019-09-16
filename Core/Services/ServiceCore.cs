using System.Collections.Generic;
using AutoMapper;
using Core.Entities;
using Core.Models;
using Core.Repositories;

namespace Core.Services
{
    public class Service<TViewModel, TEntity, TId> : IServiceCore<TViewModel, TEntity, TId>
        where TViewModel : ViewModel<TId>
        where TEntity : Entity<TId>
        where TId : class
    {
        private readonly IRepositoryCore<TEntity, TId> _repository;
        private readonly IMapper _mapper;

        public Service(IRepositoryCore<TEntity, TId> repository, IMapper mapper)
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

        public TViewModel Add(TViewModel viewModel)
        {
            TEntity entity = _mapper.Map<TEntity>(viewModel);
            _repository.Add(entity);
            return viewModel;
        }

        public IEnumerable<TViewModel> AddRange(IEnumerable<TViewModel> viewModels)
        {
            IEnumerable<TEntity> entities = _mapper.Map<IEnumerable<TEntity>>(viewModels);
            _repository.AddRange(entities);
            return viewModels;
        }

        public TViewModel Update(TViewModel viewModel)
        {
            TEntity entity = _mapper.Map<TEntity>(viewModel);
            _repository.Update(entity);
            return viewModel;
        }

        public IEnumerable<TViewModel> UpdateRange(IEnumerable<TViewModel> viewModels)
        {
            IEnumerable<TEntity> entities = _mapper.Map<IEnumerable<TEntity>>(viewModels);
            _repository.UpdateRange(entities);
            return viewModels;
        }

        public TViewModel Remove(TViewModel viewModel)
        {
            TEntity entity = _mapper.Map<TEntity>(viewModel);
            _repository.Remove(entity);
            return viewModel;
        }

        public IEnumerable<TViewModel> RemoveRange(IEnumerable<TViewModel> viewModels)
        {
            IEnumerable<TEntity> entities = _mapper.Map<IEnumerable<TEntity>>(viewModels);
            _repository.RemoveRange(entities);
            return viewModels;
        }
    }
}