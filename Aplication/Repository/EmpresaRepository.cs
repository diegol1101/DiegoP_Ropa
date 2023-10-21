using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Domain.Interfaces;
using Dominio.Entities;
using Persistency;

namespace Aplication.Repository
{
    public class EmpresaRepository : GenericRepository<Empresa>, IEmpresa
    {
        protected readonly ApiDbContext _context;
        
        public EmpresaRepository(ApiDbContext context) : base (context)
        {
            _context = context;
        }
    
        
    }
}