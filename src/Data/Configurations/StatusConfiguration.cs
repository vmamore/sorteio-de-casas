using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Metadata.Builders;
using Sorteio.Domain.Familias;
using System;
using System.Collections.Generic;
using System.Text;

namespace Data.Configurations
{
    public class StatusConfiguration : IEntityTypeConfiguration<Status>
    {
        public void Configure(EntityTypeBuilder<Status> builder)
        {
            builder.HasKey(s => s.Id);

            builder.Property(s => s.Descricao)
                .HasMaxLength(150)
                .IsRequired();

            builder.Property(s => s.CadastroValido)
                .HasDefaultValue(false)
                .IsRequired();

            builder.HasData(
                new object[] {
                new
            {
                Id = 1,
                Descricao = "Cadastro válido",
                CadastroValido = true
            },
            new {
                Id = 2,
                Descricao = "Já possui uma casa",
                CadastroValido = false
            },
            new {
                Id = 3,
                Descricao = "Selecionado em outro processo de seleção",
                CadastroValido = false
            },
            new {
                Id = 4,
                Descricao = "Cadastro incompleto",
                CadastroValido = false
            }}
            );

            builder.ToTable("Status");
        }
    }
}
