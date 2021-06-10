using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using MongoDB.Bson;
using MongoDB.Driver;

namespace Social_Network_Rental.Entidad
{
    class Rutina
    {
        public string accion { get; set; }
        public string fecha { get; set; }
        public ObjectId id { get; set; }
        public Rutina() { }
        public Rutina(string accion, string fecha)
        {
            this.accion = accion;
            this.fecha = fecha;
        }
        public Rutina(string accion, string fecha, ObjectId id)
        {
            this.accion = accion;
            this.fecha = fecha;
            this.id = id;
        }

    }
}
