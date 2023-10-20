using Microsoft.EntityFrameworkCore;
using Core.entities;
using Microsoft.EntityFrameworkCore.Metadata.Builders;

namespace Persistencia.Data.Configuration
{
    public class ColoresConfiguration : IEntityTypeConfiguration<Colores>
    {
        public void Configure(EntityTypeBuilder<Colores> builder)
        {
            builder.ToTable("Color");

            builder.HasKey(e => e.Id);
            builder.Property(e => e.Id);

            builder.Property(p => p.Descripcion)
                .IsRequired()
                .HasMaxLength(1000);
        }
    }
}