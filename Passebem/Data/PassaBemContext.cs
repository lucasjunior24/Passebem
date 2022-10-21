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
        protected override void OnModelCreating(DbModelBuilder modelBuilder)
        {
           
            base.OnModelCreating(modelBuilder);
        }



        //protected override void OnModelCreating(ModelBuilder builder)
        //{
        //    builder.ApplyConfigurationsFromAssembly(typeof(BuscadorContext).Assembly);

        //    base.OnModelCreating(builder);
        //}
    }
}