using Estacionamiento.Entities;
using Estacionamiento.Persistence.Entities.Configuration;
using System;
using System.Collections.Generic;
using System.Data.Entity;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Estacionamiento.Persistence
{
    public class EstacionamientoBDContext : DbContext 
    {
        public DbSet<Cliente> Cliente { get; set; }
        public DbSet<Articulo> Articulo { get; set; }
        public DbSet<Beneficio> Beneficio { get; set; }
        public DbSet<Boleta> Boleta { get; set; }
        public DbSet<Distrito> Distrito { get; set; }
        public DbSet<Empleado> Empleado { get; set; }
        public DbSet<Evento> Evento { get; set; }
        public DbSet<GestionReclamo> GestionReclamo { get; set; }
        public DbSet<Parkeo> Parkeo { get; set; }
        public DbSet<Publicidad> Publicidad { get; set; }
        public DbSet<SedeEstacionamiento> SedeEstacionamiento { get; set; }
        public DbSet<TarjetaPrepago> TarjetaPrepago { get; set; }
        public DbSet<TipoArticulo> TipoArticulo { get; set; }
        public DbSet<TipoBeneficio> TipoBeneficio { get; set; }
        public DbSet<TipoCliente> TipoCliente { get; set; }
        public DbSet<TipoEmpleado> TipoEmpleado { get; set; }
        public DbSet<TipoEstacionamiento> TipoEstacionamiento { get; set; }
        public DbSet<TipoEvento> TipoEvento { get; set; }
        public DbSet<TipoPago> TipoPago { get; set; }
        public DbSet<TipoVehiculo> TipoVehiculo { get; set; }
        public DbSet<UsoEstacionamiento> UsoEstacionamiento { get; set; }
        public DbSet<ValetParking> ValetParking { get; set; }
        public DbSet<Vehiculo> Vehiculo { get; set; }

		public EstacionamientoBDContext() : base("Estacionamiento")
		{

		}

       protected override void OnModelCreating(DbModelBuilder modelBuilder)
        {
            modelBuilder.Configurations.Add(new ClienteConfiguration());
            modelBuilder.Configurations.Add(new ArticuloConfiguration());
            modelBuilder.Configurations.Add(new BeneficioConfiguration());
            modelBuilder.Configurations.Add(new BoletaConfiguration());
            modelBuilder.Configurations.Add(new DistritoConfiguration());
            modelBuilder.Configurations.Add(new EmpleadoConfiguration());
            modelBuilder.Configurations.Add(new EventoConfiguration());
            modelBuilder.Configurations.Add(new GestionReclamoConfiguration());
            modelBuilder.Configurations.Add(new ParkeoConfiguration());
            modelBuilder.Configurations.Add(new PublicidadConfiguration());
            modelBuilder.Configurations.Add(new SedeEstacionamientoConfiguration());
            modelBuilder.Configurations.Add(new TarjetaPrepagoConfiguration());
            modelBuilder.Configurations.Add(new TipoArticuloConfiguration());
            modelBuilder.Configurations.Add(new TipoBeneficioConfiguration());
            modelBuilder.Configurations.Add(new TipoClienteConfiguration());
            modelBuilder.Configurations.Add(new TipoEmpleadoConfiguration());
            modelBuilder.Configurations.Add(new TipoEstacionamientoConfiguration());
            modelBuilder.Configurations.Add(new TipoEventoConfiguration());
            modelBuilder.Configurations.Add(new TipoPagoConfiguration());
            modelBuilder.Configurations.Add(new TipoVehiculoConfiguration());

            base.OnModelCreating(modelBuilder);

        }
    }

}

