using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace Core.entities
{
    public class InsumoPrenda:BaseEntity
    {
        public int IdInsumo { get; set; }
        public Insumo?  Insumo { get; set; }
        public int IdPrenda { get; set; }
        public Prenda? Prenda { get; set; }
        public int Cantidad { get; set; }
        
    }
}