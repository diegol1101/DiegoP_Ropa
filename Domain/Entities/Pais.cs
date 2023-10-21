using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Domain.Entities;

namespace Dominio.Entities;

    public class Pais:BaseEntity
    {
        public string Nombre { get; set; }

        /*llaves*/
        public ICollection<Departamento> Departamentos {get; set;}
    }
