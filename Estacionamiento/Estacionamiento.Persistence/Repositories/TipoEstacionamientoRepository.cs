using Estacionamiento.Entities;
using Estacionamiento.Entities.IRepositories;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Estacionamiento.Persistence.Repositories
{
	public class TipoEstacionamientoRepository : Repository<TipoEstacionamiento>, ITipoEstacionamientoRepository
	{
		public TipoEstacionamientoRepository(EstacionamientoBDContext context):base(context)
		{
		}
	}
}
