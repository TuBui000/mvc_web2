using Microsoft.EntityFrameworkCore;
using mvc_web2_razor.Model;
namespace mvc_web2_razor.Data
{
    public class ApplicationDbContext : DbContext
    {
        public ApplicationDbContext(DbContextOptions<ApplicationDbContext> options) : base(options)
        {

        }

        public DbSet<Category> Categories { get; set; }

        protected override void OnModelCreating(ModelBuilder modelBuilder)
        {
            modelBuilder.Entity<Category>().HasData(
                new Category { Id = 1, Name = "Action", DisPlayOrder = 1 },
                new Category { Id = 2, Name = "Humor", DisPlayOrder = 2 },
                new Category { Id = 3, Name = "Romatic", DisPlayOrder = 3 }
             );
        }
    }
}
