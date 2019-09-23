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

        [HttpGet]
        public ActionResult<IEnumerable<TViewModel>> GetAll()
            => Ok(_service.GetAll());

        [HttpGet("{id}")]
        public ActionResult<TViewModel> GetById([FromRoute]TId id)
            => Ok(_service.GetById(id));

        [HttpPost("Add")]
        public ActionResult Add([FromBody]TViewModel viewModel)
            => Ok(_service.Add(viewModel));

        [HttpPost("AddRange")]
        public ActionResult AddRange([FromBody]IEnumerable<TViewModel> viewModels)
            => Ok(_service.AddRange(viewModels));

        [HttpPut("Update")]
        public ActionResult Update([FromBody]TViewModel viewModel)
            => Ok(_service.Update(viewModel));

        [HttpPut("UpdateRange")]
        public ActionResult UpdateRange([FromBody]IEnumerable<TViewModel> viewModels)
            => Ok(_service.UpdateRange(viewModels));

        [HttpDelete("Remove")]
        public ActionResult Remove([FromBody]TViewModel viewModel)
            => Ok(_service.Remove(viewModel));

        [HttpDelete("RemoveRange")]
        public ActionResult RemoveRange([FromBody]IEnumerable<TViewModel> viewModels)
            => Ok(_service.RemoveRange(viewModels));
    }
}