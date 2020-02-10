using Microsoft.EntityFrameworkCore;
using Sorteio.Domain.Criterios;
using Sorteio.Domain.Familias;
using Sorteio.Domain.Familias.Pessoas;

namespace Data
{
    public class SorteioContext : DbContext
    {
        public DbSet<Familia> Familias { get; set; }
        public DbSet<Pessoa> Pessoas { get; set; }
        public DbSet<ResultadoDaAvaliacaoDosCriterios> Resultados { get; set; }

        public SorteioContext(DbContextOptions options) : base(options)
        {
        }

        protected override void OnModelCreating(ModelBuilder modelBuilder)
        {
            modelBuilder.ApplyConfigurationsFromAssembly(typeof(SorteioContext).Assembly);
        }
    }
}
