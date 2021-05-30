using System;
using System.Collections.Generic;

#nullable disable

namespace JewerlyStable
{
    public partial class Rabotum
    {
        public Rabotum()
        {
            IzdelieSprs = new HashSet<IzdelieSpr>();
        }

        public int IdRabota { get; set; }
        public string[] SpisokRabot { get; set; }

        public virtual ICollection<IzdelieSpr> IzdelieSprs { get; set; }
    }
}
