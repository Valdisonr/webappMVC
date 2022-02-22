using System;
using System.Collections.Generic;

#nullable disable

namespace webappMVC
{
    public partial class Produtontvenc
    {
        public long Idvenc { get; set; }
        public string Data { get; set; }
        public decimal? Vlparcela { get; set; }
        public long? Idnotafiscal { get; set; }
        public DateTime? Dtcad { get; set; }

        public virtual Produtonfiscal IdnotafiscalNavigation { get; set; }
    }
}
