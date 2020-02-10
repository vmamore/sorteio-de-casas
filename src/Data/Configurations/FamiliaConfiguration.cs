using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Metadata.Builders;
using Sorteio.Domain.Familias;

namespace Data.Configurations
{
    public class FamiliaConfiguration : IEntityTypeConfiguration<Familia>
    {
        public void Configure(EntityTypeBuilder<Familia> builder)
        {
            builder.Property(f => f.Id)
                .HasConversion(
                v => v.ToGuid(),
                v => new FamiliaId(v))
                .IsRequired();

            builder.ToTable("Familias");
        }
    }
}
