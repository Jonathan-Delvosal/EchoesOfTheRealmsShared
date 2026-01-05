using Microsoft.AspNetCore.Mvc;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace EchoesOfTheRealmsShared.Queries
{
    public class MonsterQuery
    {
        public string? type { get; set; }
        public int? hpMin {get;set;} 
        public int? hpMax {get;set;}
        public int? levelMin {get;set;} 
        public int? levelMax {get;set;}
        public int? manaMin {get;set;} 
        public int? manaMax {get;set;}
        public int? strMin {get;set;} 
        public int? strMax {get;set;}
        public int? dexMin {get;set;} 
        public int? dexMax {get;set;}
        public int? intelMin {get;set;} 
        public int? intelMax {get;set;}
        public int? vitaMin {get;set;} 
        public int? vitaMax {get;set;}
        public int? resFireMin {get;set;} 
        public int? resFireMax {get;set;}
        public int? resIceMin {get;set;} 
        public int? resIceMax {get;set;}
        public int? resLightMin {get;set;} 
        public int? resLightMax {get;set;}
        public int? xpMin {get;set;} 
        public int? xpMax {get;set;}
        public int? goldMin {get;set;} 
        public int? goldMax {get;set;}
    }
}
