using System;
using System.Collections.Generic;
using System.Linq;
using System.Linq.Expressions;
using System.Threading.Tasks;
using Core.entities;
using Core.Interfaces;
using Infrastructure.Data;
using Microsoft.EntityFrameworkCore;

namespace Infrastructure.Repositories
{
    public class GenericRepository<T> : IGenericRepository<T> where T : BaseEntity
    {
        private readonly RopaContext _context;

        public GenericRepository(RopaContext context)
        {
            _context = context;
        }

        public void Add(T entity)
        {
            _context.Set<T>().Add(entity);
        }

        public void AddRange(IEnumerable<T> entities)
        {
            _context.Set<T>().AddRange(entities);
        }

        public virtual IEnumerable<T> Find(Expression<Func<T, bool>> expression)
        {
            return _context.Set<T>().Where(expression);
       }

        public virtual async Task<IEnumerable<T>> GetAllAsync()
        {
             return await _context.Set<T>().ToListAsync();
        }

        public virtual async Task<T> GetByIdAsyn(int id)
        {
            return await _context.Set<T>().FindAsync(id);
        }

        public void Remove(T entity)
        {
         _context.Set<T>().Remove(entity);
        }

        public void RemoveRange(IEnumerable<T> entities)
        {
             _context.Set<T>().RemoveRange(entities);
        }

        public void Update(T entity)
        {
             _context.Set<T>().Update(entity);
        }
    public virtual async Task<(int totalRegistros, IEnumerable<T> Registros)>GetallAsync(
        int pageIndex,
        int pageSize,
        string _search
    )
    {
        var totalRegistros= await _context.Set<T>().CountAsync();
        var Registros= await _context.Set<T>().Skip((pageIndex=1)*pageSize).Take(pageSize).ToListAsync();
        return (totalRegistros, Registros);

    }
    }

}