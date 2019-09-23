using Api.Data.Entities;
using Api.Data.Models;
using Core.Repositories.Interfaces;

namespace Api.Data.Repositories.Interfaces
{
    public interface IUserRepository : IRepositoryCore<User, int> { }
}