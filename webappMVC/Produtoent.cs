using System;
using System.Collections.Generic;

#nullable disable

namespace webappMVC
{
    public partial class Produtoent
    {
        public long Codent { get; set; }
        public long? Codprod { get; set; }
        public int? Codempre { get; set; }
        public int? Coduser { get; set; }
        public bool? Ckntfiscal { get; set; }
        public int? Idnotafiscal { get; set; }
        public decimal? Qtd { get; set; }
        public decimal? Valorprod { get; set; }
        public DateTime? Dtentrada { get; set; }
    }
}
