using Microsoft.EntityFrameworkCore.Migrations;

#nullable disable

#pragma warning disable CA1814 // Prefer jagged arrays over multidimensional

namespace EchoesOfTheRealmsShared.Migrations
{
    /// <inheritdoc />
    public partial class Mig1102262AddWeaponType : Migration
    {
        /// <inheritdoc />
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.AddColumn<int>(
                name: "WeaponTypeId",
                table: "Equipments",
                type: "int",
                nullable: true);

            migrationBuilder.CreateTable(
                name: "WeaponTypes",
                columns: table => new
                {
                    Id = table.Column<int>(type: "int", nullable: false)
                        .Annotation("SqlServer:Identity", "1, 1"),
                    Name = table.Column<string>(type: "nvarchar(450)", nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_WeaponTypes", x => x.Id);
                });

            migrationBuilder.UpdateData(
                table: "Equipments",
                keyColumn: "Id",
                keyValue: 1L,
                column: "WeaponTypeId",
                value: 1);

            migrationBuilder.UpdateData(
                table: "Equipments",
                keyColumn: "Id",
                keyValue: 2L,
                column: "WeaponTypeId",
                value: 2);

            migrationBuilder.UpdateData(
                table: "Equipments",
                keyColumn: "Id",
                keyValue: 3L,
                column: "WeaponTypeId",
                value: 3);

            migrationBuilder.UpdateData(
                table: "Equipments",
                keyColumn: "Id",
                keyValue: 4L,
                column: "WeaponTypeId",
                value: 4);

            migrationBuilder.InsertData(
                table: "WeaponTypes",
                columns: new[] { "Id", "Name" },
                values: new object[,]
                {
                    { 1, "Epee" },
                    { 2, "Arc" },
                    { 3, "Dague" },
                    { 4, "Bâton" }
                });

            migrationBuilder.CreateIndex(
                name: "IX_Equipments_WeaponTypeId",
                table: "Equipments",
                column: "WeaponTypeId");

            migrationBuilder.CreateIndex(
                name: "IX_WeaponTypes_Name",
                table: "WeaponTypes",
                column: "Name",
                unique: true);

            migrationBuilder.AddForeignKey(
                name: "FK_Equipments_WeaponTypes_WeaponTypeId",
                table: "Equipments",
                column: "WeaponTypeId",
                principalTable: "WeaponTypes",
                principalColumn: "Id",
                onDelete: ReferentialAction.Cascade);
        }

        /// <inheritdoc />
        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropForeignKey(
                name: "FK_Equipments_WeaponTypes_WeaponTypeId",
                table: "Equipments");

            migrationBuilder.DropTable(
                name: "WeaponTypes");

            migrationBuilder.DropIndex(
                name: "IX_Equipments_WeaponTypeId",
                table: "Equipments");

            migrationBuilder.DropColumn(
                name: "WeaponTypeId",
                table: "Equipments");
        }
    }
}
