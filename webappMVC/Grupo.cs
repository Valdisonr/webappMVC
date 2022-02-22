using System;
using System.Collections.Generic;

#nullable disable

namespace webappMVC
{
    public partial class Grupo
    {
        public Grupo()
        {
            Produtos = new HashSet<Produto>();
        }

        public long Codgp { get; set; }
        public string Descricao { get; set; }
        public DateTime Dtcad { get; set; }

        public virtual ICollection<Produto> Produtos { get; set; }
    }
}
