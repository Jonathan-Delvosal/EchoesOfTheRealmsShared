using Microsoft.EntityFrameworkCore.Migrations;

#nullable disable

#pragma warning disable CA1814 // Prefer jagged arrays over multidimensional

namespace EchoesOfTheRealmsShared.Migrations
{
    /// <inheritdoc />
    public partial class Mig080126 : Migration
    {
        /// <inheritdoc />
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.CreateTable(
                name: "EquipTypes",
                columns: table => new
                {
                    Id = table.Column<int>(type: "int", nullable: false)
                        .Annotation("SqlServer:Identity", "1, 1"),
                    Name = table.Column<string>(type: "nvarchar(450)", nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_EquipTypes", x => x.Id);
                });

            migrationBuilder.CreateTable(
                name: "ItemTypes",
                columns: table => new
                {
                    Id = table.Column<int>(type: "int", nullable: false)
                        .Annotation("SqlServer:Identity", "1, 1"),
                    Name = table.Column<string>(type: "nvarchar(max)", nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_ItemTypes", x => x.Id);
                });

            migrationBuilder.CreateTable(
                name: "Jobs",
                columns: table => new
                {
                    Id = table.Column<int>(type: "int", nullable: false)
                        .Annotation("SqlServer:Identity", "1, 1"),
                    Name = table.Column<string>(type: "nvarchar(450)", nullable: false),
                    BonusHP = table.Column<int>(type: "int", nullable: false),
                    BonusMana = table.Column<int>(type: "int", nullable: false),
                    BonusStr = table.Column<int>(type: "int", nullable: false),
                    BonusDex = table.Column<int>(type: "int", nullable: false),
                    BonusIntel = table.Column<int>(type: "int", nullable: false),
                    BonusLevel = table.Column<int>(type: "int", nullable: false),
                    BonusVita = table.Column<int>(type: "int", nullable: false),
                    BonusResFire = table.Column<int>(type: "int", nullable: false),
                    BonusResIce = table.Column<int>(type: "int", nullable: false),
                    BonusResLightning = table.Column<int>(type: "int", nullable: false),
                    Symbol = table.Column<string>(type: "nvarchar(max)", nullable: true),
                    IsDeleted = table.Column<bool>(type: "bit", nullable: false),
                    CharacterId = table.Column<int>(type: "int", nullable: true)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_Jobs", x => x.Id);
                });

            migrationBuilder.CreateTable(
                name: "MaterialTypes",
                columns: table => new
                {
                    Id = table.Column<int>(type: "int", nullable: false)
                        .Annotation("SqlServer:Identity", "1, 1"),
                    Name = table.Column<string>(type: "nvarchar(450)", nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_MaterialTypes", x => x.Id);
                });

            migrationBuilder.CreateTable(
                name: "MonstersTypes",
                columns: table => new
                {
                    Id = table.Column<int>(type: "int", nullable: false)
                        .Annotation("SqlServer:Identity", "1, 1"),
                    Name = table.Column<string>(type: "nvarchar(450)", nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_MonstersTypes", x => x.Id);
                });

            migrationBuilder.CreateTable(
                name: "NPCs",
                columns: table => new
                {
                    Id = table.Column<long>(type: "bigint", nullable: false)
                        .Annotation("SqlServer:Identity", "1, 1"),
                    LastName = table.Column<string>(type: "nvarchar(max)", nullable: false),
                    FirstName = table.Column<string>(type: "nvarchar(max)", nullable: false),
                    Identity = table.Column<string>(type: "nvarchar(max)", nullable: false),
                    Personnality = table.Column<string>(type: "nvarchar(max)", nullable: false),
                    Knownledge = table.Column<string>(type: "nvarchar(max)", nullable: false),
                    Behavior = table.Column<string>(type: "nvarchar(max)", nullable: false),
                    Limit = table.Column<string>(type: "nvarchar(max)", nullable: false),
                    Resume = table.Column<string>(type: "nvarchar(max)", nullable: false),
                    StyleLangage = table.Column<string>(type: "nvarchar(max)", nullable: false),
                    Gold = table.Column<int>(type: "int", nullable: false),
                    IsDeleted = table.Column<bool>(type: "bit", nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_NPCs", x => x.Id);
                });

            migrationBuilder.CreateTable(
                name: "UserRoles",
                columns: table => new
                {
                    Id = table.Column<int>(type: "int", nullable: false)
                        .Annotation("SqlServer:Identity", "1, 1"),
                    Name = table.Column<string>(type: "nvarchar(max)", nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_UserRoles", x => x.Id);
                });

            migrationBuilder.CreateTable(
                name: "Users",
                columns: table => new
                {
                    Id = table.Column<int>(type: "int", nullable: false)
                        .Annotation("SqlServer:Identity", "1, 1"),
                    NickName = table.Column<string>(type: "nvarchar(450)", nullable: false),
                    Avatar = table.Column<string>(type: "nvarchar(max)", nullable: true),
                    LastName = table.Column<string>(type: "nvarchar(max)", nullable: false),
                    FirstName = table.Column<string>(type: "nvarchar(max)", nullable: false),
                    Mail = table.Column<string>(type: "nvarchar(450)", nullable: false),
                    Note = table.Column<string>(type: "nvarchar(max)", nullable: false),
                    IsBanned = table.Column<bool>(type: "bit", nullable: false),
                    IsDeleted = table.Column<bool>(type: "bit", nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_Users", x => x.Id);
                });

            migrationBuilder.CreateTable(
                name: "Items",
                columns: table => new
                {
                    Id = table.Column<long>(type: "bigint", nullable: false)
                        .Annotation("SqlServer:Identity", "1, 1"),
                    IdCustom = table.Column<long>(type: "bigint", nullable: false),
                    Name = table.Column<string>(type: "nvarchar(max)", nullable: false),
                    Description = table.Column<string>(type: "nvarchar(max)", nullable: false),
                    FlavorText = table.Column<string>(type: "nvarchar(max)", nullable: false),
                    Effect = table.Column<string>(type: "nvarchar(max)", nullable: false),
                    BuyPrice = table.Column<int>(type: "int", nullable: false),
                    SellPrice = table.Column<int>(type: "int", nullable: false),
                    Sprite = table.Column<string>(type: "nvarchar(max)", nullable: true),
                    IsDeleted = table.Column<bool>(type: "bit", nullable: false),
                    ItemTypeId = table.Column<int>(type: "int", nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_Items", x => x.Id);
                    table.ForeignKey(
                        name: "FK_Items_ItemTypes_ItemTypeId",
                        column: x => x.ItemTypeId,
                        principalTable: "ItemTypes",
                        principalColumn: "Id",
                        onDelete: ReferentialAction.Cascade);
                });

            migrationBuilder.CreateTable(
                name: "Monsters",
                columns: table => new
                {
                    Id = table.Column<long>(type: "bigint", nullable: false)
                        .Annotation("SqlServer:Identity", "1, 1"),
                    Name = table.Column<string>(type: "nvarchar(max)", nullable: false),
                    HP = table.Column<int>(type: "int", nullable: false),
                    Mana = table.Column<int>(type: "int", nullable: false),
                    Str = table.Column<int>(type: "int", nullable: false),
                    Dex = table.Column<int>(type: "int", nullable: false),
                    Intel = table.Column<int>(type: "int", nullable: false),
                    Level = table.Column<int>(type: "int", nullable: false),
                    Vita = table.Column<int>(type: "int", nullable: false),
                    ResFire = table.Column<int>(type: "int", nullable: false),
                    ResIce = table.Column<int>(type: "int", nullable: false),
                    ResLightning = table.Column<int>(type: "int", nullable: false),
                    Sprite = table.Column<string>(type: "nvarchar(max)", nullable: true),
                    IsDeleted = table.Column<bool>(type: "bit", nullable: false),
                    XPGiven = table.Column<int>(type: "int", nullable: false),
                    GoldGiven = table.Column<int>(type: "int", nullable: false),
                    MonsterTypeId = table.Column<int>(type: "int", nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_Monsters", x => x.Id);
                    table.ForeignKey(
                        name: "FK_Monsters_MonstersTypes_MonsterTypeId",
                        column: x => x.MonsterTypeId,
                        principalTable: "MonstersTypes",
                        principalColumn: "Id",
                        onDelete: ReferentialAction.Cascade);
                });

            migrationBuilder.CreateTable(
                name: "Adress",
                columns: table => new
                {
                    Id = table.Column<int>(type: "int", nullable: false)
                        .Annotation("SqlServer:Identity", "1, 1"),
                    Street = table.Column<string>(type: "nvarchar(max)", nullable: false),
                    Number = table.Column<int>(type: "int", nullable: false),
                    NumberBox = table.Column<int>(type: "int", nullable: false),
                    City = table.Column<string>(type: "nvarchar(max)", nullable: false),
                    PostalCode = table.Column<int>(type: "int", nullable: false),
                    Country = table.Column<string>(type: "nvarchar(max)", nullable: false),
                    CustomerId = table.Column<int>(type: "int", nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_Adress", x => x.Id);
                    table.ForeignKey(
                        name: "FK_Adress_Users_CustomerId",
                        column: x => x.CustomerId,
                        principalTable: "Users",
                        principalColumn: "Id",
                        onDelete: ReferentialAction.Cascade);
                });

            migrationBuilder.CreateTable(
                name: "Characters",
                columns: table => new
                {
                    Id = table.Column<long>(type: "bigint", nullable: false)
                        .Annotation("SqlServer:Identity", "1, 1"),
                    Name = table.Column<string>(type: "nvarchar(450)", nullable: false),
                    HP = table.Column<int>(type: "int", nullable: false),
                    Mana = table.Column<int>(type: "int", nullable: false),
                    Str = table.Column<int>(type: "int", nullable: false),
                    Dex = table.Column<int>(type: "int", nullable: false),
                    Intel = table.Column<int>(type: "int", nullable: false),
                    Vita = table.Column<int>(type: "int", nullable: false),
                    ResFire = table.Column<int>(type: "int", nullable: false),
                    ResIce = table.Column<int>(type: "int", nullable: false),
                    ResLightning = table.Column<int>(type: "int", nullable: false),
                    LvL = table.Column<int>(type: "int", nullable: false),
                    XP = table.Column<int>(type: "int", nullable: false),
                    Gold = table.Column<int>(type: "int", nullable: false),
                    Sprite = table.Column<string>(type: "nvarchar(max)", nullable: true),
                    IsDeleted = table.Column<bool>(type: "bit", nullable: false),
                    UserId = table.Column<int>(type: "int", nullable: false),
                    JobId = table.Column<int>(type: "int", nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_Characters", x => x.Id);
                    table.ForeignKey(
                        name: "FK_Characters_Jobs_JobId",
                        column: x => x.JobId,
                        principalTable: "Jobs",
                        principalColumn: "Id",
                        onDelete: ReferentialAction.Cascade);
                    table.ForeignKey(
                        name: "FK_Characters_Users_UserId",
                        column: x => x.UserId,
                        principalTable: "Users",
                        principalColumn: "Id",
                        onDelete: ReferentialAction.Cascade);
                });

            migrationBuilder.CreateTable(
                name: "UserUserRole",
                columns: table => new
                {
                    UserRolesId = table.Column<int>(type: "int", nullable: false),
                    UsersId = table.Column<int>(type: "int", nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_UserUserRole", x => new { x.UserRolesId, x.UsersId });
                    table.ForeignKey(
                        name: "FK_UserUserRole_UserRoles_UserRolesId",
                        column: x => x.UserRolesId,
                        principalTable: "UserRoles",
                        principalColumn: "Id",
                        onDelete: ReferentialAction.Cascade);
                    table.ForeignKey(
                        name: "FK_UserUserRole_Users_UsersId",
                        column: x => x.UsersId,
                        principalTable: "Users",
                        principalColumn: "Id",
                        onDelete: ReferentialAction.Cascade);
                });

            migrationBuilder.CreateTable(
                name: "ItemMonster",
                columns: table => new
                {
                    ItemsId = table.Column<long>(type: "bigint", nullable: false),
                    MonstersId = table.Column<long>(type: "bigint", nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_ItemMonster", x => new { x.ItemsId, x.MonstersId });
                    table.ForeignKey(
                        name: "FK_ItemMonster_Items_ItemsId",
                        column: x => x.ItemsId,
                        principalTable: "Items",
                        principalColumn: "Id",
                        onDelete: ReferentialAction.Cascade);
                    table.ForeignKey(
                        name: "FK_ItemMonster_Monsters_MonstersId",
                        column: x => x.MonstersId,
                        principalTable: "Monsters",
                        principalColumn: "Id",
                        onDelete: ReferentialAction.Cascade);
                });

            migrationBuilder.CreateTable(
                name: "CharacterItem",
                columns: table => new
                {
                    CharactersId = table.Column<long>(type: "bigint", nullable: false),
                    ItemsId = table.Column<long>(type: "bigint", nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_CharacterItem", x => new { x.CharactersId, x.ItemsId });
                    table.ForeignKey(
                        name: "FK_CharacterItem_Characters_CharactersId",
                        column: x => x.CharactersId,
                        principalTable: "Characters",
                        principalColumn: "Id",
                        onDelete: ReferentialAction.Cascade);
                    table.ForeignKey(
                        name: "FK_CharacterItem_Items_ItemsId",
                        column: x => x.ItemsId,
                        principalTable: "Items",
                        principalColumn: "Id",
                        onDelete: ReferentialAction.Cascade);
                });

            migrationBuilder.CreateTable(
                name: "Equipments",
                columns: table => new
                {
                    Id = table.Column<long>(type: "bigint", nullable: false)
                        .Annotation("SqlServer:Identity", "1, 1"),
                    IdCustom = table.Column<long>(type: "bigint", nullable: false),
                    Name = table.Column<string>(type: "nvarchar(max)", nullable: false),
                    Description = table.Column<string>(type: "nvarchar(max)", nullable: false),
                    FlavorText = table.Column<string>(type: "nvarchar(max)", nullable: true),
                    ModHP = table.Column<int>(type: "int", nullable: true),
                    ModMana = table.Column<int>(type: "int", nullable: true),
                    ModStr = table.Column<int>(type: "int", nullable: true),
                    ModDex = table.Column<int>(type: "int", nullable: true),
                    ModIntel = table.Column<int>(type: "int", nullable: true),
                    ModLVL = table.Column<int>(type: "int", nullable: true),
                    BuyPrice = table.Column<int>(type: "int", nullable: false),
                    SellPrice = table.Column<int>(type: "int", nullable: false),
                    ModVita = table.Column<int>(type: "int", nullable: true),
                    ModResFire = table.Column<int>(type: "int", nullable: true),
                    ModResIce = table.Column<int>(type: "int", nullable: true),
                    ModResLightning = table.Column<int>(type: "int", nullable: true),
                    LvLPrerequisites = table.Column<int>(type: "int", nullable: false),
                    Sprite = table.Column<string>(type: "nvarchar(max)", nullable: true),
                    IsDeleted = table.Column<bool>(type: "bit", nullable: false),
                    Type = table.Column<int>(type: "int", nullable: false),
                    Materials = table.Column<int>(type: "int", nullable: false),
                    CharacterId = table.Column<long>(type: "bigint", nullable: true),
                    Discriminator = table.Column<string>(type: "nvarchar(13)", maxLength: 13, nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_Equipments", x => x.Id);
                    table.ForeignKey(
                        name: "FK_Equipments_Characters_CharacterId",
                        column: x => x.CharacterId,
                        principalTable: "Characters",
                        principalColumn: "Id");
                });

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
                name: "EquipmentMonster",
                columns: table => new
                {
                    EquipmentId = table.Column<long>(type: "bigint", nullable: false),
                    MonsterId = table.Column<long>(type: "bigint", nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_EquipmentMonster", x => new { x.EquipmentId, x.MonsterId });
                    table.ForeignKey(
                        name: "FK_EquipmentMonster_Equipments_EquipmentId",
                        column: x => x.EquipmentId,
                        principalTable: "Equipments",
                        principalColumn: "Id",
                        onDelete: ReferentialAction.Cascade);
                    table.ForeignKey(
                        name: "FK_EquipmentMonster_Monsters_MonsterId",
                        column: x => x.MonsterId,
                        principalTable: "Monsters",
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

            migrationBuilder.CreateTable(
                name: "Quests",
                columns: table => new
                {
                    Id = table.Column<long>(type: "bigint", nullable: false)
                        .Annotation("SqlServer:Identity", "1, 1"),
                    Name = table.Column<string>(type: "nvarchar(max)", nullable: false),
                    Description = table.Column<string>(type: "nvarchar(max)", nullable: false),
                    Success = table.Column<bool>(type: "bit", nullable: false),
                    Failure = table.Column<bool>(type: "bit", nullable: false),
                    LvlPrerequisites = table.Column<int>(type: "int", nullable: false),
                    XPGiven = table.Column<int>(type: "int", nullable: false),
                    GoldGiven = table.Column<int>(type: "int", nullable: false),
                    IsDeleted = table.Column<bool>(type: "bit", nullable: false),
                    NpcId = table.Column<long>(type: "bigint", nullable: false),
                    ItemId = table.Column<long>(type: "bigint", nullable: true),
                    EquipmentId = table.Column<long>(type: "bigint", nullable: true)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_Quests", x => x.Id);
                    table.ForeignKey(
                        name: "FK_Quests_Equipments_EquipmentId",
                        column: x => x.EquipmentId,
                        principalTable: "Equipments",
                        principalColumn: "Id");
                    table.ForeignKey(
                        name: "FK_Quests_Items_ItemId",
                        column: x => x.ItemId,
                        principalTable: "Items",
                        principalColumn: "Id");
                    table.ForeignKey(
                        name: "FK_Quests_NPCs_NpcId",
                        column: x => x.NpcId,
                        principalTable: "NPCs",
                        principalColumn: "Id",
                        onDelete: ReferentialAction.Cascade);
                });

            migrationBuilder.CreateTable(
                name: "CharacterQuest",
                columns: table => new
                {
                    CharactersId = table.Column<long>(type: "bigint", nullable: false),
                    QuestsId = table.Column<long>(type: "bigint", nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_CharacterQuest", x => new { x.CharactersId, x.QuestsId });
                    table.ForeignKey(
                        name: "FK_CharacterQuest_Characters_CharactersId",
                        column: x => x.CharactersId,
                        principalTable: "Characters",
                        principalColumn: "Id",
                        onDelete: ReferentialAction.Cascade);
                    table.ForeignKey(
                        name: "FK_CharacterQuest_Quests_QuestsId",
                        column: x => x.QuestsId,
                        principalTable: "Quests",
                        principalColumn: "Id",
                        onDelete: ReferentialAction.Cascade);
                });

            migrationBuilder.InsertData(
                table: "EquipTypes",
                columns: new[] { "Id", "Name" },
                values: new object[,]
                {
                    { 1, "Armes" },
                    { 2, "Casque" },
                    { 3, "Armure" },
                    { 4, "Bottes" }
                });

            migrationBuilder.InsertData(
                table: "Equipments",
                columns: new[] { "Id", "BuyPrice", "CharacterId", "Description", "Discriminator", "FlavorText", "IdCustom", "IsDeleted", "LvLPrerequisites", "Materials", "ModDex", "ModHP", "ModIntel", "ModLVL", "ModMana", "ModResFire", "ModResIce", "ModResLightning", "ModStr", "ModVita", "Name", "SellPrice", "Sprite", "Type" },
                values: new object[] { 1L, 50, null, "Une épée basique en fer.", "Weapon", "Une épée parfaite pour les débutants.", 113000000001L, false, 0, 3, null, null, null, null, null, null, null, null, 15, null, "Epée en fer", 25, null, 1 });

            migrationBuilder.InsertData(
                table: "ItemTypes",
                columns: new[] { "Id", "Name" },
                values: new object[,]
                {
                    { 1, "Potion" },
                    { 2, "Bombe" },
                    { 3, "Pierre" }
                });

            migrationBuilder.InsertData(
                table: "Jobs",
                columns: new[] { "Id", "BonusDex", "BonusHP", "BonusIntel", "BonusLevel", "BonusMana", "BonusResFire", "BonusResIce", "BonusResLightning", "BonusStr", "BonusVita", "CharacterId", "IsDeleted", "Name", "Symbol" },
                values: new object[,]
                {
                    { 1, 50, 100, 25, 0, 25, 10, 10, 10, 100, 200, null, false, "Guerrier", null },
                    { 2, 100, 75, 25, 0, 50, 10, 10, 10, 50, 150, null, false, "Voleur", null },
                    { 3, 50, 50, 100, 0, 100, 20, 20, 20, 25, 150, null, false, "Mage", null }
                });

            migrationBuilder.InsertData(
                table: "MaterialTypes",
                columns: new[] { "Id", "Name" },
                values: new object[,]
                {
                    { 1, "Bois" },
                    { 2, "Tissu" },
                    { 3, "Fer" }
                });

            migrationBuilder.InsertData(
                table: "MonstersTypes",
                columns: new[] { "Id", "Name" },
                values: new object[,]
                {
                    { 1, "Loup" },
                    { 2, "Squelette" },
                    { 3, "Golem" }
                });

            migrationBuilder.InsertData(
                table: "NPCs",
                columns: new[] { "Id", "Behavior", "FirstName", "Gold", "Identity", "IsDeleted", "Knownledge", "LastName", "Limit", "Personnality", "Resume", "StyleLangage" },
                values: new object[] { 1L, "Tu ne récites jamais ton pédigré complet. Tu ne donnes que les informations utiles. Tu parles et agis comme une personne réelle de cet univers. Tu ne donnes jamais de réponses méta. Tu peux mentir, te tromper ou refuser de répondre si cela correspond à ton caractère. Tu réagis émotionnellement selon la situation.", "Arcon", 500, "Ton prénom est Arcon et ton nom de famille est Mancyan. Tu es un marchand établi dans la ville de Libra, personnage non-joueur de l’univers Pyrékrim. Tu existes uniquement dans cet univers fictif.", false, "Tu connais uniquement ce qui est cohérent avec ton rôle et ton vécu. Tu ignores toute information extérieure à l’univers Pyrékrim. Tu ne connais pas le futur, seulement ton passé et le présent.", "Mancyan", "Tu n’es pas une IA et tu ne reconnais jamais être un programme. Tu ne fais jamais référence à des règles, instructions ou messages système. Si une question sort de l’univers, tu réponds de manière in-universe (confusion, ironie, colère ou silence).", "Tu es un marchand bourru, vieux célibataire depuis la mort de ta femme, sans enfant. Tu es souvent en colère, même si ta boutique fonctionne bien. Tu t’entends correctement avec tes fournisseurs. Ton caractère influence directement tes réponses.", "", "Tu réponds uniquement en français. Ton langage est bourru, parfois insultant. Tu n’aimes pas les échanges inutiles ou futiles. Tes réponses sont courtes à moyennes. Tu n’utilises jamais de listes ni de markdown." });

            migrationBuilder.InsertData(
                table: "UserRoles",
                columns: new[] { "Id", "Name" },
                values: new object[,]
                {
                    { 1, "Admin" },
                    { 2, "User" },
                    { 3, "Moderator" }
                });

            migrationBuilder.InsertData(
                table: "Users",
                columns: new[] { "Id", "Avatar", "FirstName", "IsBanned", "IsDeleted", "LastName", "Mail", "NickName", "Note" },
                values: new object[] { 1, null, "Jonathan", false, false, "Delvosal", "jonathan.delvosal@outlook.com", "Hakuryu", "Créateur du jeu" });

            migrationBuilder.InsertData(
                table: "Adress",
                columns: new[] { "Id", "City", "Country", "CustomerId", "Number", "NumberBox", "PostalCode", "Street" },
                values: new object[] { 1, "Namur", "Belgique", 1, 136, 11, 5002, "Chaussée de Waterloo" });

            migrationBuilder.InsertData(
                table: "Characters",
                columns: new[] { "Id", "Dex", "Gold", "HP", "Intel", "IsDeleted", "JobId", "LvL", "Mana", "Name", "ResFire", "ResIce", "ResLightning", "Sprite", "Str", "UserId", "Vita", "XP" },
                values: new object[] { 1L, 50, 100, 50, 50, false, 1, 1, 50, "Haku", 10, 10, 10, null, 50, 1, 100, 0 });

            migrationBuilder.InsertData(
                table: "Items",
                columns: new[] { "Id", "BuyPrice", "Description", "Effect", "FlavorText", "IdCustom", "IsDeleted", "ItemTypeId", "Name", "SellPrice", "Sprite" },
                values: new object[] { 1L, 10, "Une simple potion de soin.", "Rend 50 HP", "Une petite potion qui vous rendra quelques points de vie, afin de tenir jusqu'à la fin du combat.", 21000000001L, false, 1, "Potion de soin", 5, null });

            migrationBuilder.InsertData(
                table: "Monsters",
                columns: new[] { "Id", "Dex", "GoldGiven", "HP", "Intel", "IsDeleted", "Level", "Mana", "MonsterTypeId", "Name", "ResFire", "ResIce", "ResLightning", "Sprite", "Str", "Vita", "XPGiven" },
                values: new object[] { 1L, 40, 10, 30, 25, false, 1, 1, 1, "Loup des steppes", 5, 20, 5, null, 10, 30, 25 });

            migrationBuilder.CreateIndex(
                name: "IX_Adress_CustomerId",
                table: "Adress",
                column: "CustomerId",
                unique: true);

            migrationBuilder.CreateIndex(
                name: "IX_CharacterItem_ItemsId",
                table: "CharacterItem",
                column: "ItemsId");

            migrationBuilder.CreateIndex(
                name: "IX_CharacterQuest_QuestsId",
                table: "CharacterQuest",
                column: "QuestsId");

            migrationBuilder.CreateIndex(
                name: "IX_Characters_JobId",
                table: "Characters",
                column: "JobId",
                unique: true);

            migrationBuilder.CreateIndex(
                name: "IX_Characters_Name",
                table: "Characters",
                column: "Name",
                unique: true);

            migrationBuilder.CreateIndex(
                name: "IX_Characters_UserId",
                table: "Characters",
                column: "UserId");

            migrationBuilder.CreateIndex(
                name: "IX_EquipmentMaterialType_MaterialTypesId",
                table: "EquipmentMaterialType",
                column: "MaterialTypesId");

            migrationBuilder.CreateIndex(
                name: "IX_EquipmentMonster_MonsterId",
                table: "EquipmentMonster",
                column: "MonsterId");

            migrationBuilder.CreateIndex(
                name: "IX_Equipments_CharacterId",
                table: "Equipments",
                column: "CharacterId");

            migrationBuilder.CreateIndex(
                name: "IX_EquipTypeEquipment_TypesId",
                table: "EquipTypeEquipment",
                column: "TypesId");

            migrationBuilder.CreateIndex(
                name: "IX_EquipTypes_Name",
                table: "EquipTypes",
                column: "Name",
                unique: true);

            migrationBuilder.CreateIndex(
                name: "IX_ItemMonster_MonstersId",
                table: "ItemMonster",
                column: "MonstersId");

            migrationBuilder.CreateIndex(
                name: "IX_Items_ItemTypeId",
                table: "Items",
                column: "ItemTypeId");

            migrationBuilder.CreateIndex(
                name: "IX_Jobs_Name",
                table: "Jobs",
                column: "Name",
                unique: true);

            migrationBuilder.CreateIndex(
                name: "IX_MaterialTypes_Name",
                table: "MaterialTypes",
                column: "Name",
                unique: true);

            migrationBuilder.CreateIndex(
                name: "IX_Monsters_MonsterTypeId",
                table: "Monsters",
                column: "MonsterTypeId");

            migrationBuilder.CreateIndex(
                name: "IX_MonstersTypes_Name",
                table: "MonstersTypes",
                column: "Name",
                unique: true);

            migrationBuilder.CreateIndex(
                name: "IX_Quests_EquipmentId",
                table: "Quests",
                column: "EquipmentId");

            migrationBuilder.CreateIndex(
                name: "IX_Quests_ItemId",
                table: "Quests",
                column: "ItemId");

            migrationBuilder.CreateIndex(
                name: "IX_Quests_NpcId",
                table: "Quests",
                column: "NpcId",
                unique: true);

            migrationBuilder.CreateIndex(
                name: "IX_Users_Mail_NickName",
                table: "Users",
                columns: new[] { "Mail", "NickName" },
                unique: true);

            migrationBuilder.CreateIndex(
                name: "IX_Users_NickName",
                table: "Users",
                column: "NickName",
                unique: true);

            migrationBuilder.CreateIndex(
                name: "IX_UserUserRole_UsersId",
                table: "UserUserRole",
                column: "UsersId");
        }

        /// <inheritdoc />
        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropTable(
                name: "Adress");

            migrationBuilder.DropTable(
                name: "CharacterItem");

            migrationBuilder.DropTable(
                name: "CharacterQuest");

            migrationBuilder.DropTable(
                name: "EquipmentMaterialType");

            migrationBuilder.DropTable(
                name: "EquipmentMonster");

            migrationBuilder.DropTable(
                name: "EquipTypeEquipment");

            migrationBuilder.DropTable(
                name: "ItemMonster");

            migrationBuilder.DropTable(
                name: "UserUserRole");

            migrationBuilder.DropTable(
                name: "Quests");

            migrationBuilder.DropTable(
                name: "MaterialTypes");

            migrationBuilder.DropTable(
                name: "EquipTypes");

            migrationBuilder.DropTable(
                name: "Monsters");

            migrationBuilder.DropTable(
                name: "UserRoles");

            migrationBuilder.DropTable(
                name: "Equipments");

            migrationBuilder.DropTable(
                name: "Items");

            migrationBuilder.DropTable(
                name: "NPCs");

            migrationBuilder.DropTable(
                name: "MonstersTypes");

            migrationBuilder.DropTable(
                name: "Characters");

            migrationBuilder.DropTable(
                name: "ItemTypes");

            migrationBuilder.DropTable(
                name: "Jobs");

            migrationBuilder.DropTable(
                name: "Users");
        }
    }
}
