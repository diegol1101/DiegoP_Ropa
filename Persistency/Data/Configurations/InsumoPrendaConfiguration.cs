using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Dominio.Entities;
using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Metadata.Builders;

namespace Persistencia.Data.Configuration;

    public class InsumoPrendaConfiguration : IEntityTypeConfiguration<InsumoPrenda>
        {
            public void Configure(EntityTypeBuilder<InsumoPrenda> builder)
            {
                builder.ToTable("insumoprenda");
    
                builder.Property(e => e.Cantidad)
                .HasColumnType("int")
                .HasColumnName("cantidad")
                .IsRequired();
                
                builder.HasKey(p=> new {p.PrendaIdFk,p.InsumoIdFk});
            }
        }
    