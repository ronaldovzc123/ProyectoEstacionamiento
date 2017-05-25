using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Estacionamiento.Entities
{
    public  class SedeEstacionamiento
    {
        public int SedeEstacionamientoID { get; set; }
        public string NombreSede { get; set; }
        public string Direccion { get; set; }
        public int CantidadLibre { get; set; }
        public string Area { get; set; }
    }
}
