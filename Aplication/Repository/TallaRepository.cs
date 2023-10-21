using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Domain.Interfaces;
using Dominio.Entities;
using Persistency;

namespace Aplication.Repository
{
    public class TallaRepository: GenericRepository<Talla>, ITalla
    {
        protected readonly ApiDbContext _context;
        
        public TallaRepository(ApiDbContext context) : base (context)
        {
            _context = context;
        }
    
    }
    
}