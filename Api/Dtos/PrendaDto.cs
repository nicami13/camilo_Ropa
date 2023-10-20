using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace Api.Dtos
{
    public class PrendaDto
    {
        public int Id { get; set; }
        public string ? IdProducto {get; set;} 
        public string ? Nombre {get; set;} 
        public double ValorUnitCop { get; set; }
        public double ValorUnitUsd { get; set; }
        public int IdEstado { get; set; }

        public int IdTipoProteccion { get; set; }

        public int IdGenero { get; set; }
    

    }
}