using System.Collections.Generic;
using Core.Entities.Interfaces;
using Core.Models.Interfaces;
using Microsoft.AspNetCore.Mvc;

namespace Core.Controllers.Interfaces
{
    public interface IControllerCore<TViewModel, TEntity, TId>
        where TViewModel : class, IViewModel<TId>
        where TEntity : class, IEntity<TId>
        where TId : struct
    {
        ActionResult<IEnumerable<TViewModel>> GetAll();
        ActionResult<TViewModel> GetById(TId id);

        ActionResult Add(TViewModel viewModel);
        ActionResult AddRange(IEnumerable<TViewModel> viewModel);

        ActionResult Update(TViewModel entity);
        ActionResult UpdateRange(IEnumerable<TViewModel> viewModels);

        ActionResult Remove(TViewModel viewModel);
        ActionResult RemoveRange(IEnumerable<TViewModel> viewModels);
    }
}