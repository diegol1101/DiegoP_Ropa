using Domain.Entities;

namespace Dominio.Entities;

    public class Color:BaseEntity
    {
        public string Descripcion {get; set;}

        /*llaves*/
        public ICollection<DetalleOrden> DetalleOrdenes { get; set;}
    }
