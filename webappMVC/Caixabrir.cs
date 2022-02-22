using System;
using System.Collections.Generic;

#nullable disable

namespace webappMVC
{
    public partial class Caixabrir
    {
        public Caixabrir()
        {
            Caixas = new HashSet<Caixa>();
        }

        public long Codabert { get; set; }
        public DateTime Dthabertura { get; set; }
        public byte Codoper { get; set; }
        public decimal Saldoinicial { get; set; }

        public virtual ICollection<Caixa> Caixas { get; set; }
    }
}
