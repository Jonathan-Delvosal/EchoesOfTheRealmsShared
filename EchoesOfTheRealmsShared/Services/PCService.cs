using EchoesOfTheRealms;
using EchoesOfTheRealmsShared.DTO;
using Microsoft.EntityFrameworkCore;
using EchoesOfTheRealmsShared.Mappers;


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

    }
}
