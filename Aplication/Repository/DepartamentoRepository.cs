
using Domain.Interfaces;
using Dominio.Entities;
using Persistency;

namespace Aplication.Repository
{
    public class DepartamentoRepository : GenericRepository<Departamento>, IDepartamento
    {
        protected readonly ApiDbContext _context;
        
        public DepartamentoRepository(ApiDbContext context) : base (context)
        {
            _context = context;
        }
    
        
    }
    
}