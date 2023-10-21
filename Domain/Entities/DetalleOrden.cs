using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Domain.Entities;

namespace Dominio.Entities;

    public class DetalleOrden:BaseEntity
    {
        public int CantidadProducir {get; set;}
        public int CantidadProducida {get; set;}

        /*llaves*/

        public int OrdenIdFk {get; set;}
        public Orden Orden {get; set;}

        public int PrendaIdFk {get; set;}
        public Prenda Prenda {get; set;}

        public int ColorIdFk {get; set;}
        public Color Color {get; set;}

        public int EstadoIdFk {get; set;}
        public Estado Estado {get; set;}

    }
