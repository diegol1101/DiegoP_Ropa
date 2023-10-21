using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace Dominio.Entities;

    public class InsumoPrenda
    {
        public int Cantidad {get; set;}
        
        /*llaves*/
        public int PrendaIdFk {get; set;}
        public Prenda Prenda {get; set;}

        public int InsumoIdFk {get; set;}
        public Insumo Insumo {get; set;}
    }
