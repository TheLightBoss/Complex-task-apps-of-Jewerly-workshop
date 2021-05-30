using System;
using System.Collections.Generic;

#nullable disable

namespace Jewerly
{
    public partial class Zakaz
    {
        public Zakaz()
        {
            Answers = new HashSet<Answer>();
            Comments = new HashSet<Comment>();
        }

        public int IdZak { get; set; }
        public DateTime DateZak { get; set; }
        public int IdIzd { get; set; }
        public string IdClient { get; set; }
        public int? IdDost { get; set; }
        public bool StatusZak { get; set; }

        public virtual Client IdClientNavigation { get; set; }
        public virtual Dostavka IdDostNavigation { get; set; }
        public virtual Izdelie IdIzdNavigation { get; set; }
        public virtual ICollection<Answer> Answers { get; set; }
        public virtual ICollection<Comment> Comments { get; set; }
    }
}
