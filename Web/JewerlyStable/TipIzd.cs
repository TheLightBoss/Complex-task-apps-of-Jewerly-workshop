using System;
using System.Collections.Generic;

#nullable disable

namespace JewerlyStable
{
    public partial class TipIzd
    {
        public TipIzd()
        {
            IzdelieSprs = new HashSet<IzdelieSpr>();
        }

        public int IdTipIzd { get; set; }
        public string NameTipIzd { get; set; }
        public decimal PriceTipIzd { get; set; }

        public virtual ICollection<IzdelieSpr> IzdelieSprs { get; set; }
    }
}
