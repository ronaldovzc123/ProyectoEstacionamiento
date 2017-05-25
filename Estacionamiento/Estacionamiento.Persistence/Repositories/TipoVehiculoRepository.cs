using Estacionamiento.Entities;
using Estacionamiento.Entities.IRepositories;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Estacionamiento.Persistence.Repositories
{
    public class TipoVehiculoRepository : Repository<TipoVehiculo>, ITipoVehiculoRepository
    {
        private readonly EstacionamientoBDContext _Context;

        public TipoVehiculoRepository(EstacionamientoBDContext context)
        {
            _Context = context;
        }

        private TipoVehiculoRepository()
        {

        }
    }
}
