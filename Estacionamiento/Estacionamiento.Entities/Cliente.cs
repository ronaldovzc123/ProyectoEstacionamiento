using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Estacionamiento.Entities
{
    public class Cliente
    {

        public int ClienteID { get; set; }

        public string   DNI { get; set; }

        public int TipoClienteID { get; set; }
        public TipoCliente TipoCliente { get; set; }

        public string  Nombre{ get; set; }
        public string Apellido { get; set; }

        public int BeneficioID { get; set; }
        public Beneficio Beneficio { get; set; }

        public Cliente()
        {
            Beneficio = new Beneficio();
            Reclamos = new List<GestionReclamo>();
            
        }



        public List<GestionReclamo> Reclamos { get; set; }
    }
}
