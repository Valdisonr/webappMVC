using System;
using System.Collections.Generic;

#nullable disable

namespace webappMVC
{
    public partial class Fornecedor
    {
        public long Codforne { get; set; }
        public string Descricao { get; set; }
        public string Fantasia { get; set; }
        public string Cnpj { get; set; }
        public string Inscricao { get; set; }
        public string Rua { get; set; }
        public string Bairro { get; set; }
        public string Cidade { get; set; }
        public string Uf { get; set; }
        public string Cep { get; set; }
        public string Telef { get; set; }
        public string Contato { get; set; }
        public DateTime Dtcad { get; set; }
    }
}
