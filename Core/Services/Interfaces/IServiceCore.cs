using System.Collections.Generic;
using Core.Entities;
using Core.Entities.Interfaces;
using Core.Models.Interfaces;

namespace Core.Services.Interfaces
{
    public interface IServiceCore<TViewModel, TEntity, TId> 
        where TViewModel : IViewModel<TId>
        where TEntity : IEntity<TId>
        where TId : struct
    {
        IEnumerable<TViewModel> GetAll();
        TViewModel GetById(TId id);

        TViewModel Add(TViewModel viewModel);
        IEnumerable<TViewModel> AddRange(IEnumerable<TViewModel> viewModel);

        TViewModel Update(TViewModel viewModel);
        IEnumerable<TViewModel> UpdateRange(IEnumerable<TViewModel> viewModels);

        TViewModel Remove(TViewModel viewModel);
        IEnumerable<TViewModel> RemoveRange(IEnumerable<TViewModel> viewModels);
    }
}