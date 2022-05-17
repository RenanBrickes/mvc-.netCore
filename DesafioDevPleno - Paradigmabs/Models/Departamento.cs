using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations.Schema;
using System.Linq;
using System.Threading.Tasks;

namespace DesafioDevPleno___Paradigmabs.Models
{
    [Table("Departamento")]
    public class Departamento
    {
        public Guid Id { get; set; }
        public string Nome { get; set; }
        public ICollection<Pessoa> Pessoa { get; set; }
    }
}
