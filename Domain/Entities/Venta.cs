using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Domain.Entities;

namespace Dominio.Entities;

    public class Venta:BaseEntity
    {
        public DateTime Fecha { get; set; }

        /*llaves*/

        public int EmpleadoIdFk { get; set; }
        public Empleado Empleado {get; set;}

        public int ClienteIdFk { get; set; }
        public Cliente Cliente {get; set;}

        public int FormaPagoIdFk { get; set;}
        public FormaPago FormaPago {get; set;}

        public ICollection<DetalleVenta> DetalleVentas {get; set;}
    }
