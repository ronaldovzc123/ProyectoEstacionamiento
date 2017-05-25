using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Estacionamiento.Entities
{
    public class Empleado
    {
        public int  EmpleadoID { get; set; }
        public string Nombre{ get; set; }
        public string Apellido { get; set; }

        public string TipoEmpleadoID { get; set; }
        public TipoEmpleado TipoEmpleado { get; set; }

        public string TipoEstacionamientoID { get; set; }
        public TipoEstacionamiento TipoEstacionamiento { get; set; }

        public Empleado(){
            TipoEmpleado = new TipoEmpleado();
        }
    }
}
