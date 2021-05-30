using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using JewerlyStable;

namespace Jewerly.Services
{
    public class MaterialService
    {
        protected jewerly_newContext dB = new();
        public MaterialService()
        {
            
        }

        public List<Material> GetMaterials()
        {
                return dB.Materials.ToList();
            
        }
    }
}
