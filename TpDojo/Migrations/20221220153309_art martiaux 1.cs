using Microsoft.EntityFrameworkCore.Migrations;

#nullable disable

namespace TpDojo.Migrations
{
    public partial class artmartiaux1 : Migration
    {
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropTable(
                name: "ArtMartialSamurai");

            migrationBuilder.CreateTable(
                name: "SamuraiArt",
                columns: table => new
                {
                    ArtMartiauxId = table.Column<int>(type: "int", nullable: false),
                    SamuraisId = table.Column<int>(type: "int", nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_SamuraiArt", x => new { x.ArtMartiauxId, x.SamuraisId });
                    table.ForeignKey(
                        name: "FK_SamuraiArt_ArtMartial_ArtMartiauxId",
                        column: x => x.ArtMartiauxId,
                        principalTable: "ArtMartial",
                        principalColumn: "Id",
                        onDelete: ReferentialAction.Cascade);
                    table.ForeignKey(
                        name: "FK_SamuraiArt_Samurai_SamuraisId",
                        column: x => x.SamuraisId,
                        principalTable: "Samurai",
                        principalColumn: "Id",
                        onDelete: ReferentialAction.Cascade);
                });

            migrationBuilder.UpdateData(
                table: "Samurai",
                keyColumn: "Id",
                keyValue: 1,
                column: "Force",
                value: 1326);

            migrationBuilder.UpdateData(
                table: "Samurai",
                keyColumn: "Id",
                keyValue: 2,
                column: "Force",
                value: 1424);

            migrationBuilder.UpdateData(
                table: "Samurai",
                keyColumn: "Id",
                keyValue: 3,
                column: "Force",
                value: 185);

            migrationBuilder.UpdateData(
                table: "Samurai",
                keyColumn: "Id",
                keyValue: 4,
                column: "Force",
                value: 254);

            migrationBuilder.UpdateData(
                table: "Samurai",
                keyColumn: "Id",
                keyValue: 5,
                column: "Force",
                value: 437);

            migrationBuilder.UpdateData(
                table: "Samurai",
                keyColumn: "Id",
                keyValue: 6,
                column: "Force",
                value: 1196);

            migrationBuilder.UpdateData(
                table: "Samurai",
                keyColumn: "Id",
                keyValue: 7,
                column: "Force",
                value: 823);

            migrationBuilder.UpdateData(
                table: "Samurai",
                keyColumn: "Id",
                keyValue: 8,
                column: "Force",
                value: 888);

            migrationBuilder.UpdateData(
                table: "Samurai",
                keyColumn: "Id",
                keyValue: 9,
                column: "Force",
                value: 1955);

            migrationBuilder.UpdateData(
                table: "Samurai",
                keyColumn: "Id",
                keyValue: 10,
                column: "Force",
                value: 931);

            migrationBuilder.UpdateData(
                table: "Samurai",
                keyColumn: "Id",
                keyValue: 11,
                column: "Force",
                value: 1431);

            migrationBuilder.UpdateData(
                table: "Samurai",
                keyColumn: "Id",
                keyValue: 12,
                column: "Force",
                value: 565);

            migrationBuilder.UpdateData(
                table: "Samurai",
                keyColumn: "Id",
                keyValue: 13,
                column: "Force",
                value: 1017);

            migrationBuilder.UpdateData(
                table: "Samurai",
                keyColumn: "Id",
                keyValue: 14,
                column: "Force",
                value: 1177);

            migrationBuilder.UpdateData(
                table: "Samurai",
                keyColumn: "Id",
                keyValue: 15,
                column: "Force",
                value: 535);

            migrationBuilder.UpdateData(
                table: "Samurai",
                keyColumn: "Id",
                keyValue: 16,
                column: "Force",
                value: 875);

            migrationBuilder.UpdateData(
                table: "Samurai",
                keyColumn: "Id",
                keyValue: 17,
                column: "Force",
                value: 1616);

            migrationBuilder.UpdateData(
                table: "Samurai",
                keyColumn: "Id",
                keyValue: 18,
                column: "Force",
                value: 1966);

            migrationBuilder.UpdateData(
                table: "Samurai",
                keyColumn: "Id",
                keyValue: 19,
                column: "Force",
                value: 1958);

            migrationBuilder.UpdateData(
                table: "Samurai",
                keyColumn: "Id",
                keyValue: 20,
                column: "Force",
                value: 1437);

            migrationBuilder.UpdateData(
                table: "Samurai",
                keyColumn: "Id",
                keyValue: 21,
                column: "Force",
                value: 1272);

            migrationBuilder.UpdateData(
                table: "Samurai",
                keyColumn: "Id",
                keyValue: 22,
                column: "Force",
                value: 152);

            migrationBuilder.UpdateData(
                table: "Samurai",
                keyColumn: "Id",
                keyValue: 23,
                column: "Force",
                value: 704);

            migrationBuilder.UpdateData(
                table: "Samurai",
                keyColumn: "Id",
                keyValue: 24,
                column: "Force",
                value: 1235);

            migrationBuilder.UpdateData(
                table: "Samurai",
                keyColumn: "Id",
                keyValue: 25,
                column: "Force",
                value: 1969);

            migrationBuilder.UpdateData(
                table: "Samurai",
                keyColumn: "Id",
                keyValue: 26,
                column: "Force",
                value: 1622);

            migrationBuilder.UpdateData(
                table: "Samurai",
                keyColumn: "Id",
                keyValue: 27,
                column: "Force",
                value: 1223);

            migrationBuilder.UpdateData(
                table: "Samurai",
                keyColumn: "Id",
                keyValue: 28,
                column: "Force",
                value: 1746);

            migrationBuilder.UpdateData(
                table: "Samurai",
                keyColumn: "Id",
                keyValue: 29,
                column: "Force",
                value: 635);

            migrationBuilder.UpdateData(
                table: "Samurai",
                keyColumn: "Id",
                keyValue: 30,
                column: "Force",
                value: 532);

            migrationBuilder.UpdateData(
                table: "Samurai",
                keyColumn: "Id",
                keyValue: 31,
                column: "Force",
                value: 1142);

            migrationBuilder.UpdateData(
                table: "Samurai",
                keyColumn: "Id",
                keyValue: 32,
                column: "Force",
                value: 1952);

            migrationBuilder.UpdateData(
                table: "Samurai",
                keyColumn: "Id",
                keyValue: 33,
                column: "Force",
                value: 1969);

            migrationBuilder.UpdateData(
                table: "Samurai",
                keyColumn: "Id",
                keyValue: 34,
                column: "Force",
                value: 1933);

            migrationBuilder.UpdateData(
                table: "Samurai",
                keyColumn: "Id",
                keyValue: 35,
                column: "Force",
                value: 1574);

            migrationBuilder.UpdateData(
                table: "Samurai",
                keyColumn: "Id",
                keyValue: 36,
                column: "Force",
                value: 272);

            migrationBuilder.UpdateData(
                table: "Samurai",
                keyColumn: "Id",
                keyValue: 37,
                column: "Force",
                value: 1568);

            migrationBuilder.UpdateData(
                table: "Samurai",
                keyColumn: "Id",
                keyValue: 38,
                column: "Force",
                value: 729);

            migrationBuilder.UpdateData(
                table: "Samurai",
                keyColumn: "Id",
                keyValue: 39,
                column: "Force",
                value: 1227);

            migrationBuilder.UpdateData(
                table: "Samurai",
                keyColumn: "Id",
                keyValue: 40,
                column: "Force",
                value: 1740);

            migrationBuilder.UpdateData(
                table: "Samurai",
                keyColumn: "Id",
                keyValue: 41,
                column: "Force",
                value: 1607);

            migrationBuilder.UpdateData(
                table: "Samurai",
                keyColumn: "Id",
                keyValue: 42,
                column: "Force",
                value: 878);

            migrationBuilder.UpdateData(
                table: "Samurai",
                keyColumn: "Id",
                keyValue: 43,
                column: "Force",
                value: 1204);

            migrationBuilder.UpdateData(
                table: "Samurai",
                keyColumn: "Id",
                keyValue: 44,
                column: "Force",
                value: 1050);

            migrationBuilder.UpdateData(
                table: "Samurai",
                keyColumn: "Id",
                keyValue: 45,
                column: "Force",
                value: 1064);

            migrationBuilder.UpdateData(
                table: "Samurai",
                keyColumn: "Id",
                keyValue: 46,
                column: "Force",
                value: 170);

            migrationBuilder.UpdateData(
                table: "Samurai",
                keyColumn: "Id",
                keyValue: 47,
                column: "Force",
                value: 311);

            migrationBuilder.UpdateData(
                table: "Samurai",
                keyColumn: "Id",
                keyValue: 48,
                column: "Force",
                value: 1906);

            migrationBuilder.UpdateData(
                table: "Samurai",
                keyColumn: "Id",
                keyValue: 49,
                column: "Force",
                value: 120);

            migrationBuilder.UpdateData(
                table: "Samurai",
                keyColumn: "Id",
                keyValue: 50,
                column: "Force",
                value: 1108);

            migrationBuilder.UpdateData(
                table: "Samurai",
                keyColumn: "Id",
                keyValue: 51,
                column: "Force",
                value: 198);

            migrationBuilder.UpdateData(
                table: "Samurai",
                keyColumn: "Id",
                keyValue: 52,
                column: "Force",
                value: 690);

            migrationBuilder.UpdateData(
                table: "Samurai",
                keyColumn: "Id",
                keyValue: 53,
                column: "Force",
                value: 1843);

            migrationBuilder.UpdateData(
                table: "Samurai",
                keyColumn: "Id",
                keyValue: 54,
                column: "Force",
                value: 653);

            migrationBuilder.UpdateData(
                table: "Samurai",
                keyColumn: "Id",
                keyValue: 55,
                column: "Force",
                value: 173);

            migrationBuilder.UpdateData(
                table: "Samurai",
                keyColumn: "Id",
                keyValue: 56,
                column: "Force",
                value: 1598);

            migrationBuilder.UpdateData(
                table: "Samurai",
                keyColumn: "Id",
                keyValue: 57,
                column: "Force",
                value: 221);

            migrationBuilder.UpdateData(
                table: "Samurai",
                keyColumn: "Id",
                keyValue: 58,
                column: "Force",
                value: 1204);

            migrationBuilder.UpdateData(
                table: "Samurai",
                keyColumn: "Id",
                keyValue: 59,
                column: "Force",
                value: 834);

            migrationBuilder.UpdateData(
                table: "Samurai",
                keyColumn: "Id",
                keyValue: 60,
                column: "Force",
                value: 1017);

            migrationBuilder.UpdateData(
                table: "Samurai",
                keyColumn: "Id",
                keyValue: 61,
                column: "Force",
                value: 837);

            migrationBuilder.UpdateData(
                table: "Samurai",
                keyColumn: "Id",
                keyValue: 62,
                column: "Force",
                value: 1696);

            migrationBuilder.UpdateData(
                table: "Samurai",
                keyColumn: "Id",
                keyValue: 63,
                column: "Force",
                value: 1739);

            migrationBuilder.UpdateData(
                table: "Samurai",
                keyColumn: "Id",
                keyValue: 64,
                column: "Force",
                value: 1801);

            migrationBuilder.UpdateData(
                table: "Samurai",
                keyColumn: "Id",
                keyValue: 65,
                column: "Force",
                value: 264);

            migrationBuilder.UpdateData(
                table: "Samurai",
                keyColumn: "Id",
                keyValue: 66,
                column: "Force",
                value: 1666);

            migrationBuilder.UpdateData(
                table: "Samurai",
                keyColumn: "Id",
                keyValue: 67,
                column: "Force",
                value: 220);

            migrationBuilder.UpdateData(
                table: "Samurai",
                keyColumn: "Id",
                keyValue: 68,
                column: "Force",
                value: 906);

            migrationBuilder.UpdateData(
                table: "Samurai",
                keyColumn: "Id",
                keyValue: 69,
                column: "Force",
                value: 140);

            migrationBuilder.UpdateData(
                table: "Samurai",
                keyColumn: "Id",
                keyValue: 70,
                column: "Force",
                value: 1730);

            migrationBuilder.UpdateData(
                table: "Samurai",
                keyColumn: "Id",
                keyValue: 71,
                column: "Force",
                value: 1638);

            migrationBuilder.UpdateData(
                table: "Samurai",
                keyColumn: "Id",
                keyValue: 72,
                column: "Force",
                value: 788);

            migrationBuilder.UpdateData(
                table: "Samurai",
                keyColumn: "Id",
                keyValue: 73,
                column: "Force",
                value: 166);

            migrationBuilder.UpdateData(
                table: "Samurai",
                keyColumn: "Id",
                keyValue: 74,
                column: "Force",
                value: 729);

            migrationBuilder.UpdateData(
                table: "Samurai",
                keyColumn: "Id",
                keyValue: 75,
                column: "Force",
                value: 496);

            migrationBuilder.UpdateData(
                table: "Samurai",
                keyColumn: "Id",
                keyValue: 76,
                column: "Force",
                value: 1042);

            migrationBuilder.UpdateData(
                table: "Samurai",
                keyColumn: "Id",
                keyValue: 77,
                column: "Force",
                value: 340);

            migrationBuilder.UpdateData(
                table: "Samurai",
                keyColumn: "Id",
                keyValue: 78,
                column: "Force",
                value: 1926);

            migrationBuilder.UpdateData(
                table: "Samurai",
                keyColumn: "Id",
                keyValue: 79,
                column: "Force",
                value: 48);

            migrationBuilder.UpdateData(
                table: "Samurai",
                keyColumn: "Id",
                keyValue: 80,
                column: "Force",
                value: 843);

            migrationBuilder.UpdateData(
                table: "Samurai",
                keyColumn: "Id",
                keyValue: 81,
                column: "Force",
                value: 891);

            migrationBuilder.UpdateData(
                table: "Samurai",
                keyColumn: "Id",
                keyValue: 82,
                column: "Force",
                value: 957);

            migrationBuilder.UpdateData(
                table: "Samurai",
                keyColumn: "Id",
                keyValue: 83,
                column: "Force",
                value: 1915);

            migrationBuilder.UpdateData(
                table: "Samurai",
                keyColumn: "Id",
                keyValue: 84,
                column: "Force",
                value: 42);

            migrationBuilder.UpdateData(
                table: "Samurai",
                keyColumn: "Id",
                keyValue: 85,
                column: "Force",
                value: 1559);

            migrationBuilder.UpdateData(
                table: "Samurai",
                keyColumn: "Id",
                keyValue: 86,
                column: "Force",
                value: 576);

            migrationBuilder.UpdateData(
                table: "Samurai",
                keyColumn: "Id",
                keyValue: 87,
                column: "Force",
                value: 1801);

            migrationBuilder.UpdateData(
                table: "Samurai",
                keyColumn: "Id",
                keyValue: 88,
                column: "Force",
                value: 645);

            migrationBuilder.UpdateData(
                table: "Samurai",
                keyColumn: "Id",
                keyValue: 89,
                column: "Force",
                value: 583);

            migrationBuilder.UpdateData(
                table: "Samurai",
                keyColumn: "Id",
                keyValue: 90,
                column: "Force",
                value: 1606);

            migrationBuilder.UpdateData(
                table: "Samurai",
                keyColumn: "Id",
                keyValue: 91,
                column: "Force",
                value: 1145);

            migrationBuilder.UpdateData(
                table: "Samurai",
                keyColumn: "Id",
                keyValue: 92,
                column: "Force",
                value: 1761);

            migrationBuilder.UpdateData(
                table: "Samurai",
                keyColumn: "Id",
                keyValue: 93,
                column: "Force",
                value: 1764);

            migrationBuilder.UpdateData(
                table: "Samurai",
                keyColumn: "Id",
                keyValue: 94,
                column: "Force",
                value: 1616);

            migrationBuilder.UpdateData(
                table: "Samurai",
                keyColumn: "Id",
                keyValue: 95,
                column: "Force",
                value: 1518);

            migrationBuilder.UpdateData(
                table: "Samurai",
                keyColumn: "Id",
                keyValue: 96,
                column: "Force",
                value: 1546);

            migrationBuilder.UpdateData(
                table: "Samurai",
                keyColumn: "Id",
                keyValue: 97,
                column: "Force",
                value: 147);

            migrationBuilder.UpdateData(
                table: "Samurai",
                keyColumn: "Id",
                keyValue: 98,
                column: "Force",
                value: 879);

            migrationBuilder.UpdateData(
                table: "Samurai",
                keyColumn: "Id",
                keyValue: 99,
                column: "Force",
                value: 1931);

            migrationBuilder.UpdateData(
                table: "Samurai",
                keyColumn: "Id",
                keyValue: 100,
                column: "Force",
                value: 322);

            migrationBuilder.UpdateData(
                table: "Samurai",
                keyColumn: "Id",
                keyValue: 101,
                column: "Force",
                value: 726);

            migrationBuilder.UpdateData(
                table: "Samurai",
                keyColumn: "Id",
                keyValue: 102,
                column: "Force",
                value: 426);

            migrationBuilder.UpdateData(
                table: "Samurai",
                keyColumn: "Id",
                keyValue: 103,
                column: "Force",
                value: 604);

            migrationBuilder.UpdateData(
                table: "Samurai",
                keyColumn: "Id",
                keyValue: 104,
                column: "Force",
                value: 66);

            migrationBuilder.UpdateData(
                table: "Samurai",
                keyColumn: "Id",
                keyValue: 105,
                column: "Force",
                value: 286);

            migrationBuilder.UpdateData(
                table: "Samurai",
                keyColumn: "Id",
                keyValue: 106,
                column: "Force",
                value: 206);

            migrationBuilder.UpdateData(
                table: "Samurai",
                keyColumn: "Id",
                keyValue: 107,
                column: "Force",
                value: 1173);

            migrationBuilder.UpdateData(
                table: "Samurai",
                keyColumn: "Id",
                keyValue: 108,
                column: "Force",
                value: 566);

            migrationBuilder.UpdateData(
                table: "Samurai",
                keyColumn: "Id",
                keyValue: 109,
                column: "Force",
                value: 1979);

            migrationBuilder.UpdateData(
                table: "Samurai",
                keyColumn: "Id",
                keyValue: 110,
                column: "Force",
                value: 653);

            migrationBuilder.UpdateData(
                table: "Samurai",
                keyColumn: "Id",
                keyValue: 111,
                column: "Force",
                value: 788);

            migrationBuilder.UpdateData(
                table: "Samurai",
                keyColumn: "Id",
                keyValue: 112,
                column: "Force",
                value: 338);

            migrationBuilder.UpdateData(
                table: "Samurai",
                keyColumn: "Id",
                keyValue: 113,
                column: "Force",
                value: 1146);

            migrationBuilder.UpdateData(
                table: "Samurai",
                keyColumn: "Id",
                keyValue: 114,
                column: "Force",
                value: 631);

            migrationBuilder.UpdateData(
                table: "Samurai",
                keyColumn: "Id",
                keyValue: 115,
                column: "Force",
                value: 1201);

            migrationBuilder.UpdateData(
                table: "Samurai",
                keyColumn: "Id",
                keyValue: 116,
                column: "Force",
                value: 1329);

            migrationBuilder.UpdateData(
                table: "Samurai",
                keyColumn: "Id",
                keyValue: 117,
                column: "Force",
                value: 1758);

            migrationBuilder.UpdateData(
                table: "Samurai",
                keyColumn: "Id",
                keyValue: 118,
                column: "Force",
                value: 1732);

            migrationBuilder.UpdateData(
                table: "Samurai",
                keyColumn: "Id",
                keyValue: 119,
                column: "Force",
                value: 349);

            migrationBuilder.UpdateData(
                table: "Samurai",
                keyColumn: "Id",
                keyValue: 120,
                column: "Force",
                value: 530);

            migrationBuilder.UpdateData(
                table: "Samurai",
                keyColumn: "Id",
                keyValue: 121,
                column: "Force",
                value: 1349);

            migrationBuilder.UpdateData(
                table: "Samurai",
                keyColumn: "Id",
                keyValue: 122,
                column: "Force",
                value: 707);

            migrationBuilder.UpdateData(
                table: "Samurai",
                keyColumn: "Id",
                keyValue: 123,
                column: "Force",
                value: 1689);

            migrationBuilder.UpdateData(
                table: "Samurai",
                keyColumn: "Id",
                keyValue: 124,
                column: "Force",
                value: 188);

            migrationBuilder.UpdateData(
                table: "Samurai",
                keyColumn: "Id",
                keyValue: 125,
                column: "Force",
                value: 1745);

            migrationBuilder.UpdateData(
                table: "Samurai",
                keyColumn: "Id",
                keyValue: 126,
                column: "Force",
                value: 1193);

            migrationBuilder.UpdateData(
                table: "Samurai",
                keyColumn: "Id",
                keyValue: 127,
                column: "Force",
                value: 77);

            migrationBuilder.UpdateData(
                table: "Samurai",
                keyColumn: "Id",
                keyValue: 128,
                column: "Force",
                value: 273);

            migrationBuilder.UpdateData(
                table: "Samurai",
                keyColumn: "Id",
                keyValue: 129,
                column: "Force",
                value: 510);

            migrationBuilder.UpdateData(
                table: "Samurai",
                keyColumn: "Id",
                keyValue: 130,
                column: "Force",
                value: 1118);

            migrationBuilder.UpdateData(
                table: "Samurai",
                keyColumn: "Id",
                keyValue: 131,
                column: "Force",
                value: 1466);

            migrationBuilder.UpdateData(
                table: "Samurai",
                keyColumn: "Id",
                keyValue: 132,
                column: "Force",
                value: 1250);

            migrationBuilder.UpdateData(
                table: "Samurai",
                keyColumn: "Id",
                keyValue: 133,
                column: "Force",
                value: 607);

            migrationBuilder.UpdateData(
                table: "Samurai",
                keyColumn: "Id",
                keyValue: 134,
                column: "Force",
                value: 851);

            migrationBuilder.UpdateData(
                table: "Samurai",
                keyColumn: "Id",
                keyValue: 135,
                column: "Force",
                value: 301);

            migrationBuilder.UpdateData(
                table: "Samurai",
                keyColumn: "Id",
                keyValue: 136,
                column: "Force",
                value: 1435);

            migrationBuilder.UpdateData(
                table: "Samurai",
                keyColumn: "Id",
                keyValue: 137,
                column: "Force",
                value: 1754);

            migrationBuilder.UpdateData(
                table: "Samurai",
                keyColumn: "Id",
                keyValue: 138,
                column: "Force",
                value: 1810);

            migrationBuilder.UpdateData(
                table: "Samurai",
                keyColumn: "Id",
                keyValue: 139,
                column: "Force",
                value: 526);

            migrationBuilder.UpdateData(
                table: "Samurai",
                keyColumn: "Id",
                keyValue: 140,
                column: "Force",
                value: 760);

            migrationBuilder.UpdateData(
                table: "Samurai",
                keyColumn: "Id",
                keyValue: 141,
                column: "Force",
                value: 840);

            migrationBuilder.UpdateData(
                table: "Samurai",
                keyColumn: "Id",
                keyValue: 142,
                column: "Force",
                value: 397);

            migrationBuilder.UpdateData(
                table: "Samurai",
                keyColumn: "Id",
                keyValue: 143,
                column: "Force",
                value: 1430);

            migrationBuilder.UpdateData(
                table: "Samurai",
                keyColumn: "Id",
                keyValue: 144,
                column: "Force",
                value: 1844);

            migrationBuilder.UpdateData(
                table: "Samurai",
                keyColumn: "Id",
                keyValue: 145,
                column: "Force",
                value: 1922);

            migrationBuilder.UpdateData(
                table: "Samurai",
                keyColumn: "Id",
                keyValue: 146,
                column: "Force",
                value: 1680);

            migrationBuilder.UpdateData(
                table: "Samurai",
                keyColumn: "Id",
                keyValue: 147,
                column: "Force",
                value: 1938);

            migrationBuilder.UpdateData(
                table: "Samurai",
                keyColumn: "Id",
                keyValue: 148,
                column: "Force",
                value: 1421);

            migrationBuilder.UpdateData(
                table: "Samurai",
                keyColumn: "Id",
                keyValue: 149,
                column: "Force",
                value: 1845);

            migrationBuilder.UpdateData(
                table: "Samurai",
                keyColumn: "Id",
                keyValue: 150,
                column: "Force",
                value: 1777);

            migrationBuilder.UpdateData(
                table: "Samurai",
                keyColumn: "Id",
                keyValue: 151,
                column: "Force",
                value: 1718);

            migrationBuilder.UpdateData(
                table: "Samurai",
                keyColumn: "Id",
                keyValue: 152,
                column: "Force",
                value: 1610);

            migrationBuilder.UpdateData(
                table: "Samurai",
                keyColumn: "Id",
                keyValue: 153,
                column: "Force",
                value: 1173);

            migrationBuilder.UpdateData(
                table: "Samurai",
                keyColumn: "Id",
                keyValue: 154,
                column: "Force",
                value: 1317);

            migrationBuilder.UpdateData(
                table: "Samurai",
                keyColumn: "Id",
                keyValue: 155,
                column: "Force",
                value: 719);

            migrationBuilder.UpdateData(
                table: "Samurai",
                keyColumn: "Id",
                keyValue: 156,
                column: "Force",
                value: 1320);

            migrationBuilder.UpdateData(
                table: "Samurai",
                keyColumn: "Id",
                keyValue: 157,
                column: "Force",
                value: 9);

            migrationBuilder.UpdateData(
                table: "Samurai",
                keyColumn: "Id",
                keyValue: 158,
                column: "Force",
                value: 1135);

            migrationBuilder.UpdateData(
                table: "Samurai",
                keyColumn: "Id",
                keyValue: 159,
                column: "Force",
                value: 1089);

            migrationBuilder.UpdateData(
                table: "Samurai",
                keyColumn: "Id",
                keyValue: 160,
                column: "Force",
                value: 172);

            migrationBuilder.UpdateData(
                table: "Samurai",
                keyColumn: "Id",
                keyValue: 161,
                column: "Force",
                value: 323);

            migrationBuilder.UpdateData(
                table: "Samurai",
                keyColumn: "Id",
                keyValue: 162,
                column: "Force",
                value: 562);

            migrationBuilder.UpdateData(
                table: "Samurai",
                keyColumn: "Id",
                keyValue: 163,
                column: "Force",
                value: 1168);

            migrationBuilder.UpdateData(
                table: "Samurai",
                keyColumn: "Id",
                keyValue: 164,
                column: "Force",
                value: 577);

            migrationBuilder.UpdateData(
                table: "Samurai",
                keyColumn: "Id",
                keyValue: 165,
                column: "Force",
                value: 176);

            migrationBuilder.UpdateData(
                table: "Samurai",
                keyColumn: "Id",
                keyValue: 166,
                column: "Force",
                value: 95);

            migrationBuilder.UpdateData(
                table: "Samurai",
                keyColumn: "Id",
                keyValue: 167,
                column: "Force",
                value: 455);

            migrationBuilder.UpdateData(
                table: "Samurai",
                keyColumn: "Id",
                keyValue: 168,
                column: "Force",
                value: 1384);

            migrationBuilder.UpdateData(
                table: "Samurai",
                keyColumn: "Id",
                keyValue: 169,
                column: "Force",
                value: 910);

            migrationBuilder.UpdateData(
                table: "Samurai",
                keyColumn: "Id",
                keyValue: 170,
                column: "Force",
                value: 552);

            migrationBuilder.UpdateData(
                table: "Samurai",
                keyColumn: "Id",
                keyValue: 171,
                column: "Force",
                value: 1265);

            migrationBuilder.UpdateData(
                table: "Samurai",
                keyColumn: "Id",
                keyValue: 172,
                column: "Force",
                value: 299);

            migrationBuilder.UpdateData(
                table: "Samurai",
                keyColumn: "Id",
                keyValue: 173,
                column: "Force",
                value: 1547);

            migrationBuilder.UpdateData(
                table: "Samurai",
                keyColumn: "Id",
                keyValue: 174,
                column: "Force",
                value: 1343);

            migrationBuilder.UpdateData(
                table: "Samurai",
                keyColumn: "Id",
                keyValue: 175,
                column: "Force",
                value: 599);

            migrationBuilder.UpdateData(
                table: "Samurai",
                keyColumn: "Id",
                keyValue: 176,
                column: "Force",
                value: 1155);

            migrationBuilder.UpdateData(
                table: "Samurai",
                keyColumn: "Id",
                keyValue: 177,
                column: "Force",
                value: 1609);

            migrationBuilder.UpdateData(
                table: "Samurai",
                keyColumn: "Id",
                keyValue: 178,
                column: "Force",
                value: 198);

            migrationBuilder.UpdateData(
                table: "Samurai",
                keyColumn: "Id",
                keyValue: 179,
                column: "Force",
                value: 759);

            migrationBuilder.UpdateData(
                table: "Samurai",
                keyColumn: "Id",
                keyValue: 180,
                column: "Force",
                value: 46);

            migrationBuilder.UpdateData(
                table: "Samurai",
                keyColumn: "Id",
                keyValue: 181,
                column: "Force",
                value: 101);

            migrationBuilder.UpdateData(
                table: "Samurai",
                keyColumn: "Id",
                keyValue: 182,
                column: "Force",
                value: 456);

            migrationBuilder.UpdateData(
                table: "Samurai",
                keyColumn: "Id",
                keyValue: 183,
                column: "Force",
                value: 440);

            migrationBuilder.UpdateData(
                table: "Samurai",
                keyColumn: "Id",
                keyValue: 184,
                column: "Force",
                value: 697);

            migrationBuilder.UpdateData(
                table: "Samurai",
                keyColumn: "Id",
                keyValue: 185,
                column: "Force",
                value: 474);

            migrationBuilder.UpdateData(
                table: "Samurai",
                keyColumn: "Id",
                keyValue: 186,
                column: "Force",
                value: 1307);

            migrationBuilder.UpdateData(
                table: "Samurai",
                keyColumn: "Id",
                keyValue: 187,
                column: "Force",
                value: 443);

            migrationBuilder.UpdateData(
                table: "Samurai",
                keyColumn: "Id",
                keyValue: 188,
                column: "Force",
                value: 750);

            migrationBuilder.UpdateData(
                table: "Samurai",
                keyColumn: "Id",
                keyValue: 189,
                column: "Force",
                value: 1859);

            migrationBuilder.UpdateData(
                table: "Samurai",
                keyColumn: "Id",
                keyValue: 190,
                column: "Force",
                value: 692);

            migrationBuilder.UpdateData(
                table: "Samurai",
                keyColumn: "Id",
                keyValue: 191,
                column: "Force",
                value: 1272);

            migrationBuilder.UpdateData(
                table: "Samurai",
                keyColumn: "Id",
                keyValue: 192,
                column: "Force",
                value: 1265);

            migrationBuilder.UpdateData(
                table: "Samurai",
                keyColumn: "Id",
                keyValue: 193,
                column: "Force",
                value: 240);

            migrationBuilder.UpdateData(
                table: "Samurai",
                keyColumn: "Id",
                keyValue: 194,
                column: "Force",
                value: 1298);

            migrationBuilder.UpdateData(
                table: "Samurai",
                keyColumn: "Id",
                keyValue: 195,
                column: "Force",
                value: 207);

            migrationBuilder.UpdateData(
                table: "Samurai",
                keyColumn: "Id",
                keyValue: 196,
                column: "Force",
                value: 170);

            migrationBuilder.UpdateData(
                table: "Samurai",
                keyColumn: "Id",
                keyValue: 197,
                column: "Force",
                value: 738);

            migrationBuilder.UpdateData(
                table: "Samurai",
                keyColumn: "Id",
                keyValue: 198,
                column: "Force",
                value: 1477);

            migrationBuilder.UpdateData(
                table: "Samurai",
                keyColumn: "Id",
                keyValue: 199,
                column: "Force",
                value: 1607);

            migrationBuilder.UpdateData(
                table: "Samurai",
                keyColumn: "Id",
                keyValue: 200,
                column: "Force",
                value: 14);

            migrationBuilder.UpdateData(
                table: "Samurai",
                keyColumn: "Id",
                keyValue: 201,
                column: "Force",
                value: 504);

            migrationBuilder.UpdateData(
                table: "Samurai",
                keyColumn: "Id",
                keyValue: 202,
                column: "Force",
                value: 1503);

            migrationBuilder.UpdateData(
                table: "Samurai",
                keyColumn: "Id",
                keyValue: 203,
                column: "Force",
                value: 485);

            migrationBuilder.UpdateData(
                table: "Samurai",
                keyColumn: "Id",
                keyValue: 204,
                column: "Force",
                value: 1332);

            migrationBuilder.UpdateData(
                table: "Samurai",
                keyColumn: "Id",
                keyValue: 205,
                column: "Force",
                value: 1794);

            migrationBuilder.UpdateData(
                table: "Samurai",
                keyColumn: "Id",
                keyValue: 206,
                column: "Force",
                value: 1651);

            migrationBuilder.UpdateData(
                table: "Samurai",
                keyColumn: "Id",
                keyValue: 207,
                column: "Force",
                value: 1598);

            migrationBuilder.UpdateData(
                table: "Samurai",
                keyColumn: "Id",
                keyValue: 208,
                column: "Force",
                value: 1149);

            migrationBuilder.UpdateData(
                table: "Samurai",
                keyColumn: "Id",
                keyValue: 209,
                column: "Force",
                value: 783);

            migrationBuilder.UpdateData(
                table: "Samurai",
                keyColumn: "Id",
                keyValue: 210,
                column: "Force",
                value: 837);

            migrationBuilder.UpdateData(
                table: "Samurai",
                keyColumn: "Id",
                keyValue: 211,
                column: "Force",
                value: 1119);

            migrationBuilder.UpdateData(
                table: "Samurai",
                keyColumn: "Id",
                keyValue: 212,
                column: "Force",
                value: 1962);

            migrationBuilder.UpdateData(
                table: "Samurai",
                keyColumn: "Id",
                keyValue: 213,
                column: "Force",
                value: 1816);

            migrationBuilder.UpdateData(
                table: "Samurai",
                keyColumn: "Id",
                keyValue: 214,
                column: "Force",
                value: 350);

            migrationBuilder.UpdateData(
                table: "Samurai",
                keyColumn: "Id",
                keyValue: 215,
                column: "Force",
                value: 760);

            migrationBuilder.UpdateData(
                table: "Samurai",
                keyColumn: "Id",
                keyValue: 216,
                column: "Force",
                value: 1703);

            migrationBuilder.UpdateData(
                table: "Samurai",
                keyColumn: "Id",
                keyValue: 217,
                column: "Force",
                value: 380);

            migrationBuilder.UpdateData(
                table: "Samurai",
                keyColumn: "Id",
                keyValue: 218,
                column: "Force",
                value: 166);

            migrationBuilder.UpdateData(
                table: "Samurai",
                keyColumn: "Id",
                keyValue: 219,
                column: "Force",
                value: 161);

            migrationBuilder.UpdateData(
                table: "Samurai",
                keyColumn: "Id",
                keyValue: 220,
                column: "Force",
                value: 1466);

            migrationBuilder.UpdateData(
                table: "Samurai",
                keyColumn: "Id",
                keyValue: 221,
                column: "Force",
                value: 1539);

            migrationBuilder.UpdateData(
                table: "Samurai",
                keyColumn: "Id",
                keyValue: 222,
                column: "Force",
                value: 737);

            migrationBuilder.UpdateData(
                table: "Samurai",
                keyColumn: "Id",
                keyValue: 223,
                column: "Force",
                value: 1920);

            migrationBuilder.UpdateData(
                table: "Samurai",
                keyColumn: "Id",
                keyValue: 224,
                column: "Force",
                value: 1553);

            migrationBuilder.UpdateData(
                table: "Samurai",
                keyColumn: "Id",
                keyValue: 225,
                column: "Force",
                value: 780);

            migrationBuilder.UpdateData(
                table: "Samurai",
                keyColumn: "Id",
                keyValue: 226,
                column: "Force",
                value: 363);

            migrationBuilder.UpdateData(
                table: "Samurai",
                keyColumn: "Id",
                keyValue: 227,
                column: "Force",
                value: 652);

            migrationBuilder.UpdateData(
                table: "Samurai",
                keyColumn: "Id",
                keyValue: 228,
                column: "Force",
                value: 184);

            migrationBuilder.UpdateData(
                table: "Samurai",
                keyColumn: "Id",
                keyValue: 229,
                column: "Force",
                value: 1722);

            migrationBuilder.UpdateData(
                table: "Samurai",
                keyColumn: "Id",
                keyValue: 230,
                column: "Force",
                value: 1747);

            migrationBuilder.UpdateData(
                table: "Samurai",
                keyColumn: "Id",
                keyValue: 231,
                column: "Force",
                value: 371);

            migrationBuilder.UpdateData(
                table: "Samurai",
                keyColumn: "Id",
                keyValue: 232,
                column: "Force",
                value: 589);

            migrationBuilder.UpdateData(
                table: "Samurai",
                keyColumn: "Id",
                keyValue: 233,
                column: "Force",
                value: 848);

            migrationBuilder.UpdateData(
                table: "Samurai",
                keyColumn: "Id",
                keyValue: 234,
                column: "Force",
                value: 1519);

            migrationBuilder.UpdateData(
                table: "Samurai",
                keyColumn: "Id",
                keyValue: 235,
                column: "Force",
                value: 150);

            migrationBuilder.UpdateData(
                table: "Samurai",
                keyColumn: "Id",
                keyValue: 236,
                column: "Force",
                value: 647);

            migrationBuilder.UpdateData(
                table: "Samurai",
                keyColumn: "Id",
                keyValue: 237,
                column: "Force",
                value: 103);

            migrationBuilder.UpdateData(
                table: "Samurai",
                keyColumn: "Id",
                keyValue: 238,
                column: "Force",
                value: 1109);

            migrationBuilder.UpdateData(
                table: "Samurai",
                keyColumn: "Id",
                keyValue: 239,
                column: "Force",
                value: 585);

            migrationBuilder.UpdateData(
                table: "Samurai",
                keyColumn: "Id",
                keyValue: 240,
                column: "Force",
                value: 1375);

            migrationBuilder.UpdateData(
                table: "Samurai",
                keyColumn: "Id",
                keyValue: 241,
                column: "Force",
                value: 1938);

            migrationBuilder.UpdateData(
                table: "Samurai",
                keyColumn: "Id",
                keyValue: 242,
                column: "Force",
                value: 1351);

            migrationBuilder.UpdateData(
                table: "Samurai",
                keyColumn: "Id",
                keyValue: 243,
                column: "Force",
                value: 1520);

            migrationBuilder.UpdateData(
                table: "Samurai",
                keyColumn: "Id",
                keyValue: 244,
                column: "Force",
                value: 321);

            migrationBuilder.UpdateData(
                table: "Samurai",
                keyColumn: "Id",
                keyValue: 245,
                column: "Force",
                value: 318);

            migrationBuilder.UpdateData(
                table: "Samurai",
                keyColumn: "Id",
                keyValue: 246,
                column: "Force",
                value: 708);

            migrationBuilder.UpdateData(
                table: "Samurai",
                keyColumn: "Id",
                keyValue: 247,
                column: "Force",
                value: 640);

            migrationBuilder.UpdateData(
                table: "Samurai",
                keyColumn: "Id",
                keyValue: 248,
                column: "Force",
                value: 826);

            migrationBuilder.UpdateData(
                table: "Samurai",
                keyColumn: "Id",
                keyValue: 249,
                column: "Force",
                value: 859);

            migrationBuilder.UpdateData(
                table: "Samurai",
                keyColumn: "Id",
                keyValue: 250,
                column: "Force",
                value: 1300);

            migrationBuilder.UpdateData(
                table: "Samurai",
                keyColumn: "Id",
                keyValue: 251,
                column: "Force",
                value: 801);

            migrationBuilder.UpdateData(
                table: "Samurai",
                keyColumn: "Id",
                keyValue: 252,
                column: "Force",
                value: 68);

            migrationBuilder.UpdateData(
                table: "Samurai",
                keyColumn: "Id",
                keyValue: 253,
                column: "Force",
                value: 2);

            migrationBuilder.UpdateData(
                table: "Samurai",
                keyColumn: "Id",
                keyValue: 254,
                column: "Force",
                value: 1884);

            migrationBuilder.UpdateData(
                table: "Samurai",
                keyColumn: "Id",
                keyValue: 255,
                column: "Force",
                value: 1484);

            migrationBuilder.UpdateData(
                table: "Samurai",
                keyColumn: "Id",
                keyValue: 256,
                column: "Force",
                value: 1781);

            migrationBuilder.UpdateData(
                table: "Samurai",
                keyColumn: "Id",
                keyValue: 257,
                column: "Force",
                value: 1206);

            migrationBuilder.UpdateData(
                table: "Samurai",
                keyColumn: "Id",
                keyValue: 258,
                column: "Force",
                value: 1713);

            migrationBuilder.UpdateData(
                table: "Samurai",
                keyColumn: "Id",
                keyValue: 259,
                column: "Force",
                value: 1364);

            migrationBuilder.UpdateData(
                table: "Samurai",
                keyColumn: "Id",
                keyValue: 260,
                column: "Force",
                value: 1357);

            migrationBuilder.UpdateData(
                table: "Samurai",
                keyColumn: "Id",
                keyValue: 261,
                column: "Force",
                value: 1111);

            migrationBuilder.UpdateData(
                table: "Samurai",
                keyColumn: "Id",
                keyValue: 262,
                column: "Force",
                value: 202);

            migrationBuilder.UpdateData(
                table: "Samurai",
                keyColumn: "Id",
                keyValue: 263,
                column: "Force",
                value: 1919);

            migrationBuilder.UpdateData(
                table: "Samurai",
                keyColumn: "Id",
                keyValue: 264,
                column: "Force",
                value: 852);

            migrationBuilder.UpdateData(
                table: "Samurai",
                keyColumn: "Id",
                keyValue: 265,
                column: "Force",
                value: 1973);

            migrationBuilder.UpdateData(
                table: "Samurai",
                keyColumn: "Id",
                keyValue: 266,
                column: "Force",
                value: 1642);

            migrationBuilder.UpdateData(
                table: "Samurai",
                keyColumn: "Id",
                keyValue: 267,
                column: "Force",
                value: 1017);

            migrationBuilder.UpdateData(
                table: "Samurai",
                keyColumn: "Id",
                keyValue: 268,
                column: "Force",
                value: 361);

            migrationBuilder.UpdateData(
                table: "Samurai",
                keyColumn: "Id",
                keyValue: 269,
                column: "Force",
                value: 1159);

            migrationBuilder.UpdateData(
                table: "Samurai",
                keyColumn: "Id",
                keyValue: 270,
                column: "Force",
                value: 1385);

            migrationBuilder.UpdateData(
                table: "Samurai",
                keyColumn: "Id",
                keyValue: 271,
                column: "Force",
                value: 1655);

            migrationBuilder.UpdateData(
                table: "Samurai",
                keyColumn: "Id",
                keyValue: 272,
                column: "Force",
                value: 844);

            migrationBuilder.UpdateData(
                table: "Samurai",
                keyColumn: "Id",
                keyValue: 273,
                column: "Force",
                value: 1474);

            migrationBuilder.UpdateData(
                table: "Samurai",
                keyColumn: "Id",
                keyValue: 274,
                column: "Force",
                value: 1787);

            migrationBuilder.UpdateData(
                table: "Samurai",
                keyColumn: "Id",
                keyValue: 275,
                column: "Force",
                value: 1820);

            migrationBuilder.UpdateData(
                table: "Samurai",
                keyColumn: "Id",
                keyValue: 276,
                column: "Force",
                value: 1715);

            migrationBuilder.UpdateData(
                table: "Samurai",
                keyColumn: "Id",
                keyValue: 277,
                column: "Force",
                value: 566);

            migrationBuilder.UpdateData(
                table: "Samurai",
                keyColumn: "Id",
                keyValue: 278,
                column: "Force",
                value: 552);

            migrationBuilder.UpdateData(
                table: "Samurai",
                keyColumn: "Id",
                keyValue: 279,
                column: "Force",
                value: 115);

            migrationBuilder.UpdateData(
                table: "Samurai",
                keyColumn: "Id",
                keyValue: 280,
                column: "Force",
                value: 1648);

            migrationBuilder.UpdateData(
                table: "Samurai",
                keyColumn: "Id",
                keyValue: 281,
                column: "Force",
                value: 1512);

            migrationBuilder.UpdateData(
                table: "Samurai",
                keyColumn: "Id",
                keyValue: 282,
                column: "Force",
                value: 929);

            migrationBuilder.UpdateData(
                table: "Samurai",
                keyColumn: "Id",
                keyValue: 283,
                column: "Force",
                value: 1799);

            migrationBuilder.UpdateData(
                table: "Samurai",
                keyColumn: "Id",
                keyValue: 284,
                column: "Force",
                value: 1298);

            migrationBuilder.UpdateData(
                table: "Samurai",
                keyColumn: "Id",
                keyValue: 285,
                column: "Force",
                value: 498);

            migrationBuilder.UpdateData(
                table: "Samurai",
                keyColumn: "Id",
                keyValue: 286,
                column: "Force",
                value: 8);

            migrationBuilder.UpdateData(
                table: "Samurai",
                keyColumn: "Id",
                keyValue: 287,
                column: "Force",
                value: 1894);

            migrationBuilder.UpdateData(
                table: "Samurai",
                keyColumn: "Id",
                keyValue: 288,
                column: "Force",
                value: 1844);

            migrationBuilder.UpdateData(
                table: "Samurai",
                keyColumn: "Id",
                keyValue: 289,
                column: "Force",
                value: 235);

            migrationBuilder.UpdateData(
                table: "Samurai",
                keyColumn: "Id",
                keyValue: 290,
                column: "Force",
                value: 691);

            migrationBuilder.UpdateData(
                table: "Samurai",
                keyColumn: "Id",
                keyValue: 291,
                column: "Force",
                value: 1544);

            migrationBuilder.UpdateData(
                table: "Samurai",
                keyColumn: "Id",
                keyValue: 292,
                column: "Force",
                value: 380);

            migrationBuilder.UpdateData(
                table: "Samurai",
                keyColumn: "Id",
                keyValue: 293,
                column: "Force",
                value: 1624);

            migrationBuilder.UpdateData(
                table: "Samurai",
                keyColumn: "Id",
                keyValue: 294,
                column: "Force",
                value: 732);

            migrationBuilder.UpdateData(
                table: "Samurai",
                keyColumn: "Id",
                keyValue: 295,
                column: "Force",
                value: 169);

            migrationBuilder.UpdateData(
                table: "Samurai",
                keyColumn: "Id",
                keyValue: 296,
                column: "Force",
                value: 527);

            migrationBuilder.UpdateData(
                table: "Samurai",
                keyColumn: "Id",
                keyValue: 297,
                column: "Force",
                value: 1369);

            migrationBuilder.UpdateData(
                table: "Samurai",
                keyColumn: "Id",
                keyValue: 298,
                column: "Force",
                value: 426);

            migrationBuilder.UpdateData(
                table: "Samurai",
                keyColumn: "Id",
                keyValue: 299,
                column: "Force",
                value: 1299);

            migrationBuilder.UpdateData(
                table: "Samurai",
                keyColumn: "Id",
                keyValue: 300,
                column: "Force",
                value: 1026);

            migrationBuilder.UpdateData(
                table: "Samurai",
                keyColumn: "Id",
                keyValue: 301,
                column: "Force",
                value: 308);

            migrationBuilder.UpdateData(
                table: "Samurai",
                keyColumn: "Id",
                keyValue: 302,
                column: "Force",
                value: 605);

            migrationBuilder.UpdateData(
                table: "Samurai",
                keyColumn: "Id",
                keyValue: 303,
                column: "Force",
                value: 546);

            migrationBuilder.UpdateData(
                table: "Samurai",
                keyColumn: "Id",
                keyValue: 304,
                column: "Force",
                value: 855);

            migrationBuilder.UpdateData(
                table: "Samurai",
                keyColumn: "Id",
                keyValue: 305,
                column: "Force",
                value: 1022);

            migrationBuilder.UpdateData(
                table: "Samurai",
                keyColumn: "Id",
                keyValue: 306,
                column: "Force",
                value: 1942);

            migrationBuilder.UpdateData(
                table: "Samurai",
                keyColumn: "Id",
                keyValue: 307,
                column: "Force",
                value: 581);

            migrationBuilder.UpdateData(
                table: "Samurai",
                keyColumn: "Id",
                keyValue: 308,
                column: "Force",
                value: 1392);

            migrationBuilder.UpdateData(
                table: "Samurai",
                keyColumn: "Id",
                keyValue: 309,
                column: "Force",
                value: 261);

            migrationBuilder.UpdateData(
                table: "Samurai",
                keyColumn: "Id",
                keyValue: 310,
                column: "Force",
                value: 465);

            migrationBuilder.UpdateData(
                table: "Samurai",
                keyColumn: "Id",
                keyValue: 311,
                column: "Force",
                value: 604);

            migrationBuilder.UpdateData(
                table: "Samurai",
                keyColumn: "Id",
                keyValue: 312,
                column: "Force",
                value: 944);

            migrationBuilder.UpdateData(
                table: "Samurai",
                keyColumn: "Id",
                keyValue: 313,
                column: "Force",
                value: 792);

            migrationBuilder.UpdateData(
                table: "Samurai",
                keyColumn: "Id",
                keyValue: 314,
                column: "Force",
                value: 38);

            migrationBuilder.UpdateData(
                table: "Samurai",
                keyColumn: "Id",
                keyValue: 315,
                column: "Force",
                value: 248);

            migrationBuilder.UpdateData(
                table: "Samurai",
                keyColumn: "Id",
                keyValue: 316,
                column: "Force",
                value: 298);

            migrationBuilder.UpdateData(
                table: "Samurai",
                keyColumn: "Id",
                keyValue: 317,
                column: "Force",
                value: 981);

            migrationBuilder.UpdateData(
                table: "Samurai",
                keyColumn: "Id",
                keyValue: 318,
                column: "Force",
                value: 808);

            migrationBuilder.UpdateData(
                table: "Samurai",
                keyColumn: "Id",
                keyValue: 319,
                column: "Force",
                value: 1508);

            migrationBuilder.UpdateData(
                table: "Samurai",
                keyColumn: "Id",
                keyValue: 320,
                column: "Force",
                value: 1496);

            migrationBuilder.CreateIndex(
                name: "IX_SamuraiArt_SamuraisId",
                table: "SamuraiArt",
                column: "SamuraisId");
        }

        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropTable(
                name: "SamuraiArt");

