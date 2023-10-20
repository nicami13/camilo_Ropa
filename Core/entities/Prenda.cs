using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace Core.entities
{
    public class Prenda:BaseEntity
    {
        public string ? IdProducto {get; set;} 
        public string ? Nombre {get; set;} 
        public double ValorUnitCop { get; set; }
        public double ValorUnitUsd { get; set; }
        public int IdEstado { get; set; }
        public Estado ? Estado {get; set;} 
        public int IdTipoProteccion { get; set; }
        public TipoProteccion ? TipoProteccion { get; set; }
        public int IdGenero { get; set; }
        public Genero ? Genero{ get; set; }

        public ICollection<DatalleOrden> DatalleOrdenes {get; set;}
        public ICollection<Inventario> Inventarios {get; set;}
        public ICollection<InsumoPrenda> InsumoPrendas {get; set;}

    }
}