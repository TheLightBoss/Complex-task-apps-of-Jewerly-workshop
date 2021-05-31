using System;
using System.Collections.Generic;

#nullable disable

namespace JewerlyStable
{
    public partial class ZakazForClient
    {
        public DateTime? DateZak { get; set; }
        public bool? StatusZak { get; set; }
        public decimal? PriceIzd { get; set; }
        public double? Razmer { get; set; }
        public string NameIzd { get; set; }
    }
}
