using System;
using System.Collections.Generic;

#nullable disable

namespace webappMVC
{
    public partial class Usuario
    {
        public Usuario()
        {
            Caixas = new HashSet<Caixa>();
        }

        public long Coduser { get; set; }
        public string CompleteName { get; set; }
        public string LoginName { get; set; }
        public string Password { get; set; }
        public bool? Enabled { get; set; }
        public byte? CodEmpre { get; set; }
        public byte? Codcargo { get; set; }
        public DateTime? Dtcad { get; set; }
        public DateTime? Dtatualizacao { get; set; }

        public virtual ICollection<Caixa> Caixas { get; set; }
    }
}
