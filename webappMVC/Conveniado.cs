using System;
using System.Collections.Generic;

#nullable disable

namespace webappMVC
{
    public partial class Conveniado
    {
        public Conveniado()
        {
            Vendaconvenios = new HashSet<Vendaconvenio>();
        }

        public long Idcon { get; set; }
        public string Nome { get; set; }
        public string Cpf { get; set; }
        public string Rg { get; set; }
        public string Matric { get; set; }
        public string Cargo { get; set; }
        public long Codempre { get; set; }
        public bool Ativo { get; set; }
        public decimal Vrlimite { get; set; }
        public decimal Vrcompra { get; set; }
        public string Telefone { get; set; }
        public string Depende { get; set; }
        public DateTime Dtcad { get; set; }
        public DateTime? Dtcompra { get; set; }

        public virtual Convenio CodempreNavigation { get; set; }
        public virtual ICollection<Vendaconvenio> Vendaconvenios { get; set; }
    }
}
