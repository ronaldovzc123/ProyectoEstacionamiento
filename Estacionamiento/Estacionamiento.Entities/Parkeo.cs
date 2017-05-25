using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Estacionamiento.Entities
{
    public class Parkeo
    {
        public int ParkeoID { get; set; }
        public string Estado { get; set; }
        public DateTime Fecha { get; set; } 
        public DateTime Hora { get; set; }
        public double Mora { get; set; }
    }
}
