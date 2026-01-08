using Microsoft.EntityFrameworkCore.Migrations;

#nullable disable

namespace EchoesOfTheRealmsShared.Migrations
{
    /// <inheritdoc />
    public partial class Mig0801263 : Migration
    {
        /// <inheritdoc />
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.AddColumn<int>(
                name: "NpcRoleId",
                table: "NPCs",
                type: "int",
                nullable: false,
                defaultValue: 0);

            migrationBuilder.CreateTable(
                name: "NPCRole",
                columns: table => new
                {
                    Id = table.Column<int>(type: "int", nullable: false)
                        .Annotation("SqlServer:Identity", "1, 1"),
                    Name = table.Column<string>(type: "nvarchar(max)", nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_NPCRole", x => x.Id);
                });

            migrationBuilder.InsertData(
                table: "NPCRole",
                columns: new[] { "Id", "Name" },
                values: new object[] { 1, "Marchand" });

            migrationBuilder.UpdateData(
                table: "NPCs",
                keyColumn: "Id",
                keyValue: 1L,
                column: "NpcRoleId",
                value: 1);

            migrationBuilder.CreateIndex(
                name: "IX_NPCs_NpcRoleId",
                table: "NPCs",
                column: "NpcRoleId");

            migrationBuilder.AddForeignKey(
                name: "FK_NPCs_NPCRole_NpcRoleId",
                table: "NPCs",
                column: "NpcRoleId",
                principalTable: "NPCRole",
                principalColumn: "Id",
                onDelete: ReferentialAction.Cascade);
        }

        /// <inheritdoc />
        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropForeignKey(
                name: "FK_NPCs_NPCRole_NpcRoleId",
                table: "NPCs");

            migrationBuilder.DropTable(
                name: "NPCRole");

            migrationBuilder.DropIndex(
                name: "IX_NPCs_NpcRoleId",
                table: "NPCs");

            migrationBuilder.DropColumn(
                name: "NpcRoleId",
                table: "NPCs");
        }
    }
}
