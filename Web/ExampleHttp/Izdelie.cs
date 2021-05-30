using System;
using System.Collections.Generic;

#nullable disable

namespace ExampleHttp
{
    public partial class Izdelie
    {
        public Izdelie()
        {
            Izgotovlenies = new HashSet<Izgotovlenie>();
            Zakazs = new HashSet<Zakaz>();
        }

        public int IdIzd { get; set; }
        public decimal PriceIzd { get; set; }
        public int IdProb { get; set; }
        public DateTime? DateShtampa { get; set; }
        public int IdIzdspr { get; set; }
        public double? Razmer { get; set; }

        public virtual IzdelieSpr IdIzdsprNavigation { get; set; }
        public virtual ICollection<Izgotovlenie> Izgotovlenies { get; set; }
        public virtual ICollection<Zakaz> Zakazs { get; set; }
    }
}
