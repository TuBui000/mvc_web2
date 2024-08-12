using Microsoft.EntityFrameworkCore.Migrations;

#nullable disable

#pragma warning disable CA1814 // Prefer jagged arrays over multidimensional

namespace Book_web2.DataAccess.Migrations
{
    /// <inheritdoc />
    public partial class AddProductsToDb : Migration
    {
        /// <inheritdoc />
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.CreateTable(
                name: "Products",
                columns: table => new
                {
                    Id = table.Column<int>(type: "int", nullable: false)
                        .Annotation("SqlServer:Identity", "1, 1"),
                    Title = table.Column<string>(type: "nvarchar(max)", nullable: false),
                    Description = table.Column<string>(type: "nvarchar(max)", nullable: false),
                    ISBN = table.Column<string>(type: "nvarchar(max)", nullable: false),
                    Author = table.Column<string>(type: "nvarchar(max)", nullable: false),
                    ListPrice = table.Column<double>(type: "float", nullable: false),
                    Price = table.Column<double>(type: "float", nullable: false),
                    Price50 = table.Column<double>(type: "float", nullable: false),
                    Price100 = table.Column<double>(type: "float", nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_Products", x => x.Id);
                });

            migrationBuilder.InsertData(
                table: "Products",
                columns: new[] { "Id", "Author", "Description", "ISBN", "ListPrice", "Price", "Price100", "Price50", "Title" },
                values: new object[,]
                {
                    { 1, "Billy Spark", "Praesent vitae .................", "SWD9999001", 99.0, 90.0, 80.0, 85.0, "Fortune of Time" },
                    { 2, "Samantha Wood", "Lorem ipsum dolor sit amet, consectetur adipiscing elit...", "SWD9999002", 120.0, 110.0, 100.0, 105.0, "Mystery of the East" },
                    { 3, "Michael Johnson", "Suspendisse potenti. Nullam ac tortor vitae purus...", "SWD9999003", 150.0, 140.0, 130.0, 135.0, "Journey to the West" },
                    { 4, "Isabella Clark", "Pellentesque habitant morbi tristique senectus...", "SWD9999004", 80.0, 70.0, 60.0, 65.0, "Secrets of the North" },
                    { 5, "William Turner", "Etiam sit amet nisl purus in mollis nunc sed id...", "SWD9999005", 95.0, 85.0, 75.0, 80.0, "Legends of the South" },
                    { 6, "Emily Davis", "Vestibulum ante ipsum primis in faucibus orci luctus...", "SWD9999006", 110.0, 100.0, 90.0, 95.0, "Whispers of the Wind" }
                });
        }

        /// <inheritdoc />
        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropTable(
                name: "Products");
        }
    }
}
