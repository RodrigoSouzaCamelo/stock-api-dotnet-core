using Api.Data.Entities;
using Api.Data.Models;
using Core.Services.Interfaces;

namespace MyNamespace
{
    public interface IUserService : IServiceCore<UserVM, User, int>
    {
        
    }
}