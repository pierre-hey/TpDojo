using Microsoft.EntityFrameworkCore.Migrations;

#nullable disable

namespace TpDojo.Migrations
{
    public partial class cascadingtest2 : Migration
    {
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropIndex(
                name: "IX_Samurai_ArmeId",
                table: "Samurai");

            migrationBuilder.CreateIndex(
                name: "IX_Samurai_ArmeId",
                table: "Samurai",
                column: "ArmeId",
                unique: true,
                filter: "[ArmeId] IS NOT NULL");
        }

        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropIndex(
                name: "IX_Samurai_ArmeId",
                table: "Samurai");

            migrationBuilder.CreateIndex(
                name: "IX_Samurai_ArmeId",
                table: "Samurai",
                column: "ArmeId");
        }
    }
}
