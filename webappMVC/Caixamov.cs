using System;
using System.Collections.Generic;

#nullable disable

namespace webappMVC
{
    public partial class Caixamov
    {
        public long Codmov { get; set; }
        public byte Codpg { get; set; }
        public decimal Vlnota { get; set; }
        public DateTime? Data { get; set; }
        public string Status { get; set; }
        public byte? Codcaixa { get; set; }
    }
}
