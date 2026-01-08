using EchoesOfTheRealms;
using EchoesOfTheRealmsShared.Entities.NPCFiles;
using EchoesOfTheRealmsShared.Queries;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Runtime.CompilerServices;
using System.Text;
using System.Threading.Tasks;

namespace EchoesOfTheRealmsShared.Services
{
    public class NPCService(EotRContext _db)
    {

        public List<NPC> Get() 
        { 
        
            IQueryable<NPC> query  = _db.NPCs.Where(m => !m.IsDeleted);

            return query.ToList();

        }

        public List<NPC> GetParams(NPCQuery queryN)
        {

            IQueryable<NPC> query = _db.NPCs.Where(m => !m.IsDeleted);

            return query.ToList();

        }

        public NPC Create(NPC npc)
        {

            return ;
        
        }

        public NPC Read(long id) { }

        public bool Update(NPC npc) { }

        public bool Delete(long id) { }

    }
}
