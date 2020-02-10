using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Metadata.Builders;
using Sorteio.Domain.Familias.Pessoas;

namespace Data.Configurations
{
    public class PessoaConfiguration : IEntityTypeConfiguration<Pessoa>
    {
        public void Configure(EntityTypeBuilder<Pessoa> builder)
        {
            builder.ToTable("Pessoas");

            builder.Property(p => p.Id)
                .HasConversion(
                v => v.ToGuid(),
                v => new PessoaId(v))
                .IsRequired();

            builder.Property(p => p.Nome)
                .HasConversion(
                v => v.ToString(),
                v => Nome.CriarNovo(v))
                .IsRequired();

            builder.Property(p => p.Idade)
                .HasColumnName("DataDeNascimento")
                .HasConversion(
                v => v.DataDeNascimento,
                v => Idade.CriarNovo(v))
                .IsRequired();

            builder.Property(p => p.Renda)
                .HasConversion(
                v => v.Valor.ToDecimal(),
                v => Renda.CriarNovo(v))
            .IsRequired(false);

            builder.Property(p => p.Tipo);

            builder.HasOne(p => p.Familia)
                .WithMany(p => p.Pessoas)
                .HasForeignKey(p => p.FamiliaId);
        }
    }
}
