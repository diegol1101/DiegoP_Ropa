using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Dominio.Entities;
using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Metadata.Builders;

namespace Persistency.Data.Configurations;

    public class VentaConfiguration : IEntityTypeConfiguration<Venta>
        {
            public void Configure(EntityTypeBuilder<Venta> builder)
            {
                builder.ToTable("venta");
    
                builder.HasKey(e => e.Id);
                builder.Property(e => e.Id)
                .HasMaxLength(3);
    
                builder.Property(e => e.Fecha)
                .HasColumnName("fecha")
                .HasColumnType("datetime")
                .IsRequired();

                builder.HasOne(p => p.Empleado)
                .WithMany(p => p.Ventas)
                .HasForeignKey(p => p.EmpleadoIdFk);

                builder.HasOne(p => p.Cliente)
                .WithMany(p => p.Ventas)
                .HasForeignKey(p => p.ClienteIdFk);

                builder.HasOne(p => p.FormaPago)
                .WithMany(p => p.Ventas)
                .HasForeignKey(p => p.FormaPagoIdFk);

            }
        }
    
