using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace Core.entities
{
    public class Proveedor:BaseEntity
    {
        public string ? NItProveedor {get; set;} 
        public string ? Nombre {get; set;} 
        public int IdTipoPersona { get; set; }

        public TipoPersona?  TipoPersona { get; set; }
        public int IdMunicipio { get; set; }

        public Municipio Municipio { get; set; }

        public ICollection<InsumoProveedor> InsumoProveedores {get; set;}
        
    }
}