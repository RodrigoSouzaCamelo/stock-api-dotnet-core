using Api.Data.Entities;
using Api.Data.Models;
using Api.Data.Repositories;
using Api.Services;
using AutoMapper;
using Core.Repositories;
using Core.Services;

namespace Core.Controllers
{
    public class ValueService : Service<ValueModel, Value, int>, IValueService
    {
        public ValueService(IValueRepository repository, IMapper mapper) : base(repository, mapper)
        {
        }
    }
}