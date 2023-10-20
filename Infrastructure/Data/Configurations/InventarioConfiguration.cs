using Microsoft.EntityFrameworkCore;
using Core.entities;
using Microsoft.EntityFrameworkCore.Metadata.Builders;

namespace Persistencia.Data.Configuration
{
    public class InventarioConfiguration : IEntityTypeConfiguration<Inventario>
    {
        public void Configure(EntityTypeBuilder<Inventario> builder)
        {
            builder.ToTable("Inventario");

            builder.HasKey(e => e.Id);
            builder.Property(e => e.Id);

            builder.HasIndex(p => p.CodInv)
                .IsUnique();
            
            builder.HasOne(p => p.Prenda)
                .WithMany(e => e.Inventarios)
                .HasForeignKey(f => f.IdPrenda);

            builder.Property(p => p.ValorVtaCop)
                .HasColumnType("double");

            builder.Property(p => p.ValorVtaUsd)
            .HasColumnType("double");

            // Agrega configuraciones adicionales aquí si es necesario
        }
    }
}