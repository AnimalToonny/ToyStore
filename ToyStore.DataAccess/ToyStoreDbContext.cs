using Microsoft.EntityFrameworkCore;
using ToyStore.DataAccess.Entities;

namespace ToyStore.DataAccess
{
    public class ToyStoreDbContext : DbContext
    {
        public ToyStoreDbContext(DbContextOptions<ToyStoreDbContext> options) : base(options)
        {}

        public DbSet<ToyEntity> Toys { get; set; }
    }
}
