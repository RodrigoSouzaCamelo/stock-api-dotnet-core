using Api.Data.Entities;
using Microsoft.EntityFrameworkCore;

namespace Api.Data
{
    public class StockContext : DbContext
    {
        public StockContext(DbContextOptions<StockContext> options)
            :base(options) { }

        public DbSet<User> Users { get; set; }
    }
}