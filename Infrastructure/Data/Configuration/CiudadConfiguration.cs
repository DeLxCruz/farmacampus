using core.Entities;
using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Metadata.Builders;
namespace Infraestructure.Data.Configuration;

    public class CiudadConfiguration : IEntityTypeConfiguration<Ciudad>
    {
         public void Configure(EntityTypeBuilder<Ciudad> builder)
        {
            builder.ToTable("ciudad");

            builder.HasKey(p => p.Id);
            builder.Property(p => p.Id);

            builder.Property(p => p.Nombre)
                .IsRequired()
                .HasMaxLength(50);

            builder.HasOne(d => d.Departamentos).WithMany(d => d.Ciudades).HasForeignKey(p => p.IdDepartamentoFK);
        }
    }