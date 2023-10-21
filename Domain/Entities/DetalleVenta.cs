using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Domain.Entities;

namespace Dominio.Entities;

    public class DetalleVenta:BaseEntity
    {
        public int Cantidad {get; set;}
        public double ValorUnitario {get; set;}

        /*llaves*/
        public int VentaIdFk {get; set;}
        public Venta Venta {get; set;}

        public int InventarioIdFk {get; set;}
        public Inventario Inventario {get; set;}

        public int TallaIdFk {get; set;}
        public Talla Talla {get; set;}


    }
