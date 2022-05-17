using DesafioDevPleno___Paradigmabs.ModelsView;
using Microsoft.EntityFrameworkCore;
using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations.Schema;
using System.Linq;
using System.Threading.Tasks;

namespace DesafioDevPleno___Paradigmabs.Models
{
    [Table("Pessoa")]
    public class Pessoa
    {

        public Guid Id { get; set; }

        public string Nome { get; set; }

        public decimal Salario { get; set; }

        public Guid Departamento { get; set; }

        public virtual Departamento Departamento_fk { get; set; }

        public SalarioModelView PegaSalario(Context context)
        {
            var teste = context.Pessoa.FromSqlRaw("SUA SQL AQUI").ToList();

            return null;
        }

    }
}
