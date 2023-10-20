using Microsoft.EntityFrameworkCore;
using Core.entities;
using Microsoft.EntityFrameworkCore.Metadata.Builders;

namespace Persistencia.Data.Configuration
{
    public class OrdenConfiguration : IEntityTypeConfiguration<Orden>
    {
        public void Configure(EntityTypeBuilder<Orden> builder)
        {
            builder.ToTable("Orden");

            builder.HasKey(e=> e.Id);

            builder.HasOne(p => p.Empleado)
                .WithMany(e => e.Ordenes)
                .HasForeignKey(f => f.IdEmpleado);
            
            builder.HasOne(p => p.Cliente)
                .WithMany(e => e.Ordenes)
                .HasForeignKey(f => f.IdCliente);

            builder.HasOne(p => p.Estado)
                .WithMany(e => e.Ordenes)
                .HasForeignKey(f => f.IdEstado);
        }
    }
}