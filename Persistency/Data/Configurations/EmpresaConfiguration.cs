using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Dominio.Entities;
using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Metadata.Builders;

namespace Persistencia.Data.Configuration;

    public class EmpresaConfiguration : IEntityTypeConfiguration<Empresa>
        {
            public void Configure(EntityTypeBuilder<Empresa> builder)
            {
                builder.ToTable("empresa");
    
                builder.HasKey(e => e.Id);
                builder.Property(e => e.Id)
                .HasMaxLength(3);
    
                builder.Property(e => e.Nit)
                .HasColumnName("nit")
                .IsRequired()
                .HasMaxLength(100);

                builder.Property(e => e.RazonSocial)
                .HasColumnName("razonsocial")
                .IsRequired()
                .HasMaxLength(100);

                builder.Property(e => e.RepresentanteLegal)
                .HasColumnName("representantelegal")
                .IsRequired()
                .HasMaxLength(100);

                builder.Property(e => e.FechaCreacion)
                .HasColumnName("fechacreacion")
                .HasColumnType("datetime")
                .IsRequired();

                builder.HasOne(p => p.Municipio)
                .WithMany(p => p.Empresas)
                .HasForeignKey(p => p.MunicipioIdFk);
            }
        }
    