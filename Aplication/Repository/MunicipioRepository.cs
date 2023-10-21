using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Domain.Interfaces;
using Dominio.Entities;
using Persistency;

namespace Aplication.Repository
{
    public class MunicipioRepository: GenericRepository<Municipio>, IMunicipio
    {
        protected readonly ApiDbContext _context;
        
        public MunicipioRepository(ApiDbContext context) : base (context)
        {
            _context = context;
        }
    
        
    }
    
}