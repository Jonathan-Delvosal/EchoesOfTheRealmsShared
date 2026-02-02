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
                //.Include(c => c.HelmetId)
                //.Include(c => c.ArmorId)
                //.Include(c => c.BootId)
                //.Include(c => c.WeaponId)
                .FirstOrDefault(c => !c.IsDeleted && c.Id == IdPc && c.UserId == IdUser);

            return Character?.Map();
        }

        public List<PCSheetDTO> GetAllPcByUser(long IdUser)
        {

            var Characters = _db.Characters
                .Include(c => c.Job)
                //.Include(c => c.HelmetId)
                //.Include(c => c.ArmorId)
                //.Include(c => c.BootId)
                //.Include(c => c.WeaponId)
                .Where(c => !c.IsDeleted && c.UserId == IdUser);

            return Characters.Select(MapperExtension.Map).ToList();

        }

    }
}
