using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Estacionamiento.Entities
{
    public class Boleta
    {
        public int BoletaID { get; set; }

        public int ClienteID { get; set; }
        public Cliente Cliente { get; set; }
       
        public int  ArticuloID { get; set; }
        public Articulo Articulo { get; set; }

        public int  TipoPagoID{ get; set; }
        public TipoPago TipoPago { get; set; }

        public double  Total { get; set; }




        public Boleta()
            {
            
                Cliente = new Cliente();
                Articulo = new Articulo();
                TipoPago = new TipoPago();
            }
    }
}
