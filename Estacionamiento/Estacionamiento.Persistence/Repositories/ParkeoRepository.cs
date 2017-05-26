using Estacionamiento.Entities;
using Estacionamiento.Entities.IRepositories;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Estacionamiento.Persistence.Repositories
{
    public class ParkeoRepository : Repository<Parkeo>, IParkeoRepository
    {
		public ParkeoRepository(EstacionamientoBDContext context):base(context)
		{
		}
	}
}
