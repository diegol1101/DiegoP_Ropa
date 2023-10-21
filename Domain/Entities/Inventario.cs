using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Domain.Entities;

namespace Dominio.Entities;

    public class Inventario:BaseEntity
    {
        public string CodInv {get; set;}
        public double ValorVtaCop {get; set;}
        public double ValorVtaUsd {get; set;}

        /*llaves*/
        public int PrendaIdFk { get; set; }
        public Prenda Prenda {get; set;}

        public ICollection<DetalleVenta> DetalleVentas {get; set;}
        public ICollection<InventarioTalla> InventarioTallas {get; set;}


    }
