using System;
using System.Collections.Generic;

#nullable disable

namespace ExampleHttp
{
    public partial class Client
    {
        public Client()
        {
            Comments = new HashSet<Comment>();
            Zakazs = new HashSet<Zakaz>();
        }

        public int IdClient { get; set; }
        public string Passport { get; set; }
        public string Login { get; set; }
        public string Password { get; set; }
        public string Fio { get; set; }
        public string Rekvizits { get; set; }
        public string AddressLive { get; set; }
        public string ContactFace { get; set; }

        public virtual ICollection<Comment> Comments { get; set; }
        public virtual ICollection<Zakaz> Zakazs { get; set; }
    }
}
