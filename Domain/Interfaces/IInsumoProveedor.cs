using System;
using System.Collections.Generic;
using System.Linq;
using System.Linq.Expressions;
using System.Threading.Tasks;
using Dominio.Entities;

namespace Domain.Interfaces
{
    public interface IInsumoProveedor
    {
        Task<IEnumerable<InsumoProveedor>> GetAllAsync();
        Task<(int totalRegisters, IEnumerable<InsumoProveedor> registers)> GetAllAsync (int pageIndex, int pageSize, string Search);
        IEnumerable<InsumoProveedor> Find(Expression<Func<InsumoProveedor, bool>> expression);
        void Add(InsumoProveedor entity);
        void AddRange(IEnumerable<InsumoProveedor> entities);
        void Remove(InsumoProveedor entity);
        void RemoveRange(IEnumerable<InsumoProveedor> entities);
        void Update(InsumoProveedor entity);
    }
}