using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Domain.Entities;

namespace Dominio.Entities;

    public class Talla:BaseEntity
    {
        public string Descripcion {get; set;}
        
        /*llaves*/

        public ICollection<InventarioTalla> InventarioTallas {get; set;}
        public ICollection<DetalleVenta> DetalleVentas {get; set;}
    }
