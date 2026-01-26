using Microsoft.EntityFrameworkCore.Migrations;

#nullable disable

namespace EchoesOfTheRealmsShared.Migrations
{
    /// <inheritdoc />
    public partial class Mig260126 : Migration
    {
        /// <inheritdoc />
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.AddColumn<long>(
                name: "ArmorId",
                table: "Characters",
                type: "bigint",
                nullable: true);

            migrationBuilder.AddColumn<long>(
                name: "BootId",
                table: "Characters",
                type: "bigint",
                nullable: true);

            migrationBuilder.AddColumn<long>(
                name: "HelmetId",
                table: "Characters",
                type: "bigint",
                nullable: true);

            migrationBuilder.AddColumn<long>(
                name: "WeaponId",
                table: "Characters",
                type: "bigint",
                nullable: true);

            migrationBuilder.UpdateData(
                table: "Characters",
                keyColumn: "Id",
                keyValue: 1L,
                columns: new[] { "ArmorId", "BootId", "HelmetId", "WeaponId" },
                values: new object[] { null, null, null, null });

            migrationBuilder.CreateIndex(
                name: "IX_Characters_ArmorId",
                table: "Characters",
                column: "ArmorId");

            migrationBuilder.CreateIndex(
                name: "IX_Characters_BootId",
                table: "Characters",
                column: "BootId");

            migrationBuilder.CreateIndex(
                name: "IX_Characters_HelmetId",
                table: "Characters",
                column: "HelmetId");

            migrationBuilder.CreateIndex(
                name: "IX_Characters_WeaponId",
                table: "Characters",
                column: "WeaponId");

            migrationBuilder.AddForeignKey(
                name: "FK_Characters_Equipments_ArmorId",
                table: "Characters",
                column: "ArmorId",
                principalTable: "Equipments",
                principalColumn: "Id");

            migrationBuilder.AddForeignKey(
                name: "FK_Characters_Equipments_BootId",
                table: "Characters",
                column: "BootId",
                principalTable: "Equipments",
                principalColumn: "Id");

            migrationBuilder.AddForeignKey(
                name: "FK_Characters_Equipments_HelmetId",
                table: "Characters",
                column: "HelmetId",
                principalTable: "Equipments",
                principalColumn: "Id");

            migrationBuilder.AddForeignKey(
                name: "FK_Characters_Equipments_WeaponId",
                table: "Characters",
                column: "WeaponId",
                principalTable: "Equipments",
                principalColumn: "Id");
        }

        /// <inheritdoc />
        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropForeignKey(
                name: "FK_Characters_Equipments_ArmorId",
                table: "Characters");

            migrationBuilder.DropForeignKey(
                name: "FK_Characters_Equipments_BootId",
                table: "Characters");

            migrationBuilder.DropForeignKey(
                name: "FK_Characters_Equipments_HelmetId",
                table: "Characters");

            migrationBuilder.DropForeignKey(
                name: "FK_Characters_Equipments_WeaponId",
                table: "Characters");

            migrationBuilder.DropIndex(
                name: "IX_Characters_ArmorId",
                table: "Characters");

            migrationBuilder.DropIndex(
                name: "IX_Characters_BootId",
                table: "Characters");

            migrationBuilder.DropIndex(
                name: "IX_Characters_HelmetId",
                table: "Characters");

            migrationBuilder.DropIndex(
                name: "IX_Characters_WeaponId",
                table: "Characters");

            migrationBuilder.DropColumn(
                name: "ArmorId",
                table: "Characters");

            migrationBuilder.DropColumn(
                name: "BootId",
                table: "Characters");

            migrationBuilder.DropColumn(
                name: "HelmetId",
                table: "Characters");

            migrationBuilder.DropColumn(
                name: "WeaponId",
                table: "Characters");
        }
    }
}
