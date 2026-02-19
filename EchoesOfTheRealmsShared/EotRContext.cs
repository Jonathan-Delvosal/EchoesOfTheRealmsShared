using EchoesOfTheRealmsShared.Entities.AttackFiles;
using EchoesOfTheRealmsShared.Entities.CharacterFiles;
using EchoesOfTheRealmsShared.Entities.EquipmentFiles;
using EchoesOfTheRealmsShared.Entities.ItemFiles;
using EchoesOfTheRealmsShared.Entities.MonsterFiles;
using EchoesOfTheRealmsShared.Entities.NPCFiles;
using EchoesOfTheRealmsShared.Entities.QuestFiles;
using EchoesOfTheRealmsShared.Entities.Useless;
using EchoesOfTheRealmsShared.Entities.UserFiles;
using EchoesOfTheRealmsShared.Enums;
using EotR.App.Utils;
using Microsoft.EntityFrameworkCore;

namespace EchoesOfTheRealms
{
    public class EotRContext(DbContextOptions options) : DbContext(options)
    {

        public DbSet<Character> Characters { get; set; }
        public DbSet<Job> Jobs { get; set; }

        public DbSet<DamageType> DamageTypes { get; set; }
        public DbSet<Attacks> Attacks { get; set; }
        public DbSet<JobAttacks> JobAttacks { get; set; }
        public DbSet<MonsterAttacks> MonsterAttacks { get; set; }

        public DbSet<Equipment> Equipments { get; set; }
        public DbSet<Weapon> Weapons { get; set; }
        public DbSet<WeaponType> WeaponTypes { get; set; }
        public DbSet<Helmet> Helmets { get; set; }
        public DbSet<Armor> Armors { get; set; }
        public DbSet<Boot> Boots { get; set; }
        public DbSet<MaterialType> MaterialTypes { get; set; }
        public DbSet<EquipType> EquipTypes { get; set; }


        public DbSet<Item> Items { get; set; }
        public DbSet<ItemType> ItemTypes { get; set; }

        public DbSet<Monster> Monsters { get; set; }
        public DbSet<MonsterType> MonstersTypes { get; set; }

        public DbSet<NPC> NPCs { get; set; }

        public DbSet<Quest> Quests { get; set; }


        public DbSet<Address> Adress { get; set; }
        public DbSet<User> Users { get; set; }
        public DbSet<UserRole> UserRoles { get; set; }


