using Passebem.Models;
using System.Data.Entity;

namespace Passebem.Data
{
    public class PassaBemContext : DbContext
    {
        public PassaBemContext() : base("ClimaTempoSimples")
        {
        }

        public DbSet<Estado> Estados { get; set; }
        public DbSet<Cidade> Cidades { get; set; }
        public DbSet<PrevisaoClima> PrevisoesDoClima { get; set; }
        protected override void OnModelCreating(DbModelBuilder modelBuilder)
        {
           
            base.OnModelCreating(modelBuilder);
        }

    }
}