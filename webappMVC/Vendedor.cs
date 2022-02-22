using System;
using System.Collections.Generic;

#nullable disable

namespace webappMVC
{
    public partial class Vendedor
    {
        public Vendedor()
        {
            Vendapedidos = new HashSet<Vendapedido>();
        }

        public long Codven { get; set; }
        public string Nome { get; set; }
        public string Sobrenome { get; set; }
        public DateTime Dtcad { get; set; }

        public virtual ICollection<Vendapedido> Vendapedidos { get; set; }
    }
}
