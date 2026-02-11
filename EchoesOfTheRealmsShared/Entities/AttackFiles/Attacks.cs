using Microsoft.EntityFrameworkCore;
using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace EchoesOfTheRealmsShared.Entities.AttackFiles
{
    [Index("Name", IsUnique = true)]

    public class Attacks
    {
        [Key]
        public int Id { get; set; }

        [Required]
        public string Name { get; set; } = null!;

        public string? Description { get; set; }

        [Required]
        public int ManaCost { get; set; }

        [Required]
        public double Multiplier { get; set; }

        [Required]
        public bool CanCrit { get; set; }

        [Required]

        public Enums.DefenseTargetType DefenseTarget { get; set; }

        [Required]
        public Enums.StatType PrimaryStat { get; set; }

        public Enums.StatType? SecondaryStat { get; set; }

        [Required]
        public double SecondaryWeight { get; set; } = 0.0;

        [Required]
        public int DamageTypeId { get; set; }

        public DamageType DamageType { get; set; } = null!;

        public List<JobAttacks> JobAttacks { get; set; } = new();

        public List<MonsterAttacks> MonsterAttacks { get; set; } = new();




    }
}
