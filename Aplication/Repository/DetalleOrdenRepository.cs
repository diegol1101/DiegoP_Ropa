

using Domain.Interfaces;
using Dominio.Entities;
using Persistency;

namespace Aplication.Repository
{
    public class DetalleOrdenRepository : GenericRepository<DetalleOrden>, IDetalleOrden
    {
        protected readonly ApiDbContext _context;
        
        public DetalleOrdenRepository(ApiDbContext context) : base (context)
        {
            _context = context;
        }
    
        
    }
}