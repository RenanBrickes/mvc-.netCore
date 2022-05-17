using Microsoft.EntityFrameworkCore;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace DesafioDevPleno___Paradigmabs.Models
{
    public class Context : DbContext
    {
        public Context(DbContextOptions options) : base(options)
        {

        }

        public DbSet<Departamento> Departamento { get; set; }
        public DbSet<Pessoa> Pessoa { get; set; }

        protected override void OnModelCreating(ModelBuilder modelBuilder)
        {
            base.OnModelCreating(modelBuilder);

            //Colaborador
            modelBuilder.Entity<Pessoa>().HasOne(p => p.Departamento_fk).WithMany(b => b.Pessoa).HasForeignKey(p => p.Departamento);
        }
    }
}
