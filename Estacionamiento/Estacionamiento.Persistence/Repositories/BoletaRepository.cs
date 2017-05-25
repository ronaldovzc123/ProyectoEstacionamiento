using Estacionamiento.Entities;
using Estacionamiento.Entities.IRepositories;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Estacionamiento.Persistence.Repositories
{
    public class BoletaRepository : Repository<Boleta>, IBoletaRepository
    {
        private readonly EstacionamientoBDContext _Context;

        public BoletaRepository(EstacionamientoBDContext context)
        {
            _Context = context;
        }

        private BoletaRepository()
        {

        }
    }
}
