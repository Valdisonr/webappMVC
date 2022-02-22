using System;
using System.Collections.Generic;

#nullable disable

namespace webappMVC
{
    public partial class Locacaoitem
    {
        public long Coditem { get; set; }
        public long Npedido { get; set; }
        public int? Codempr { get; set; }
        public int? Coduser { get; set; }
        public long? Codcliente { get; set; }
        public string Identificador { get; set; }
        public string Status { get; set; }
        public long Codprod { get; set; }
        public string Unidad { get; set; }
        public short? Qtd { get; set; }
        public decimal Valortotal { get; set; }
        public DateTime? Dataloc { get; set; }
        public DateTime? Datadev { get; set; }
        public DateTime? Dtdevolvido { get; set; }
        public DateTime? Dtatualizacao { get; set; }
        public string Nomedev { get; set; }
    }
}
