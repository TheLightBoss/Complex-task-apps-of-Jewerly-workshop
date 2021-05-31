using JewerlyStable;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace Jewerly.Services
{
    public class IzdelieService
    {
        protected jewerly_newContext dB = new();
        public IzdelieService()
        { }

        public List<Izdelie> GetIzdelies()
        {
            return dB.Izdelies.ToList();
        }

        public void InsertIzdelie(Izdelie izdelie)
        {
            dB.Izdelies.Add(izdelie);
            dB.SaveChanges();
        }
    }
}
