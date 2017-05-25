using Estacionamiento.Entities;
using System;
using System.Collections.Generic;
using System.Data.Entity.ModelConfiguration;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Estacionamiento.Persistence.Entities.Configuration
{
    public class ClienteConfiguration : EntityTypeConfiguration<Cliente>
    {
        public ClienteConfiguration()
        {
            ToTable("Cliente");
            HasKey(cl => cl.ClienteID);

          

            //ida hasmany * , hasrequired 1, hasoptional 0..1
           //regreso withMany, wihtREquiered, withOptional

            //relacionesConfiguracion
                                                                                      
            //HasMany(a=> a.Courses)  autor --- curso
            //WhitReqired (c=> c.Courses) ----- regreso de curso a autor  


         //   HasMany(cl => cl.Beneficio)
           //   .WithRequired(cl => cl.Cliente);

            //HasRequired(cl=> cl.TarjetaPrepago)

            HasMany(cl => cl.Reclamos)
                .WithRequired( r=> r.Cliente)
                .HasForeignKey( r=> r.ClienteID);


        }

        //private object HasMany(Func<Cliente, ICollection<TTargetEntity>> func)
        //{
        //    throw new NotImplementedException();
        //}

       


       // private object HasMany(Func<Cliente, ICollection<TTargetEntity>> func)
        //{
          //  throw new NotImplementedException();
       // }


    }
}


//private object HasMany(Func<Cliente, ICollection<TTargetEntity>> func)
// {
//   throw new NotImplementedException();
// }