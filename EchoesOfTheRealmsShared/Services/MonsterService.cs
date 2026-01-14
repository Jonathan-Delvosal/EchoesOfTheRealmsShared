using EchoesOfTheRealms;
using EchoesOfTheRealmsShared.DTO;
using EchoesOfTheRealmsShared.Entities.MonsterFiles;
using EchoesOfTheRealmsShared.Mappers;
using EchoesOfTheRealmsShared.Queries;

using Microsoft.AspNetCore.Mvc;
using Microsoft.EntityFrameworkCore;
using System.Threading;

namespace EchoesOfTheRealmsShared.Services
{
    public class MonsterService(EotRContext _db)
    {

        public MonsterScreenResponseDTO? GetById(long id)
        {

            if (id <= 0) return null;

            try
            {

                var monster = _db.Monsters.Include(Mtype => Mtype.MonsterType).SingleOrDefault(m => !m.IsDeleted && m.Id == id);


                return monster?.Map();

            }

            catch (Exception)
            {

                //ToDo: log error
                return null;

            }

        }

        public Monster GetMonsterByRndLvl(int lvlMin, int lvlMax)
        {
            Random rnd = new Random();

            var Liste = _db.Monsters
                .Where(m => !m.IsDeleted && m.Level >= lvlMin && m.Level <= lvlMax)
                .ToList();

            return Liste[rnd.Next(Liste.Count)];
        }








        public List<MonsterScreenResponseDTO>?  GetListMonster()
        {
            var monster = _db.Monsters.Include(Mtype => Mtype.MonsterType)
                .Select(e=> e.Map())
                .ToList();

            return monster;
        }

        public List<Monster> GetSearch(MonsterQuery queryM)
        {

            IQueryable<Monster> query = _db.Monsters.Where(m => !m.IsDeleted);
            if (queryM.type != null)
            {
                query = query.Where(m => m.MonsterType.Name == queryM.type);
            }

            if (queryM.hpMin != null)
            {
                query = query.Where(m => m.HP >= queryM.hpMin);
            }

            if (queryM.hpMax != null)
            {
                query = query.Where(m => m.HP <= queryM.hpMax);
            }

            if (queryM.levelMin != null)
            {
                query = query.Where(m => m.Level >= queryM.levelMin);
            }

            if (queryM.levelMax != null)
            {
                query = query.Where(m => m.Level <= queryM.levelMax);
            }

            if (queryM.manaMin != null)
            {
                query = query.Where(m => m.Mana >= queryM.manaMin);
            }

            if (queryM.manaMax != null)
            {
                query = query.Where(m => m.Mana <= queryM.manaMax);
            }

            if (queryM.strMin != null)
            {
                query = query.Where(m => m.Str >= queryM.strMin);
            }

            if (queryM.strMax != null)
            {
                query = query.Where(m => m.Str <= queryM.strMax);
            }

            if (queryM.dexMin != null)
            {
                query = query.Where(m => m.Dex >= queryM.dexMin);
            }

            if (queryM.dexMax != null)
            {
                query = query.Where(m => m.Dex <= queryM.dexMax);
            }

            if (queryM.intelMin != null)
            {
                query = query.Where(m => m.Intel >= queryM.intelMin);
            }

            if (queryM.intelMax != null)
            {
                query = query.Where(m => m.Intel <= queryM.intelMax);
            }

            if (queryM.vitaMin != null)
            {
                query = query.Where(m => m.Vita >= queryM.vitaMin);
            }

            if (queryM.vitaMax != null)
            {
                query = query.Where(m => m.Vita <= queryM.vitaMax);
            }

            if (queryM.resFireMin != null)
            {
                query = query.Where(m => m.ResFire >= queryM.resFireMin);
            }

            if (queryM.resFireMax != null)
            {
                query = query.Where(m => m.ResFire <= queryM.resFireMax);
            }

            if (queryM.resIceMin != null)
            {
                query = query.Where(m => m.ResIce >= queryM.resIceMin);
            }

            if (queryM.resIceMax != null)
            {
                query = query.Where(m => m.ResIce <= queryM.resIceMax);
            }

            if (queryM.resLightMin != null)
            {
                query = query.Where(m => m.ResLightning >= queryM.resLightMin);
            }

            if (queryM.resLightMax != null)
            {
                query = query.Where(m => m.ResLightning <= queryM.resLightMax);
            }

            if (queryM.xpMin != null)
            {
                query = query.Where(m => m.XPGiven >= queryM.xpMin);
            }

            if (queryM.xpMax != null)
            {
                query = query.Where(m => m.XPGiven <= queryM.xpMax);
            }

            if (queryM.goldMin != null)
            {
                query = query.Where(m => m.GoldGiven >= queryM.goldMin);
            }

            if (queryM.goldMax != null)
            {
                query = query.Where(m => m.GoldGiven <= queryM.goldMax);
            }

            return query.ToList();
        }

    }
}
