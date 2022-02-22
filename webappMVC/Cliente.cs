using System;
using System.Collections.Generic;

#nullable disable

namespace webappMVC
{
    public partial class Cliente
    {
        public long Codcli { get; set; }
        public string Nome { get; set; }
        public string Rua { get; set; }
        public string Bairro { get; set; }
        public string Cidade { get; set; }
        public string Uf { get; set; }
        public string Cep { get; set; }
        public string Telef { get; set; }
        public string Referencia { get; set; }
        public DateTime? Dtcad { get; set; }
        public int? Codsetor { get; set; }
        public DateTime? Dtatualizacao { get; set; }
        public int? Coduser { get; set; }
        public int CodEmp { get; set; }
        public string Matricula { get; set; }
        public string Identificador { get; set; }
        public string ClassificacaoId { get; set; }
        public bool? Estado { get; set; }
    }
}
