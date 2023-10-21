using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Domain.Entities;

namespace Dominio.Entities;

    public class TipoPersona:BaseEntity
    {
        public string Nombre {get; set;}

        /*llaves*/
        public ICollection<Cliente> Clientes {get; set;}
        public ICollection<Proveedor> Proveedores {get; set;}
        

    }
