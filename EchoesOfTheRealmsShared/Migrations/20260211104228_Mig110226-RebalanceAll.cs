using Microsoft.EntityFrameworkCore.Migrations;

#nullable disable

#pragma warning disable CA1814 // Prefer jagged arrays over multidimensional

namespace EchoesOfTheRealmsShared.Migrations
{
    /// <inheritdoc />
    public partial class Mig110226RebalanceAll : Migration
    {
        /// <inheritdoc />
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.AddColumn<double>(
                name: "CritChance",
                table: "Monsters",
                type: "float",
                nullable: false,
                defaultValue: 0.0);

            migrationBuilder.AddColumn<double>(
                name: "CritMultiplier",
                table: "Monsters",
                type: "float",
                nullable: false,
                defaultValue: 0.0);

            migrationBuilder.AddColumn<int>(
                name: "Defense",
                table: "Monsters",
                type: "int",
                nullable: false,
                defaultValue: 0);

            migrationBuilder.AddColumn<double>(
                name: "BonusCritChance",
                table: "Jobs",
                type: "float",
                nullable: false,
                defaultValue: 0.0);

            migrationBuilder.AddColumn<double>(
                name: "BonusCritMultiplier",
                table: "Jobs",
                type: "float",
                nullable: false,
                defaultValue: 0.0);

            migrationBuilder.AddColumn<int>(
                name: "BonusDefense",
                table: "Jobs",
                type: "int",
                nullable: false,
                defaultValue: 0);

            migrationBuilder.AddColumn<double>(
                name: "ModCritChance",
                table: "Equipments",
                type: "float",
                nullable: true);

            migrationBuilder.AddColumn<double>(
                name: "ModCritMultiplier",
                table: "Equipments",
                type: "float",
                nullable: true);

            migrationBuilder.AddColumn<int>(
                name: "ModDefense",
                table: "Equipments",
                type: "int",
                nullable: true);

            migrationBuilder.AddColumn<double>(
                name: "CritChance",
                table: "Characters",
                type: "float",
                nullable: false,
                defaultValue: 0.0);

            migrationBuilder.AddColumn<double>(
                name: "CritMultiplier",
                table: "Characters",
                type: "float",
                nullable: false,
                defaultValue: 0.0);

            migrationBuilder.AddColumn<int>(
                name: "Defense",
                table: "Characters",
                type: "int",
                nullable: false,
                defaultValue: 0);

            migrationBuilder.UpdateData(
                table: "Characters",
                keyColumn: "Id",
                keyValue: 1L,
                columns: new[] { "CritChance", "CritMultiplier", "Defense" },
                values: new object[] { 0.050000000000000003, 1.5, 10 });

            migrationBuilder.UpdateData(
                table: "Equipments",
                keyColumn: "Id",
                keyValue: 1L,
                columns: new[] { "BuyPrice", "LvLPrerequisites", "ModCritChance", "ModCritMultiplier", "ModDefense", "SellPrice" },
                values: new object[] { 80, 1, null, null, null, 40 });

            migrationBuilder.InsertData(
                table: "Equipments",
                columns: new[] { "Id", "BuyPrice", "Description", "Discriminator", "FlavorText", "IdCustom", "IsDeleted", "LvLPrerequisites", "MaterialTypeId", "ModCritChance", "ModCritMultiplier", "ModDefense", "ModDex", "ModHP", "ModIntel", "ModLVL", "ModMana", "ModResFire", "ModResIce", "ModResLightning", "ModStr", "ModVita", "Name", "SellPrice", "Sprite", "TypeId" },
                values: new object[,]
                {
                    { 2L, 80, "Un arc court en bois, simple et fiable.", "Weapon", "Idéal pour apprendre à viser sans se ruiner.", 111000000002L, false, 1, 1, null, null, null, 15, null, null, null, null, null, null, null, null, null, "Arc court", 40, null, 1 },
                    { 3L, 80, "Une dague légère en fer, conçue pour frapper vite.", "Weapon", "Discrète, rapide… et parfois fatale.", 113000000003L, false, 1, 3, 0.02, null, null, 12, null, null, null, null, null, null, null, null, null, "Dague en fer", 40, null, 1 },
                    { 4L, 80, "Un bâton en bois gravé de runes simples.", "Weapon", "Un focus basique pour canaliser la magie.", 111000000004L, false, 1, 1, null, null, null, null, null, 15, null, null, null, null, null, null, null, "Bâton de mage", 40, null, 1 }
                });

            migrationBuilder.UpdateData(
                table: "Items",
                keyColumn: "Id",
                keyValue: 1L,
                column: "Effect",
                value: "Rend 30 HP");

            migrationBuilder.UpdateData(
                table: "Jobs",
                keyColumn: "Id",
                keyValue: 1,
                columns: new[] { "BonusCritChance", "BonusCritMultiplier", "BonusDefense" },
                values: new object[] { 0.01, 0.10000000000000001, 25 });

