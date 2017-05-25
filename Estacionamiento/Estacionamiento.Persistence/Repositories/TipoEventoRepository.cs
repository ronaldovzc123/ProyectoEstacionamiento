using Estacionamiento.Entities;
using Estacionamiento.Entities.IRepositories;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Estacionamiento.Persistence.Repositories
{
    public class TipoEventoRepository : Repository<TipoEvento>, ITipoEventoRepository
    {
        private readonly EstacionamientoBDContext _Context;

        public TipoEventoRepository(EstacionamientoBDContext context)
        {
            _Context = context;
        }

        private TipoEventoRepository()
        {

        }
    }
}
