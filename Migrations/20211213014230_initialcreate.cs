using Microsoft.EntityFrameworkCore.Migrations;

namespace CoffeeHouseProducts.Migrations
{
    public partial class initialcreate : Migration
    {
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.CreateTable(
                name: "Products",
                columns: table => new
                {
                    Id = table.Column<int>(nullable: false)
                        .Annotation("SqlServer:Identity", "1, 1"),
                    Name = table.Column<string>(type: "nvarChar(100)", nullable: false),
                    Description = table.Column<string>(type: "nvarChar(200)", nullable: false),
                    Price = table.Column<decimal>(nullable: false),
                    Type = table.Column<int>(nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_Products", x => x.Id);
                });

            migrationBuilder.InsertData(
                table: "Products",
                columns: new[] { "Id", "Description", "Name", "Price", "Type" },
                values: new object[,]
                {
                    { 1, "Fresh brew from coffee house", "Lg Coffee", 3.00m, 0 },
                    { 2, "Fresh brew from BRC", "Md Coffee", 2.00m, 0 },
                    { 3, "Fresh brew from BRC", "Sm Coffee", 1.00m, 0 },
                    { 4, "Delicious suger glazed treat", "Blueberry Muffin", 2.00m, 1 },
                    { 5, "Soft Cotton-Blend", "Sm T-Shirt", 20.00m, 2 }
                });
        }

        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropTable(
                name: "Products");
        }
    }
}
