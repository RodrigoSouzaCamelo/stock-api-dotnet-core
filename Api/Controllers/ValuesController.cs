using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Api.Data.Entities;
using Api.Data.Models;
using Core.Controllers;
using Core.Services;
using Microsoft.AspNetCore.Mvc;

namespace Api.Controllers
{
    [Route("api/[controller]")]
    [ApiController]
    public class ValuesController : ControllerCore<ValueModel, Value, int>
    {
        public ValuesController(IServiceCore<ValueModel, Value, int> service) : base(service)
        {
        }
    }
}
