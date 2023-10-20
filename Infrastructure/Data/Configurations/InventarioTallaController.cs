using Microsoft.EntityFrameworkCore;
using Core.entities;
using Microsoft.EntityFrameworkCore.Metadata.Builders;

namespace Persistencia.Data.Configuration
{
    public class InventarioTallaConfiguration : IEntityTypeConfiguration<InventarioTalla>
    {
        public void Configure(EntityTypeBuilder<InventarioTalla> builder)
        {
            builder.ToTable("InventarioTalla");

                builder.HasOne(p => p.Inventario)
                    .WithMany(e => e.InventarioTallas)
                    .HasForeignKey(f => f.IdInventario);
                
                builder.Property(p => p.Cantidad)
                    .IsRequired()
                    .HasMaxLength(300);
                
                builder.HasOne(p => p.Talla)
                    .WithMany(e => e.InventarioTallas)
                    .HasForeignKey(f => f.IdTalla);
        }
    }
}