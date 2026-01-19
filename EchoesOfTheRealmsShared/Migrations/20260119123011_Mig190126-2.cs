using Microsoft.EntityFrameworkCore.Migrations;

#nullable disable

namespace EchoesOfTheRealmsShared.Migrations
{
    /// <inheritdoc />
    public partial class Mig1901262 : Migration
    {
        /// <inheritdoc />
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.UpdateData(
                table: "Users",
                keyColumn: "Id",
                keyValue: 1,
                column: "Password",
                value: "c3d435eb-8ca7-42ee-97b4-643d7ba76b36HN8puinASaYoKZXLUek0k6LfkSkTTxaDYMDAI87rSCpgDZ9DQSSjMfSyQ14x2SZGieNNR0I9NcbhPZgtwzlEkw==");
        }

        /// <inheritdoc />
        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.UpdateData(
                table: "Users",
                keyColumn: "Id",
                keyValue: 1,
                column: "Password",
                value: "Hakuryu1234-*");
        }
    }
}
