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
        IEnumerable<TViewModel> GetAll();
        TViewModel GetById(TId id);

        void Add(TViewModel viewModel);
        void AddRange(IEnumerable<TViewModel> viewModel);

        void Update(TViewModel entity);
        void UpdateRange(IEnumerable<TViewModel> viewModels);

        void Remove(TViewModel viewModel);
        void RemoveRange(IEnumerable<TViewModel> entities);
    }
}