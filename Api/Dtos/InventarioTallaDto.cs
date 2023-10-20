using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace Api.Dtos
{
    public class InventarioTallaDto
    {
        public int IdInventario { get; set; }

        public int IdTalla { get; set; }

        public int Cantidad { get; set; }
    }
}