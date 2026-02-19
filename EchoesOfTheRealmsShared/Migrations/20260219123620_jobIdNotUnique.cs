using Microsoft.EntityFrameworkCore.Migrations;

#nullable disable

namespace EchoesOfTheRealmsShared.Migrations
{
    /// <inheritdoc />
    public partial class jobIdNotUnique : Migration
    {
        /// <inheritdoc />
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropIndex(
                name: "IX_Characters_JobId",
                table: "Characters");

            migrationBuilder.CreateIndex(
                name: "IX_Characters_JobId",
                table: "Characters",
                column: "JobId");
        }

        /// <inheritdoc />
        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropIndex(
                name: "IX_Characters_JobId",
                table: "Characters");

            migrationBuilder.CreateIndex(
                name: "IX_Characters_JobId",
                table: "Characters",
                column: "JobId",
                unique: true);
        }
    }
}
