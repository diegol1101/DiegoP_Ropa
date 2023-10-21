using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Dominio.Entities;
using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Metadata.Builders;

namespace Persistencia.Data.Configuration;

    public class TipoEstadoConfiguration : IEntityTypeConfiguration<TipoEstado>
        {
            public void Configure(EntityTypeBuilder<TipoEstado> builder)
            {
                builder.ToTable("tipoestado");
    
                builder.HasKey(e => e.Id);
                builder.Property(e => e.Id)
                .HasMaxLength(3);
    
                builder.Property(e => e.Descripcion)
                .HasColumnName("descripcion")
                .IsRequired()
                .HasMaxLength(50);
            }
        }