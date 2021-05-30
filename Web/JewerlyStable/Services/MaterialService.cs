using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using JewerlyStable;

namespace Jewerly.Services
{
    public class MaterialService
    {
        protected jewerlyContext dB;
        public MaterialService()
        {
            
        }

        public List<Material> GetMaterials()
        {
            using(dB = new jewerlyContext())
            {
                return dB.Materials.ToList();
            }
            
        }
    }
}
