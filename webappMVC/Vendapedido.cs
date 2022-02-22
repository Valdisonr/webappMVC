using System;
using System.Collections.Generic;

#nullable disable

namespace webappMVC
{
    public partial class Vendapedido
    {
        public Vendapedido()
        {
            Vendaconvenios = new HashSet<Vendaconvenio>();
            Vendaitems = new HashSet<Vendaitem>();
        }

        public long Codped { get; set; }
        public long Codpg { get; set; }
        public long Codven { get; set; }
        public decimal Vlnota { get; set; }
        public DateTime Dtped { get; set; }
        public byte Codcaixa { get; set; }

        public virtual Pgto CodpgNavigation { get; set; }
        public virtual Vendedor CodvenNavigation { get; set; }
        public virtual ICollection<Vendaconvenio> Vendaconvenios { get; set; }
        public virtual ICollection<Vendaitem> Vendaitems { get; set; }
    }
}
