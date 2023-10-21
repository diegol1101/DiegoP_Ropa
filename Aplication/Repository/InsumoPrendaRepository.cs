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
    public class InsumoPrendaRepository: IInsumoPrenda
    {
        private readonly ApiDbContext _context;
        public InsumoPrendaRepository(ApiDbContext context){
            _context = context;
        }
        public virtual void Add(InsumoPrenda entity)
    {
        _context.Set<InsumoPrenda>().Add(entity);
    }
    public virtual void AddRange(IEnumerable<InsumoPrenda> entities)
    {
        _context.Set<InsumoPrenda>().AddRange(entities);
    }
    public virtual IEnumerable<InsumoPrenda> Find(Expression<Func<InsumoPrenda, bool>> expression)
    {
        return _context.Set<InsumoPrenda>().Where(expression);
    }
    public virtual async Task<IEnumerable<InsumoPrenda>> GetAllAsync()
    {
        return await _context.Set<InsumoPrenda>().ToListAsync();
    }
    public virtual async Task<(int totalRegisters, IEnumerable<InsumoPrenda> registers)> GetAllAsync (int pageIndex, int pageSize, string Search){
            var totalRegisters = await _context.Set<InsumoPrenda>().CountAsync();
            var registers = await _context.Set<InsumoPrenda>().Skip((pageIndex -1) * pageSize).Take(pageSize).ToListAsync();
            return (totalRegisters, registers);
        }
    public virtual async Task<InsumoPrenda> GetByIdAsync(int id)
    {
        return await _context.Set<InsumoPrenda>().FindAsync(id);
    }
    public virtual async Task<InsumoPrenda> GetByIdAsync(string id)
    {
       return await _context.Set<InsumoPrenda>().FindAsync(id);
    }
    public virtual void Remove(InsumoPrenda entity)
    {
        _context.Set<InsumoPrenda>().Remove(entity);
    }
    public virtual void RemoveRange(IEnumerable<InsumoPrenda> entities)
    {
        _context.Set<InsumoPrenda>().RemoveRange(entities);
    }
    public virtual void Update(InsumoPrenda entity)
    {
        _context.Set<InsumoPrenda>()
            .Update(entity);
    }
        
    }
    
}