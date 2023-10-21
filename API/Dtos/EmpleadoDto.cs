using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace API.Dtos
{
    public class EmpleadoDto
    {
        public string IdEmpleado { get; set; }
        public string Nombre {get; set;}
        public DateTime FechaIngreso {get; set; }
    }
}