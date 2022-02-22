using System;
using System.Collections.Generic;

#nullable disable

namespace webappMVC
{
    public partial class Empresa
    {
        public long CodEmp { get; set; }
        public string Rsocial { get; set; }
        public string Inscricao { get; set; }
        public string Cnpj { get; set; }
        public string Resp { get; set; }
        public string Endereco { get; set; }
        public string Bairro { get; set; }
        public string Cidade { get; set; }
        public string Cep { get; set; }
        public string Uf { get; set; }
        public string Email { get; set; }
        public string Sistema { get; set; }
        public string Logomarca { get; set; }
        public DateTime? Dtcad { get; set; }
        public DateTime? Dtatualizacao { get; set; }
        public int? Coduser { get; set; }
    }
}
