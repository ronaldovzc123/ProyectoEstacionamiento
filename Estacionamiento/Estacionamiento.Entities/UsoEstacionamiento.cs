using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Estacionamiento.Entities
{
    public class UsoEstacionamiento
    {
        public int UsoEstacionamientoID { get; set; }
        
        public int SedeEstacionamientoID { get; set; }
        public SedeEstacionamiento SedeEstacionamiento { get; set; }

        public string DNI { get; set; }
        public  DateTime  Fecha { get; set; }
        public DateTime Hora { get; set; }
        
    }
}
