using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace Api.Dtos
{
    public class ProveedorDto
    {
        public int Id { get; set; }
        public string ? NItProveedor {get; set;} 
        public string ? Nombre {get; set;} 
        public int IdTipoPersona { get; set; }

  
        public int IdMunicipio { get; set; }


        
    }
}