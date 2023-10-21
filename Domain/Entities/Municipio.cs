using System;
using System.Collections.Generic;
using System.Linq;
using System.Runtime.CompilerServices;
using System.Threading.Tasks;
using Domain.Entities;
using Microsoft.AspNetCore.Mvc;

namespace Dominio.Entities;

    public class Municipio:BaseEntity
    {
        public String Nombre {get; set;}


        /*llaves*/
        public int DepartamentoIdFk {get; set;}
        public Departamento Departamento {get; set;}

        public ICollection<Empresa> Empresas {get; set;}
        public ICollection<Cliente> Clientes {get; set;}
        public ICollection<Empleado> Empleados {get; set;}
        public ICollection<Proveedor> Proveedores {get; set;}

    }