            migrationBuilder.UpdateData(
                table: "Jobs",
                keyColumn: "Id",
                keyValue: 2,
                columns: new[] { "BonusCritChance", "BonusCritMultiplier", "BonusDefense" },
                values: new object[] { 0.050000000000000003, 0.20000000000000001, 10 });

            migrationBuilder.UpdateData(
                table: "Jobs",
                keyColumn: "Id",
                keyValue: 3,
                columns: new[] { "BonusCritChance", "BonusCritMultiplier", "BonusDefense" },
                values: new object[] { 0.02, 0.29999999999999999, 5 });

            migrationBuilder.UpdateData(
                table: "Monsters",
                keyColumn: "Id",
                keyValue: 1L,
                columns: new[] { "CritChance", "CritMultiplier", "Defense", "Dex", "HP", "Intel", "ResIce", "Str", "Vita" },
                values: new object[] { 0.080000000000000002, 1.5, 10, 60, 70, 10, 0, 40, 40 });

            migrationBuilder.UpdateData(
                table: "Monsters",
                keyColumn: "Id",
                keyValue: 2L,
                columns: new[] { "CritChance", "CritMultiplier", "Defense", "Dex", "HP", "Intel", "ResFire", "Str", "Vita" },
                values: new object[] { 0.050000000000000003, 1.6000000000000001, 15, 20, 60, 30, 0, 45, 35 });

            migrationBuilder.UpdateData(
                table: "Monsters",
                keyColumn: "Id",
                keyValue: 3L,
                columns: new[] { "CritChance", "CritMultiplier", "Defense", "Dex", "HP", "Intel", "ResFire", "ResIce", "ResLightning", "Str", "Vita" },
                values: new object[] { 0.02, 1.3999999999999999, 30, 10, 120, 5, 25, -10, 25, 55, 70 });
        }

        /// <inheritdoc />
        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DeleteData(
                table: "Equipments",
                keyColumn: "Id",
                keyValue: 2L);

            migrationBuilder.DeleteData(
                table: "Equipments",
                keyColumn: "Id",
                keyValue: 3L);

            migrationBuilder.DeleteData(
                table: "Equipments",
                keyColumn: "Id",
                keyValue: 4L);

            migrationBuilder.DropColumn(
                name: "CritChance",
                table: "Monsters");

            migrationBuilder.DropColumn(
                name: "CritMultiplier",
                table: "Monsters");

            migrationBuilder.DropColumn(
                name: "Defense",
                table: "Monsters");

            migrationBuilder.DropColumn(
                name: "BonusCritChance",
                table: "Jobs");

            migrationBuilder.DropColumn(
                name: "BonusCritMultiplier",
                table: "Jobs");

            migrationBuilder.DropColumn(
                name: "BonusDefense",
                table: "Jobs");

            migrationBuilder.DropColumn(
                name: "ModCritChance",
                table: "Equipments");

            migrationBuilder.DropColumn(
                name: "ModCritMultiplier",
                table: "Equipments");

            migrationBuilder.DropColumn(
                name: "ModDefense",
                table: "Equipments");

            migrationBuilder.DropColumn(
                name: "CritChance",
                table: "Characters");

            migrationBuilder.DropColumn(
                name: "CritMultiplier",
                table: "Characters");

            migrationBuilder.DropColumn(
                name: "Defense",
                table: "Characters");

            migrationBuilder.UpdateData(
                table: "Equipments",
                keyColumn: "Id",
                keyValue: 1L,
                columns: new[] { "BuyPrice", "LvLPrerequisites", "SellPrice" },
                values: new object[] { 50, 0, 25 });

            migrationBuilder.UpdateData(
                table: "Items",
                keyColumn: "Id",
                keyValue: 1L,
                column: "Effect",
                value: "Rend 50 HP");

            migrationBuilder.UpdateData(
                table: "Monsters",
                keyColumn: "Id",
                keyValue: 1L,
                columns: new[] { "Dex", "HP", "Intel", "ResIce", "Str", "Vita" },
                values: new object[] { 40, 30, 25, 20, 10, 30 });

            migrationBuilder.UpdateData(
                table: "Monsters",
                keyColumn: "Id",
                keyValue: 2L,
                columns: new[] { "Dex", "HP", "Intel", "ResFire", "Str", "Vita" },
                values: new object[] { 10, 50, 5, 5, 40, 50 });

            migrationBuilder.UpdateData(
                table: "Monsters",
                keyColumn: "Id",
                keyValue: 3L,
                columns: new[] { "Dex", "HP", "Intel", "ResFire", "ResIce", "ResLightning", "Str", "Vita" },
                values: new object[] { 20, 100, 10, 20, 5, 50, 100, 50 });
        }
    }
}
