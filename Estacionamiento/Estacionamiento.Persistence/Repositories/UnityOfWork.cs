using Estacionamiento.Entities.IRepositories;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Estacionamiento.Persistence.Repositories
{
    public class UnityOfWork : IUnityOfWork
    {
        private readonly EstacionamientoBDContext _Context;
        private static UnityOfWork _Instance;
        private static readonly object _Lock = new object();

        public IArticuloRepository Articulos { get; private set; }

        public IBeneficioRepository Beneficios { get; private set; }

        public IBoletaRepository Boletas { get; private set; }

        public IClienteRepository Clientes { get; private set; }

        public IDistritoRepository Distritos { get; private set; }

        public IEmpleadoRepository Empleados { get; private set; }

        public IEventoRepository Eventos { get; private set; }

        public IGestionReclamoRepository GestionReclamos { get; private set; }

        public IParkeoRepository Parkeos { get; private set; }

        public IPublicidadRepository Publicidades { get; private set; }

        public ISedeEstacionamientoRepository Sedes { get; private set; }

        public ITarjetaPrepagoRepository TarjetasPrepago { get; private set; }

        public ITipoArticuloRepository TiposArticulo { get; private set; }

        public ITipoBeneficioRepository TiposBeneficio { get; private set; }

        public ITipoClienteRepository TiposCliente { get; private set; }

        public ITipoEmpleadoRepository TiposEmpleado { get; private set; }

        public ITipoEstacionamientoRepository TiposEstacionamiento { get; private set; }

        public ITipoEventoRepository TiposEvento { get; private set; }

        public ITipoPagoRepository TiposPago { get; private set; }

        public ITipoVehiculoRepository TiposVehiculo { get; private set; }

        public IUsoEstacionamientoRepository UsosEstacionamiento { get; private set; }

        public IValetParkingRepository ValetsParking { get; private set; }

        public IVehiculoRepository Vehiculos { get; private set; }


        
        private UnityOfWork()
        {
            _Context = new EstacionamientoBDContext();

            Articulos = new ArticuloRepository(_Context);
            Beneficios = new BeneficioRepository(_Context);
            Boletas = new BoletaRepository(_Context);
            Clientes = new ClienteRepository(_Context);
            Distritos = new DistritoRepository(_Context);
            Empleados = new EmpleadoRepository(_Context);
            Eventos = new EventoRepository(_Context);
            GestionReclamos = new GestionReclamoRepository(_Context);
            Parkeos = new ParkeoRepository(_Context);
            Publicidades = new PublicidadRepository(_Context);
            Sedes = new SedeEstacionamientoRepository(_Context);
            TarjetasPrepago = new TarjetaPrepagoRepository(_Context);
            TiposArticulo = new TipoArticuloRepository(_Context);
            TiposBeneficio = new TipoBeneficioRepository(_Context);
            TiposCliente = new TipoClienteRepository(_Context);
            TiposEmpleado = new TipoEmpleadoRepository(_Context);
            TiposEstacionamiento = new TipoEstacionamientoRepository(_Context);
            TiposEvento = new TipoEventoRepository(_Context);
            TiposPago = new TipoPagoRepository(_Context);
            TiposVehiculo = new TipoVehiculoRepository(_Context);
            UsosEstacionamiento = new UsoEstacionamientoRepository(_Context);
            ValetsParking = new ValetParkingRepository(_Context);
            Vehiculos = new VehiculoRepository(_Context);


        }

        public static UnityOfWork Instance
        {
            get
            {
                lock(_Lock)
                {
                    if (_Instance == null)
                        _Instance = new UnityOfWork();
                }

                return _Instance;
            }
        }
       


        public void Dispose()
        {
            _Context.Dispose();
        }

        public int SaveChanges()
        {
            return _Context.SaveChanges();
        }

        public void StateModified(object Entity)
        {
            _Context.Entry(Entity).State = System.Data.Entity.EntityState.Modified;
        }

    }
}
