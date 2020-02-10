using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Metadata.Builders;
using Sorteio.Domain.CalculadoraDePontos;
using Sorteio.Domain.Criterios;

namespace Data.Configurations
{
    public class ResultadoDaAvaliacaoDosCriteriosConfiguration : IEntityTypeConfiguration<ResultadoDaAvaliacaoDosCriterios>
    {
        public void Configure(EntityTypeBuilder<ResultadoDaAvaliacaoDosCriterios> builder)
        {
            builder.ToTable("ResultadosDaAvaliacaoDosCriterios");

            builder.Property(p => p.Id)
                .HasConversion(
                v => v.ToGuid(),
                v => new ResultadoDaAvaliacaoDosCriteriosId(v))
                .IsRequired();

            builder.Property(p => p.PontuacaoTotal)
                .HasConversion(
                p => p.Valor,
                p => Pontuacao.CriarNovo(p))
                .IsRequired();

            builder.Property(p => p.DataDeSelecao)
                .IsRequired();

            builder.HasOne(p => p.Familia)
                .WithOne()
                .HasForeignKey<ResultadoDaAvaliacaoDosCriterios>(p => p.FamiliaId);

            builder.Ignore(p => p.CriteriosAtendidos);
        }
    }
}
