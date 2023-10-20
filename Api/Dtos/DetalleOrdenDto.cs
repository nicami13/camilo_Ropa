using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace Api.Dtos
{
    public class DetalleOrdenDto
    {
        public int Id { get; set; }
        public int IdPrenda { get; set; }
        
        public int IdColor { get; set; }
        
        public int IdOrden { get; set; }
        
        public int IdEstado { get; set; }
        public int CantidadProducir { get; set; }
        public int CantidadProducida { get; set; }
    }
}