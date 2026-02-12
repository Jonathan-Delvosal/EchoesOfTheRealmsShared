using Microsoft.EntityFrameworkCore.Migrations;

#nullable disable

#pragma warning disable CA1814 // Prefer jagged arrays over multidimensional

namespace EchoesOfTheRealmsShared.Migrations
{
    /// <inheritdoc />
    public partial class Mig120226EndAttack : Migration
    {
        /// <inheritdoc />
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.CreateTable(
                name: "DamageTypes",
                columns: table => new
                {
                    Id = table.Column<int>(type: "int", nullable: false)
                        .Annotation("SqlServer:Identity", "1, 1"),
                    Name = table.Column<string>(type: "nvarchar(450)", nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_DamageTypes", x => x.Id);
                });

            migrationBuilder.CreateTable(
                name: "Attacks",
                columns: table => new
                {
                    Id = table.Column<int>(type: "int", nullable: false)
                        .Annotation("SqlServer:Identity", "1, 1"),
                    Name = table.Column<string>(type: "nvarchar(450)", nullable: false),
                    Description = table.Column<string>(type: "nvarchar(max)", nullable: true),
                    ManaCost = table.Column<int>(type: "int", nullable: false),
                    Multiplier = table.Column<double>(type: "float", nullable: false),
                    CanCrit = table.Column<bool>(type: "bit", nullable: false),
                    DefenseTarget = table.Column<int>(type: "int", nullable: false),
                    PrimaryStat = table.Column<int>(type: "int", nullable: false),
                    SecondaryStat = table.Column<int>(type: "int", nullable: true),
                    SecondaryWeight = table.Column<double>(type: "float", nullable: false),
                    DamageTypeId = table.Column<int>(type: "int", nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_Attacks", x => x.Id);
                    table.ForeignKey(
                        name: "FK_Attacks_DamageTypes_DamageTypeId",
                        column: x => x.DamageTypeId,
                        principalTable: "DamageTypes",
                        principalColumn: "Id",
                        onDelete: ReferentialAction.Cascade);
                });

            migrationBuilder.CreateTable(
                name: "JobAttacks",
                columns: table => new
                {
                    JobId = table.Column<int>(type: "int", nullable: false),
                    AttackId = table.Column<int>(type: "int", nullable: false),
                    RequiredLevel = table.Column<int>(type: "int", nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_JobAttacks", x => new { x.JobId, x.AttackId });
                    table.ForeignKey(
                        name: "FK_JobAttacks_Attacks_AttackId",
                        column: x => x.AttackId,
                        principalTable: "Attacks",
                        principalColumn: "Id",
                        onDelete: ReferentialAction.Cascade);
                    table.ForeignKey(
                        name: "FK_JobAttacks_Jobs_JobId",
                        column: x => x.JobId,
                        principalTable: "Jobs",
                        principalColumn: "Id",
                        onDelete: ReferentialAction.Cascade);
                });

            migrationBuilder.CreateTable(
                name: "MonsterAttacks",
                columns: table => new
                {
                    MonsterId = table.Column<long>(type: "bigint", nullable: false),
                    AttackId = table.Column<int>(type: "int", nullable: false),
                    Weight = table.Column<int>(type: "int", nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_MonsterAttacks", x => new { x.MonsterId, x.AttackId });
                    table.ForeignKey(
                        name: "FK_MonsterAttacks_Attacks_AttackId",
                        column: x => x.AttackId,
                        principalTable: "Attacks",
                        principalColumn: "Id",
                        onDelete: ReferentialAction.Cascade);
                    table.ForeignKey(
                        name: "FK_MonsterAttacks_Monsters_MonsterId",
                        column: x => x.MonsterId,
                        principalTable: "Monsters",
                        principalColumn: "Id",
                        onDelete: ReferentialAction.Cascade);
                });

            migrationBuilder.InsertData(
                table: "DamageTypes",
                columns: new[] { "Id", "Name" },
                values: new object[,]
                {
                    { 1, "Physique" },
                    { 2, "Feu" },
                    { 3, "Glace" },
                    { 4, "Foudre" }
                });

            migrationBuilder.InsertData(
                table: "Attacks",
                columns: new[] { "Id", "CanCrit", "DamageTypeId", "DefenseTarget", "Description", "ManaCost", "Multiplier", "Name", "PrimaryStat", "SecondaryStat", "SecondaryWeight" },
                values: new object[,]
                {
                    { 1, true, 1, 0, "Une attaque basique à l'épée.", 0, 0.29999999999999999, "Coup d'épée", 0, null, 0.0 },
                    { 2, true, 1, 0, "Un tir rapide visant à submerger l'adversaire.", 0, 0.29999999999999999, "Tir à la volée", 1, null, 0.0 },
                    { 3, true, 1, 0, "Une dague lancée avec précision et force.", 0, 0.29999999999999999, "Lancer de dague", 1, 0, 0.29999999999999999 },
                    { 4, true, 4, 1, "Un éclat d'énergie foudroyante frappant l'adversaire.", 0, 0.29999999999999999, "Éclat magique", 2, null, 0.0 },
                    { 5, true, 1, 0, "Une frappe lourde qui écrase l'adversaire.", 20, 0.45000000000000001, "Frappe écrasante", 0, null, 0.0 },
                    { 6, true, 1, 0, "Une flèche précise qui transperce la défense ennemie.", 20, 0.45000000000000001, "Flèche perçante", 1, null, 0.0 },
                    { 7, true, 1, 0, "Une entaille rapide qui ouvre une plaie profonde.", 20, 0.45000000000000001, "Lacération", 1, 0, 0.40000000000000002 },
                    { 8, true, 2, 1, "Projette une sphère de flammes brûlantes.", 20, 0.55000000000000004, "Boule de feu", 2, null, 0.0 },
                    { 9, true, 3, 1, "Projette une lance de givre qui transperce l'adversaire.", 20, 0.5, "Lance de givre", 2, null, 0.0 },
                    { 10, true, 4, 1, "Un arc d'électricité qui frappe l'adversaire.", 20, 0.52000000000000002, "Arc électrique", 2, null, 0.0 }
                });

            migrationBuilder.InsertData(
                table: "JobAttacks",
                columns: new[] { "AttackId", "JobId", "RequiredLevel" },
                values: new object[,]
                {
                    { 1, 1, 1 },
                    { 5, 1, 1 },
                    { 2, 2, 1 },
                    { 3, 2, 1 },
                    { 6, 2, 1 },
                    { 7, 2, 1 },
                    { 4, 3, 1 },
                    { 8, 3, 1 },
                    { 9, 3, 1 },
                    { 10, 3, 1 }
                });

            migrationBuilder.CreateIndex(
                name: "IX_Attacks_DamageTypeId",
                table: "Attacks",
                column: "DamageTypeId");

            migrationBuilder.CreateIndex(
                name: "IX_Attacks_Name",
                table: "Attacks",
                column: "Name",
                unique: true);

            migrationBuilder.CreateIndex(
                name: "IX_DamageTypes_Name",
                table: "DamageTypes",
                column: "Name",
                unique: true);

            migrationBuilder.CreateIndex(
                name: "IX_JobAttacks_AttackId",
                table: "JobAttacks",
                column: "AttackId");

            migrationBuilder.CreateIndex(
                name: "IX_MonsterAttacks_AttackId",
                table: "MonsterAttacks",
                column: "AttackId");
        }

        /// <inheritdoc />
        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropTable(
                name: "JobAttacks");

            migrationBuilder.DropTable(
                name: "MonsterAttacks");

            migrationBuilder.DropTable(
                name: "Attacks");

            migrationBuilder.DropTable(
                name: "DamageTypes");
        }
    }
}
