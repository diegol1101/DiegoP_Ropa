using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Dominio.Entities;
using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Metadata.Builders;

namespace Persistencia.Data.Configuration;

    public class DepartamentoConfiguration : IEntityTypeConfiguration<Departamento>
        {
            public void Configure(EntityTypeBuilder<Departamento> builder)
            {
                builder.ToTable("departamento");
    
                builder.HasKey(e => e.Id);
                builder.Property(e => e.Id)
                .HasMaxLength(3);
    
                builder.Property(e => e.Nombre)
                .HasColumnName("nombre")
                .IsRequired()
                .HasMaxLength(50);

                builder.HasOne(p => p.Pais)
                .WithMany(p => p.Departamentos)
                .HasForeignKey(p => p.PaisFk);
            }
        }
