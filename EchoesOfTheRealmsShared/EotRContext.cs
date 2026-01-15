using Microsoft.EntityFrameworkCore;
using EchoesOfTheRealmsShared.Entities.UserFiles;
using EchoesOfTheRealmsShared.Entities.EquipmentFiles;
using EchoesOfTheRealmsShared.Entities.ItemFiles;
using EchoesOfTheRealmsShared.Entities.MonsterFiles;
using EchoesOfTheRealmsShared.Entities.CharacterFiles;
using EchoesOfTheRealmsShared.Entities.Useless;
using EchoesOfTheRealmsShared.Entities.NPCFiles;
using EchoesOfTheRealmsShared.Entities.QuestFiles;

namespace EchoesOfTheRealms
{
    public class EotRContext(DbContextOptions options) : DbContext(options)
    {

        public DbSet<Character> Characters { get; set; }
        public DbSet<Job> Jobs { get; set; }

        public DbSet<Equipment> Equipments { get; set; }
        public DbSet<Weapon> Weapons { get; set; }
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
                        Mana = 50,
                        Str = 50,
                        Dex = 50,
                        Intel = 50,
                        Vita = 100,
                        ResFire = 10,
                        ResIce = 10,
                        ResLightning = 10,
                        LvL = 1,
                        XP = 0,
                        Gold = 100,
                        IsDeleted = false,
                        UserId = 1,
                        JobId = 1
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
                        BonusResFire = 20,
                        BonusResIce = 20,
                        BonusResLightning = 20,
                        IsDeleted = false
                    },
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
                        Type = 1,
                        Materials = 3,
                        IdCustom = 113000000001,
                        Name = "Epée en fer",
                        Description = "Une épée basique en fer.",
                        FlavorText = "Une épée parfaite pour les débutants.",
                        ModStr = 15,
                        BuyPrice = 50,
                        SellPrice = 25,
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
                        Effect = "Rend 50 HP", //a remplacer par un effet fonctionnelle
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
                    HP = 30, 
                    Mana = 1, 
                    Level = 1, 
                    Str = 10, 
                    Dex = 40, 
                    Intel = 25, 
                    Vita = 30, 
                    ResFire = 5, 
                    ResIce = 20, 
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
                    HP = 50,
                    Mana = 1,
                    Level = 1,
                    Str = 40,
                    Dex = 10,
                    Intel = 5,
                    Vita = 50,
                    ResFire = 5,
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
                    HP = 100,
                    Mana = 1,
                    Level = 1,
                    Str = 100,
                    Dex = 20,
                    Intel = 10,
                    Vita = 50,
                    ResFire = 20,
                    ResIce = 5,
                    ResLightning = 50,
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
                    Name = "Admin" 
                },
                new UserRole
                { 
                    Id = 2, 
                    Name = "User" 
                },
                new UserRole
                { 
                    Id = 3, 
                    Name = "Moderator" 
                },

                ]);


            modelBuilder.Entity<User>().HasData([
                new User
                    { 
                        Id = 1, 
                        NickName = "Hakuryu", 
                        LastName = "Delvosal", 
                        FirstName = "Jonathan", 
                        Mail = "jonathan.delvosal@outlook.com",
                        Note = "Créateur du jeu",
                        IsBanned = false,
                        IsDeleted = false  
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
