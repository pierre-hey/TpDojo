using Microsoft.EntityFrameworkCore.Migrations;

#nullable disable

namespace TpDojo.Migrations
{
    public partial class cascadingtest1 : Migration
    {
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropForeignKey(
                name: "FK_Samurai_Arme_ArmeId",
                table: "Samurai");

            migrationBuilder.AlterColumn<int>(
                name: "ArmeId",
                table: "Samurai",
                type: "int",
                nullable: true,
                oldClrType: typeof(int),
                oldType: "int");

            migrationBuilder.AddForeignKey(
                name: "FK_Samurai_Arme_ArmeId",
                table: "Samurai",
                column: "ArmeId",
                principalTable: "Arme",
                principalColumn: "Id");
        }

        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropForeignKey(
                name: "FK_Samurai_Arme_ArmeId",
                table: "Samurai");

            migrationBuilder.AlterColumn<int>(
                name: "ArmeId",
                table: "Samurai",
                type: "int",
                nullable: false,
                defaultValue: 0,
                oldClrType: typeof(int),
                oldType: "int",
                oldNullable: true);

            migrationBuilder.AddForeignKey(
                name: "FK_Samurai_Arme_ArmeId",
                table: "Samurai",
                column: "ArmeId",
                principalTable: "Arme",
                principalColumn: "Id",
                onDelete: ReferentialAction.Cascade);
        }
    }
}
