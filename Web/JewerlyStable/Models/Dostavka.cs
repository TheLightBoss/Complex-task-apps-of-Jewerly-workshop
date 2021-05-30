using System;
using System.Collections.Generic;

#nullable disable

namespace JewerlyStable
{
    public partial class Dostavka
    {
        public Dostavka()
        {
            Zakazs = new HashSet<Zakaz>();
        }

        public int IdDost { get; set; }
        public DateTime? DateDost { get; set; }
        public bool StatusDost { get; set; }
        public string PochtaIndex { get; set; }
        public string AddressDost { get; set; }

        public virtual ICollection<Zakaz> Zakazs { get; set; }
    }
}
