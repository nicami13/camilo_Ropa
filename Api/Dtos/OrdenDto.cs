using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace Api.Dtos
{
    public class OrdenDto
    {
        public int IdOrden { get; set; }
        

        public int IdEmpleado { get; set; }
        
        public int IdCliente { get; set; }

        public int IdEstado { get; set; }

    }
}