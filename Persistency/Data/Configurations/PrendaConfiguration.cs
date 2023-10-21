using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Dominio.Entities;
using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Metadata.Builders;

namespace Persistencia.Data.Configuration;

    public class PrendaConfiguration : IEntityTypeConfiguration<Prenda>
        {
            public void Configure(EntityTypeBuilder<Prenda> builder)
            {
                builder.ToTable("prenda");
    
                builder.HasKey(e => e.Id);
                builder.Property(e => e.Id)
                .HasMaxLength(3);
    
                builder.Property(e => e.IdPrenda)
                .HasColumnName("prenda")
                .IsRequired()
                .HasMaxLength(50);

                builder.Property(e => e.Nombre)
                .HasColumnName("nombre")
                .IsRequired()
                .HasMaxLength(50);

                builder.Property(e => e.ValorUnitCop)
                .HasColumnType("double")
                .HasColumnName("valorunitcop")
                .IsRequired();

                builder.Property(e => e.ValorUnitUsd)
                .HasColumnType("double")
                .HasColumnName("valorunitusd")
                .IsRequired();

                builder.HasOne(p => p.TipoProteccion)
                .WithMany(p => p.Prendas)
                .HasForeignKey(p => p.TipoProteccionIdFk);

                builder.HasOne(p => p.Genero)
                .WithMany(p => p.Prendas)
                .HasForeignKey(p => p.GeneroIdFk);

                builder.HasOne(p => p.Estado)
                .WithMany(p => p.Prendas)
                .HasForeignKey(p => p.EstadoIdFk);

            }
        }
   