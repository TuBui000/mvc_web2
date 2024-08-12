using Microsoft.EntityFrameworkCore;
using Book_web2.Models;
using Microsoft.AspNetCore.Identity.EntityFrameworkCore;

namespace Book_web2.DataAccess.Data
{
    public class ApplicationContext : IdentityDbContext
    {
        public ApplicationContext(DbContextOptions<ApplicationContext> options) : base(options) 
        {

        } 

        public DbSet<Category> Categories { get; set; }
        public DbSet<Product> Products { get; set; }

        protected override void OnModelCreating(ModelBuilder modelBuilder)
        {

            base.OnModelCreating(modelBuilder);

            modelBuilder.Entity<Category>().HasData(
                new Category { Id = 1, Name = "Action", DisPlayOrder = 1 },
                new Category { Id = 2, Name = "Humor", DisPlayOrder = 2 },
                new Category { Id = 3, Name = "Romatic", DisPlayOrder = 3 }
             );

            modelBuilder.Entity<Product>().HasData(
                new Product
                {
                    Id = 1,
                    Title = "Fortune of Time",
                    Author = "Billy Spark",
                    Description = "Praesent vitae .................",
                    ISBN = "SWD9999001",
                    ListPrice = 99,
                    Price = 90,
                    Price50 = 85,
                    Price100 = 80,
                    CategoryId = 1,
                    ImgURL =""
                },

               new Product
               {
                   Id = 2,
                   Title = "Mystery of the East",
                   Author = "Samantha Wood",
                   Description = "Lorem ipsum dolor sit amet, consectetur adipiscing elit...",
                   ISBN = "SWD9999002",
                   ListPrice = 120,
                   Price = 110,
                   Price50 = 105,
                   Price100 = 100,
                   CategoryId = 1,
                   ImgURL = ""
               },

                new Product
                {
                    Id = 3,
                    Title = "Journey to the West",
                    Author = "Michael Johnson",
                    Description = "Suspendisse potenti. Nullam ac tortor vitae purus...",
                    ISBN = "SWD9999003",
                    ListPrice = 150,
                    Price = 140,
                    Price50 = 135,
                    Price100 = 130,
                    CategoryId = 2,
                    ImgURL = ""
                },

                new Product
                {
                    Id = 4,
                    Title = "Secrets of the North",
                    Author = "Isabella Clark",
                    Description = "Pellentesque habitant morbi tristique senectus...",
                    ISBN = "SWD9999004",
                    ListPrice = 80,
                    Price = 70,
                    Price50 = 65,
                    Price100 = 60,
                    CategoryId = 2,
                    ImgURL = ""
                },

                new Product
                {
                    Id = 5,
                    Title = "Legends of the South",
                    Author = "William Turner",
                    Description = "Etiam sit amet nisl purus in mollis nunc sed id...",
                    ISBN = "SWD9999005",
                    ListPrice = 95,
                    Price = 85,
                    Price50 = 80,
                    Price100 = 75,
                    CategoryId = 2,
                    ImgURL = ""
                },

                new Product
                {
                    Id = 6,
                    Title = "Whispers of the Wind",
                    Author = "Emily Davis",
                    Description = "Vestibulum ante ipsum primis in faucibus orci luctus...",
                    ISBN = "SWD9999006",
                    ListPrice = 110,
                    Price = 100,
                    Price50 = 95,
                    Price100 = 90,
                    CategoryId = 3,
                    ImgURL = ""
                }
            );
        }
    }

}
