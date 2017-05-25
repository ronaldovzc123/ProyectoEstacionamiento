using Estacionamiento.Entities;
using System;
using System.Collections.Generic;
using System.Data.Entity.ModelConfiguration;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Estacionamiento.Persistence.Entities.Configuration
{
    public class ValetParkingConfiguration : EntityTypeConfiguration<ValetParking>
    {
        public ValetParkingConfiguration()
        {
            ToTable("ValetParking");
            HasKey(cl => cl.ValetParkingID);
        }
    }
}
