using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace Dominio.Entities;

    public class InventarioTalla
    {
        public int Cantidad {get; set;}
        
        /*llaves*/
        public int InventarioIdFk {get; set;}
        public Inventario Inventario {get; set;}

        public int TallaIdFk {get; set;}
        public Talla Talla {get; set;}
    }
