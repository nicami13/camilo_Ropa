using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace Core.entities
{
    public class Departamento:BaseEntity
    {

        public int IdPais { get; set; }
        public Pais ? Pais {get; set;} 

        public string ? Nombre {get; set;} 
        public ICollection<Municipio> Municipios {get; set;}

        
    }
}