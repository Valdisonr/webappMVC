using System;
using System.Collections.Generic;

#nullable disable

namespace webappMVC
{
    public partial class Produto
    {
        public Produto()
        {
            Estoques = new HashSet<Estoque>();
            Materiaisexits = new HashSet<Materiaisexit>();
            Vendaitems = new HashSet<Vendaitem>();
        }

        public long Codprod { get; set; }
        public string Descricao { get; set; }
        public long Codgp { get; set; }
        public int Codunid { get; set; }
        public decimal Precocus { get; set; }
        public decimal Precocon { get; set; }
        public long Codfab { get; set; }
        public decimal? Saldo { get; set; }
        public string Codbarra { get; set; }
        public DateTime Dtcad { get; set; }
        public decimal? Estoque { get; set; }
        public string Patrimonio { get; set; }

        public virtual Fabricante CodfabNavigation { get; set; }
        public virtual Grupo CodgpNavigation { get; set; }
        public virtual Unidad Codun { get; set; }
        public virtual ICollection<Estoque> Estoques { get; set; }
        public virtual ICollection<Materiaisexit> Materiaisexits { get; set; }
        public virtual ICollection<Vendaitem> Vendaitems { get; set; }
    }
}
