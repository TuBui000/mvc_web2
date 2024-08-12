using Microsoft.EntityFrameworkCore;
using Book_web2_razor_temp.Model;

namespace Book_web2_razor_temp.Data
{
    public class ApplicationContext : DbContext
    {
        public ApplicationContext(DbContextOptions<ApplicationContext> options) : base(options)
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
