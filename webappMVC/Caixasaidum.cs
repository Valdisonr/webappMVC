using System;
using System.Collections.Generic;

#nullable disable

namespace webappMVC
{
    public partial class Caixasaidum
    {
        public long Codsai { get; set; }
        public decimal Valor { get; set; }
        public string Motivo { get; set; }
        public long Codcaixa { get; set; }
        public DateTime? Data { get; set; }

        public virtual Caixa CodcaixaNavigation { get; set; }
    }
}
