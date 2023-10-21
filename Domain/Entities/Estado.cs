using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Domain.Entities;

namespace Dominio.Entities;

    public class Estado:BaseEntity
    {
        public string Descripcion {get; set;}

        /*llaves*/
        public int TipoEstadoIdFk {get; set;}
        public TipoEstado TipoEstado {get; set;}
        public ICollection<Prenda> Prendas {get; set;}
        public ICollection<DetalleOrden> DetalleOrdenes {get; set;}
        public ICollection<Orden> Ordenes {get; set;}

    }
