using Estacionamiento.Entities;
using System;
using System.Collections.Generic;
using System.Data.Entity.ModelConfiguration;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Estacionamiento.Persistence.Entities.Configuration
{
    public class ParkeoConfiguration : EntityTypeConfiguration<Parkeo>
    {
        public ParkeoConfiguration()
        {
            ToTable("Parkeo");
            HasKey(cl => cl.ParkeoID);
        }
    }
}
