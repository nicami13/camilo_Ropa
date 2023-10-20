using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace Core.entities
{
    public class Cargo:BaseEntity
    {
        public string ? Descripcion {get; set;} 
        public double SueldoBase { get; set; }
        public ICollection<Empleado> Empleados {get; set;}
        
    }
}