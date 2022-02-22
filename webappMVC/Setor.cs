using System;
using System.Collections.Generic;

#nullable disable

namespace webappMVC
{
    public partial class Setor
    {
        public Setor()
        {
            Materiaisexits = new HashSet<Materiaisexit>();
        }

        public int Codsetor { get; set; }
        public string Descricao { get; set; }
        public int? Coduser { get; set; }
        public int? Codempr { get; set; }
        public DateTime? Dtcad { get; set; }
        public DateTime? Dtatualizacao { get; set; }
        public string Observe { get; set; }

        public virtual ICollection<Materiaisexit> Materiaisexits { get; set; }
    }
}
