using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Domain.Entities;

namespace Dominio.Entities;

    public class InsumoProveedor
    {
        public int Cantidad {get; set;}
        /*llaves*/

        public int InsumoIdFk {get; set;}
        public Insumo Insumo {get; set;}

        public int ProveedorIdFk {get; set;}
        public Proveedor Provedor {get; set;}
    }
