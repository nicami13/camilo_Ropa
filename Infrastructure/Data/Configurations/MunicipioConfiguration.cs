using Microsoft.EntityFrameworkCore;
using Core.entities;
using Microsoft.EntityFrameworkCore.Metadata.Builders;

namespace Persistencia.Data.Configuration
{
    public class MunicipioConfiguration : IEntityTypeConfiguration<Municipio>
    {
        public void Configure(EntityTypeBuilder<Municipio> builder)
        {
            builder.ToTable("Municipio");

            builder.HasKey(e => e.Id);
            builder.Property(e => e.Id);

            builder.Property(p => p.Nombre)
                .IsRequired()
                .HasMaxLength(50);
            
            builder.HasOne(p => p.Departamento)
                .WithMany(e => e.Municipios)
                .HasForeignKey(f => f.IdDepartamento);

        }
    }
}