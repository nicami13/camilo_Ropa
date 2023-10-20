using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace Core.entities
{
    public class Colores:BaseEntity
    {
        public string ? Descripcion {get; set;} 

        public ICollection<DatalleOrden> DatalleOrdenes {get; set;}
        
    }
}