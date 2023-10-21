

using Dominio.Entities;
using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Metadata.Builders;

namespace Persistencia.Data.Configuration;

    public class ColorConfiguration : IEntityTypeConfiguration<Color>
        {
            public void Configure(EntityTypeBuilder<Color> builder)
            {
                builder.ToTable("color");
    
                builder.HasKey(e => e.Id);
                builder.Property(e => e.Id)
                .HasMaxLength(3);
    
                builder.Property(e => e.Descripcion)
                .HasColumnName("descripcion")
                .IsRequired()
                .HasMaxLength(50);
                
            }
        }
    
    
