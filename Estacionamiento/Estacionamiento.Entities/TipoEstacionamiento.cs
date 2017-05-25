using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Estacionamiento.Entities
{
    public class TipoEstacionamiento
    {
        public int TipoEstacionamientoID { get; set; }
        public string ParkeoID { get; set; }
        public Parkeo Parkeo { get; set; }
        public string Cantidad { get; set; }
    }
}
