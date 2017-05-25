using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Estacionamiento.Entities
{
    public class Publicidad
    {
        public int PublicidadID { get; set; }
        
        public string ParkeoID { get; set; }
        public Parkeo Parkeo { get; set; }
        
        public int ClienteID { get; set; }
        public Cliente Cliente { get; set; }

        public int Cantidad { get; set; }
        public DateTime Fecha { get; set; } 
    }
}
