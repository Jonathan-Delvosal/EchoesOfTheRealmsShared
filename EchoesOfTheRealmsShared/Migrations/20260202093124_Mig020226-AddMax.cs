using Microsoft.EntityFrameworkCore.Migrations;

#nullable disable

namespace EchoesOfTheRealmsShared.Migrations
{
    /// <inheritdoc />
    public partial class Mig020226AddMax : Migration
    {
        /// <inheritdoc />
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.UpdateData(
                table: "Characters",
                keyColumn: "Id",
                keyValue: 1L,
                columns: new[] { "HPMax", "ManaMax" },
                values: new object[] { 50, 50 });
        }

        /// <inheritdoc />
        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.UpdateData(
                table: "Characters",
                keyColumn: "Id",
                keyValue: 1L,
                columns: new[] { "HPMax", "ManaMax" },
                values: new object[] { 0, 0 });
        }
    }
}
