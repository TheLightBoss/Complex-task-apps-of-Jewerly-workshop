using System;
using System.Collections.Generic;

#nullable disable

namespace JewerlyStable
{
    public partial class Prize
    {
        public int IdPriz { get; set; }
        public int[] IdIzgotMass { get; set; }
        public decimal? SummPriz { get; set; }
        public int IdSotr { get; set; }

        public virtual Sotrudnik IdSotrNavigation { get; set; }
    }
}
