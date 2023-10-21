using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Dominio.Entities;
using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Metadata.Builders;

namespace Persistencia.Data.Configuration;

    public class DetalleVentaConfiguration : IEntityTypeConfiguration<DetalleVenta>
        {
            public void Configure(EntityTypeBuilder<DetalleVenta> builder)
            {
                builder.ToTable("detalleventa");
    
                builder.HasKey(e => e.Id);
                builder.Property(e => e.Id)
                .HasMaxLength(3);
    
                builder.Property(e => e.Cantidad)
                .HasColumnName("cantidad")
                .HasColumnType("int")
                .IsRequired();

                builder.Property(e => e.ValorUnitario)
                .HasColumnName("valorunitario")
                .HasColumnType("double")
                .IsRequired();

                builder.HasOne(p => p.Venta)
                .WithMany(p => p.DetalleVentas)
                .HasForeignKey(p => p.VentaIdFk);

                builder.HasOne(p => p.Inventario)
                .WithMany(p => p.DetalleVentas)
                .HasForeignKey(p => p.InventarioIdFk);

                builder.HasOne(p => p.Talla)
                .WithMany(p => p.DetalleVentas)
                .HasForeignKey(p => p.TallaIdFk);
            }
        }
    