using Microsoft.EntityFrameworkCore;
using Core.entities;
using Microsoft.EntityFrameworkCore.Metadata.Builders;

namespace Persistencia.Data.Configuration
{
    public class DetalleVentaConfiguration : IEntityTypeConfiguration<DetalleVenta>
    {
        public void Configure(EntityTypeBuilder<DetalleVenta> builder)
        {
            builder.ToTable("DetalleVenta");

            builder.HasKey(e => e.Id);
            builder.Property(e => e.Id);

             builder.Property(p => p.Cantidad)
                 .IsRequired()
                 .HasMaxLength(30);

            builder.Property(p => p.ValorUnitario)
                .HasColumnType("double");
            
            builder.HasOne(p => p.Venta)
                .WithMany(e => e.DetalleVentas)
                .HasForeignKey(f => f.IdVenta);
            
            builder.HasOne(p => p.Inventario)
                .WithMany(e => e.DetalleVentas)
                .HasForeignKey(f => f.IdProducto);
            
            builder.HasOne(p => p.Talla)
                .WithMany(e => e.DetalleVentas)
                .HasForeignKey(f => f.IdTalla);
                

            // Agrega configuraciones adicionales aquí si es necesario
        }
    }
}