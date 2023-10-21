using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Dominio.Entities;
using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Metadata.Builders;

namespace Persistencia.Data.Configuration;

    public class InsumoProveedorConfiguration : IEntityTypeConfiguration<InsumoProveedor>
        {
            public void Configure(EntityTypeBuilder<InsumoProveedor> builder)
            {
                builder.ToTable("insumoproveedor");

                builder.Property(e => e.Cantidad)
                .HasColumnType("int")
                .HasColumnName("cantidad")
                .IsRequired();
    
                builder.HasKey(p=> new {p.InsumoIdFk,p.ProveedorIdFk});
            }
        }
    