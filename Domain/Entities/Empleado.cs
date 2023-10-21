using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Domain.Entities;

namespace Dominio.Entities;

    public class Empleado:BaseEntity
    {
        public string IdEmpleado { get; set; }
        public string Nombre {get; set;}
        public DateTime FechaIngreso {get; set; }

        /*llaves*/
        public int CargoIdFk {get; set; }
        public Cargo Cargo {get; set;}

        public int MunicipioIdFk {get; set; }
        public Municipio Municipio {get; set;}

        public ICollection<Venta> Ventas {get; set;}
        public ICollection<Orden> Ordenes {get; set;} 
    }
