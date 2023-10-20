using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace Core.entities
{
    public class Empleado:BaseEntity
    {
        public int IdEmp { get; set; }
        public string ? Nombre {get; set;}
        public DateTime FechaIngreso { get; set; } 
        public int IdMunicipio { get; set; }
        public Municipio ? Municipio { get; set; }
        public int IdCargo { get; set; }
        public Cargo Cargo { get; set; }

        public ICollection<Orden> Ordenes {get; set;}
        

        
    }
}