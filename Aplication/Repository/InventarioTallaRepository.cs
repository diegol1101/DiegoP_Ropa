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
    public class InventarioTallaRepository :IInventarioTalla
    {
        private readonly ApiDbContext _context;
        public InventarioTallaRepository(ApiDbContext context){
            _context = context;
        }
        public virtual void Add(InventarioTalla entity)
    {
        _context.Set<InventarioTalla>().Add(entity);
    }

    public virtual void AddRange(IEnumerable<InventarioTalla> entities)
    {
        _context.Set<InventarioTalla>().AddRange(entities);
    }
    public virtual IEnumerable<InventarioTalla> Find(Expression<Func<InventarioTalla, bool>> expression)
    {
        return _context.Set<InventarioTalla>().Where(expression);
    }
    public virtual async Task<IEnumerable<InventarioTalla>> GetAllAsync()
    {
        return await _context.Set<InventarioTalla>().ToListAsync();
    }
    public virtual async Task<(int totalRegisters, IEnumerable<InventarioTalla> registers)> GetAllAsync (int pageIndex, int pageSize, string Search){
            var totalRegisters = await _context.Set<InventarioTalla>().CountAsync();
            var registers = await _context.Set<InventarioTalla>().Skip((pageIndex -1) * pageSize).Take(pageSize).ToListAsync();
            return (totalRegisters, registers);
        }
    public virtual async Task<InventarioTalla> GetByIdAsync(int id)
    {
        return await _context.Set<InventarioTalla>().FindAsync(id);
    }
    public virtual async Task<InventarioTalla> GetByIdAsync(string id)
    {
       return await _context.Set<InventarioTalla>().FindAsync(id);
    }
    public virtual void Remove(InventarioTalla entity)
    {
        _context.Set<InventarioTalla>().Remove(entity);
    }
    public virtual void RemoveRange(IEnumerable<InventarioTalla> entities)
    {
        _context.Set<InventarioTalla>().RemoveRange(entities);
    }
    public virtual void Update(InventarioTalla entity)
    {
        _context.Set<InventarioTalla>()
            .Update(entity);
    }
    }
}