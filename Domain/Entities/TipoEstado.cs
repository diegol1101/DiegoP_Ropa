using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Domain.Entities;

namespace Dominio.Entities;

    public class TipoEstado:BaseEntity
    {
        public string Descripcion {get; set;}

        /*llaves*/
        public ICollection<Estado> Estados {get; set;}
    }
