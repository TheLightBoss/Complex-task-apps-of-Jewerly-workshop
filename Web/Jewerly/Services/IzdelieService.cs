using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace Jewerly.Services
{
    public class IzdelieService
    {
        protected jewerlyContext dB;
        public IzdelieService()
        { }

        public List<Izdelie> GetIzdelies()
        {
            using (dB = new jewerlyContext())
            {
                return dB.Izdelies.ToList();
            }
        }

        public bool InsertIzdelie(Izdelie izdelie)
        {
            using (dB = new jewerlyContext())
            {
                dB.Izdelies.Add(izdelie);
                dB.SaveChanges();
                return true;
            }
        }
    }
}
