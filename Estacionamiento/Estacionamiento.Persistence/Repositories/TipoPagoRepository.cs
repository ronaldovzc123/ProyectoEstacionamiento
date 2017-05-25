using Estacionamiento.Entities;
using Estacionamiento.Entities.IRepositories;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Estacionamiento.Persistence.Repositories
{
    public class TipoPagoRepository : Repository<TipoPago>, ITipoPagoRepository
    {
        private readonly EstacionamientoBDContext _Context;

        public TipoPagoRepository(EstacionamientoBDContext context)
        {
            _Context = context;
        }

        private TipoPagoRepository()
        {

        }
    }
}
