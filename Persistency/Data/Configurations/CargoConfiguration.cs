
using Dominio.Entities;
using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Metadata.Builders;

namespace Persistencia.Data.Configuration;

    public class CargoConfiguration : IEntityTypeConfiguration<Cargo>
        {
            public void Configure(EntityTypeBuilder<Cargo> builder)
            {
                builder.ToTable("cargo");
    
                builder.HasKey(e => e.Id);
                builder.Property(e => e.Id)
                .HasMaxLength(3);
    
                builder.Property(e => e.Descripcion)
                .HasColumnName("descripcion")
                .IsRequired()
                .HasMaxLength(50);

                builder.Property(e => e.SueldoBase)
                .HasColumnType("double")
                .HasColumnName("sueldobase")
                .IsRequired();
                
            }
        }
    