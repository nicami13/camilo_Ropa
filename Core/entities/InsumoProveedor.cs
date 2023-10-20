using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace Core.entities
{
    public class InsumoProveedor:BaseEntity
    {
        public int IdInsumo { get; set; }
        public Insumo?  Insumo { get; set; }
        public int IdProovedor { get; set; }
        public Proveedor? Proveedor { get; set; }
    }
}