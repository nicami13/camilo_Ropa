using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace Core.entities
{
    public class Genero:BaseEntity
    {
        public string ? Descripcion {get; set;}

        public ICollection<Prenda> Prendasc {get; set;} 
        
    }
}