            migrationBuilder.CreateTable(
                name: "ArtMartialSamurai",
                columns: table => new
                {
                    ArtMartiauxId = table.Column<int>(type: "int", nullable: false),
                    SamuraisId = table.Column<int>(type: "int", nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_ArtMartialSamurai", x => new { x.ArtMartiauxId, x.SamuraisId });
                    table.ForeignKey(
                        name: "FK_ArtMartialSamurai_ArtMartial_ArtMartiauxId",
                        column: x => x.ArtMartiauxId,
                        principalTable: "ArtMartial",
                        principalColumn: "Id",
                        onDelete: ReferentialAction.Cascade);
                    table.ForeignKey(
                        name: "FK_ArtMartialSamurai_Samurai_SamuraisId",
                        column: x => x.SamuraisId,
                        principalTable: "Samurai",
                        principalColumn: "Id",
                        onDelete: ReferentialAction.Cascade);
                });

            migrationBuilder.UpdateData(
                table: "Samurai",
                keyColumn: "Id",
                keyValue: 1,
                column: "Force",
                value: 728);

            migrationBuilder.UpdateData(
                table: "Samurai",
                keyColumn: "Id",
                keyValue: 2,
                column: "Force",
                value: 698);

            migrationBuilder.UpdateData(
                table: "Samurai",
                keyColumn: "Id",
                keyValue: 3,
                column: "Force",
                value: 1035);

            migrationBuilder.UpdateData(
                table: "Samurai",
                keyColumn: "Id",
                keyValue: 4,
                column: "Force",
                value: 576);

            migrationBuilder.UpdateData(
                table: "Samurai",
                keyColumn: "Id",
                keyValue: 5,
                column: "Force",
                value: 1176);

            migrationBuilder.UpdateData(
                table: "Samurai",
                keyColumn: "Id",
                keyValue: 6,
                column: "Force",
                value: 394);

            migrationBuilder.UpdateData(
                table: "Samurai",
                keyColumn: "Id",
                keyValue: 7,
                column: "Force",
                value: 1156);

            migrationBuilder.UpdateData(
                table: "Samurai",
                keyColumn: "Id",
                keyValue: 8,
                column: "Force",
                value: 1349);

            migrationBuilder.UpdateData(
                table: "Samurai",
                keyColumn: "Id",
                keyValue: 9,
                column: "Force",
                value: 1920);

            migrationBuilder.UpdateData(
                table: "Samurai",
                keyColumn: "Id",
                keyValue: 10,
                column: "Force",
                value: 582);

            migrationBuilder.UpdateData(
                table: "Samurai",
                keyColumn: "Id",
                keyValue: 11,
                column: "Force",
                value: 1076);

            migrationBuilder.UpdateData(
                table: "Samurai",
                keyColumn: "Id",
                keyValue: 12,
                column: "Force",
                value: 353);

            migrationBuilder.UpdateData(
                table: "Samurai",
                keyColumn: "Id",
                keyValue: 13,
                column: "Force",
                value: 37);

            migrationBuilder.UpdateData(
                table: "Samurai",
                keyColumn: "Id",
                keyValue: 14,
                column: "Force",
                value: 1781);

            migrationBuilder.UpdateData(
                table: "Samurai",
                keyColumn: "Id",
                keyValue: 15,
                column: "Force",
                value: 397);

            migrationBuilder.UpdateData(
                table: "Samurai",
                keyColumn: "Id",
                keyValue: 16,
                column: "Force",
                value: 1367);

            migrationBuilder.UpdateData(
                table: "Samurai",
                keyColumn: "Id",
                keyValue: 17,
                column: "Force",
                value: 253);

            migrationBuilder.UpdateData(
                table: "Samurai",
                keyColumn: "Id",
                keyValue: 18,
                column: "Force",
                value: 287);

            migrationBuilder.UpdateData(
                table: "Samurai",
                keyColumn: "Id",
                keyValue: 19,
                column: "Force",
                value: 1022);

            migrationBuilder.UpdateData(
                table: "Samurai",
                keyColumn: "Id",
                keyValue: 20,
                column: "Force",
                value: 1640);

            migrationBuilder.UpdateData(
                table: "Samurai",
                keyColumn: "Id",
                keyValue: 21,
                column: "Force",
                value: 1337);

            migrationBuilder.UpdateData(
                table: "Samurai",
                keyColumn: "Id",
                keyValue: 22,
                column: "Force",
                value: 1731);

            migrationBuilder.UpdateData(
                table: "Samurai",
                keyColumn: "Id",
                keyValue: 23,
                column: "Force",
                value: 1265);

            migrationBuilder.UpdateData(
                table: "Samurai",
                keyColumn: "Id",
                keyValue: 24,
                column: "Force",
                value: 156);

            migrationBuilder.UpdateData(
                table: "Samurai",
                keyColumn: "Id",
                keyValue: 25,
                column: "Force",
                value: 46);

            migrationBuilder.UpdateData(
                table: "Samurai",
                keyColumn: "Id",
                keyValue: 26,
                column: "Force",
                value: 1259);

            migrationBuilder.UpdateData(
                table: "Samurai",
                keyColumn: "Id",
                keyValue: 27,
                column: "Force",
                value: 506);

            migrationBuilder.UpdateData(
                table: "Samurai",
                keyColumn: "Id",
                keyValue: 28,
                column: "Force",
                value: 951);

            migrationBuilder.UpdateData(
                table: "Samurai",
                keyColumn: "Id",
                keyValue: 29,
                column: "Force",
                value: 1664);

            migrationBuilder.UpdateData(
                table: "Samurai",
                keyColumn: "Id",
                keyValue: 30,
                column: "Force",
                value: 1396);

            migrationBuilder.UpdateData(
                table: "Samurai",
                keyColumn: "Id",
                keyValue: 31,
                column: "Force",
                value: 1711);

            migrationBuilder.UpdateData(
                table: "Samurai",
                keyColumn: "Id",
                keyValue: 32,
                column: "Force",
                value: 271);

            migrationBuilder.UpdateData(
                table: "Samurai",
                keyColumn: "Id",
                keyValue: 33,
                column: "Force",
                value: 637);

            migrationBuilder.UpdateData(
                table: "Samurai",
                keyColumn: "Id",
                keyValue: 34,
                column: "Force",
                value: 1079);

            migrationBuilder.UpdateData(
                table: "Samurai",
                keyColumn: "Id",
                keyValue: 35,
                column: "Force",
                value: 384);

            migrationBuilder.UpdateData(
                table: "Samurai",
                keyColumn: "Id",
                keyValue: 36,
                column: "Force",
                value: 689);

            migrationBuilder.UpdateData(
                table: "Samurai",
                keyColumn: "Id",
                keyValue: 37,
                column: "Force",
                value: 592);

            migrationBuilder.UpdateData(
                table: "Samurai",
                keyColumn: "Id",
                keyValue: 38,
                column: "Force",
                value: 1662);

            migrationBuilder.UpdateData(
                table: "Samurai",
                keyColumn: "Id",
                keyValue: 39,
                column: "Force",
                value: 270);

            migrationBuilder.UpdateData(
                table: "Samurai",
                keyColumn: "Id",
                keyValue: 40,
                column: "Force",
                value: 1765);

            migrationBuilder.UpdateData(
                table: "Samurai",
                keyColumn: "Id",
                keyValue: 41,
                column: "Force",
                value: 510);

            migrationBuilder.UpdateData(
                table: "Samurai",
                keyColumn: "Id",
                keyValue: 42,
                column: "Force",
                value: 232);

            migrationBuilder.UpdateData(
                table: "Samurai",
                keyColumn: "Id",
                keyValue: 43,
                column: "Force",
                value: 1163);

            migrationBuilder.UpdateData(
                table: "Samurai",
                keyColumn: "Id",
                keyValue: 44,
                column: "Force",
                value: 1935);

            migrationBuilder.UpdateData(
                table: "Samurai",
                keyColumn: "Id",
                keyValue: 45,
                column: "Force",
                value: 1876);

            migrationBuilder.UpdateData(
                table: "Samurai",
                keyColumn: "Id",
                keyValue: 46,
                column: "Force",
                value: 1455);

            migrationBuilder.UpdateData(
                table: "Samurai",
                keyColumn: "Id",
                keyValue: 47,
                column: "Force",
                value: 829);

            migrationBuilder.UpdateData(
                table: "Samurai",
                keyColumn: "Id",
                keyValue: 48,
                column: "Force",
                value: 1042);

            migrationBuilder.UpdateData(
                table: "Samurai",
                keyColumn: "Id",
                keyValue: 49,
                column: "Force",
                value: 775);

            migrationBuilder.UpdateData(
                table: "Samurai",
                keyColumn: "Id",
                keyValue: 50,
                column: "Force",
                value: 1938);

            migrationBuilder.UpdateData(
                table: "Samurai",
                keyColumn: "Id",
                keyValue: 51,
                column: "Force",
                value: 1391);

            migrationBuilder.UpdateData(
                table: "Samurai",
                keyColumn: "Id",
                keyValue: 52,
                column: "Force",
                value: 1911);

            migrationBuilder.UpdateData(
                table: "Samurai",
                keyColumn: "Id",
                keyValue: 53,
                column: "Force",
                value: 663);

            migrationBuilder.UpdateData(
                table: "Samurai",
                keyColumn: "Id",
                keyValue: 54,
                column: "Force",
                value: 1605);

            migrationBuilder.UpdateData(
                table: "Samurai",
                keyColumn: "Id",
                keyValue: 55,
                column: "Force",
                value: 355);

            migrationBuilder.UpdateData(
                table: "Samurai",
                keyColumn: "Id",
                keyValue: 56,
                column: "Force",
                value: 1929);

            migrationBuilder.UpdateData(
                table: "Samurai",
                keyColumn: "Id",
                keyValue: 57,
                column: "Force",
                value: 592);

            migrationBuilder.UpdateData(
                table: "Samurai",
                keyColumn: "Id",
                keyValue: 58,
                column: "Force",
                value: 1488);

            migrationBuilder.UpdateData(
                table: "Samurai",
                keyColumn: "Id",
                keyValue: 59,
                column: "Force",
                value: 755);

            migrationBuilder.UpdateData(
                table: "Samurai",
                keyColumn: "Id",
                keyValue: 60,
                column: "Force",
                value: 281);

            migrationBuilder.UpdateData(
                table: "Samurai",
                keyColumn: "Id",
                keyValue: 61,
                column: "Force",
                value: 100);

            migrationBuilder.UpdateData(
                table: "Samurai",
                keyColumn: "Id",
                keyValue: 62,
                column: "Force",
                value: 273);

            migrationBuilder.UpdateData(
                table: "Samurai",
                keyColumn: "Id",
                keyValue: 63,
                column: "Force",
                value: 1304);

            migrationBuilder.UpdateData(
                table: "Samurai",
                keyColumn: "Id",
                keyValue: 64,
                column: "Force",
                value: 639);

            migrationBuilder.UpdateData(
                table: "Samurai",
                keyColumn: "Id",
                keyValue: 65,
                column: "Force",
                value: 651);

            migrationBuilder.UpdateData(
                table: "Samurai",
                keyColumn: "Id",
                keyValue: 66,
                column: "Force",
                value: 1867);

            migrationBuilder.UpdateData(
                table: "Samurai",
                keyColumn: "Id",
                keyValue: 67,
                column: "Force",
                value: 483);

            migrationBuilder.UpdateData(
                table: "Samurai",
                keyColumn: "Id",
                keyValue: 68,
                column: "Force",
                value: 1345);

            migrationBuilder.UpdateData(
                table: "Samurai",
                keyColumn: "Id",
                keyValue: 69,
                column: "Force",
                value: 54);

            migrationBuilder.UpdateData(
                table: "Samurai",
                keyColumn: "Id",
                keyValue: 70,
                column: "Force",
                value: 1710);

            migrationBuilder.UpdateData(
                table: "Samurai",
                keyColumn: "Id",
                keyValue: 71,
                column: "Force",
                value: 199);

            migrationBuilder.UpdateData(
                table: "Samurai",
                keyColumn: "Id",
                keyValue: 72,
                column: "Force",
                value: 921);

            migrationBuilder.UpdateData(
                table: "Samurai",
                keyColumn: "Id",
                keyValue: 73,
                column: "Force",
                value: 1924);

            migrationBuilder.UpdateData(
                table: "Samurai",
                keyColumn: "Id",
                keyValue: 74,
                column: "Force",
                value: 561);

            migrationBuilder.UpdateData(
                table: "Samurai",
                keyColumn: "Id",
                keyValue: 75,
                column: "Force",
                value: 590);

            migrationBuilder.UpdateData(
                table: "Samurai",
                keyColumn: "Id",
                keyValue: 76,
                column: "Force",
                value: 758);

            migrationBuilder.UpdateData(
                table: "Samurai",
                keyColumn: "Id",
                keyValue: 77,
                column: "Force",
                value: 1813);

            migrationBuilder.UpdateData(
                table: "Samurai",
                keyColumn: "Id",
                keyValue: 78,
                column: "Force",
                value: 1998);

            migrationBuilder.UpdateData(
                table: "Samurai",
                keyColumn: "Id",
                keyValue: 79,
                column: "Force",
                value: 1148);

            migrationBuilder.UpdateData(
                table: "Samurai",
                keyColumn: "Id",
                keyValue: 80,
                column: "Force",
                value: 399);

            migrationBuilder.UpdateData(
                table: "Samurai",
                keyColumn: "Id",
                keyValue: 81,
                column: "Force",
                value: 1619);

            migrationBuilder.UpdateData(
                table: "Samurai",
                keyColumn: "Id",
                keyValue: 82,
                column: "Force",
                value: 1421);

            migrationBuilder.UpdateData(
                table: "Samurai",
                keyColumn: "Id",
                keyValue: 83,
                column: "Force",
                value: 173);

            migrationBuilder.UpdateData(
                table: "Samurai",
                keyColumn: "Id",
                keyValue: 84,
                column: "Force",
                value: 1468);

            migrationBuilder.UpdateData(
                table: "Samurai",
                keyColumn: "Id",
                keyValue: 85,
                column: "Force",
                value: 982);

            migrationBuilder.UpdateData(
                table: "Samurai",
                keyColumn: "Id",
                keyValue: 86,
                column: "Force",
                value: 430);

            migrationBuilder.UpdateData(
                table: "Samurai",
                keyColumn: "Id",
                keyValue: 87,
                column: "Force",
                value: 734);

            migrationBuilder.UpdateData(
                table: "Samurai",
                keyColumn: "Id",
                keyValue: 88,
                column: "Force",
                value: 811);

            migrationBuilder.UpdateData(
                table: "Samurai",
                keyColumn: "Id",
                keyValue: 89,
                column: "Force",
                value: 91);

            migrationBuilder.UpdateData(
                table: "Samurai",
                keyColumn: "Id",
                keyValue: 90,
                column: "Force",
                value: 1903);

            migrationBuilder.UpdateData(
                table: "Samurai",
                keyColumn: "Id",
                keyValue: 91,
                column: "Force",
                value: 889);

            migrationBuilder.UpdateData(
                table: "Samurai",
                keyColumn: "Id",
                keyValue: 92,
                column: "Force",
                value: 1580);

            migrationBuilder.UpdateData(
                table: "Samurai",
                keyColumn: "Id",
                keyValue: 93,
                column: "Force",
                value: 459);

            migrationBuilder.UpdateData(
                table: "Samurai",
                keyColumn: "Id",
                keyValue: 94,
                column: "Force",
                value: 763);

            migrationBuilder.UpdateData(
                table: "Samurai",
                keyColumn: "Id",
                keyValue: 95,
                column: "Force",
                value: 1051);

            migrationBuilder.UpdateData(
                table: "Samurai",
                keyColumn: "Id",
                keyValue: 96,
                column: "Force",
                value: 1108);

            migrationBuilder.UpdateData(
                table: "Samurai",
                keyColumn: "Id",
                keyValue: 97,
                column: "Force",
                value: 1768);

            migrationBuilder.UpdateData(
                table: "Samurai",
                keyColumn: "Id",
                keyValue: 98,
                column: "Force",
                value: 1261);

            migrationBuilder.UpdateData(
                table: "Samurai",
                keyColumn: "Id",
                keyValue: 99,
                column: "Force",
                value: 1412);

            migrationBuilder.UpdateData(
                table: "Samurai",
                keyColumn: "Id",
                keyValue: 100,
                column: "Force",
                value: 735);

            migrationBuilder.UpdateData(
                table: "Samurai",
                keyColumn: "Id",
                keyValue: 101,
                column: "Force",
                value: 1477);

            migrationBuilder.UpdateData(
                table: "Samurai",
                keyColumn: "Id",
                keyValue: 102,
                column: "Force",
                value: 1595);

            migrationBuilder.UpdateData(
                table: "Samurai",
                keyColumn: "Id",
                keyValue: 103,
                column: "Force",
                value: 772);

            migrationBuilder.UpdateData(
                table: "Samurai",
                keyColumn: "Id",
                keyValue: 104,
                column: "Force",
                value: 1557);

            migrationBuilder.UpdateData(
                table: "Samurai",
                keyColumn: "Id",
                keyValue: 105,
                column: "Force",
                value: 173);

            migrationBuilder.UpdateData(
                table: "Samurai",
                keyColumn: "Id",
                keyValue: 106,
                column: "Force",
                value: 1790);

            migrationBuilder.UpdateData(
                table: "Samurai",
                keyColumn: "Id",
                keyValue: 107,
                column: "Force",
                value: 661);

            migrationBuilder.UpdateData(
                table: "Samurai",
                keyColumn: "Id",
                keyValue: 108,
                column: "Force",
                value: 1040);

            migrationBuilder.UpdateData(
                table: "Samurai",
                keyColumn: "Id",
                keyValue: 109,
                column: "Force",
                value: 665);

            migrationBuilder.UpdateData(
                table: "Samurai",
                keyColumn: "Id",
                keyValue: 110,
                column: "Force",
                value: 1659);

            migrationBuilder.UpdateData(
                table: "Samurai",
                keyColumn: "Id",
                keyValue: 111,
                column: "Force",
                value: 127);

            migrationBuilder.UpdateData(
                table: "Samurai",
                keyColumn: "Id",
                keyValue: 112,
                column: "Force",
                value: 636);

            migrationBuilder.UpdateData(
                table: "Samurai",
                keyColumn: "Id",
                keyValue: 113,
                column: "Force",
                value: 1244);

            migrationBuilder.UpdateData(
                table: "Samurai",
                keyColumn: "Id",
                keyValue: 114,
                column: "Force",
                value: 625);

            migrationBuilder.UpdateData(
                table: "Samurai",
                keyColumn: "Id",
                keyValue: 115,
                column: "Force",
                value: 1100);

            migrationBuilder.UpdateData(
                table: "Samurai",
                keyColumn: "Id",
                keyValue: 116,
                column: "Force",
                value: 1669);

            migrationBuilder.UpdateData(
                table: "Samurai",
                keyColumn: "Id",
                keyValue: 117,
                column: "Force",
                value: 512);

            migrationBuilder.UpdateData(
                table: "Samurai",
                keyColumn: "Id",
                keyValue: 118,
                column: "Force",
                value: 1602);

            migrationBuilder.UpdateData(
                table: "Samurai",
                keyColumn: "Id",
                keyValue: 119,
                column: "Force",
                value: 628);

            migrationBuilder.UpdateData(
                table: "Samurai",
                keyColumn: "Id",
                keyValue: 120,
                column: "Force",
                value: 702);

            migrationBuilder.UpdateData(
                table: "Samurai",
                keyColumn: "Id",
                keyValue: 121,
                column: "Force",
                value: 2);

            migrationBuilder.UpdateData(
                table: "Samurai",
                keyColumn: "Id",
                keyValue: 122,
                column: "Force",
                value: 441);

            migrationBuilder.UpdateData(
                table: "Samurai",
                keyColumn: "Id",
                keyValue: 123,
                column: "Force",
                value: 1225);

            migrationBuilder.UpdateData(
                table: "Samurai",
                keyColumn: "Id",
                keyValue: 124,
                column: "Force",
                value: 1528);

            migrationBuilder.UpdateData(
                table: "Samurai",
                keyColumn: "Id",
                keyValue: 125,
                column: "Force",
                value: 1829);

            migrationBuilder.UpdateData(
                table: "Samurai",
                keyColumn: "Id",
                keyValue: 126,
                column: "Force",
                value: 200);

            migrationBuilder.UpdateData(
                table: "Samurai",
                keyColumn: "Id",
                keyValue: 127,
                column: "Force",
                value: 680);

            migrationBuilder.UpdateData(
                table: "Samurai",
                keyColumn: "Id",
                keyValue: 128,
                column: "Force",
                value: 334);

            migrationBuilder.UpdateData(
                table: "Samurai",
                keyColumn: "Id",
                keyValue: 129,
                column: "Force",
                value: 1732);

            migrationBuilder.UpdateData(
                table: "Samurai",
                keyColumn: "Id",
                keyValue: 130,
                column: "Force",
                value: 1206);

            migrationBuilder.UpdateData(
                table: "Samurai",
                keyColumn: "Id",
                keyValue: 131,
                column: "Force",
                value: 1989);

            migrationBuilder.UpdateData(
                table: "Samurai",
                keyColumn: "Id",
                keyValue: 132,
                column: "Force",
                value: 281);

            migrationBuilder.UpdateData(
                table: "Samurai",
                keyColumn: "Id",
                keyValue: 133,
                column: "Force",
                value: 195);

            migrationBuilder.UpdateData(
                table: "Samurai",
                keyColumn: "Id",
                keyValue: 134,
                column: "Force",
                value: 982);

            migrationBuilder.UpdateData(
                table: "Samurai",
                keyColumn: "Id",
                keyValue: 135,
                column: "Force",
                value: 876);

            migrationBuilder.UpdateData(
                table: "Samurai",
                keyColumn: "Id",
                keyValue: 136,
                column: "Force",
                value: 1355);

            migrationBuilder.UpdateData(
                table: "Samurai",
                keyColumn: "Id",
                keyValue: 137,
                column: "Force",
                value: 1154);

            migrationBuilder.UpdateData(
                table: "Samurai",
                keyColumn: "Id",
                keyValue: 138,
                column: "Force",
                value: 1274);

            migrationBuilder.UpdateData(
                table: "Samurai",
                keyColumn: "Id",
                keyValue: 139,
                column: "Force",
                value: 1540);

            migrationBuilder.UpdateData(
                table: "Samurai",
                keyColumn: "Id",
                keyValue: 140,
                column: "Force",
                value: 801);

            migrationBuilder.UpdateData(
                table: "Samurai",
                keyColumn: "Id",
                keyValue: 141,
                column: "Force",
                value: 1420);

            migrationBuilder.UpdateData(
                table: "Samurai",
                keyColumn: "Id",
                keyValue: 142,
                column: "Force",
                value: 1643);

            migrationBuilder.UpdateData(
                table: "Samurai",
                keyColumn: "Id",
                keyValue: 143,
                column: "Force",
                value: 1071);

            migrationBuilder.UpdateData(
                table: "Samurai",
                keyColumn: "Id",
                keyValue: 144,
                column: "Force",
                value: 441);

            migrationBuilder.UpdateData(
                table: "Samurai",
                keyColumn: "Id",
                keyValue: 145,
                column: "Force",
                value: 14);

            migrationBuilder.UpdateData(
                table: "Samurai",
                keyColumn: "Id",
                keyValue: 146,
                column: "Force",
                value: 1219);

            migrationBuilder.UpdateData(
                table: "Samurai",
                keyColumn: "Id",
                keyValue: 147,
                column: "Force",
                value: 151);

            migrationBuilder.UpdateData(
                table: "Samurai",
                keyColumn: "Id",
                keyValue: 148,
                column: "Force",
                value: 1303);

            migrationBuilder.UpdateData(
                table: "Samurai",
                keyColumn: "Id",
                keyValue: 149,
                column: "Force",
                value: 876);

            migrationBuilder.UpdateData(
                table: "Samurai",
                keyColumn: "Id",
                keyValue: 150,
                column: "Force",
                value: 637);

            migrationBuilder.UpdateData(
                table: "Samurai",
                keyColumn: "Id",
                keyValue: 151,
                column: "Force",
                value: 657);

            migrationBuilder.UpdateData(
                table: "Samurai",
                keyColumn: "Id",
                keyValue: 152,
                column: "Force",
                value: 1354);

            migrationBuilder.UpdateData(
                table: "Samurai",
                keyColumn: "Id",
                keyValue: 153,
                column: "Force",
                value: 651);

            migrationBuilder.UpdateData(
                table: "Samurai",
                keyColumn: "Id",
                keyValue: 154,
                column: "Force",
                value: 1178);

            migrationBuilder.UpdateData(
                table: "Samurai",
                keyColumn: "Id",
                keyValue: 155,
                column: "Force",
                value: 951);

            migrationBuilder.UpdateData(
                table: "Samurai",
                keyColumn: "Id",
                keyValue: 156,
                column: "Force",
                value: 1726);

            migrationBuilder.UpdateData(
                table: "Samurai",
                keyColumn: "Id",
                keyValue: 157,
                column: "Force",
                value: 292);

            migrationBuilder.UpdateData(
                table: "Samurai",
                keyColumn: "Id",
                keyValue: 158,
                column: "Force",
                value: 1022);

            migrationBuilder.UpdateData(
                table: "Samurai",
                keyColumn: "Id",
                keyValue: 159,
                column: "Force",
                value: 1539);

            migrationBuilder.UpdateData(
                table: "Samurai",
                keyColumn: "Id",
                keyValue: 160,
                column: "Force",
                value: 350);

            migrationBuilder.UpdateData(
                table: "Samurai",
                keyColumn: "Id",
                keyValue: 161,
                column: "Force",
                value: 1267);

            migrationBuilder.UpdateData(
                table: "Samurai",
                keyColumn: "Id",
                keyValue: 162,
                column: "Force",
                value: 1218);

            migrationBuilder.UpdateData(
                table: "Samurai",
                keyColumn: "Id",
                keyValue: 163,
                column: "Force",
                value: 898);

            migrationBuilder.UpdateData(
                table: "Samurai",
                keyColumn: "Id",
                keyValue: 164,
                column: "Force",
                value: 1484);

            migrationBuilder.UpdateData(
                table: "Samurai",
                keyColumn: "Id",
                keyValue: 165,
                column: "Force",
                value: 428);

            migrationBuilder.UpdateData(
                table: "Samurai",
                keyColumn: "Id",
                keyValue: 166,
                column: "Force",
                value: 800);

            migrationBuilder.UpdateData(
                table: "Samurai",
                keyColumn: "Id",
                keyValue: 167,
                column: "Force",
                value: 675);

            migrationBuilder.UpdateData(
                table: "Samurai",
                keyColumn: "Id",
                keyValue: 168,
                column: "Force",
                value: 19);

            migrationBuilder.UpdateData(
                table: "Samurai",
                keyColumn: "Id",
                keyValue: 169,
                column: "Force",
                value: 1519);

            migrationBuilder.UpdateData(
                table: "Samurai",
                keyColumn: "Id",
                keyValue: 170,
                column: "Force",
                value: 362);

            migrationBuilder.UpdateData(
                table: "Samurai",
                keyColumn: "Id",
                keyValue: 171,
                column: "Force",
                value: 1781);

            migrationBuilder.UpdateData(
                table: "Samurai",
                keyColumn: "Id",
                keyValue: 172,
                column: "Force",
                value: 243);

            migrationBuilder.UpdateData(
                table: "Samurai",
                keyColumn: "Id",
                keyValue: 173,
                column: "Force",
                value: 909);

            migrationBuilder.UpdateData(
                table: "Samurai",
                keyColumn: "Id",
                keyValue: 174,
                column: "Force",
                value: 1468);

            migrationBuilder.UpdateData(
                table: "Samurai",
                keyColumn: "Id",
                keyValue: 175,
                column: "Force",
                value: 1111);

            migrationBuilder.UpdateData(
                table: "Samurai",
                keyColumn: "Id",
                keyValue: 176,
                column: "Force",
                value: 1332);

            migrationBuilder.UpdateData(
                table: "Samurai",
                keyColumn: "Id",
                keyValue: 177,
                column: "Force",
                value: 1150);

            migrationBuilder.UpdateData(
                table: "Samurai",
                keyColumn: "Id",
                keyValue: 178,
                column: "Force",
                value: 1185);

            migrationBuilder.UpdateData(
                table: "Samurai",
                keyColumn: "Id",
                keyValue: 179,
                column: "Force",
                value: 1268);

            migrationBuilder.UpdateData(
                table: "Samurai",
                keyColumn: "Id",
                keyValue: 180,
                column: "Force",
                value: 1090);

            migrationBuilder.UpdateData(
                table: "Samurai",
                keyColumn: "Id",
                keyValue: 181,
                column: "Force",
                value: 832);

            migrationBuilder.UpdateData(
                table: "Samurai",
                keyColumn: "Id",
                keyValue: 182,
                column: "Force",
                value: 172);

            migrationBuilder.UpdateData(
                table: "Samurai",
                keyColumn: "Id",
                keyValue: 183,
                column: "Force",
                value: 220);

            migrationBuilder.UpdateData(
                table: "Samurai",
                keyColumn: "Id",
                keyValue: 184,
                column: "Force",
                value: 172);

            migrationBuilder.UpdateData(
                table: "Samurai",
                keyColumn: "Id",
                keyValue: 185,
                column: "Force",
                value: 1812);

            migrationBuilder.UpdateData(
                table: "Samurai",
                keyColumn: "Id",
                keyValue: 186,
                column: "Force",
                value: 1912);

            migrationBuilder.UpdateData(
                table: "Samurai",
                keyColumn: "Id",
                keyValue: 187,
                column: "Force",
                value: 1724);

            migrationBuilder.UpdateData(
                table: "Samurai",
                keyColumn: "Id",
                keyValue: 188,
                column: "Force",
                value: 1359);

            migrationBuilder.UpdateData(
                table: "Samurai",
                keyColumn: "Id",
                keyValue: 189,
                column: "Force",
                value: 1141);

            migrationBuilder.UpdateData(
                table: "Samurai",
                keyColumn: "Id",
                keyValue: 190,
                column: "Force",
                value: 782);

            migrationBuilder.UpdateData(
                table: "Samurai",
                keyColumn: "Id",
                keyValue: 191,
                column: "Force",
                value: 380);

            migrationBuilder.UpdateData(
                table: "Samurai",
                keyColumn: "Id",
                keyValue: 192,
                column: "Force",
                value: 1148);

            migrationBuilder.UpdateData(
                table: "Samurai",
                keyColumn: "Id",
                keyValue: 193,
                column: "Force",
                value: 738);

            migrationBuilder.UpdateData(
                table: "Samurai",
                keyColumn: "Id",
                keyValue: 194,
                column: "Force",
                value: 772);

            migrationBuilder.UpdateData(
                table: "Samurai",
                keyColumn: "Id",
                keyValue: 195,
                column: "Force",
                value: 1326);

            migrationBuilder.UpdateData(
                table: "Samurai",
                keyColumn: "Id",
                keyValue: 196,
                column: "Force",
                value: 1692);

            migrationBuilder.UpdateData(
                table: "Samurai",
                keyColumn: "Id",
                keyValue: 197,
                column: "Force",
                value: 1332);

            migrationBuilder.UpdateData(
                table: "Samurai",
                keyColumn: "Id",
                keyValue: 198,
                column: "Force",
                value: 1420);

            migrationBuilder.UpdateData(
                table: "Samurai",
                keyColumn: "Id",
                keyValue: 199,
                column: "Force",
                value: 1239);

            migrationBuilder.UpdateData(
                table: "Samurai",
                keyColumn: "Id",
                keyValue: 200,
                column: "Force",
                value: 105);

            migrationBuilder.UpdateData(
                table: "Samurai",
                keyColumn: "Id",
                keyValue: 201,
                column: "Force",
                value: 152);

            migrationBuilder.UpdateData(
                table: "Samurai",
                keyColumn: "Id",
                keyValue: 202,
                column: "Force",
                value: 778);

            migrationBuilder.UpdateData(
                table: "Samurai",
                keyColumn: "Id",
                keyValue: 203,
                column: "Force",
                value: 1725);

            migrationBuilder.UpdateData(
                table: "Samurai",
                keyColumn: "Id",
                keyValue: 204,
                column: "Force",
                value: 1245);

            migrationBuilder.UpdateData(
                table: "Samurai",
                keyColumn: "Id",
                keyValue: 205,
                column: "Force",
                value: 1160);

            migrationBuilder.UpdateData(
                table: "Samurai",
                keyColumn: "Id",
                keyValue: 206,
                column: "Force",
                value: 1978);

            migrationBuilder.UpdateData(
                table: "Samurai",
                keyColumn: "Id",
                keyValue: 207,
                column: "Force",
                value: 995);

            migrationBuilder.UpdateData(
                table: "Samurai",
                keyColumn: "Id",
                keyValue: 208,
                column: "Force",
                value: 302);

            migrationBuilder.UpdateData(
                table: "Samurai",
                keyColumn: "Id",
                keyValue: 209,
                column: "Force",
                value: 564);

            migrationBuilder.UpdateData(
                table: "Samurai",
                keyColumn: "Id",
                keyValue: 210,
                column: "Force",
                value: 275);

            migrationBuilder.UpdateData(
                table: "Samurai",
                keyColumn: "Id",
                keyValue: 211,
                column: "Force",
                value: 1757);

            migrationBuilder.UpdateData(
                table: "Samurai",
                keyColumn: "Id",
                keyValue: 212,
                column: "Force",
                value: 894);

            migrationBuilder.UpdateData(
                table: "Samurai",
                keyColumn: "Id",
                keyValue: 213,
                column: "Force",
                value: 1806);

            migrationBuilder.UpdateData(
                table: "Samurai",
                keyColumn: "Id",
                keyValue: 214,
                column: "Force",
                value: 1442);

            migrationBuilder.UpdateData(
                table: "Samurai",
                keyColumn: "Id",
                keyValue: 215,
                column: "Force",
                value: 566);

            migrationBuilder.UpdateData(
                table: "Samurai",
                keyColumn: "Id",
                keyValue: 216,
                column: "Force",
                value: 1615);

            migrationBuilder.UpdateData(
                table: "Samurai",
                keyColumn: "Id",
                keyValue: 217,
                column: "Force",
                value: 286);

            migrationBuilder.UpdateData(
                table: "Samurai",
                keyColumn: "Id",
                keyValue: 218,
                column: "Force",
                value: 1775);

            migrationBuilder.UpdateData(
                table: "Samurai",
                keyColumn: "Id",
                keyValue: 219,
                column: "Force",
                value: 1577);

            migrationBuilder.UpdateData(
                table: "Samurai",
                keyColumn: "Id",
                keyValue: 220,
                column: "Force",
                value: 90);

            migrationBuilder.UpdateData(
                table: "Samurai",
                keyColumn: "Id",
                keyValue: 221,
                column: "Force",
                value: 1998);

            migrationBuilder.UpdateData(
                table: "Samurai",
                keyColumn: "Id",
                keyValue: 222,
                column: "Force",
                value: 1481);

            migrationBuilder.UpdateData(
                table: "Samurai",
                keyColumn: "Id",
                keyValue: 223,
                column: "Force",
                value: 1762);

            migrationBuilder.UpdateData(
                table: "Samurai",
                keyColumn: "Id",
                keyValue: 224,
                column: "Force",
                value: 1643);

            migrationBuilder.UpdateData(
                table: "Samurai",
                keyColumn: "Id",
                keyValue: 225,
                column: "Force",
                value: 1361);

            migrationBuilder.UpdateData(
                table: "Samurai",
                keyColumn: "Id",
                keyValue: 226,
                column: "Force",
                value: 829);

            migrationBuilder.UpdateData(
                table: "Samurai",
                keyColumn: "Id",
                keyValue: 227,
                column: "Force",
                value: 779);

            migrationBuilder.UpdateData(
                table: "Samurai",
                keyColumn: "Id",
                keyValue: 228,
                column: "Force",
                value: 1502);

            migrationBuilder.UpdateData(
                table: "Samurai",
                keyColumn: "Id",
                keyValue: 229,
                column: "Force",
                value: 1873);

            migrationBuilder.UpdateData(
                table: "Samurai",
                keyColumn: "Id",
                keyValue: 230,
                column: "Force",
                value: 1619);

            migrationBuilder.UpdateData(
                table: "Samurai",
                keyColumn: "Id",
                keyValue: 231,
                column: "Force",
                value: 1061);

            migrationBuilder.UpdateData(
                table: "Samurai",
                keyColumn: "Id",
                keyValue: 232,
                column: "Force",
                value: 590);

            migrationBuilder.UpdateData(
                table: "Samurai",
                keyColumn: "Id",
                keyValue: 233,
                column: "Force",
                value: 377);

            migrationBuilder.UpdateData(
                table: "Samurai",
                keyColumn: "Id",
                keyValue: 234,
                column: "Force",
                value: 421);

            migrationBuilder.UpdateData(
                table: "Samurai",
                keyColumn: "Id",
                keyValue: 235,
                column: "Force",
                value: 1117);

            migrationBuilder.UpdateData(
                table: "Samurai",
                keyColumn: "Id",
                keyValue: 236,
                column: "Force",
                value: 135);

            migrationBuilder.UpdateData(
                table: "Samurai",
                keyColumn: "Id",
                keyValue: 237,
                column: "Force",
                value: 365);

            migrationBuilder.UpdateData(
                table: "Samurai",
                keyColumn: "Id",
                keyValue: 238,
                column: "Force",
                value: 453);

            migrationBuilder.UpdateData(
                table: "Samurai",
                keyColumn: "Id",
                keyValue: 239,
                column: "Force",
                value: 1232);

            migrationBuilder.UpdateData(
                table: "Samurai",
                keyColumn: "Id",
                keyValue: 240,
                column: "Force",
                value: 300);

            migrationBuilder.UpdateData(
                table: "Samurai",
                keyColumn: "Id",
                keyValue: 241,
                column: "Force",
                value: 1351);

            migrationBuilder.UpdateData(
                table: "Samurai",
                keyColumn: "Id",
                keyValue: 242,
                column: "Force",
                value: 1961);

            migrationBuilder.UpdateData(
                table: "Samurai",
                keyColumn: "Id",
                keyValue: 243,
                column: "Force",
                value: 1777);

            migrationBuilder.UpdateData(
                table: "Samurai",
                keyColumn: "Id",
                keyValue: 244,
                column: "Force",
                value: 586);

            migrationBuilder.UpdateData(
                table: "Samurai",
                keyColumn: "Id",
                keyValue: 245,
                column: "Force",
                value: 1992);

            migrationBuilder.UpdateData(
                table: "Samurai",
                keyColumn: "Id",
                keyValue: 246,
                column: "Force",
                value: 1481);

            migrationBuilder.UpdateData(
                table: "Samurai",
                keyColumn: "Id",
                keyValue: 247,
                column: "Force",
                value: 1397);

            migrationBuilder.UpdateData(
                table: "Samurai",
                keyColumn: "Id",
                keyValue: 248,
                column: "Force",
                value: 1458);

            migrationBuilder.UpdateData(
                table: "Samurai",
                keyColumn: "Id",
                keyValue: 249,
                column: "Force",
                value: 92);

            migrationBuilder.UpdateData(
                table: "Samurai",
                keyColumn: "Id",
                keyValue: 250,
                column: "Force",
                value: 1547);

            migrationBuilder.UpdateData(
                table: "Samurai",
                keyColumn: "Id",
                keyValue: 251,
                column: "Force",
                value: 1664);

            migrationBuilder.UpdateData(
                table: "Samurai",
                keyColumn: "Id",
                keyValue: 252,
                column: "Force",
                value: 1308);

            migrationBuilder.UpdateData(
                table: "Samurai",
                keyColumn: "Id",
                keyValue: 253,
                column: "Force",
                value: 1128);

            migrationBuilder.UpdateData(
                table: "Samurai",
                keyColumn: "Id",
                keyValue: 254,
                column: "Force",
                value: 348);

            migrationBuilder.UpdateData(
                table: "Samurai",
                keyColumn: "Id",
                keyValue: 255,
                column: "Force",
                value: 1168);

            migrationBuilder.UpdateData(
                table: "Samurai",
                keyColumn: "Id",
                keyValue: 256,
                column: "Force",
                value: 1924);

            migrationBuilder.UpdateData(
                table: "Samurai",
                keyColumn: "Id",
                keyValue: 257,
                column: "Force",
                value: 1972);

            migrationBuilder.UpdateData(
                table: "Samurai",
                keyColumn: "Id",
                keyValue: 258,
                column: "Force",
                value: 1131);

            migrationBuilder.UpdateData(
                table: "Samurai",
                keyColumn: "Id",
                keyValue: 259,
                column: "Force",
                value: 56);

            migrationBuilder.UpdateData(
                table: "Samurai",
                keyColumn: "Id",
                keyValue: 260,
                column: "Force",
                value: 331);

            migrationBuilder.UpdateData(
                table: "Samurai",
                keyColumn: "Id",
                keyValue: 261,
                column: "Force",
                value: 1255);

            migrationBuilder.UpdateData(
                table: "Samurai",
                keyColumn: "Id",
                keyValue: 262,
                column: "Force",
                value: 180);

            migrationBuilder.UpdateData(
                table: "Samurai",
                keyColumn: "Id",
                keyValue: 263,
                column: "Force",
                value: 621);

            migrationBuilder.UpdateData(
                table: "Samurai",
                keyColumn: "Id",
                keyValue: 264,
                column: "Force",
                value: 1205);

            migrationBuilder.UpdateData(
                table: "Samurai",
                keyColumn: "Id",
                keyValue: 265,
                column: "Force",
                value: 1279);

            migrationBuilder.UpdateData(
                table: "Samurai",
                keyColumn: "Id",
                keyValue: 266,
                column: "Force",
                value: 1509);

            migrationBuilder.UpdateData(
                table: "Samurai",
                keyColumn: "Id",
                keyValue: 267,
                column: "Force",
                value: 1487);

            migrationBuilder.UpdateData(
                table: "Samurai",
                keyColumn: "Id",
                keyValue: 268,
                column: "Force",
                value: 1148);

            migrationBuilder.UpdateData(
                table: "Samurai",
                keyColumn: "Id",
                keyValue: 269,
                column: "Force",
                value: 1851);

            migrationBuilder.UpdateData(
                table: "Samurai",
                keyColumn: "Id",
                keyValue: 270,
                column: "Force",
                value: 900);

            migrationBuilder.UpdateData(
                table: "Samurai",
                keyColumn: "Id",
                keyValue: 271,
                column: "Force",
                value: 1787);

            migrationBuilder.UpdateData(
                table: "Samurai",
                keyColumn: "Id",
                keyValue: 272,
                column: "Force",
                value: 328);

            migrationBuilder.UpdateData(
                table: "Samurai",
                keyColumn: "Id",
                keyValue: 273,
                column: "Force",
                value: 1193);

            migrationBuilder.UpdateData(
                table: "Samurai",
                keyColumn: "Id",
                keyValue: 274,
                column: "Force",
                value: 233);

            migrationBuilder.UpdateData(
                table: "Samurai",
                keyColumn: "Id",
                keyValue: 275,
                column: "Force",
                value: 1220);

            migrationBuilder.UpdateData(
                table: "Samurai",
                keyColumn: "Id",
                keyValue: 276,
                column: "Force",
                value: 1069);

            migrationBuilder.UpdateData(
                table: "Samurai",
                keyColumn: "Id",
                keyValue: 277,
                column: "Force",
                value: 1639);

            migrationBuilder.UpdateData(
                table: "Samurai",
                keyColumn: "Id",
                keyValue: 278,
                column: "Force",
                value: 1973);

            migrationBuilder.UpdateData(
                table: "Samurai",
                keyColumn: "Id",
                keyValue: 279,
                column: "Force",
                value: 612);

            migrationBuilder.UpdateData(
                table: "Samurai",
                keyColumn: "Id",
                keyValue: 280,
                column: "Force",
                value: 1048);

            migrationBuilder.UpdateData(
                table: "Samurai",
                keyColumn: "Id",
                keyValue: 281,
                column: "Force",
                value: 829);

            migrationBuilder.UpdateData(
                table: "Samurai",
                keyColumn: "Id",
                keyValue: 282,
                column: "Force",
                value: 437);

            migrationBuilder.UpdateData(
                table: "Samurai",
                keyColumn: "Id",
                keyValue: 283,
                column: "Force",
                value: 1039);

            migrationBuilder.UpdateData(
                table: "Samurai",
                keyColumn: "Id",
                keyValue: 284,
                column: "Force",
                value: 907);

            migrationBuilder.UpdateData(
                table: "Samurai",
                keyColumn: "Id",
                keyValue: 285,
                column: "Force",
                value: 1439);

            migrationBuilder.UpdateData(
                table: "Samurai",
                keyColumn: "Id",
                keyValue: 286,
                column: "Force",
                value: 1444);

            migrationBuilder.UpdateData(
                table: "Samurai",
                keyColumn: "Id",
                keyValue: 287,
                column: "Force",
                value: 1902);

            migrationBuilder.UpdateData(
                table: "Samurai",
                keyColumn: "Id",
                keyValue: 288,
                column: "Force",
                value: 1039);

            migrationBuilder.UpdateData(
                table: "Samurai",
                keyColumn: "Id",
                keyValue: 289,
                column: "Force",
                value: 838);

            migrationBuilder.UpdateData(
                table: "Samurai",
                keyColumn: "Id",
                keyValue: 290,
                column: "Force",
                value: 1494);

            migrationBuilder.UpdateData(
                table: "Samurai",
                keyColumn: "Id",
                keyValue: 291,
                column: "Force",
                value: 376);

            migrationBuilder.UpdateData(
                table: "Samurai",
                keyColumn: "Id",
                keyValue: 292,
                column: "Force",
                value: 17);

            migrationBuilder.UpdateData(
                table: "Samurai",
                keyColumn: "Id",
                keyValue: 293,
                column: "Force",
                value: 11);

            migrationBuilder.UpdateData(
                table: "Samurai",
                keyColumn: "Id",
                keyValue: 294,
                column: "Force",
                value: 789);

            migrationBuilder.UpdateData(
                table: "Samurai",
                keyColumn: "Id",
                keyValue: 295,
                column: "Force",
                value: 1683);

            migrationBuilder.UpdateData(
                table: "Samurai",
                keyColumn: "Id",
                keyValue: 296,
                column: "Force",
                value: 773);

            migrationBuilder.UpdateData(
                table: "Samurai",
                keyColumn: "Id",
                keyValue: 297,
                column: "Force",
                value: 1105);

            migrationBuilder.UpdateData(
                table: "Samurai",
                keyColumn: "Id",
                keyValue: 298,
                column: "Force",
                value: 1277);

            migrationBuilder.UpdateData(
                table: "Samurai",
                keyColumn: "Id",
                keyValue: 299,
                column: "Force",
                value: 1759);

            migrationBuilder.UpdateData(
                table: "Samurai",
                keyColumn: "Id",
                keyValue: 300,
                column: "Force",
                value: 1331);

            migrationBuilder.UpdateData(
                table: "Samurai",
                keyColumn: "Id",
                keyValue: 301,
                column: "Force",
                value: 1736);

            migrationBuilder.UpdateData(
                table: "Samurai",
                keyColumn: "Id",
                keyValue: 302,
                column: "Force",
                value: 843);

            migrationBuilder.UpdateData(
                table: "Samurai",
                keyColumn: "Id",
                keyValue: 303,
                column: "Force",
                value: 1897);

            migrationBuilder.UpdateData(
                table: "Samurai",
                keyColumn: "Id",
                keyValue: 304,
                column: "Force",
                value: 660);

            migrationBuilder.UpdateData(
                table: "Samurai",
                keyColumn: "Id",
                keyValue: 305,
                column: "Force",
                value: 422);

            migrationBuilder.UpdateData(
                table: "Samurai",
                keyColumn: "Id",
                keyValue: 306,
                column: "Force",
                value: 216);

            migrationBuilder.UpdateData(
                table: "Samurai",
                keyColumn: "Id",
                keyValue: 307,
                column: "Force",
                value: 794);

            migrationBuilder.UpdateData(
                table: "Samurai",
                keyColumn: "Id",
                keyValue: 308,
                column: "Force",
                value: 1568);

            migrationBuilder.UpdateData(
                table: "Samurai",
                keyColumn: "Id",
                keyValue: 309,
                column: "Force",
                value: 1057);

            migrationBuilder.UpdateData(
                table: "Samurai",
                keyColumn: "Id",
                keyValue: 310,
                column: "Force",
                value: 72);

            migrationBuilder.UpdateData(
                table: "Samurai",
                keyColumn: "Id",
                keyValue: 311,
                column: "Force",
                value: 167);

            migrationBuilder.UpdateData(
                table: "Samurai",
                keyColumn: "Id",
                keyValue: 312,
                column: "Force",
                value: 940);

            migrationBuilder.UpdateData(
                table: "Samurai",
                keyColumn: "Id",
                keyValue: 313,
                column: "Force",
                value: 525);

            migrationBuilder.UpdateData(
                table: "Samurai",
                keyColumn: "Id",
                keyValue: 314,
                column: "Force",
                value: 1613);

            migrationBuilder.UpdateData(
                table: "Samurai",
                keyColumn: "Id",
                keyValue: 315,
                column: "Force",
                value: 1364);

            migrationBuilder.UpdateData(
                table: "Samurai",
                keyColumn: "Id",
                keyValue: 316,
                column: "Force",
                value: 11);

            migrationBuilder.UpdateData(
                table: "Samurai",
                keyColumn: "Id",
                keyValue: 317,
                column: "Force",
                value: 426);

            migrationBuilder.UpdateData(
                table: "Samurai",
                keyColumn: "Id",
                keyValue: 318,
                column: "Force",
                value: 579);

            migrationBuilder.UpdateData(
                table: "Samurai",
                keyColumn: "Id",
                keyValue: 319,
                column: "Force",
                value: 187);

            migrationBuilder.UpdateData(
                table: "Samurai",
                keyColumn: "Id",
                keyValue: 320,
                column: "Force",
                value: 532);

            migrationBuilder.CreateIndex(
                name: "IX_ArtMartialSamurai_SamuraisId",
                table: "ArtMartialSamurai",
                column: "SamuraisId");
        }
    }
}
