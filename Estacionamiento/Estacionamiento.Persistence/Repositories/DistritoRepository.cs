using Estacionamiento.Entities;
using Estacionamiento.Entities.IRepositories;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Estacionamiento.Persistence.Repositories
{
    public class DistritoRepository : Repository<Distrito>, IDistritoRepository
    {
        private readonly EstacionamientoBDContext _Context;

        public DistritoRepository(EstacionamientoBDContext context)
        {
            _Context = context;
        }

        private DistritoRepository()
        {

        }

        public Distrito Get(int? id)
        {
            throw new NotImplementedException();
        }
    }
}
