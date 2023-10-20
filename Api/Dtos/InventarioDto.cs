using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace Api.Dtos
{
    public class InventarioDto
    {
        public int Id { get; set; }
        public string ? CodInv {get; set;}
        public int IdPrenda { get; set; } 
        public double ValorVtaCop { get; set; }
        public double ValorVtaUsd { get; set; }

         
  
    }
}