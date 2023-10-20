using Microsoft.EntityFrameworkCore;
using Core.entities;
using Microsoft.EntityFrameworkCore.Metadata.Builders;

namespace Persistencia.Data.Configuration
{
    public class InsumoPrendaConfiguration : IEntityTypeConfiguration<InsumoPrenda>
    {
        public void Configure(EntityTypeBuilder<InsumoPrenda> builder)
        {
            builder.ToTable("InsumoPrenda");

            builder.HasOne(p => p.Insumo)
                .WithMany(e => e.InsumoPrendas)
                .HasForeignKey(f => f.IdInsumo);
            
            builder.HasOne(p => p.Prenda)
                .WithMany(e => e.InsumoPrendas)
                .HasForeignKey(f => f.IdPrenda);
            
            builder.Property(p => p.Cantidad)
                .IsRequired()
                .HasMaxLength(300);

        }
    }
}