using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace API.Dtos
{
    public class ClienteDto
    {
        public string IdCliente { get; set; }
        public string Nombre {get; set;}
        public DateTime FechaRegistro {get; set; }
    }
}