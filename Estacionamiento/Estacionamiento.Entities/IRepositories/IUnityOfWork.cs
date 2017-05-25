using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Estacionamiento.Entities.IRepositories
{
    public interface IUnityOfWork : IDisposable
    {


        IArticuloRepository Articulos { get; }
        IBeneficioRepository Beneficios { get; }
        IBoletaRepository Boletas { get; }
        IClienteRepository Clientes { get; }
        IDistritoRepository Distritos { get; }
        IEmpleadoRepository Empleados { get; }
        IEventoRepository Eventos { get; }
        IGestionReclamoRepository GestionReclamos { get; }
        IParkeoRepository Parkeos { get; }
        IPublicidadRepository Publicidades { get; }
        ISedeEstacionamientoRepository Sedes { get; }
        ITarjetaPrepagoRepository TarjetasPrepago { get; }
        ITipoArticuloRepository TiposArticulo { get; }
        ITipoBeneficioRepository TiposBeneficio { get; }
        ITipoClienteRepository TiposCliente { get; }
        ITipoEmpleadoRepository TiposEmpleado { get; }
        ITipoEstacionamientoRepository TiposEstacionamiento { get; }
        ITipoEventoRepository TiposEvento { get; }
        ITipoPagoRepository TiposPago { get; }
        ITipoVehiculoRepository TiposVehiculo { get; }
        IUsoEstacionamientoRepository UsosEstacionamiento { get; }
        IValetParkingRepository ValetsParking { get; }
        IVehiculoRepository Vehiculos { get; }


        int SaveChanges();

        void StateModified(object entity);


    }
}
