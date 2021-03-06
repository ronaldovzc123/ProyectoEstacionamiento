﻿using Estacionamiento.Entities;
using System;
using System.Collections.Generic;
using System.Data.Entity.ModelConfiguration;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Estacionamiento.Persistence.Entities.Configuration
{
	public  class TipoClienteConfiguration : EntityTypeConfiguration<TipoCliente>
	{
		public TipoClienteConfiguration()
		{
			ToTable("TipoCliente");
			HasKey(tc => tc.TipoClienteId);

			HasMany(tc => tc.Clientes)
				.WithRequired(c => c.TipoCliente)
				.HasForeignKey(c => c.TipoClienteID);
		}
	}
}
