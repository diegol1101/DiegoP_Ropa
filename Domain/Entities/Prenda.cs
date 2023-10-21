using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Domain.Entities;

namespace Dominio.Entities;

    public class Prenda:BaseEntity
    {   
        public string IdPrenda {get; set;}
        public string Nombre { get; set; }
        public double ValorUnitCop {get; set;}
        public double ValorUnitUsd {get; set;}

        /*llaves*/
        public int TipoProteccionIdFk {get; set;}
        public TipoProteccion TipoProteccion {get; set;}

        public int GeneroIdFk {get; set;}
        public Genero Genero {get; set;}

        public int EstadoIdFk {get; set;}
        public Estado Estado {get; set;}

        public ICollection<DetalleOrden> DetalleOrdenes {get; set;}
        public ICollection<InsumoPrenda> InsumoPrendas {get; set;}
        public ICollection<Inventario> Inventarios {get; set;}
    }
