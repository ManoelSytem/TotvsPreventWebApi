using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace TotvsPreventWebApi.Model
{
    public class Funcionario
    {
        public int Matricula { get; set; }
        public string Cargo { get; set; }
        public string Nome { get; set; }

        public int Departamento { get; set; }
        public string Salario { get; set; }
        public string TipoPagamento { get; set; }
        public string Status { get; set; }

    }
}
