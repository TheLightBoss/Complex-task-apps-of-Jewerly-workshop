using JewerlyStable.Data;
using System;
using System.Collections.Generic;

#nullable disable

namespace JewerlyStable
{
    public partial class Zakaz
    {
        public Zakaz()
        {

        }

        public int IdZak { get; set; }
        public DateTime DateZak { get; set; }
        public int IdIzd { get; set; }
        public int? IdDost { get; set; }
        public bool StatusZak { get; set; }
        public string IdClient { get; set; }

        public virtual User IdClientNavigation { get; set; }
        public virtual Dostavka IdDostNavigation { get; set; }
        public virtual Izdelie IdIzdNavigation { get; set; }

    }
}
