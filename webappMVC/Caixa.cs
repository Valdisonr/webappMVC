using System;
using System.Collections.Generic;

#nullable disable

namespace webappMVC
{
    public partial class Caixa
    {
        public Caixa()
        {
            Caixafechas = new HashSet<Caixafecha>();
            Caixasaida = new HashSet<Caixasaidum>();
        }

        public long Codcaixa { get; set; }
        public long Codoper { get; set; }
        public string Status { get; set; }
        public long Codabert { get; set; }
        public DateTime? Dthabertura { get; set; }
        public DateTime? Dthfechamento { get; set; }

        public virtual Caixabrir CodabertNavigation { get; set; }
        public virtual Usuario CodoperNavigation { get; set; }
        public virtual ICollection<Caixafecha> Caixafechas { get; set; }
        public virtual ICollection<Caixasaidum> Caixasaida { get; set; }
    }
}
