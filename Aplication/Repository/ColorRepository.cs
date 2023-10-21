
using Domain.Interfaces;
using Dominio.Entities;
using Persistency;

namespace Aplication.Repository
{
    public class ColorRepository : GenericRepository<Color>, IColor
    {
        protected readonly ApiDbContext _context;
        
        public ColorRepository(ApiDbContext context) : base (context)
        {
            _context = context;
        }
    
        
    }}