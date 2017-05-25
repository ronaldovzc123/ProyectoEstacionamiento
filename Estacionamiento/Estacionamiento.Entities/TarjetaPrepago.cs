using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Estacionamiento.Entities
{
    public class TarjetaPrepago
    {
        public int TarjetaPrepagoID { get; set; }
        
        public string ClienteID { get; set; }
        public Cliente Cliente { get; set; }

        public string DescripcionTarjeta { get; set; }

       
    }
}
