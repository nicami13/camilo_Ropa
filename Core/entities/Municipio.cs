using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace Core.entities
{
    public class Municipio:BaseEntity
    {
        public int IdDepartamento { get; set; }
        public Departamento ? Departamento {get; set;} 
        public string ? Nombre {get; set;} 

        public ICollection<Cliente> Clientes {get; set;}

        public ICollection<Empleado> Empleados {get; set;}

        public ICollection<Proveedor>   Proveedores  {get; set;}

    }
}