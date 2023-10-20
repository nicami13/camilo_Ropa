using Microsoft.EntityFrameworkCore;
using Core.entities;
using Microsoft.EntityFrameworkCore.Metadata.Builders;

namespace Persistencia.Data.Configuration
{
    public class VentaConfiguration : IEntityTypeConfiguration<Venta>
    {
        public void Configure(EntityTypeBuilder<Venta> builder)
        {
            builder.ToTable("Venta");

            builder.HasKey(e => e.Id);
            builder.Property(e => e.Id);

            builder.Property(p => p.Fecha)
            .HasColumnType("DateTime");

            builder.HasOne(p => p.Empleado)
                .WithMany(e => e.Ventas)
                .HasForeignKey(f => f.IdEmpleado);
            
            builder.HasOne(p => p.Cliente)
                .WithMany(e => e.Ventas)
                .HasForeignKey(f => f.IdCliente);

            builder.HasOne(p => p.FormaPago)
                .WithMany(e => e.Ventas)
                .HasForeignKey(f => f.IdFormaPago);
        }
    }
}