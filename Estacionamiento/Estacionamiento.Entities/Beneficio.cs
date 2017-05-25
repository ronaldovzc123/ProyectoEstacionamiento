using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Estacionamiento.Entities
{
    public class Beneficio
    {
        public int BeneficioID { get; set; }

        public int TipoBeneficioID { get; set; }
        public TipoBeneficio TipoBeneficio { get; set; }

        public int  Cantidad { get; set; }

         public Beneficio()
        {
            TipoBeneficio = new TipoBeneficio();
        }

    }
}
