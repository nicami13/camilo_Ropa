using Microsoft.EntityFrameworkCore;
using Core.entities;
using Microsoft.EntityFrameworkCore.Metadata.Builders;

namespace Persistencia.Data.Configuration
{
    public class DatalleOrdenConfiguration : IEntityTypeConfiguration<DatalleOrden>
    {
        public void Configure(EntityTypeBuilder<DatalleOrden> builder)
        {
            builder.ToTable("DetalleOrden");

            builder.HasKey(e => e.Id);
            builder.Property(e => e.Id);

           builder.Property(p => p.CantidadProducida)
               .IsRequired()
               .HasMaxLength(300000);
            
            builder.Property(p => p.CantidadProducir)
                .IsRequired()
                .HasMaxLength(300000);
            
            builder.HasOne(p => p.Prenda)
                .WithMany(e => e.DatalleOrdenes)
                .HasForeignKey(f => f.IdPrenda);
            
            builder.HasOne(p => p.Color)
                .WithMany(e => e.DatalleOrdenes)
                .HasForeignKey(f => f.IdColor);
            
            builder.HasOne(p => p.Estado)
                .WithMany(e => e.DetalleOrdenes)
                .HasForeignKey(f => f.IdEstado
                );
            
            builder.HasOne(p => p.Orden)
                .WithMany(e => e.DatalleOrdenes)
                .HasForeignKey(f => f.IdOrden);
        }
    }
}