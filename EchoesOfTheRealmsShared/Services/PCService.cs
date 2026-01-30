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
            var Character = _db.Characters.FirstOrDefault(c => !c.IsDeleted && c.Id == IdPc && c.UserId == IdUser);

            return Character?.Map();
        }

        public List<PCSheetDTO> GetAllPcByUser(long IdUser)
        {

            var Characters = _db.Characters.Where(c => !c.IsDeleted && c.UserId == IdUser);

            return Characters.Select(MapperExtension.Map).ToList();

        }

    }
}
