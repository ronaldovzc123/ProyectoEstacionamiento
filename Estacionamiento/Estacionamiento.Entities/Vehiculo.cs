using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Estacionamiento.Entities
{
    public class Vehiculo
    {
        public int VehiculoID { get; set; }
        public string Placa { get; set; }
        
        public string TipoVehiculoID { get; set; }
        public TipoVehiculo TipoVehiculo { get; set; }

        public Vehiculo()
        {

            TipoVehiculo = new TipoVehiculo();

        }
    }
}
