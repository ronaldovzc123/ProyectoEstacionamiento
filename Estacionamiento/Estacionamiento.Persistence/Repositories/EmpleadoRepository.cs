using Estacionamiento.Entities;
using Estacionamiento.Entities.IRepositories;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Estacionamiento.Persistence.Repositories
{
    public class EmpleadoRepository : Repository<Empleado>, IEmpleadoRepository
    {
        private readonly EstacionamientoBDContext _Context;

        public EmpleadoRepository(EstacionamientoBDContext context)
        {
            _Context = context;
        }

        private EmpleadoRepository()
        {

        }
    }
}
