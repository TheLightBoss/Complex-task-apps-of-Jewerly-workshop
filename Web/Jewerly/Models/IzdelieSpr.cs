using System;
using System.Collections.Generic;

#nullable disable

namespace Jewerly
{
    public partial class IzdelieSpr
    {
        public IzdelieSpr()
        {
            Izdelies = new HashSet<Izdelie>();
        }

        public int IdIzdspr { get; set; }
        public string NameIzd { get; set; }
        public string UrlPic { get; set; }
        public int IdRabota { get; set; }
        public int? IdMaterial { get; set; }
        public int? IdTipIzd { get; set; }
        public string NameItm { get; set; }
        public int? IdOtdelk { get; set; }

        public virtual Material IdMaterialNavigation { get; set; }
        public virtual Otdelka IdOtdelkNavigation { get; set; }
        public virtual Rabotum IdRabotaNavigation { get; set; }
        public virtual TipIzd IdTipIzdNavigation { get; set; }
        public virtual ICollection<Izdelie> Izdelies { get; set; }
    }
}
