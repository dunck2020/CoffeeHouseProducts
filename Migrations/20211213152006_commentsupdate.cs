using Microsoft.EntityFrameworkCore.Migrations;

namespace CoffeeHouseProducts.Migrations
{
    public partial class commentsupdate : Migration
    {
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.CreateTable(
                name: "Comments",
                columns: table => new
                {
                    Id = table.Column<int>(nullable: false)
                        .Annotation("SqlServer:Identity", "1, 1"),
                    Author = table.Column<string>(nullable: true),
                    Text = table.Column<string>(nullable: true)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_Comments", x => x.Id);
                });

            migrationBuilder.InsertData(
                table: "Comments",
                columns: new[] { "Id", "Author", "Text" },
                values: new object[] { 1, "Daniel Lo Nigro", "Hello ReactJS.NET World!" });

            migrationBuilder.InsertData(
                table: "Comments",
                columns: new[] { "Id", "Author", "Text" },
                values: new object[] { 2, "Pete Hunt", "This is one comment" });

            migrationBuilder.InsertData(
                table: "Comments",
                columns: new[] { "Id", "Author", "Text" },
                values: new object[] { 3, "Jordan Walke", "This is *another* comment" });
        }

        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropTable(
                name: "Comments");
        }
    }
}
