using Estacionamiento.Entities;
using Estacionamiento.Entities.IRepositories;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Estacionamiento.Persistence.Repositories
{
    public class VehiculoRepository : Repository<Vehiculo>, IVehiculoRepository
    {
        private readonly EstacionamientoBDContext _Context;

        public VehiculoRepository(EstacionamientoBDContext context)
        {
            _Context = context;
        }

        private VehiculoRepository()
        {

        }
    }
}
