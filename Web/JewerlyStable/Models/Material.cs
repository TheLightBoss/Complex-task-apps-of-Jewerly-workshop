using System;
using System.Collections.Generic;

#nullable disable

namespace Jewerly
{
    public partial class Material
    {
        public Material()
        {
            IzdelieSprs = new HashSet<IzdelieSpr>();
            Zakupkas = new HashSet<Zakupka>();
        }

        public int IdMater { get; set; }
        public string NameMater { get; set; }
        public string UrlMater { get; set; }
        public decimal PriceMater { get; set; }
        public int? IdBank { get; set; }

        public virtual ICollection<IzdelieSpr> IzdelieSprs { get; set; }
        public virtual ICollection<Zakupka> Zakupkas { get; set; }
    }
}
