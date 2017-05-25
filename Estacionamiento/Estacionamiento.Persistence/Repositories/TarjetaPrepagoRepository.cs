using Estacionamiento.Entities;
using Estacionamiento.Entities.IRepositories;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Estacionamiento.Persistence.Repositories
{
    public class TarjetaPrepagoRepository : Repository<TarjetaPrepago>, ITarjetaPrepagoRepository
    {
        private readonly EstacionamientoBDContext _Context;

        public TarjetaPrepagoRepository(EstacionamientoBDContext context)
        {
            _Context = context;
        }

        private TarjetaPrepagoRepository()
        {

        }
    }
}
