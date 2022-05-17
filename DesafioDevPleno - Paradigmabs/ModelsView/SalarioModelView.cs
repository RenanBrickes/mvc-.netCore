using System;
using System.Collections.Generic;
using System.Globalization;
using System.Linq;
using System.Threading.Tasks;

namespace DesafioDevPleno___Paradigmabs.ModelsView
{
    public class SalarioModelView
    {
        public List<PessoaSalarioView> pessoaSalario { get; set; }
    }

    public class PessoaSalarioView
    {
        public string Departamento { get; set; }
        public string Pessoa { get; set; }
        public decimal Salario { get; set; }
        public string SalarioBr { get => Salario.ToString("C", CultureInfo.CurrentCulture); }


    }
}
