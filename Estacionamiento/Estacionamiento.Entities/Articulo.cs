using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Estacionamiento.Entities
{
    public class Articulo
    {
        public int ArticuloID{ get; set; }

        public int TipoArticuloID { get; set; }
        public TipoArticulo TipoArticulo { get; set; }

        public int Cantidad { get; set; }

 

        

        public Articulo()
        {
            TipoArticulo = new TipoArticulo();
        }



    }
}
