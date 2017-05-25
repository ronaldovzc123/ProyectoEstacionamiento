using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Estacionamiento.Entities
{
    public class Evento
    {
        public int EventoID { get; set; }

        public int TipoEventoID { get; set; }
        public TipoEvento TipoEvento { get; set; }

        public int ClienteID { get; set; }
        public Cliente Cliente { get; set; }

        public int SedeID { get; set; }
        public SedeEstacionamiento SedeEstacionamiento { get; set; }

        public DateTime Fecha { get; set; }


        public Evento(){

            TipoEvento = new TipoEvento();
        }
    }
}
