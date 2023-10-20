using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Core.entities;
using Core.Interfaces;
using Infrastructure.Data;

namespace Infrastructure.Repositories
{
    public class DepartamentoRepository : GenericRepository<Departamento>, IDepartamento
    {
        private readonly RopaContext _context;

        public DepartamentoRepository(RopaContext context) : base(context)
        {
            _context = context;
        }
    }
}