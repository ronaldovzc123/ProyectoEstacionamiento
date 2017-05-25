using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Estacionamiento.Entities
{
    public class Distrito
    {
        public int  DistritoID { get; set; }

        public int SedeEstacionamientoID { get; set; }
        public SedeEstacionamiento SedeEstacionamiento { get; set; }

        public string NombreDistrito { get; set; }
        public string Direccion { get; set; }

      public Distrito()
        {
            SedeEstacionamiento = new SedeEstacionamiento();
            
        }
      }
}
