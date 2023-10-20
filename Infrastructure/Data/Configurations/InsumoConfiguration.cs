using Microsoft.EntityFrameworkCore;
using Core.entities;
using Microsoft.EntityFrameworkCore.Metadata.Builders;

namespace Persistencia.Data.Configuration
{
    public class InsumoConfiguration : IEntityTypeConfiguration<Insumo>
    {
        public void Configure(EntityTypeBuilder<Insumo> builder)
        {
            builder.ToTable("Insumo");

            builder.HasKey(e => e.Id);
            builder.Property(e => e.Id);

            builder.HasIndex(p => p.Nombre)
                .IsUnique();
                
            builder.Property(p => p.ValorUnitario)
                .HasColumnType("double");
            builder.Property(p => p.StockMin)
                .IsRequired()
                .HasMaxLength(200);
            builder.Property(p => p.StockMax)
                .IsRequired()
                .HasMaxLength(3000);
        }
    }
}