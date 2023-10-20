using Microsoft.EntityFrameworkCore;
using Core.entities;
using Microsoft.EntityFrameworkCore.Metadata.Builders;

namespace Persistencia.Data.Configuration
{
    public class EmpleadoConfiguration : IEntityTypeConfiguration<Empleado>
    {
        public void Configure(EntityTypeBuilder<Empleado> builder)
        {
            builder.ToTable("Empleado");

            builder.HasKey(e => e.Id);
            builder.Property(e => e.Id);

            builder.HasIndex(p => p.IdEmp)
            .IsUnique();

            builder.Property(p => p.Nombre)
                .IsRequired()
                .HasMaxLength(50);
            
            builder.Property(p => p.FechaIngreso)
                .HasColumnType("DateTime");
            
            builder.HasOne(p => p.Municipio)
                .WithMany(e => e.Empleados)
                .HasForeignKey(f => f.IdMunicipio);
            
            builder.HasOne(p => p.Cargo)
                .WithMany(e => e.Empleados)
                .HasForeignKey(f => f.IdCargo);
        }
    }
}