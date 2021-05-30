using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using JewerlyStable;

namespace Jewerly.Services
{
    public class IzgotovlenieSevice
    {
        protected jewerly_newContext dB = new();
        public IzgotovlenieSevice()
        {
        }

        public List<Izgotovlenie> GetIzgotovlenies()
        {

            return dB.Izgotovlenies.ToList();

        }
    }
}
