using System;
using System.Collections.Generic;
using System.Linq;
using System.Linq.Expressions;
using System.Threading.Tasks;
using Dominio.Entities;

namespace Domain.Interfaces
{
    public interface IInventarioTalla
    {
        Task<IEnumerable<InventarioTalla>> GetAllAsync();
        Task<(int totalRegisters, IEnumerable<InventarioTalla> registers)> GetAllAsync (int pageIndex, int pageSize, string Search);
        IEnumerable<InventarioTalla> Find(Expression<Func<InventarioTalla, bool>> expression);
        void Add(InventarioTalla entity);
        void AddRange(IEnumerable<InventarioTalla> entities);
        void Remove(InventarioTalla entity);
        void RemoveRange(IEnumerable<InventarioTalla> entities);
        void Update(InventarioTalla entity);
    }
}