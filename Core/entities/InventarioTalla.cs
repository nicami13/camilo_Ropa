using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace Core.entities
{
    public class InventarioTalla
    {
        public int IdInventario { get; set; }
        public Inventario Inventario { get; set; }
        public int IdTalla { get; set; }
        public Talla Talla { get; set; }
        public int Cantidad { get; set; }
    }
}