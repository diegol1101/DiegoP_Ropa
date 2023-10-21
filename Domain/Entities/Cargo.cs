using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Domain.Entities;

namespace Dominio.Entities;

    public class Cargo:BaseEntity
    {
        public string Descripcion {get; set;}
        public double SueldoBase {get; set;}

        /*llaves*/
        public ICollection<Empleado> Empleados {get; set;}
    }
