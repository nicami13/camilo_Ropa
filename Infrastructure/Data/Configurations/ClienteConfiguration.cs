using Microsoft.EntityFrameworkCore;
using Core.entities;
using Microsoft.EntityFrameworkCore.Metadata.Builders;

namespace Persistencia.Data.Configuration
{
    public class ClienteClaseConfiguration : IEntityTypeConfiguration<Cliente>
    {
        public void Configure(EntityTypeBuilder<Cliente> builder)
        {
            builder.ToTable("Cliente");

            builder.HasKey(e => e.Id);
            builder.Property(e => e.Id);

            builder.Property(p => p.Nombre)
                .IsRequired()
                .HasMaxLength(50);

            builder.HasIndex(p => p.IdCLiente)
                .IsUnique();
            
            builder.HasOne(p => p.TipoPersona)
                .WithMany(e => e.Clientes)
                .HasForeignKey(f => f.IdTipoPersona);

            builder.HasOne(p => p.Municipio)
                .WithMany(e => e.Clientes)
                .HasForeignKey(f => f.IdMunicipio);

            builder.Property(p => p.Fecharegistro)
                .HasColumnType("DateTime");
            
        }
    }
}