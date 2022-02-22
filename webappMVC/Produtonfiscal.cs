using System;
using System.Collections.Generic;

#nullable disable

namespace webappMVC
{
    public partial class Produtonfiscal
    {
        public Produtonfiscal()
        {
            Produtontvencs = new HashSet<Produtontvenc>();
        }

        public long Idnotafiscal { get; set; }
        public int Codfornecedor { get; set; }
        public DateTime? Emissao { get; set; }
        public string Ntfiscal { get; set; }
        public string Chaveacesso { get; set; }
        public decimal? Valornota { get; set; }
        public DateTime? Dtcadastro { get; set; }

        public virtual ICollection<Produtontvenc> Produtontvencs { get; set; }
    }
}
