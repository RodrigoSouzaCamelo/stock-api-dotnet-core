using Api.Data.Entities;
using Api.Data.Repositories.Interfaces;
using Core.Repositories;

namespace Api.Data.Repositories
{
    public class UserRepository : RepositoryCore<User, int>, IUserRepository
    {
        public UserRepository(StockContext context)
            :base(context) { }
    }
}