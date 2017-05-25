using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Estacionamiento.Entities
{
    public class GestionReclamo
    {
        public int GestionReclamoID { get; set; }

        public int ClienteID { get; set; }
        public Cliente Cliente { get; set; }

        public string Observacion { get; set; }
    }
}