        protected override void OnModelCreating(ModelBuilder modelBuilder)
        {

            modelBuilder.Entity<Character>().HasData([
                new Character
                {
                    Id = 1,
                    Name = "Haku",
                    HP = 50,
                    HPMax = 50,
                    Mana = 50,
                    ManaMax = 50,
                    Str = 50,
                    Dex = 50,
                    Intel = 50,
                    Vita = 100,
                    CritChance = 0.05,
                    CritMultiplier = 1.5,
                    Defense = 10,
                    ResFire = 10,
                    ResIce = 10,
                    ResLightning = 10,
                    LvL = 1,
                    XP = 0,
                    Gold = 100,
                    IsDeleted = false,
                    UserId = 1,
                    JobId = 1,
                    WeaponId = 1,
                }
            ]);

            modelBuilder.Entity<Job>().HasData([
                new Job
                {
                    Id = 1,
                    Name = "Guerrier",
                    BonusHP = 100,
                    BonusMana = 25,
                    BonusStr = 100,
                    BonusDex = 50,
                    BonusIntel = 25,
                    BonusLevel = 0,
                    BonusVita = 200,
                    BonusDefense = 25,
                    BonusCritChance = 0.01,
                    BonusCritMultiplier = 0.1,
                    BonusResFire = 10,
                    BonusResIce = 10,
                    BonusResLightning = 10,
                    IsDeleted = false
                 },

                new Job
                {
                    Id = 2,
                    Name = "Voleur",
                    BonusHP = 75,
                    BonusMana = 50,
                    BonusStr = 50,
                    BonusDex = 100,
                    BonusIntel = 25,
                    BonusLevel = 0,
                    BonusVita = 150,
                    BonusDefense = 10,
                    BonusCritChance = 0.05,
                    BonusCritMultiplier = 0.2,
                    BonusResFire = 10,
                    BonusResIce = 10,
                    BonusResLightning = 10,
                    IsDeleted = false
                },

                new Job
                {
                    Id = 3,
                    Name = "Mage",
                    BonusHP = 50,
                    BonusMana = 100,
                    BonusStr = 25,
                    BonusDex = 50,
                    BonusIntel = 100,
                    BonusLevel = 0,
                    BonusVita = 150,
                    BonusDefense = 5,
                    BonusCritChance = 0.02,
                    BonusCritMultiplier = 0.3,
                    BonusResFire = 20,
                    BonusResIce = 20,
                    BonusResLightning = 20,
                    IsDeleted = false
                },
            ]);

            modelBuilder.Entity<DamageType>().HasData([
                new DamageType
                {
                    Id = 1,
                    Name = "Physique",
                },

                new DamageType
                {
                    Id = 2,
                    Name = "Feu",
                },

                new DamageType
                {
                    Id = 3,
                    Name = "Glace",
                },

                new DamageType
                {
                    Id = 4,
                    Name = "Foudre",
                }
            ]);

            modelBuilder.Entity<JobAttacks>()
                        .HasKey(ja => new { ja.JobId, ja.AttackId });

            modelBuilder.Entity<MonsterAttacks>()
                        .HasKey(ma => new { ma.MonsterId, ma.AttackId });

            modelBuilder.Entity<Attacks>().HasData([
                new Attacks
                {
                    Id = 1,
                    Name = "Coup d'épée",
                    Description = "Une attaque basique à l'épée.",
                    ManaCost = 0,
                    Multiplier = 0.30,
                    CanCrit = true,
                    DefenseTarget = DefenseTargetType.Defense,      // 0 = Defense
                    PrimaryStat = StatType.Str,        // 0 = Str
                    SecondaryStat = null,
                    SecondaryWeight = 0.0,
                    DamageTypeId = 1        // 1 = Physique
                },

                new Attacks
                {
                    Id = 2,
                    Name = "Tir à la volée",
                    Description = "Un tir rapide visant à submerger l'adversaire.",
                    ManaCost = 0,
                    Multiplier = 0.30,
                    CanCrit = true,
                    DefenseTarget = DefenseTargetType.Defense,
                    PrimaryStat = StatType.Dex,
                    SecondaryStat = null,
                    SecondaryWeight = 0.0,
                    DamageTypeId = 1 // Physique
                },
                new Attacks
                {
                    Id = 3,
                    Name = "Lancer de dague",
                    Description = "Une dague lancée avec précision et force.",
                    ManaCost = 0,
                    Multiplier = 0.30,
                    CanCrit = true,
                    DefenseTarget = DefenseTargetType.Defense,
                    PrimaryStat = StatType.Dex,
                    SecondaryStat = StatType.Str,
                    SecondaryWeight = 0.30,
                    DamageTypeId = 1 // Physique
                },
                new Attacks
                {
                    Id = 4,
                    Name = "Éclat magique",
                    Description = "Un éclat d'énergie foudroyante frappant l'adversaire.",
                    ManaCost = 0,
                    Multiplier = 0.30,
                    CanCrit = true,
                    DefenseTarget = DefenseTargetType.Resistance,
                    PrimaryStat = StatType.Intel,
                    SecondaryStat = null,
                    SecondaryWeight = 0.0,
                    DamageTypeId = 4 // Foudre
                },
                new Attacks
                {
                    Id = 5,
                    Name = "Frappe écrasante",
                    Description = "Une frappe lourde qui écrase l'adversaire.",
                    ManaCost = 20,
                    Multiplier = 0.45,
                    CanCrit = true,
                    DefenseTarget = DefenseTargetType.Defense,
                    PrimaryStat = StatType.Str,
                    SecondaryStat = null,
                    SecondaryWeight = 0.0,
                    DamageTypeId = 1 // Physique
                },
                new Attacks
                {
                    Id = 6,
                    Name = "Flèche perçante",
                    Description = "Une flèche précise qui transperce la défense ennemie.",
                    ManaCost = 20,
                    Multiplier = 0.45,
                    CanCrit = true,
                    DefenseTarget = DefenseTargetType.Defense,
                    PrimaryStat = StatType.Dex,
                    SecondaryStat = null,
                    SecondaryWeight = 0.0,
                    DamageTypeId = 1 // Physique
                },
                new Attacks
                {
                    Id = 7,
                    Name = "Lacération",
                    Description = "Une entaille rapide qui ouvre une plaie profonde.",
                    ManaCost = 20,
                    Multiplier = 0.45,
                    CanCrit = true,
                    DefenseTarget = DefenseTargetType.Defense,
                    PrimaryStat = StatType.Dex,
                    SecondaryStat = StatType.Str,
                    SecondaryWeight = 0.40,
                    DamageTypeId = 1 // Physique
                },
                new Attacks
                {
                    Id = 8,
                    Name = "Boule de feu",
                    Description = "Projette une sphère de flammes brûlantes.",
                    ManaCost = 20,
                    Multiplier = 0.55,
                    CanCrit = true,
                    DefenseTarget = DefenseTargetType.Resistance,
                    PrimaryStat = StatType.Intel,
                    SecondaryStat = null,
                    SecondaryWeight = 0.0,
                    DamageTypeId = 2 // Feu
                },
                new Attacks
                {
                    Id = 9,
                    Name = "Lance de givre",
                    Description = "Projette une lance de givre qui transperce l'adversaire.",
                    ManaCost = 20,
                    Multiplier = 0.50,
                    CanCrit = true,
                    DefenseTarget = DefenseTargetType.Resistance,
                    PrimaryStat = StatType.Intel,
                    SecondaryStat = null,
                    SecondaryWeight = 0.0,
                    DamageTypeId = 3 // Glace
                },
                new Attacks
                {
                    Id = 10,
                    Name = "Arc électrique",
                    Description = "Un arc d'électricité qui frappe l'adversaire.",
                    ManaCost = 20,
                    Multiplier = 0.52,
                    CanCrit = true,
                    DefenseTarget = DefenseTargetType.Resistance,
                    PrimaryStat = StatType.Intel,
                    SecondaryStat = null,
                    SecondaryWeight = 0.0,
                    DamageTypeId = 4 // Foudre
                }
            ]);

            modelBuilder.Entity<JobAttacks>().HasData([
                new JobAttacks
                {
                    JobId = 1,        // Guerrier
                    AttackId = 1,     // Coup d'épée
                    RequiredLevel = 1
                },
                new JobAttacks
                {
                    JobId = 2,        // Voleur
                    AttackId = 2,     // Tir à la volée
                    RequiredLevel = 1
                },
                new JobAttacks
                {
                    JobId = 2,        // Voleur
                    AttackId = 3,     // Lancer de dague
                    RequiredLevel = 1
                },
                new JobAttacks
                {
                    JobId = 3,        // Mage
                    AttackId = 4,     // Éclat magique
                    RequiredLevel = 1
                },
                new JobAttacks
                {
                    JobId = 1,       // Guerrier
                    AttackId = 5,    // Frappe écrasante
                    RequiredLevel = 1
                },
                new JobAttacks
                {
                    JobId = 2,       // Voleur
                    AttackId = 6,    // Flèche perçante
                    RequiredLevel = 1
                },
                new JobAttacks
                {
                    JobId = 2,     // Voleur
                    AttackId = 7,  // Lacération
                    RequiredLevel = 1
                },
                new JobAttacks
                {
                    JobId = 3,     // Mage
                    AttackId = 8,  // Boule de feu
                    RequiredLevel = 1
                },
                new JobAttacks
                {
                    JobId = 3,     // Mage
                    AttackId = 9,  // Lance de givre
                    RequiredLevel = 1
                },
                new JobAttacks
                {
                    JobId = 3,      // Mage
                    AttackId = 10,  // Arc électrique
                    RequiredLevel = 1
                }
            ]);

            modelBuilder.Entity<MaterialType>().HasData([
                new MaterialType
                {
                    Id = 1,
                    Name = "Bois",
                },

                new MaterialType
                {
                    Id = 2,
                    Name = "Tissu",
                },

                new MaterialType
                {
                    Id = 3,
                    Name = "Fer",
                }
            ]);

            modelBuilder.Entity<EquipType>().HasData([
                new EquipType
                {
                    Id = 1,
                    Name = "Armes",
                },

                new EquipType
                {
                    Id = 2,
                    Name = "Casque",
                },

                new EquipType
                {
                    Id = 3,
                    Name = "Armure",
                },

                new EquipType
                {
                    Id = 4,
                    Name = "Bottes",
                }
            ]);

            modelBuilder.Entity<WeaponType>().HasData([
                new WeaponType
                {
                    Id = 1,
                    Name = "Epee",
                },

                new WeaponType
                {
                    Id = 2,
                    Name = "Arc",
                },

                new WeaponType
                {
                    Id = 3,
                    Name = "Dague",
                },

                new WeaponType
                {
                    Id = 4,
                    Name = "Bâton",
                }
            ]);

            //113000000001
            //    1 pour l'équpement
            //    1 pour le type d'équipement
            //      1 pour les armes
            //      2 pour les helmets
            //      3 pour les armors
            //      4 pour les boots
            //    3 pour le type de matériel (ici fer) à définir en fonction de la table MaterialType
            //    000000001 pour l'ID unique de l'équipement (9 chiffres au total)
            modelBuilder.Entity<Weapon>().HasData([
                new Weapon
                {
                    Id = 1,
                    TypeId = 1,
                    MaterialTypeId = 3,
                    WeaponTypeId = 1,
                    IdCustom = 113000000001,
                    Name = "Epée en fer",
                    Description = "Une épée basique en fer.",
                    FlavorText = "Une épée parfaite pour les débutants.",
                    ModStr = 15,
                    LvLPrerequisites = 1,
                    BuyPrice = 80,
                    SellPrice = 40,
                    IsDeleted = false
                },

                new Weapon
                {
                    Id = 2,
                    TypeId = 1,                 // Armes
                    MaterialTypeId = 1,         // Bois
                    WeaponTypeId = 2,
                    IdCustom = 111000000002,
                    Name = "Arc court",
                    Description = "Un arc court en bois, simple et fiable.",
                    FlavorText = "Idéal pour apprendre à viser sans se ruiner.",
                    ModDex = 15,
                    LvLPrerequisites = 1,
                    BuyPrice = 80,
                    SellPrice = 40,
                    IsDeleted = false
                },

                new Weapon
                {
                    Id = 3,
                    TypeId = 1,                 // Armes
                    MaterialTypeId = 3,         // Fer
                    WeaponTypeId = 3,
                    IdCustom = 113000000003,
                    Name = "Dague en fer",
                    Description = "Une dague légère en fer, conçue pour frapper vite.",
                    FlavorText = "Discrète, rapide… et parfois fatale.",
                    ModDex = 12,
                    ModCritChance = 0.02,       // +2% crit (léger, early-safe)
                    LvLPrerequisites = 1,
                    BuyPrice = 80,
                    SellPrice = 40,
                    IsDeleted = false
                },

                new Weapon
                {
                    Id = 4,
                    TypeId = 1,                 // Armes
                    MaterialTypeId = 1,         // Bois
                    WeaponTypeId= 4,
                    IdCustom = 111000000004,
                    Name = "Bâton de mage",
                    Description = "Un bâton en bois gravé de runes simples.",
                    FlavorText = "Un focus basique pour canaliser la magie.",
                    ModIntel = 15,
                    LvLPrerequisites = 1,
                    BuyPrice = 80,
                    SellPrice = 40,
                    IsDeleted = false
                }
            ]);

            modelBuilder.Entity<ItemType>().HasData([
                new ItemType
                {
                    Id = 1,
                    Name = "Potion"
                },

                new ItemType
                {
                    Id = 2,
                    Name = "Bombe"
                },

                new ItemType
                {
                    Id = 3,
                    Name = "Pierre",
                }
            ]);

            //21000000001
            //    2 pour l'objet
            //    1 pour le type d'objet (ici potion)
            //      1 voir table ItemType
            //    X pour le sous-type d'objet (à définir plus tard si nécessaire)
            //    000000001 pour l'ID unique de l'équipement (9 chiffres au totalà

            modelBuilder.Entity<Item>().HasData([
                new Item
                {
                    Id = 1,
                    ItemTypeId = 1,
                    IdCustom = 21000000001,
                    Name = "Potion de soin",
                    Description = "Une simple potion de soin.",
                    FlavorText = "Une petite potion qui vous rendra quelques points de vie, afin de tenir jusqu'à la fin du combat.",
                    Effect = "Rend 30 HP", //a remplacer par un effet fonctionnelle
                    BuyPrice = 10,
                    SellPrice = 5,
                    IsDeleted = false
                }
            ]);


            modelBuilder.Entity<MonsterType>().HasData([
                new MonsterType
                {
                    Id = 1,
                    Name = "Loup"
                },

                new MonsterType
                {
                    Id = 2,
                    Name = "Squelette"
                },

                new MonsterType
                {
                    Id = 3,
                    Name = "Golem",
                }
            ]);

            modelBuilder.Entity<Monster>().HasData([
                new Monster
                {
                    Id = 1,
                    MonsterTypeId = 1,
                    Name = "Loup des steppes",
                    HP = 70,
                    Mana = 1,
                    Level = 1,
                    Str = 40,
                    Dex = 60,
                    Intel = 10,
                    Vita = 40,
                    Defense = 10,
                    CritChance = 0.08,
                    CritMultiplier = 1.5,
                    ResFire = 5,
                    ResIce = 0,
                    ResLightning = 5,
                    XPGiven = 25,
                    GoldGiven = 10,
                    IsDeleted = false
                },

                new Monster
                {
                    Id = 2,
                    MonsterTypeId = 2,
                    Name = "Squelette décrépit",
                    HP = 60,
                    Mana = 1,
                    Level = 1,
                    Str = 45,
                    Dex = 20,
                    Intel = 30,
                    Vita = 35,
                    Defense = 15,
                    CritChance = 0.05,
                    CritMultiplier = 1.6,
                    ResFire = 0,
                    ResIce = 5,
                    ResLightning = 20,
                    XPGiven = 50,
                    GoldGiven = 25,
                    IsDeleted = false
                },

                new Monster
                {
                    Id = 3,
                    MonsterTypeId = 3,
                    Name = "Golem nain",
                    HP = 120,
                    Mana = 1,
                    Level = 1,
                    Str = 55,
                    Dex = 10,
                    Intel = 5,
                    Vita = 70,
                    Defense = 30,
                    CritChance = 0.02,
                    CritMultiplier = 1.4,
                    ResFire = 25,
                    ResIce = -10,
                    ResLightning = 25,
                    XPGiven = 100,
                    GoldGiven = 50,
                    IsDeleted = false
                }
            ]);


            modelBuilder.Entity<NPC>().HasData([
                new NPC
                {
                    Id = 1,
                    LastName = "Mancyan",
                    FirstName = "Arcon",
                    Identity = "Ton prénom est Arcon et ton nom de famille est Mancyan. Tu es un marchand établi dans la ville de Libra, personnage non-joueur de l’univers Pyrékrim. Tu existes uniquement dans cet univers fictif.",
                    Personnality = "Tu es un marchand bourru, vieux célibataire depuis la mort de ta femme, sans enfant. Tu es souvent en colère, même si ta boutique fonctionne bien. Tu t’entends correctement avec tes fournisseurs. Ton caractère influence directement tes réponses.",
                    Knownledge = "Tu connais uniquement ce qui est cohérent avec ton rôle et ton vécu. Tu ignores toute information extérieure à l’univers Pyrékrim. Tu ne connais pas le futur, seulement ton passé et le présent.",
                    Behavior = "Tu ne récites jamais ton pédigré complet. Tu ne donnes que les informations utiles. Tu parles et agis comme une personne réelle de cet univers. Tu ne donnes jamais de réponses méta. Tu peux mentir, te tromper ou refuser de répondre si cela correspond à ton caractère. Tu réagis émotionnellement selon la situation.",
                    Limit = "Tu n’es pas une IA et tu ne reconnais jamais être un programme. Tu ne fais jamais référence à des règles, instructions ou messages système. Si une question sort de l’univers, tu réponds de manière in-universe (confusion, ironie, colère ou silence).",
                    Resume = "",
                    StyleLangage = "Tu réponds uniquement en français. Ton langage est bourru, parfois insultant. Tu n’aimes pas les échanges inutiles ou futiles. Tes réponses sont courtes à moyennes. Tu n’utilises jamais de listes ni de markdown.",
                    Gold = 500,
                    NpcRoleId = 1,
                    IsDeleted = false,
                    //Quest = null
                }
                ]);

            modelBuilder.Entity<NPCRole>().HasData([
                new NPCRole
                {
                    Id = 1,
                    Name = "Marchand"
                }

            ]);

            modelBuilder.Entity<UserRole>().HasData([
                new UserRole
                {
                    Id = 1,
                    Name = "User"
                },
                new UserRole
                {
                    Id = 2,
                    Name = "Moderator"
                },
                new UserRole
                {
                    Id = 3,
                    Name = "Admin"
                },

            ]);


            modelBuilder.Entity<User>().HasData([
                new User
                    {
                        Id = 1,
                        NickName = "Hakuryu",
                        Password = PasswordUtils.HashPassword("Hakuryu1234-*", Guid.Parse("c3d435eb-8ca7-42ee-97b4-643d7ba76b36")),
                        LastName = "Delvosal",
                        FirstName = "Jonathan",
                        Mail = "jonathan.delvosal@outlook.com",
                        Note = "Créateur du jeu",
                        IsBanned = false,
                        IsDeleted = false ,
                    }
            ]);

            modelBuilder.Entity<Address>().HasData([
                new Address
                {
                    Id = 1,
                    Street = "Chaussée de Waterloo",
                    Number = 136,
                    NumberBox = 0011,
                    City = "Namur",
                    PostalCode = 5002,
                    Country = "Belgique",
                    CustomerId = 1}
            ]);

            modelBuilder.Entity<Character>().HasIndex("JobId").IsUnique(false);

            //modelBuilder.Entity<Quest>().HasData([
            //    new Quest
            //        {
            //            Id = 1,
            //            Name = "Massacre des Loups",
            //            Description = "Aller massacrer 10 loups des steppes",
            //            Success = false,
            //            Failure = false,
            //            LvlPrerequisites = 1,
            //            XPGiven = 300,
            //            GoldGiven = 500,
            //            IsDeleted = false
            //        }
            //    ]);

            //modelBuilder.Entity<EquipType>().HasData([
            //    new EquipType{ Id = 4, Name = "Epée"}
            //    ]);

            //modelBuilder.Entity<EquipType>().HasData([
            //    new EquipType{ Id = 5, Name = "Arc"}
            //    ]);

            //modelBuilder.Entity<EquipType>().HasData([
            //    new EquipType{ Id = 6, Name = "Bâton"}
            //    ]);

        }

    }
}
