using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Dominio.Entities;
using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Metadata.Builders;

namespace Persistencia.Data.Configuration;

    public class InventarioTallaConfiguration : IEntityTypeConfiguration<InventarioTalla>
        {
            public void Configure(EntityTypeBuilder<InventarioTalla> builder)
            {
                builder.ToTable("inventariotalla");
    
                builder.Property(e => e.Cantidad)
                .HasColumnName("cantidad")
                .HasColumnType("int")
                .IsRequired();

                builder.HasKey(p=> new {p.InventarioIdFk,p.TallaIdFk});

            }
        }
