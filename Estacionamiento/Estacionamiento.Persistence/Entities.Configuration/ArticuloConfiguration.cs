using Estacionamiento.Entities;
using System;
using System.Collections.Generic;
using System.Data.Entity.ModelConfiguration;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Estacionamiento.Persistence.Entities.Configuration
{
    public class ArticuloConfiguration : EntityTypeConfiguration<Articulo>
    {
        public ArticuloConfiguration()
        {
            ToTable("Articulo");
            HasKey(cl => cl.ArticuloID);

             //ida hasmany * , hasrequired 1, hasoptional 0..1
           //regreso withMany, wihtREquiered, withOptional

            //relacionesConfiguracion
                                                                                      
            //HasMany(a=> a.Courses)  autor --- curso
            //WhitReqired (c=> c.Courses) ----- regreso de curso a autor  
                
           


        }
    }
}
