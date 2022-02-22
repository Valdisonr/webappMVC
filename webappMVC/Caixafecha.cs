using System;
using System.Collections.Generic;

#nullable disable

namespace webappMVC
{
    public partial class Caixafecha
    {
        public long Codfech { get; set; }
        public DateTime? Dthfechamento { get; set; }
        public byte? Codpg { get; set; }
        public decimal? Valor { get; set; }
        public string Status { get; set; }
        public long Codcaixa { get; set; }
        public byte? Codoper { get; set; }

        public virtual Caixa CodcaixaNavigation { get; set; }
    }
}
