using System;
using System.Collections.Generic;

#nullable disable

namespace Jewerly
{
    public partial class Zakupka
    {
        public int IdZakup { get; set; }
        public int IdMater { get; set; }
        public float Amount { get; set; }

        public virtual Material IdMaterNavigation { get; set; }
    }
}
