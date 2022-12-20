using Microsoft.EntityFrameworkCore.Migrations;

#nullable disable

namespace TpDojo.Migrations
{
    public partial class cascadingtest3 : Migration
    {
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropForeignKey(
                name: "FK_Samurai_Arme_ArmeId",
                table: "Samurai");

            migrationBuilder.AddForeignKey(
                name: "FK_Samurai_Arme_ArmeId",
                table: "Samurai",
                column: "ArmeId",
                principalTable: "Arme",
                principalColumn: "Id",
                onDelete: ReferentialAction.SetNull);
        }

        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropForeignKey(
                name: "FK_Samurai_Arme_ArmeId",
                table: "Samurai");

            migrationBuilder.AddForeignKey(
                name: "FK_Samurai_Arme_ArmeId",
                table: "Samurai",
                column: "ArmeId",
                principalTable: "Arme",
                principalColumn: "Id");
        }
    }
}
