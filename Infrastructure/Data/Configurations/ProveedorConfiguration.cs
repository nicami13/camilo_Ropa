using Microsoft.EntityFrameworkCore;
using Core.entities;
using Microsoft.EntityFrameworkCore.Metadata.Builders;

namespace Persistencia.Data.Configuration
{
    public class ProveedorConfiguration : IEntityTypeConfiguration<Proveedor>
    {
        public void Configure(EntityTypeBuilder<Proveedor> builder)
        {
            builder.ToTable("Proveedor");

            builder.HasKey(e => e.Id);
            builder.Property(e => e.Id);

            builder.HasIndex(p => p.NItProveedor)
                .IsUnique();
            
            builder.Property(p => p.Nombre)
                .IsRequired()
                .HasMaxLength(50);
            
            builder.HasOne(p => p.TipoPersona)
                .WithMany(e => e.proveedores)
                .HasForeignKey(f => f.IdTipoPersona);
            
            builder.HasOne(p => p.Municipio)
                .WithMany(e => e.Proveedores)
                .HasForeignKey(f => f.IdMunicipio);
        }
    }
}