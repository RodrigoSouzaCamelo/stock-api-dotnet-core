using Api.Data.Entities;
using Microsoft.EntityFrameworkCore;

namespace Api.Data
{
    public class ValueContext : DbContext
    {
        public ValueContext(DbContextOptions<ValueContext> options) : base(options){}
        
        public DbSet<Value> Value { get; set; }
    }
}