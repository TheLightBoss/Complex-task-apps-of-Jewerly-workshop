using System;
using System.Collections.Generic;

#nullable disable

namespace ExampleHttp
{
    public partial class Izgotovlenie
    {
        public int IdIzgot { get; set; }
        public DateTime DataStart { get; set; }
        public DateTime? DataEnd { get; set; }
        public int IdIzd { get; set; }
        public int IdSotr { get; set; }
        public string[] ListDoneJob { get; set; }
        public bool? Status { get; set; }
        public bool? PoluStatus { get; set; }

        public virtual Izdelie IdIzdNavigation { get; set; }
        public virtual Sotrudnik IdSotrNavigation { get; set; }
    }
}
