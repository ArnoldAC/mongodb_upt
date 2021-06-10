using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using MongoDB.Bson;
using MongoDB.Bson.Serialization.Attributes;

namespace Social_Network_Rental.Entidad
{
    public class Publico_IEntidad
    {
        [BsonId]
        [BsonRepresentation(BsonType.ObjectId)]
        public int idusuario { get; set; }
        [BsonElement("idinmueble")]
        public int idinmueble { get; set; }
        [BsonElement("direccion")]
        public string Direccion { get; set; }
        [BsonElement("numeroh")]
        public string NumeroH { get; set; }
        [BsonElement("ciudad")]
        public string Ciudad { get; set; }
        [BsonElement("descripcion")]
        public string Descripcion { get; set; }
        [BsonElement("estado")]
        public string Estado { get; set; }
        [BsonElement("precio")]
        public string Precio { get; set; }
        [BsonElement("imagen")]
        public byte[] Imagen { get; set; }
    }
}
