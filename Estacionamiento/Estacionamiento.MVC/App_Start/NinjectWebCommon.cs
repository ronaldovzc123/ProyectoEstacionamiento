[assembly: WebActivatorEx.PreApplicationStartMethod(typeof(Estacionamiento.MVC.App_Start.NinjectWebCommon), "Start")]
[assembly: WebActivatorEx.ApplicationShutdownMethodAttribute(typeof(Estacionamiento.MVC.App_Start.NinjectWebCommon), "Stop")]

namespace Estacionamiento.MVC.App_Start
{
    using System;
    using System.Web;

    using Microsoft.Web.Infrastructure.DynamicModuleHelper;

    using Ninject;
    using Ninject.Web.Common;
    using Estacionamiento.Persistence.Repositories;
    using Estacionamiento.Entities.IRepositories;
    using Estacionamiento.Persistence;

    public static class NinjectWebCommon 
    {
        private static readonly Bootstrapper bootstrapper = new Bootstrapper();

        /// <summary>
        /// Starts the application
        /// </summary>
        public static void Start() 
        {
            DynamicModuleUtility.RegisterModule(typeof(OnePerRequestHttpModule));
            DynamicModuleUtility.RegisterModule(typeof(NinjectHttpModule));
            bootstrapper.Initialize(CreateKernel);
        }
        
        /// <summary>
        /// Stops the application.
        /// </summary>
        public static void Stop()
        {
            bootstrapper.ShutDown();
        }
        
        /// <summary>
        /// Creates the kernel that will manage your application.
        /// </summary>
        /// <returns>The created kernel.</returns>
        private static IKernel CreateKernel()
        {
            var kernel = new StandardKernel();
            try
            {
                kernel.Bind<Func<IKernel>>().ToMethod(ctx => () => new Bootstrapper().Kernel);
                kernel.Bind<IHttpModule>().To<HttpApplicationInitializationHttpModule>();

                RegisterServices(kernel);
                return kernel;
            }
            catch
            {
                kernel.Dispose();
                throw;
            }
        }

        /// <summary>
        /// Load your modules or register your services here!
        /// </summary>
        /// <param name="kernel">The kernel.</param>
        private static void RegisterServices(IKernel kernel)
        {
            kernel.Bind<IUnityOfWork>().To<UnityOfWork>();

            kernel.Bind<EstacionamientoBDContext>().To<EstacionamientoBDContext>();

            kernel.Bind<IArticuloRepository>().To<ArticuloRepository>();
            kernel.Bind<IBeneficioRepository>().To<BeneficioRepository>();
            kernel.Bind<IBoletaRepository>().To<BoletaRepository>();
            kernel.Bind<IClienteRepository>().To<ClienteRepository>();
            kernel.Bind<IDistritoRepository>().To<DistritoRepository>();
            kernel.Bind<IEmpleadoRepository>().To<EmpleadoRepository>();
            kernel.Bind<IEventoRepository>().To<EventoRepository>();
            kernel.Bind<IGestionReclamoRepository>().To<GestionReclamoRepository>();
            kernel.Bind<IPublicidadRepository>().To<PublicidadRepository>();
            kernel.Bind<ISedeEstacionamientoRepository>().To<SedeEstacionamientoRepository>();
            kernel.Bind<ITarjetaPrepagoRepository>().To<TarjetaPrepagoRepository>();
            kernel.Bind<ITipoArticuloRepository>().To<TipoArticuloRepository>();
            kernel.Bind<ITipoBeneficioRepository>().To<TipoBeneficioRepository>();
            kernel.Bind<ITipoClienteRepository>().To<TipoClienteRepository>();
            kernel.Bind<ITipoEmpleadoRepository>().To<TipoEmpleadoRepository>();
            kernel.Bind<TipoEstacionamientoRepository>().To<TipoEstacionamientoRepository>();
            kernel.Bind<ITipoEventoRepository>().To<TipoEventoRepository>();
            kernel.Bind<ITipoPagoRepository>().To<TipoPagoRepository>();
            kernel.Bind<ITipoVehiculoRepository>().To<TipoVehiculoRepository>();
            kernel.Bind<IUnityOfWork>().To<UnityOfWork>();
            kernel.Bind<IUsoEstacionamientoRepository>().To<UsoEstacionamientoRepository>();
            kernel.Bind<IValetParkingRepository>().To<ValetParkingRepository>();
            kernel.Bind<IVehiculoRepository>().To<VehiculoRepository>();




        }
    }
}
