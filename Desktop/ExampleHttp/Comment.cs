using System;
using System.Collections.Generic;

#nullable disable

namespace ExampleHttp
{
    public partial class Comment
    {
        public int IdComment { get; set; }
        public int IdZak { get; set; }
        public int Message { get; set; }
        public DateTime DateComment { get; set; }
        public int? IdClient { get; set; }

        public virtual Client IdClientNavigation { get; set; }
        public virtual Zakaz IdZakNavigation { get; set; }
        public virtual Answer Answer { get; set; }
    }
}
