
using Domain.Entities;

namespace Dominio.Entities;

    public class Cliente:BaseEntity
    {
        public string IdCliente { get; set; }
        public string Nombre {get; set;}
        public DateTime FechaRegistro {get; set; }

        /*llaves*/
        public int MunicipioIdFk {get; set;}
        public Municipio Municipio {get; set;}

        public int TipoPersonaIdFk {get; set;}
        public TipoPersona TipoPersona {get; set;}

        public ICollection<Venta> Ventas {get; set;}
        public ICollection<Orden> Ordenes {get; set;}


    }
