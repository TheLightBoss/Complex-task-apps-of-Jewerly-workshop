using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using JewerlyStable;


namespace Jewerly.Services
{
    public class IzdelieSprService
    {
        protected jewerly_newContext dB = new();
        public IzdelieSprService()
        {
        }
        //GetIzdelie_spr
        public List<IzdelieSpr> GetIzdelieSprs()
        {

            return dB.IzdelieSprs.ToList();

        }
    }
}
