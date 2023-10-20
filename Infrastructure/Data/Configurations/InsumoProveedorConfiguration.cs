using Microsoft.EntityFrameworkCore;
using Core.entities;
using Microsoft.EntityFrameworkCore.Metadata.Builders;

namespace Persistencia.Data.Configuration
{
    public class InsumoProveedorConfiguration : IEntityTypeConfiguration<InsumoProveedor>
    {
        public void Configure(EntityTypeBuilder<InsumoProveedor> builder)
        {
            builder.ToTable("InsumoProveedor");

        builder.HasOne(p => p.Insumo)
            .WithMany(e => e.InsumoProveedores)
            .HasForeignKey(f => f.IdInsumo);
        
        builder.HasOne(p => p.Proveedor)
            .WithMany(e => e.InsumoProveedores)
            .HasForeignKey(f => f.IdProovedor);
        }
    }
}