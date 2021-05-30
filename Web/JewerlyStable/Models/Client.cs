using System;
using System.Collections.Generic;

#nullable disable

namespace JewerlyStable
{
    public partial class Client
    {
        public Client()
        {
            Comments = new HashSet<Comment>();
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
    }
}
