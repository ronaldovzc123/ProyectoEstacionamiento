using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Estacionamiento.Entities
{
    public class TipoBeneficio
    {
        public int TipoBeneficioID { get; set; }
        public string DescripcionBeneficio { get; set; }
        public DateTimeOffset FechaRegistro { get; set; }
    }
}
