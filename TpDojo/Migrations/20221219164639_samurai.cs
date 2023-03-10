using Microsoft.EntityFrameworkCore.Migrations;

#nullable disable

namespace TpDojo.Migrations
{
    public partial class samurai : Migration
    {
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.CreateTable(
                name: "Samurai",
                columns: table => new
                {
                    Id = table.Column<int>(type: "int", nullable: false)
                        .Annotation("SqlServer:Identity", "1, 1"),
                    Nom = table.Column<string>(type: "nvarchar(max)", nullable: false),
                    Force = table.Column<int>(type: "int", nullable: false),
                    ArmeId = table.Column<int>(type: "int", nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_Samurai", x => x.Id);
                    table.ForeignKey(
                        name: "FK_Samurai_Arme_ArmeId",
                        column: x => x.ArmeId,
                        principalTable: "Arme",
                        principalColumn: "Id",
                        onDelete: ReferentialAction.Cascade);
                });

            migrationBuilder.CreateIndex(
                name: "IX_Samurai_ArmeId",
                table: "Samurai",
                column: "ArmeId");
        }

        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropTable(
                name: "Samurai");
        }
    }
}
