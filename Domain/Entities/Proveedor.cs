using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Domain.Entities;

namespace Dominio.Entities;

    public class Proveedor:BaseEntity
    {
        
        public string NitProveedor { get; set; }
        public string Nombre {get; set;}

        /*llaves*/
        public int MunicipioIdFk {get; set;}
        public Municipio Municipio {get; set;}

        public int TipoPersonaIdFk {get; set;}
        public TipoPersona TipoPersona {get; set;}

        public ICollection<InsumoProveedor> InsumoProveedores {get; set;}
    }
