using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace API.Dtos
{
    public class InventarioDto
    {
        public string CodInv {get; set;}
        public double ValorVtaCop {get; set;}
        public double ValorVtaUsd {get; set;}
    }
}