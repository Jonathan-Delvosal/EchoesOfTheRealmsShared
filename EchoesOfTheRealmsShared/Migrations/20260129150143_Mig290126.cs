using Microsoft.EntityFrameworkCore.Migrations;

#nullable disable

namespace EchoesOfTheRealmsShared.Migrations
{
    /// <inheritdoc />
    public partial class Mig290126 : Migration
    {
        /// <inheritdoc />
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.AddColumn<int>(
                name: "DexMax",
                table: "Characters",
                type: "int",
                nullable: false,
                defaultValue: 0);

            migrationBuilder.AddColumn<int>(
                name: "HPMax",
                table: "Characters",
                type: "int",
                nullable: false,
                defaultValue: 0);

            migrationBuilder.AddColumn<int>(
                name: "IntelMax",
                table: "Characters",
                type: "int",
                nullable: false,
                defaultValue: 0);

            migrationBuilder.AddColumn<int>(
                name: "ManaMax",
                table: "Characters",
                type: "int",
                nullable: false,
                defaultValue: 0);

            migrationBuilder.AddColumn<int>(
                name: "ResFireMax",
                table: "Characters",
                type: "int",
                nullable: false,
                defaultValue: 0);

            migrationBuilder.AddColumn<int>(
                name: "ResIceMax",
                table: "Characters",
                type: "int",
                nullable: false,
                defaultValue: 0);

            migrationBuilder.AddColumn<int>(
                name: "ResLightningMax",
                table: "Characters",
                type: "int",
                nullable: false,
                defaultValue: 0);

            migrationBuilder.AddColumn<int>(
                name: "StrMax",
                table: "Characters",
                type: "int",
                nullable: false,
                defaultValue: 0);

            migrationBuilder.AddColumn<int>(
                name: "VitaMax",
                table: "Characters",
                type: "int",
                nullable: false,
                defaultValue: 0);

            migrationBuilder.UpdateData(
                table: "Characters",
                keyColumn: "Id",
                keyValue: 1L,
                columns: new[] { "DexMax", "HPMax", "IntelMax", "ManaMax", "ResFireMax", "ResIceMax", "ResLightningMax", "StrMax", "VitaMax" },
                values: new object[] { 0, 0, 0, 0, 0, 0, 0, 0, 0 });
        }

        /// <inheritdoc />
        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropColumn(
                name: "DexMax",
                table: "Characters");

            migrationBuilder.DropColumn(
                name: "HPMax",
                table: "Characters");

            migrationBuilder.DropColumn(
                name: "IntelMax",
                table: "Characters");

            migrationBuilder.DropColumn(
                name: "ManaMax",
                table: "Characters");

            migrationBuilder.DropColumn(
                name: "ResFireMax",
                table: "Characters");

            migrationBuilder.DropColumn(
                name: "ResIceMax",
                table: "Characters");

            migrationBuilder.DropColumn(
                name: "ResLightningMax",
                table: "Characters");

            migrationBuilder.DropColumn(
                name: "StrMax",
                table: "Characters");

            migrationBuilder.DropColumn(
                name: "VitaMax",
                table: "Characters");
        }
    }
}
