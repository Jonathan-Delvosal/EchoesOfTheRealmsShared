using Microsoft.EntityFrameworkCore.Migrations;

#nullable disable

namespace EchoesOfTheRealmsShared.Migrations
{
    /// <inheritdoc />
    public partial class Mig0302262ModifJointure : Migration
    {
        /// <inheritdoc />
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropTable(
                name: "EquipmentMaterialType");

            migrationBuilder.DropTable(
                name: "EquipTypeEquipment");

            migrationBuilder.RenameColumn(
                name: "Type",
                table: "Equipments",
                newName: "TypeId");

            migrationBuilder.RenameColumn(
                name: "Materials",
                table: "Equipments",
                newName: "MaterialTypeId");

            migrationBuilder.CreateIndex(
                name: "IX_Equipments_MaterialTypeId",
                table: "Equipments",
                column: "MaterialTypeId");

            migrationBuilder.CreateIndex(
                name: "IX_Equipments_TypeId",
                table: "Equipments",
                column: "TypeId");

            migrationBuilder.AddForeignKey(
                name: "FK_Equipments_EquipTypes_TypeId",
                table: "Equipments",
                column: "TypeId",
                principalTable: "EquipTypes",
                principalColumn: "Id",
                onDelete: ReferentialAction.Cascade);

            migrationBuilder.AddForeignKey(
                name: "FK_Equipments_MaterialTypes_MaterialTypeId",
                table: "Equipments",
                column: "MaterialTypeId",
                principalTable: "MaterialTypes",
                principalColumn: "Id",
                onDelete: ReferentialAction.Cascade);
        }

        /// <inheritdoc />
        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropForeignKey(
                name: "FK_Equipments_EquipTypes_TypeId",
                table: "Equipments");

            migrationBuilder.DropForeignKey(
                name: "FK_Equipments_MaterialTypes_MaterialTypeId",
                table: "Equipments");

            migrationBuilder.DropIndex(
                name: "IX_Equipments_MaterialTypeId",
                table: "Equipments");

            migrationBuilder.DropIndex(
                name: "IX_Equipments_TypeId",
                table: "Equipments");

            migrationBuilder.RenameColumn(
                name: "TypeId",
                table: "Equipments",
                newName: "Type");

            migrationBuilder.RenameColumn(
                name: "MaterialTypeId",
                table: "Equipments",
                newName: "Materials");

            migrationBuilder.CreateTable(
                name: "EquipmentMaterialType",
                columns: table => new
                {
                    EquipmentId = table.Column<long>(type: "bigint", nullable: false),
                    MaterialTypesId = table.Column<int>(type: "int", nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_EquipmentMaterialType", x => new { x.EquipmentId, x.MaterialTypesId });
                    table.ForeignKey(
                        name: "FK_EquipmentMaterialType_Equipments_EquipmentId",
                        column: x => x.EquipmentId,
                        principalTable: "Equipments",
                        principalColumn: "Id",
                        onDelete: ReferentialAction.Cascade);
                    table.ForeignKey(
                        name: "FK_EquipmentMaterialType_MaterialTypes_MaterialTypesId",
                        column: x => x.MaterialTypesId,
                        principalTable: "MaterialTypes",
                        principalColumn: "Id",
                        onDelete: ReferentialAction.Cascade);
                });

            migrationBuilder.CreateTable(
                name: "EquipTypeEquipment",
                columns: table => new
                {
                    EquipmentId = table.Column<long>(type: "bigint", nullable: false),
                    TypesId = table.Column<int>(type: "int", nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_EquipTypeEquipment", x => new { x.EquipmentId, x.TypesId });
                    table.ForeignKey(
                        name: "FK_EquipTypeEquipment_EquipTypes_TypesId",
                        column: x => x.TypesId,
                        principalTable: "EquipTypes",
                        principalColumn: "Id",
                        onDelete: ReferentialAction.Cascade);
                    table.ForeignKey(
                        name: "FK_EquipTypeEquipment_Equipments_EquipmentId",
                        column: x => x.EquipmentId,
                        principalTable: "Equipments",
                        principalColumn: "Id",
                        onDelete: ReferentialAction.Cascade);
                });

            migrationBuilder.CreateIndex(
                name: "IX_EquipmentMaterialType_MaterialTypesId",
                table: "EquipmentMaterialType",
                column: "MaterialTypesId");

            migrationBuilder.CreateIndex(
                name: "IX_EquipTypeEquipment_TypesId",
                table: "EquipTypeEquipment",
                column: "TypesId");
        }
    }
}
