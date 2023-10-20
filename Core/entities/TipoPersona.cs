using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace Core.entities
{
    public class TipoPersona:BaseEntity
    {
        public string ? Nombre {get; set;} 
        public ICollection<Proveedor> proveedores {get; set;}
        public ICollection<Cliente> Clientes {get; set;}
        
    }
}