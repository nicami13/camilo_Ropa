using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace Api.Dtos
{
    public class ClienteDto
    {
        public int Id { get; set; }
        public int IdCLiente { get; set; }
        public int IdTipoPersona{ get; set; }
        
        public int IdMunicipio{ get; set; }
        
        public DateTime Fecharegistro { get; set; }
    }
}