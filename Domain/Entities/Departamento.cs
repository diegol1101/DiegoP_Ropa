using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Domain.Entities;

namespace Dominio.Entities;

    public class Departamento:BaseEntity
    {
        public string Nombre {get; set;}

        /*llaves*/

        public int PaisFk {get; set;}
        public Pais Pais {get; set;}

        public ICollection<Municipio> Municipios {get; set;}
    }
