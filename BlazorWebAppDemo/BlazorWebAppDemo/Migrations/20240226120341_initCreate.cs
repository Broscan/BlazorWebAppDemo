using Microsoft.EntityFrameworkCore.Migrations;

#nullable disable

namespace BlazorWebAppDemo.Migrations
{
    /// <inheritdoc />
    public partial class initCreate : Migration
    {
        /// <inheritdoc />
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.CreateTable(
                name: "Hamburgers",
                columns: table => new
                {
                    Id = table.Column<int>(type: "int", nullable: false)
                        .Annotation("SqlServer:Identity", "1, 1"),
                    Name = table.Column<string>(type: "nvarchar(max)", nullable: false),
                    Description = table.Column<string>(type: "nvarchar(max)", nullable: false),
                    Price = table.Column<int>(type: "int", nullable: false),
                    ImageUrl = table.Column<string>(type: "nvarchar(max)", nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_Hamburgers", x => x.Id);
                });

            migrationBuilder.InsertData(
                table: "Hamburgers",
                columns: new[] { "Id", "Description", "ImageUrl", "Name", "Price" },
                values: new object[] { 1, "God som fan", "https://www.max.se/contentassets/c4bc7d0b2980409db9e40bb48906ce8a/68657_hemsida-produkt_friscobbqchipotle_beef-meny_c1_2024_1920x1787px_se_dk_no_pl.jpg?width=1160&sharpen=5&sigma=1,4&threshold=0", "Frisco", 99 });
        }

        /// <inheritdoc />
        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropTable(
                name: "Hamburgers");
        }
    }
}
