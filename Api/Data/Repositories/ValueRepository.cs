using Api.Data.Entities;
using Api.Data.Models;
using Core.Repositories;
using Microsoft.EntityFrameworkCore;

namespace Api.Data.Repositories
{
    public class ValueRepository : RepositoryCore<Value, int>, IValueRepository
    {
        public ValueRepository(ValueContext context) : base(context)
        {
        }
    }
}