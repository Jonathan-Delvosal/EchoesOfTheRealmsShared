using EchoesOfTheRealms;
using EchoesOfTheRealmsShared.DTO;
using EchoesOfTheRealmsShared.Entities.CharacterFiles;
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

            Sheet.HP = dto.Hp;
            Sheet.HPMax = dto.HpMax;
            Sheet.Mana = dto.Mana;
            Sheet.ManaMax = dto.ManaMax;
            Sheet.Str = dto.Str;
            Sheet.Dex = dto.Dex;
            Sheet.Intel = dto.Intel;
            Sheet.Vita = dto.Vita;
            Sheet.VitaMax = dto.VitaMax;
            Sheet.ResFire = dto.ResFire;
            Sheet.ResIce = dto.ResIce;
            Sheet.ResLightning = dto.ResLightning;
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

    }
}
