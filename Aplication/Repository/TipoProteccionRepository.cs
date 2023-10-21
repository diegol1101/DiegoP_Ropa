using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Domain.Interfaces;
using Dominio.Entities;
using Persistency;

namespace Aplication.Repository
{
    public class TipoProteccionRepository: GenericRepository<TipoProteccion>, ITipoProteccion
    {
        protected readonly ApiDbContext _context;
        
        public TipoProteccionRepository(ApiDbContext context) : base (context)
        {
            _context = context;
        }
    
        
    }

}