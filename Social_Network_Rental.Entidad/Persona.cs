using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using MongoDB.Bson;
using MongoDB.Bson.Serialization.Attributes;

namespace Social_Network_Rental.Entidad
{
    public class Persona
    {
        [BsonId]
        [BsonRepresentation(BsonType.ObjectId)]
        public int PersonaId { set; get; }
        [BsonElement("dni")]
        public string Dni { set; get; }
        [BsonElement("nombre")]
        public string Nombre { set; get; }
        [BsonElement("apellido")]
        public string Apellido { set; get; }
        [BsonElement("celular")]
        public string Celular { set; get; }
        [BsonElement("email")]
        public string Email { set; get; }
        [BsonElement("direccion")]
        public string Direccion { set; get; }

    }
}
