using Microsoft.EntityFrameworkCore;
using PratikSurvivor.Models;

namespace PratikSurvivor.Contexts
{
    public class AppDbContext : DbContext
    {
        public AppDbContext(DbContextOptions<AppDbContext> options) : base(options)
        {

        }

        public DbSet<Competitor> Competitors { get; set; }
        public DbSet<Category> Categories { get; set; }
        protected override void OnModelCreating(ModelBuilder modelBuilder)
        {
            base.OnModelCreating(modelBuilder);

            modelBuilder.Entity<Category>().HasData(
                new Category { Id = 1, Name = "Ünlüler", CreatedDate = DateTime.Now, IsDeleted = false },
                new Category { Id = 2, Name = "Gönüllüler", CreatedDate = DateTime.Now, IsDeleted = false }
            );

            modelBuilder.Entity<Competitor>().HasData(
                new Competitor { Id = 1, FirstName = "Acun", LastName = "Ilıcalı", CategoryId = 1, CreatedDate = DateTime.Now, IsDeleted = false },
                new Competitor { Id = 2, FirstName = "Aleyna", LastName = "Avcı", CategoryId = 1, CreatedDate = DateTime.Now, IsDeleted = false },
                new Competitor { Id = 3, FirstName = "Hadise", LastName = "Açıkgöz", CategoryId = 1, CreatedDate = DateTime.Now, IsDeleted = false },
                new Competitor { Id = 4, FirstName = "Sertan", LastName = "Bozkuş", CategoryId = 1, CreatedDate = DateTime.Now, IsDeleted = false },
                new Competitor { Id = 5, FirstName = "Özge", LastName = "Açık", CategoryId = 1, CreatedDate = DateTime.Now, IsDeleted = false },
                new Competitor { Id = 6, FirstName = "Kıvanç", LastName = "Tatlıtuğ", CategoryId = 1, CreatedDate = DateTime.Now, IsDeleted = false },
                new Competitor { Id = 7, FirstName = "Ahmet", LastName = "Yılmaz", CategoryId = 2, CreatedDate = DateTime.Now, IsDeleted = false },
                new Competitor { Id = 8, FirstName = "Elif", LastName = "Demirtaş", CategoryId = 2, CreatedDate = DateTime.Now, IsDeleted = false },
                new Competitor { Id = 9, FirstName = "Cem", LastName = "Öztürk", CategoryId = 2, CreatedDate = DateTime.Now, IsDeleted = false },
                new Competitor { Id = 10, FirstName = "Ayşe", LastName = "Karaca", CategoryId = 2, CreatedDate = DateTime.Now, IsDeleted = false }
            );
        }
    }
}
