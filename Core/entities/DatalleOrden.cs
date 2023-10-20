using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace Core.entities
{
    public class DatalleOrden:BaseEntity
    {
        public int IdPrenda { get; set; }
        public Prenda? Prenda { get; set; }
        public int IdColor { get; set; }
        public Color?  Color { get; set; }
        public int IdOrden { get; set; }
        public Orden ? Orden { get; set; }
        public int IdEstado { get; set; }
        public Estado?  Estado { get; set; }
        public int CantidadProducir { get; set; }
        public int CantidadProducida { get; set; }



        
    }
}