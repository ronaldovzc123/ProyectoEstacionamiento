using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Estacionamiento.Entities
{
    public class TipoEvento
    {
        public int TipoEventoID { get; set; }
        public string DescripcionEvento { get; set; }
        public DateTimeOffset Fecha { get; set; }
        public DateTime Hora { get; set; }
    }
}
