using System;
using System.Collections.Generic;

#nullable disable

namespace webappMVC
{
    public partial class Colaborador
    {
        public long Idcolab { get; set; }
        public int? Id { get; set; }
        public string Nome { get; set; }
        public string Identificador { get; set; }
        public string Empresa { get; set; }
        public bool? Aceite { get; set; }
        public DateTime? Datacad { get; set; }
    }
}
