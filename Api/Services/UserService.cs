using Api.Data.Entities;
using Api.Data.Models;
using Api.Data.Repositories.Interfaces;
using AutoMapper;
using Core.Services;
using MyNamespace;

namespace Api.Services
{
    public class UserService : Service<UserVM, User, int>, IUserService
    {
        public UserService(IUserRepository repository, IMapper mapper) 
            :base(repository, mapper){}
    }
}