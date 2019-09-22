using System.Collections.Generic;
using Core.Controllers.Interfaces;
using Core.Entities;
using Core.Entities.Interfaces;
using Core.Models;
using Core.Models.Interfaces;
using Core.Services;
using Core.Services.Interfaces;
using Microsoft.AspNetCore.Mvc;

namespace Core.Controllers
{
    public class ControllerCore<TViewModel, TEntity, TId> : ControllerBase, IControllerCore<TViewModel, TEntity, TId>
        where TViewModel : class, IViewModel<TId>
        where TEntity : class, IEntity<TId>
        where TId : struct
    {
        private readonly IServiceCore<TViewModel, TEntity, TId> _service;

        public ControllerCore(IServiceCore<TViewModel, TEntity, TId> service) => _service = service;

        public ActionResult<IEnumerable<TViewModel>> GetAll()
            => Ok(_service.GetAll());

        public ActionResult<TViewModel> GetById(TId id)
            => Ok(_service.GetById(id));

        public ActionResult Add(TViewModel viewModel)
            => Ok(_service.Add(viewModel));

        public ActionResult AddRange(IEnumerable<TViewModel> viewModels)
            => Ok(_service.AddRange(viewModels));

        public ActionResult Update(TViewModel viewModel)
            => Ok(_service.Update(viewModel));

        public ActionResult UpdateRange(IEnumerable<TViewModel> viewModels)
            => Ok(_service.UpdateRange(viewModels));

        public ActionResult Remove(TViewModel viewModel)
            => Ok(_service.Remove(viewModel));

        public ActionResult RemoveRange(IEnumerable<TViewModel> viewModels)
            => Ok(_service.RemoveRange(viewModels));
    }
}