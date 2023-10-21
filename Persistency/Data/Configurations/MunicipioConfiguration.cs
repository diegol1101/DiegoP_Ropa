using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Dominio.Entities;
using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Metadata.Builders;

namespace Persistencia.Data.Configuration;

    public class MunicipioConfiguration : IEntityTypeConfiguration<Municipio>
        {
            public void Configure(EntityTypeBuilder<Municipio> builder)
            {
                builder.ToTable("municipio");
    
                builder.HasKey(e => e.Id);
                builder.Property(e => e.Id)
                .HasMaxLength(3);
    
                builder.Property(e => e.Nombre)
                .HasColumnName("nombre")
                .IsRequired()
                .HasMaxLength(50);

                builder.HasOne(p => p.Departamento)
                .WithMany(p => p.Municipios)
                .HasForeignKey(p => p.DepartamentoIdFk);
            }
        }
   