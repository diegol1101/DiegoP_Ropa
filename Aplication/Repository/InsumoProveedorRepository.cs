using System;
using System.Collections.Generic;
using System.Linq;
using System.Linq.Expressions;
using System.Threading.Tasks;
using Domain.Interfaces;
using Dominio.Entities;
using Microsoft.EntityFrameworkCore;
using Persistency;

namespace Aplication.Repository
{
    public class InsumoProveedorRepository :IInsumoProveedor
    {
        private readonly ApiDbContext _context;
        public InsumoProveedorRepository(ApiDbContext context){
            _context = context;
        }
        public virtual void Add(InsumoProveedor entity)
    {
        _context.Set<InsumoProveedor>().Add(entity);
    }
    public virtual void AddRange(IEnumerable<InsumoProveedor> entities)
    {
        _context.Set<InsumoProveedor>().AddRange(entities);
    }
    public virtual IEnumerable<InsumoProveedor> Find(Expression<Func<InsumoProveedor, bool>> expression)
    {
        return _context.Set<InsumoProveedor>().Where(expression);
    }
    public virtual async Task<IEnumerable<InsumoProveedor>> GetAllAsync()
    {
        return await _context.Set<InsumoProveedor>().ToListAsync();
    }
    public virtual async Task<(int totalRegisters, IEnumerable<InsumoProveedor> registers)> GetAllAsync (int pageIndex, int pageSize, string Search){
            var totalRegisters = await _context.Set<InsumoProveedor>().CountAsync();
            var registers = await _context.Set<InsumoProveedor>().Skip((pageIndex -1) * pageSize).Take(pageSize).ToListAsync();
            return (totalRegisters, registers);
        }
    public virtual async Task<InsumoProveedor> GetByIdAsync(int id)
    {
        return await _context.Set<InsumoProveedor>().FindAsync(id);
    }
    public virtual async Task<InsumoProveedor> GetByIdAsync(string id)
    {
       return await _context.Set<InsumoProveedor>().FindAsync(id);
    }
    public virtual void Remove(InsumoProveedor entity)
    {
        _context.Set<InsumoProveedor>().Remove(entity);
    }
    public virtual void RemoveRange(IEnumerable<InsumoProveedor> entities)
    {
        _context.Set<InsumoProveedor>().RemoveRange(entities);
    }
    public virtual void Update(InsumoProveedor entity)
    {
        _context.Set<InsumoProveedor>()
            .Update(entity);
    }
    }
    
}