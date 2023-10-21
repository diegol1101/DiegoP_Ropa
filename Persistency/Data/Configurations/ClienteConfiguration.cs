using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Dominio.Entities;
using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Metadata.Builders;

namespace Persistencia.Data.Configuration;

    public class ClienteConfiguration : IEntityTypeConfiguration<Cliente>
        {
            public void Configure(EntityTypeBuilder<Cliente> builder)
            {
                builder.ToTable("cliente");
    
                builder.HasKey(e => e.Id);
                builder.Property(e => e.Id)
                .HasMaxLength(3);
    
                builder.Property(e => e.IdCliente)
                .HasColumnName("id_cliente")
                .IsRequired()
                .HasMaxLength(50);

                builder.Property(e => e.Nombre)
                .HasColumnName("nombre")
                .IsRequired()
                .HasMaxLength(50);

                builder.Property(e => e.FechaRegistro)
                .HasColumnName("fecharegistro")
                .HasColumnType("datetime")
                .IsRequired();

                builder.HasOne(p => p.Municipio)
                .WithMany(p => p.Clientes)
                .HasForeignKey(p => p.MunicipioIdFk);

                builder.HasOne(p => p.TipoPersona)
                .WithMany(p => p.Clientes)
                .HasForeignKey(p => p.TipoPersonaIdFk);
                
            }
        }
