using System;
using System.Collections.Generic;

#nullable disable

namespace ExampleHttp
{
    public partial class Answer
    {
        public int IdAns { get; set; }
        public int IdZak { get; set; }
        public string Message { get; set; }
        public DateTime DateAns { get; set; }
        public int IdComment { get; set; }

        public virtual Comment IdAnsNavigation { get; set; }
        public virtual Zakaz IdZakNavigation { get; set; }
    }
}
