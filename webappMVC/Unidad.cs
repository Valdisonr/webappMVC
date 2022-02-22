using System;
using System.Collections.Generic;

#nullable disable

namespace webappMVC
{
    public partial class Unidad
    {
        public Unidad()
        {
            Produtos = new HashSet<Produto>();
        }

        public int Codunid { get; set; }
        public string Descricao { get; set; }
        public string Sigla { get; set; }
        public DateTime Dtcad { get; set; }

        public virtual ICollection<Produto> Produtos { get; set; }
    }
}
