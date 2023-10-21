using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Dominio.Entities;
using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Metadata.Builders;

namespace Persistencia.Data.Configuration;

    public class InventarioConfiguration : IEntityTypeConfiguration<Inventario>
        {
            public void Configure(EntityTypeBuilder<Inventario> builder)
            {
                builder.ToTable("inventario");
    
                builder.HasKey(e => e.Id);
                builder.Property(e => e.Id)
                .HasMaxLength(3);
    
                builder.Property(e => e.CodInv)
                .HasColumnName("codinv")
                .IsRequired()
                .HasMaxLength(50);

                builder.Property(e => e.ValorVtaCop)
                .HasColumnName("valorventacop")
                .HasColumnType("double")
                .IsRequired();

                builder.Property(e => e.ValorVtaUsd)
                .HasColumnName("valorventausd")
                .HasColumnType("double")
                .IsRequired();

                builder.HasOne(p => p.Prenda)
                .WithMany(p => p.Inventarios)
                .HasForeignKey(p => p.PrendaIdFk);
            }
        }
    