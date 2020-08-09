using Microsoft.EntityFrameworkCore.Migrations;

namespace Taxi.web.Migrations
{
    public partial class Crearindiceunicopatente : Migration
    {
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.CreateIndex(
                name: "IX_Taxis_Plaque",
                table: "Taxis",
                column: "Plaque",
                unique: true);
        }

        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropIndex(
                name: "IX_Taxis_Plaque",
                table: "Taxis");
        }
    }
}
