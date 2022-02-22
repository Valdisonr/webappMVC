using System;
using System.Collections.Generic;

#nullable disable

namespace webappMVC
{
    public partial class Cargo
    {
        public long Codcargo { get; set; }
        public string Descricao { get; set; }
        public DateTime? Dtcad { get; set; }
        public DateTime? Dtatualizacao { get; set; }
        public int? Coduser { get; set; }
    }
}
