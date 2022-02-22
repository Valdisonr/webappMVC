using System;
using System.Collections.Generic;

#nullable disable

namespace webappMVC
{
    public partial class Convenio
    {
        public Convenio()
        {
            Conveniados = new HashSet<Conveniado>();
        }

        public long Codconvenio { get; set; }
        public string Razao { get; set; }
        public string Cnpj { get; set; }
        public string Ie { get; set; }
        public string Endereco { get; set; }
        public string Bairro { get; set; }
        public string Cidade { get; set; }
        public string Uf { get; set; }
        public string Cep { get; set; }
        public string Fone { get; set; }
        public string Referencia { get; set; }
        public decimal Desconto { get; set; }
        public int Diafecha { get; set; }
        public DateTime Dtcad { get; set; }

        public virtual ICollection<Conveniado> Conveniados { get; set; }
    }
}
