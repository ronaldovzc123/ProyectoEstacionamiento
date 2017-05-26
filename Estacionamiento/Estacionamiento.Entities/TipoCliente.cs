using System;
using System.Collections.Generic;
using System.Collections.ObjectModel;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Estacionamiento.Entities
{
	public class TipoCliente
	{
		public int TipoClienteId { get; set; }
		public string Descripcion { get; set; }

		public ICollection<Cliente> Clientes { get; set; }

		public TipoCliente()
		{
			Clientes = new Collection<Cliente>();
		}
	}
}
