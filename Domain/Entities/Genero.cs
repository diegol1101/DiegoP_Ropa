using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Domain.Entities;

namespace Dominio.Entities;

    public class Genero:BaseEntity
    {
        public string Descripcion {get; set;}

        /*llaves*/
        public ICollection<Prenda> Prendas {get; set;}
    }
