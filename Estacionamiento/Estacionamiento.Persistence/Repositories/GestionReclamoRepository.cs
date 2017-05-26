using Estacionamiento.Entities;
using Estacionamiento.Entities.IRepositories;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Estacionamiento.Persistence.Repositories
{
    public class GestionReclamoRepository : Repository<GestionReclamo>, IGestionReclamoRepository
    {
		public GestionReclamoRepository(EstacionamientoBDContext context):base(context)
		{
		}

	}
}
