using System;
using System.Collections.Generic;

#nullable disable

namespace webappMVC
{
    public partial class Vendaitem
    {
        public long Coditem { get; set; }
        public long Codped { get; set; }
        public long Codpro { get; set; }
        public string Unid { get; set; }
        public decimal Qtdven { get; set; }
        public decimal Descont { get; set; }
        public decimal Vltotal { get; set; }
        public DateTime Dtvenda { get; set; }

        public virtual Vendapedido CodpedNavigation { get; set; }
        public virtual Produto CodproNavigation { get; set; }
    }
}
