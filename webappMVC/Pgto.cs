using System;
using System.Collections.Generic;

#nullable disable

namespace webappMVC
{
    public partial class Pgto
    {
        public Pgto()
        {
            Vendapedidos = new HashSet<Vendapedido>();
        }

        public long Codpg { get; set; }
        public string Descricao { get; set; }
        public DateTime? Dtcad { get; set; }

        public virtual ICollection<Vendapedido> Vendapedidos { get; set; }
    }
}
