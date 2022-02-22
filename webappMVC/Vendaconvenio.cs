using System;
using System.Collections.Generic;

#nullable disable

namespace webappMVC
{
    public partial class Vendaconvenio
    {
        public long Codcon { get; set; }
        public long Codped { get; set; }
        public long Idcon { get; set; }
        public decimal Vltotal { get; set; }
        public DateTime Dtvenda { get; set; }

        public virtual Vendapedido CodpedNavigation { get; set; }
        public virtual Conveniado IdconNavigation { get; set; }
    }
}
