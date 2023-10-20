using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace Core.entities
{
    public class Orden
    {
        public int IdOrden { get; set; }
        public DatalleOrden ? DetalleOrden { get; set; }

        public int IdEmpleado { get; set; }
        public Empleado ? Empleado { get; set; }
        public int IdCliente { get; set; }
        public Cliente ? Cliente { get; set; }
        public int IdEstado { get; set; }
        public Estado ?  Estado{ get; set; }

        public ICollection<DatalleOrden> DatalleOrdenes {get; set;}
    }
}