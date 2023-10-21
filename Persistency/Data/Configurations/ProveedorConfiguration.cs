using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Dominio.Entities;
using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Metadata.Builders;

namespace Persistencia.Data.Configuration;

    public class ProveedorConfiguration : IEntityTypeConfiguration<Proveedor>
        {
            public void Configure(EntityTypeBuilder<Proveedor> builder)
            {
                builder.ToTable("proveedor");
    
                builder.HasKey(e => e.Id);
                builder.Property(e => e.Id)
                .HasMaxLength(3);
    
                builder.Property(e => e.NitProveedor)
                .HasColumnName("nitproveedor")
                .IsRequired()
                .HasMaxLength(50);

                builder.Property(e => e.Nombre)
                .HasColumnName("nombre")
                .IsRequired()
                .HasMaxLength(50);

                builder.HasOne(p => p.Municipio)
                .WithMany(p => p.Proveedores)
                .HasForeignKey(p => p.MunicipioIdFk);

                builder.HasOne(p => p.TipoPersona)
                .WithMany(p => p.Proveedores)
                .HasForeignKey(p => p.TipoPersonaIdFk);
            }
        }
    
