using System;
using System.Collections.Generic;
using Core.Entities;
using Core.Models;
using Core.Services;
using Microsoft.AspNetCore.Mvc;

namespace Core.Controllers
{
    public interface IControllerCore<TViewModel, TEntity, TId>
        where TViewModel : class, IViewModel<TId>
        where TEntity : class, IEntity<TId>
        where TId : class
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