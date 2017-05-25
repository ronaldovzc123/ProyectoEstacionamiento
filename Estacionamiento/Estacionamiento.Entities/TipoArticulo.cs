using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Estacionamiento.Entities
{
    public class TipoArticulo
    {
        public int TipoArticuloID { get; set; }
        public string DescripcionArticulo { get; set; }
        public double Precio{ get; set; }
    }
}
