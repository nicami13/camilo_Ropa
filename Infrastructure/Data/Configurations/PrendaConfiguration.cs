using Microsoft.EntityFrameworkCore;
using Core.entities;
using Microsoft.EntityFrameworkCore.Metadata.Builders;

namespace Persistencia.Data.Configuration
{
    public class PrendaConfiguration : IEntityTypeConfiguration<Prenda>
    {
        public void Configure(EntityTypeBuilder<Prenda> builder)
        {
            builder.ToTable("Prenda");

            builder.HasKey(e => e.Id);
            builder.Property(e => e.Id);

            builder.HasIndex(p => p.IdPrenda)
                .IsUnique();

            builder.Property(p => p.Nombre)
                .IsRequired()
                .HasMaxLength(50);

            builder.Property(p => p.ValorUnitCop)
                .HasColumnType("double");

            builder.Property(p => p.ValorUnitUsd)
                .HasColumnType("double");

            builder.HasOne(p => p.Estado)
                .WithMany(e => e.Prendas)
                .HasForeignKey(f => f.IdEstado);
            
            builder.HasOne(p => p.TipoProteccion)
                .WithMany(e => e.Prendas)
                .HasForeignKey(f => f.IdTipoProteccion);
            
            builder.HasOne(p => p.Genero)
                .WithMany(e => e.Prendas)
                .HasForeignKey(f => f.IdGenero);


            
        }
    }
}