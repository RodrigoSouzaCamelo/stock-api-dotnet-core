using Api.Data.Entities;
using Api.Data.Models;
using Core.Services;

namespace Api.Services
{
    public interface IValueService: IServiceCore<ValueModel, Value, int>
    {
        
    }
}