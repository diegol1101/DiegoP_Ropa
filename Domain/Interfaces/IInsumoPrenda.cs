using System;
using System.Collections.Generic;
using System.Linq;
using System.Linq.Expressions;
using System.Threading.Tasks;
using Dominio.Entities;

namespace Domain.Interfaces
{
    public interface IInsumoPrenda
    {
        
        Task<IEnumerable<InsumoPrenda>> GetAllAsync();
        Task<(int totalRegisters, IEnumerable<InsumoPrenda> registers)> GetAllAsync (int pageIndex, int pageSize, string Search);
        IEnumerable<InsumoPrenda> Find(Expression<Func<InsumoPrenda, bool>> expression);
        void Add(InsumoPrenda entity);
        void AddRange(IEnumerable<InsumoPrenda> entities);
        void Remove(InsumoPrenda entity);
        void RemoveRange(IEnumerable<InsumoPrenda> entities);
        void Update(InsumoPrenda entity);
    }
}