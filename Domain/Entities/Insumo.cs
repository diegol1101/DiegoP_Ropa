using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Domain.Entities;

namespace Dominio.Entities;

    public class Insumo:BaseEntity
    {
        public string Nombre {get; set;}
        public double ValorUnit {get; set;}


        /*llaves*/
        public ICollection<InsumoPrenda> InsumoPrendas {get; set;}
        public ICollection<InsumoProveedor> InsumoProveedores {get; set;}
    }
