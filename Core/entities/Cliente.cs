using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace Core.entities
{
    public class Cliente:BaseEntity
    {
        public int IdCLiente { get; set; }
        public string ? Nombre {get; set;} 
        public int IdTipoPersona{ get; set; }
        public TipoPersona TipoPersona { get; set; }
        public int IdMunicipio{ get; set; }
        public Municipio Municipio { get; set; }
        public DateTime Fecharegistro { get; set; }

        public ICollection<Orden> Ordenes {get; set;}

    }
}