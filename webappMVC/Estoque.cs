using System;
using System.Collections.Generic;

#nullable disable

namespace webappMVC
{
    public partial class Estoque
    {
        public long Codestoque { get; set; }
        public long Codprod { get; set; }
        public decimal? Estoque1 { get; set; }
        public int Codempre { get; set; }
        public int Coduser { get; set; }
        public decimal? Minimo { get; set; }
        public decimal? Maximo { get; set; }
        public DateTime? Dtatualiza { get; set; }
        public DateTime? Dtcad { get; set; }

        public virtual Produto CodprodNavigation { get; set; }
    }
}
