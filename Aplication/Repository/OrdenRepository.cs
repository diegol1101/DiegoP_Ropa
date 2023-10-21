using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Domain.Interfaces;
using Dominio.Entities;
using Persistency;

namespace Aplication.Repository
{
    public class OrdenRepository: GenericRepository<Orden>, IOrden
    {
        protected readonly ApiDbContext _context;
        
        public OrdenRepository(ApiDbContext context) : base (context)
        {
            _context = context;
        }
    
        
    }
    
}