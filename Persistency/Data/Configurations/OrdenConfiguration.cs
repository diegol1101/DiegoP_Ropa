using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Dominio.Entities;
using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Metadata.Builders;

namespace Persistencia.Data.Configuration;

    public class OrdenConfiguration : IEntityTypeConfiguration<Orden>
        {
            public void Configure(EntityTypeBuilder<Orden> builder)
            {
                builder.ToTable("orden");
    
                builder.HasKey(e => e.Id);
                builder.Property(e => e.Id)
                .HasMaxLength(3);
    
                builder.Property(e => e.Fecha)
                .HasColumnName("fecha")
                .HasColumnType("datetime")
                .IsRequired();

                builder.HasOne(p => p.Empleado)
                .WithMany(p => p.Ordenes)
                .HasForeignKey(p => p.EmpleadoIdFk);

                builder.HasOne(p => p.Cliente)
                .WithMany(p => p.Ordenes)
                .HasForeignKey(p => p.ClienteIdFk);

                builder.HasOne(p => p.Estado)
                .WithMany(p => p.Ordenes)
                .HasForeignKey(p => p.EstadoIdFk);
            }
        }
