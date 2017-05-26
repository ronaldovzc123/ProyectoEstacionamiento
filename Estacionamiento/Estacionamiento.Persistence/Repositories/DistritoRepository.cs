using Estacionamiento.Entities;
using Estacionamiento.Entities.IRepositories;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Estacionamiento.Persistence.Repositories
{
    public class DistritoRepository : Repository<Distrito>, IDistritoRepository
    {
		public DistritoRepository(EstacionamientoBDContext context):base(context)
		{
		}
	}
}
