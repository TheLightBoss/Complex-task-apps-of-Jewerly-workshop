using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Jewerly.Data;

namespace Jewerly.Services
{
    public class IzgotovlenieSevice
    {
        protected jewerlyContext dB;
        public IzgotovlenieSevice()
        {
        }
        
        public List<Izgotovlenie> GetIzgotovlenies()
        {
            using (dB = new jewerlyContext())
            {
                return dB.Izgotovlenies.ToList();
            }
        }
    }
}
