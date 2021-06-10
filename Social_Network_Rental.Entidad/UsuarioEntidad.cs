using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using MongoDB.Bson;
using MongoDB.Bson.Serialization.Attributes;

namespace Social_Network_Rental.Entidad
{
    public class UsuarioEntidad
    {
        [BsonId]
        [BsonRepresentation(BsonType.ObjectId)]
        public  int idUsuario { get; set; }

        [BsonElement("usuario")]
        public  string usuario { get; set; }

        [BsonElement("clave")]
        public  string clave { get; set; }

        [BsonElement("nivel")]
        public  string nivel { get; set; }

        [BsonElement("estado")]
        public  string estado { get; set; }

    }
}
