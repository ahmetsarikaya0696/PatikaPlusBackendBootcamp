using Microsoft.EntityFrameworkCore;
using Pratik43.Entities;

namespace Pratik43.Contexts
{
    public class PatikaSecondDbContext : DbContext
    {
        public DbSet<User> Users{ get; set; }
        public DbSet<Post> Posts { get; set; }

        public PatikaSecondDbContext(DbContextOptions<PatikaSecondDbContext> options ) : base(options)
        {
            
        }
    }
}
