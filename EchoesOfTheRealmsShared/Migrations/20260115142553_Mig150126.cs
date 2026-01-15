using Microsoft.EntityFrameworkCore.Migrations;

#nullable disable

#pragma warning disable CA1814 // Prefer jagged arrays over multidimensional

namespace EchoesOfTheRealmsShared.Migrations
{
    /// <inheritdoc />
    public partial class Mig150126 : Migration
    {
        /// <inheritdoc />
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.InsertData(
                table: "Monsters",
                columns: new[] { "Id", "Dex", "GoldGiven", "HP", "Intel", "IsDeleted", "Level", "Mana", "MonsterTypeId", "Name", "ResFire", "ResIce", "ResLightning", "Sprite", "Str", "Vita", "XPGiven" },
                values: new object[,]
                {
                    { 2L, 10, 25, 50, 5, false, 1, 1, 2, "Squelette décrépit", 5, 5, 20, null, 40, 50, 50 },
                    { 3L, 20, 50, 100, 10, false, 1, 1, 3, "Golem nain", 20, 5, 50, null, 100, 50, 100 }
                });
        }

        /// <inheritdoc />
        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DeleteData(
                table: "Monsters",
                keyColumn: "Id",
                keyValue: 2L);

            migrationBuilder.DeleteData(
                table: "Monsters",
                keyColumn: "Id",
                keyValue: 3L);
        }
    }
}
