using Estacionamiento.Entities;
using Estacionamiento.Entities.IRepositories;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Estacionamiento.Persistence.Repositories
{
    public class TipoArticuloRepository : Repository<TipoArticulo>, ITipoArticuloRepository
    {
        private readonly EstacionamientoBDContext _Context;

        public TipoArticuloRepository(EstacionamientoBDContext context)
        {
            _Context = context;
        }


        private TipoArticuloRepository()
        {

        }
    }
}
