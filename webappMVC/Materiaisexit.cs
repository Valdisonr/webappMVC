using System;
using System.Collections.Generic;

#nullable disable

namespace webappMVC
{
    public partial class Materiaisexit
    {
        public long Coditem { get; set; }
        public long Npedido { get; set; }
        public string Empresa { get; set; }
        public int? Coduser { get; set; }
        public int? Codcliente { get; set; }
        public int? Codsetor { get; set; }
        public string Identificador { get; set; }
        public string Status { get; set; }
        public long? Codprod { get; set; }
        public string Unidad { get; set; }
        public decimal Qtd { get; set; }
        public decimal? Valortotal { get; set; }
        public DateTime? Dtsaida { get; set; }

        public virtual Produto CodprodNavigation { get; set; }
        public virtual Setor CodsetorNavigation { get; set; }
    }
}
