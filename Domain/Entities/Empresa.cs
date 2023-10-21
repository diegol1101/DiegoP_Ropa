using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Domain.Entities;

namespace Dominio.Entities;

    public class Empresa:BaseEntity
    {
        public string Nit {get; set;}
        public string RazonSocial {get; set;}
        public string RepresentanteLegal {get; set;}
        public DateTime FechaCreacion {get; set;}

        /*llaves*/
        public int MunicipioIdFk {get; set;}
        public Municipio Municipio {get; set;}
    }
