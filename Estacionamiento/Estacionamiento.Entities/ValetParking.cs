using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Estacionamiento.Entities
{
    public class ValetParking
    {
        public int ValetParkingID { get; set; }
        public string UsoEstacionamientoID { get; set; }
        public UsoEstacionamiento UsoEstacionamiento { get; set; }
        
        public string ParkeoID { get; set; }
        public Parkeo Parkeo { get; set; } 
        
        public string Estado { get; set; }
    }
}
