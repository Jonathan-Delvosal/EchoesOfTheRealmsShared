using Microsoft.EntityFrameworkCore.Migrations;

#nullable disable

namespace EchoesOfTheRealmsShared.Migrations
{
    /// <inheritdoc />
    public partial class Mig1901265 : Migration
    {
        /// <inheritdoc />
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropIndex(
                name: "IX_Users_Mail_NickName",
                table: "Users");

            migrationBuilder.CreateIndex(
                name: "IX_Users_Mail",
                table: "Users",
                column: "Mail",
                unique: true);
        }

        /// <inheritdoc />
        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropIndex(
                name: "IX_Users_Mail",
                table: "Users");

            migrationBuilder.CreateIndex(
                name: "IX_Users_Mail_NickName",
                table: "Users",
                columns: new[] { "Mail", "NickName" },
                unique: true);
        }
    }
}
