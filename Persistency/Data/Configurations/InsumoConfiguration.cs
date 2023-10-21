using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Dominio.Entities;
using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Metadata.Builders;

namespace Persistencia.Data.Configuration;

    public class InsumoConfiguration : IEntityTypeConfiguration<Insumo>
        {
            public void Configure(EntityTypeBuilder<Insumo> builder)
            {
                builder.ToTable("insumo");
    
                builder.HasKey(e => e.Id);
                builder.Property(e => e.Id)
                .HasMaxLength(3);
    
                builder.Property(e => e.Nombre)
                .HasColumnName("nombre")
                .IsRequired()
                .HasMaxLength(50);

                builder.Property(e => e.ValorUnit)
                .HasColumnName("valorunit")
                .HasColumnType("double")
                .IsRequired();

            }
        }
    