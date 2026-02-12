using EchoesOfTheRealms;
using EchoesOfTheRealmsShared.DTO;
using EchoesOfTheRealmsShared.Entities.CharacterFiles;
using EchoesOfTheRealmsShared.Entities.EquipmentFiles;
using EchoesOfTheRealmsShared.Entities.UserFiles;
using EchoesOfTheRealmsShared.Mappers;
using Microsoft.EntityFrameworkCore;


namespace EchoesOfTheRealmsShared.Services
{
    public class PCService(EotRContext _db)
    {

        public PCSheetDTO? GetPcByUserId(long IdUser, long IdPc)
        {
            var Character = _db.Characters
                .Include(c => c.Job)
                .Include(c => c.Helmet)
                    .ThenInclude(h => h.Type)
                .Include(c => c.Helmet)
                    .ThenInclude(h => h.MaterialType)
                .Include(c => c.Armor)
                    .ThenInclude(a => a.Type)
                .Include(c => c.Armor)
                    .ThenInclude(a => a.MaterialType)
                .Include(c => c.Boot)
                    .ThenInclude(b => b.Type)
                .Include(c => c.Boot)
                    .ThenInclude(b => b.MaterialType)
                .Include(c => c.Weapon)
                    .ThenInclude(w => w.Type)
                .Include(c => c.Weapon)
                    .ThenInclude(w => w.MaterialType)
                .FirstOrDefault(c => !c.IsDeleted && c.Id == IdPc && c.UserId == IdUser);

            return Character?.Map();
        }

        public List<PCSheetDTO> GetAllPcByUser(long IdUser)
        {

            var Characters = _db.Characters
                .Include(c => c.Job)
                .Include(c => c.Helmet)
                    .ThenInclude(h => h.Type)
                .Include(c => c.Helmet)
                    .ThenInclude(h => h.MaterialType)
                .Include(c => c.Armor)
                    .ThenInclude(a => a.Type)
                .Include(c => c.Armor)
                    .ThenInclude(a => a.MaterialType)
                .Include(c => c.Boot)
                    .ThenInclude(b => b.Type)
                .Include(c => c.Boot)
                    .ThenInclude(b => b.MaterialType)
                .Include(c => c.Weapon)
                    .ThenInclude(w => w.Type)
                .Include(c => c.Weapon)
                    .ThenInclude(w => w.MaterialType)
                .Where(c => !c.IsDeleted && c.UserId == IdUser);

            return Characters.Select(MapperExtension.Map).ToList();

        }

        public List<JobDTO> GetAllJobs()
        {

            var Job = _db.Jobs.Where(c => !c.IsDeleted).Select(
                MapperExtension.Map
             ).ToList();


            return Job;
        }

        public void PutSavePC(SavingPCDTO dto, long idUser, long idPc)
        {
            Character Sheet = 
                _db.Characters.FirstOrDefault(c => !c.IsDeleted && c.Id == idPc && c.UserId == idUser) ?? throw new Exception("Le personnage n'existe pas");

            Sheet.HP = Math.Max(0, dto.Hp);
            Sheet.Mana = Math.Max(0, dto.Mana);

            Sheet.LvL = dto.Lvl;
            Sheet.XP = dto.Xp;
            Sheet.Gold = dto.Gold;

            Sheet.JobId = dto.JobId;
            Sheet.WeaponId = dto.WeaponId;
            Sheet.HelmetId = dto.HelmetId;
            Sheet.ArmorId = dto.ArmorId;
            Sheet.BootId =  dto.BootId;

            _db.SaveChanges();
        }

        public void PostNewPC(NewPCSheetDTO dto, int idU)
        {


            Character Sheet = new Character() { 
                Name = dto.Name,
                JobId = dto.JobId,
                HP = 50,
                HPMax = 50,
                Mana = 50,
                ManaMax = 50,
                Str = 50,
                Dex = 50,
                Intel = 50,
                Vita = 100,
                VitaMax = 100,
                ResFire = 10,
                ResIce = 10,
                ResLightning = 10,
                LvL = 1,
                UserId = idU,
                IsDeleted = false
            };

            _db.Characters.Add(Sheet);
            _db.SaveChanges();
        }

        public PCSheetResolvedDTO? GetPcResolvedByUserId(long idUser, long idPc)
        {
            var c = _db.Characters
                .Include(x => x.Job)
                .Include(x => x.Helmet).ThenInclude(h => h.Type)
                .Include(x => x.Helmet).ThenInclude(h => h.MaterialType)
                .Include(x => x.Armor).ThenInclude(a => a.Type)
                .Include(x => x.Armor).ThenInclude(a => a.MaterialType)
                .Include(x => x.Boot).ThenInclude(b => b.Type)
                .Include(x => x.Boot).ThenInclude(b => b.MaterialType)
                .Include(x => x.Weapon).ThenInclude(w => w.Type)
                .Include(x => x.Weapon).ThenInclude(w => w.MaterialType)
                .FirstOrDefault(x => !x.IsDeleted && x.Id == idPc && x.UserId == idUser);

            return c?.MapResolved();
        }

    }
}
