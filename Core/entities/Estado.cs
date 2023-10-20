using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace Core.entities
{
    public class Estado:BaseEntity
    {
        public string ? Descripcion {get; set;} 
        public int IdTipoEstado { get; set; }
        public TipoEstado TipoEstado { get; set; }

        public ICollection<DatalleOrden> DetalleOrdenes {get; set;}

        public ICollection<Orden> Ordenes {get; set;}
        public ICollection<Prenda> Prendas {get; set;}
    }
}