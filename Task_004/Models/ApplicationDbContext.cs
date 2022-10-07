using Microsoft.EntityFrameworkCore;
using Task_004.Models.Entities;

namespace Task_004.Models
{
    public class ApplicationDbContext : DbContext
    {
        public ApplicationDbContext(DbContextOptions<ApplicationDbContext> options)
            :base(options)
        {
            Database.EnsureDeleted();
            Database.EnsureCreated();
        }

        DbSet<Author> Authors { get; set; } = null!;
        DbSet<Book> Books { get; set; } = null!;

        protected override void OnModelCreating(ModelBuilder modelBuilder)
        {
            modelBuilder.ApplyConfigurationsFromAssembly(typeof(ApplicationDbContext).Assembly);
        }
    }
}
