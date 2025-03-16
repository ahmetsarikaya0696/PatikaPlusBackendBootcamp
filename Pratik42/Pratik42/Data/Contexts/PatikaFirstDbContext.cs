using Microsoft.EntityFrameworkCore;
using Pratik42.Data.Entities;

namespace Pratik42.Data.Contexts
{
    public class PatikaFirstDbContext : DbContext
    {
        public DbSet<Game> Games { get; set; }
        public DbSet<Movie> Movies { get; set; }

        public PatikaFirstDbContext(DbContextOptions<PatikaFirstDbContext> options) : base(options)
        {

        }
    }
}
