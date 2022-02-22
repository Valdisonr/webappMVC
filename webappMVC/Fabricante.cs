using System;
using System.Collections.Generic;

#nullable disable

namespace webappMVC
{
    public partial class Fabricante
    {
        public Fabricante()
        {
            Produtos = new HashSet<Produto>();
        }

        public long Codfab { get; set; }
        public string Descricao { get; set; }
        public DateTime? Dtcad { get; set; }

        public virtual ICollection<Produto> Produtos { get; set; }
    }
}
