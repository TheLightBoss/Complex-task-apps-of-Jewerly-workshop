using System;
using System.Collections.Generic;

#nullable disable

namespace ExampleHttp
{
    public partial class Otdelka
    {
        public Otdelka()
        {
            IzdelieSprs = new HashSet<IzdelieSpr>();
        }

        public int IdOtdelk { get; set; }
        public string Type { get; set; }
        public decimal Koeff { get; set; }

        public virtual ICollection<IzdelieSpr> IzdelieSprs { get; set; }
    }
}
