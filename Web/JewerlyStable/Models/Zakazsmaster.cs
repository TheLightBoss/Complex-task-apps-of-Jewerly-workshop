using System;
using System.Collections.Generic;

#nullable disable

namespace JewerlyStable
{
    public partial class Zakazsmaster
    {
        public string NameIzd { get; set; }
        public double? Razmer { get; set; }
        public int? IdIzd { get; set; }
        public string[] SpisokRabot { get; set; }
        public bool? Status { get; set; }
        public bool? PoluStatus { get; set; }
        public string[] ListDoneJob { get; set; }
        public DateTime? DataStart { get; set; }
        public int? IdSotr { get; set; }
        public string UrlPic { get; set; }
    }
}
