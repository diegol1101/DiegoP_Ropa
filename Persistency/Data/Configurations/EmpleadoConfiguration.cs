using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Dominio.Entities;
using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Metadata.Builders;

namespace Persistencia.Data.Configuration;

    public class EmpleadoConfiguration : IEntityTypeConfiguration<Empleado>
        {
            public void Configure(EntityTypeBuilder<Empleado> builder)
            {
                builder.ToTable("empleado");
    
                builder.HasKey(e => e.Id);
                builder.Property(e => e.Id)
                .HasMaxLength(3);
    
                builder.Property(e => e.IdEmpleado)
                .HasColumnName("idempleado")
                .IsRequired()
                .HasMaxLength(50);

                builder.Property(e => e.Nombre)
                .HasColumnName("nombre")
                .IsRequired()
                .HasMaxLength(50);

                builder.Property(e => e.FechaIngreso)
                .HasColumnName("fechaingreso")
                .HasColumnType("datetime")
                .IsRequired();

                builder.HasOne(p => p.Cargo)
                .WithMany(p => p.Empleados)
                .HasForeignKey(p => p.CargoIdFk);

                builder.HasOne(p => p.Municipio)
                .WithMany(p => p.Empleados)
                .HasForeignKey(p => p.MunicipioIdFk);
                
            }
        }
    