using Api.Data.Entities;
using Api.Data.Models;
using Core.Controllers;
using Microsoft.AspNetCore.Mvc;
using MyNamespace;

namespace Api.Controllers 
{
    [ApiController]
    [Route("api/[controller]")]
    public class UserController : ControllerCore<UserVM, User, int>
    {
        public UserController(IUserService service)
            :base(service){}
    }
}