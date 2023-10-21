using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Dominio.Entities;
using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Metadata.Builders;

namespace Persistencia.Data.Configuration;

    public class DetalleOrdenConfiguration: IEntityTypeConfiguration<DetalleOrden>
        {
            public void Configure(EntityTypeBuilder<DetalleOrden> builder)
            {
                builder.ToTable("detalleorden");
    
                builder.HasKey(e => e.Id);
                builder.Property(e => e.Id)
                .HasMaxLength(3);
    
                builder.Property(e => e.CantidadProducir)
                .HasColumnName("cantidadproducir")
                .HasColumnType("int")
                .IsRequired();

                builder.Property(e => e.CantidadProducida)
                .HasColumnName("cantidadproducida")
                .HasColumnType("int")
                .IsRequired();

                builder.HasOne(p => p.Orden)
                .WithMany(p => p.DetalleOrdenes)
                .HasForeignKey(p => p.OrdenIdFk);

                builder.HasOne(p => p.Prenda)
                .WithMany(p => p.DetalleOrdenes)
                .HasForeignKey(p => p.PrendaIdFk);

                builder.HasOne(p => p.Color)
                .WithMany(p => p.DetalleOrdenes)
                .HasForeignKey(p => p.ColorIdFk);

                builder.HasOne(p => p.Estado)
                .WithMany(p => p.DetalleOrdenes)
                .HasForeignKey(p => p.EstadoIdFk);
                
            }
        }
    