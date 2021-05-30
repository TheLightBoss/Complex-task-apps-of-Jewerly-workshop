using System;
using System.Collections.Generic;

#nullable disable

namespace JewerlyStable
{
    public partial class Sotrudnik
    {
        public Sotrudnik()
        {
            Izgotovlenies = new HashSet<Izgotovlenie>();
            Prizes = new HashSet<Prize>();
        }

        public int IdSotr { get; set; }
        public string Fio { get; set; }
        public string Address { get; set; }
        public string Passport { get; set; }
        public short Stag { get; set; }
        public string Login { get; set; }
        public string Password { get; set; }

        public virtual ICollection<Izgotovlenie> Izgotovlenies { get; set; }
        public virtual ICollection<Prize> Prizes { get; set; }
    }
}
