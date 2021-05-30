using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using JewerlyStable;


namespace Jewerly.Services
{
    public class IzdelieSprService
    {
        protected jewerlyContext dB;
        public IzdelieSprService()
        {
        }
        //GetIzdelie_spr
        public List<IzdelieSpr> GetIzdelieSprs()
        {
            using(dB = new jewerlyContext())
            {
                return dB.IzdelieSprs.ToList();
            }
        }
    }
}
