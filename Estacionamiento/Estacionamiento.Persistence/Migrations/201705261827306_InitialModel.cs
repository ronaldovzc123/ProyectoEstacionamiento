namespace Estacionamiento.Persistence.Migrations
{
    using System;
    using System.Data.Entity.Migrations;
    
    public partial class InitialModel : DbMigration
    {
        public override void Up()
        {
            CreateTable(
                "dbo.Articulo",
                c => new
                    {
                        ArticuloID = c.Int(nullable: false, identity: true),
                        TipoArticuloID = c.Int(nullable: false),
                        Cantidad = c.Int(nullable: false),
                    })
                .PrimaryKey(t => t.ArticuloID)
                .ForeignKey("dbo.TipoArticulo", t => t.TipoArticuloID, cascadeDelete: true)
                .Index(t => t.TipoArticuloID);
            
            CreateTable(
                "dbo.TipoArticulo",
                c => new
                    {
                        TipoArticuloID = c.Int(nullable: false, identity: true),
                        DescripcionArticulo = c.String(),
                        Precio = c.Double(nullable: false),
                    })
                .PrimaryKey(t => t.TipoArticuloID);
            
            CreateTable(
                "dbo.Beneficio",
                c => new
                    {
                        BeneficioID = c.Int(nullable: false, identity: true),
                        TipoBeneficioID = c.Int(nullable: false),
                        Cantidad = c.Int(nullable: false),
                    })
                .PrimaryKey(t => t.BeneficioID)
                .ForeignKey("dbo.TipoBeneficio", t => t.TipoBeneficioID, cascadeDelete: true)
                .Index(t => t.TipoBeneficioID);
            
            CreateTable(
                "dbo.TipoBeneficio",
                c => new
                    {
                        TipoBeneficioID = c.Int(nullable: false, identity: true),
                        DescripcionBeneficio = c.String(),
                        FechaRegistro = c.DateTimeOffset(nullable: false, precision: 7),
                    })
                .PrimaryKey(t => t.TipoBeneficioID);
            
            CreateTable(
                "dbo.Boleta",
                c => new
                    {
                        BoletaID = c.Int(nullable: false, identity: true),
                        ClienteID = c.Int(nullable: false),
                        ArticuloID = c.Int(nullable: false),
                        TipoPagoID = c.Int(nullable: false),
                        Total = c.Double(nullable: false),
                    })
                .PrimaryKey(t => t.BoletaID)
                .ForeignKey("dbo.Articulo", t => t.ArticuloID, cascadeDelete: true)
                .ForeignKey("dbo.Cliente", t => t.ClienteID, cascadeDelete: true)
                .ForeignKey("dbo.TipoPago", t => t.TipoPagoID, cascadeDelete: true)
                .Index(t => t.ClienteID)
                .Index(t => t.ArticuloID)
                .Index(t => t.TipoPagoID);
            
            CreateTable(
                "dbo.Cliente",
                c => new
                    {
                        ClienteID = c.Int(nullable: false, identity: true),
                        DNI = c.String(),
                        TipoClienteID = c.Int(nullable: false),
                        Nombre = c.String(),
                        Apellido = c.String(),
                        BeneficioID = c.Int(nullable: false),
                    })
                .PrimaryKey(t => t.ClienteID)
                .ForeignKey("dbo.Beneficio", t => t.BeneficioID, cascadeDelete: true)
                .ForeignKey("dbo.TipoCliente", t => t.TipoClienteID, cascadeDelete: true)
                .Index(t => t.TipoClienteID)
                .Index(t => t.BeneficioID);
            
            CreateTable(
                "dbo.GestionReclamo",
                c => new
                    {
                        GestionReclamoID = c.Int(nullable: false, identity: true),
                        ClienteID = c.Int(nullable: false),
                        Observacion = c.String(),
                    })
                .PrimaryKey(t => t.GestionReclamoID)
                .ForeignKey("dbo.Cliente", t => t.ClienteID, cascadeDelete: true)
                .Index(t => t.ClienteID);
            
            CreateTable(
                "dbo.TipoCliente",
                c => new
                    {
                        TipoClienteID = c.Int(nullable: false, identity: true),
                        Descripcion = c.String(),
                    })
                .PrimaryKey(t => t.TipoClienteID);
            
            CreateTable(
                "dbo.TipoPago",
                c => new
                    {
                        TipoPagoID = c.Int(nullable: false, identity: true),
                        NombreTipoPago = c.String(),
                    })
                .PrimaryKey(t => t.TipoPagoID);
            
            CreateTable(
                "dbo.Distrito",
                c => new
                    {
                        DistritoID = c.Int(nullable: false, identity: true),
                        SedeEstacionamientoID = c.Int(nullable: false),
                        NombreDistrito = c.String(),
                        Direccion = c.String(),
                    })
                .PrimaryKey(t => t.DistritoID)
                .ForeignKey("dbo.SedeEstacionamiento", t => t.SedeEstacionamientoID, cascadeDelete: true)
                .Index(t => t.SedeEstacionamientoID);
            
            CreateTable(
                "dbo.SedeEstacionamiento",
                c => new
                    {
                        SedeEstacionamientoID = c.Int(nullable: false, identity: true),
                        NombreSede = c.String(),
                        Direccion = c.String(),
                        CantidadLibre = c.Int(nullable: false),
                        Area = c.String(),
                    })
                .PrimaryKey(t => t.SedeEstacionamientoID);
            
            CreateTable(
                "dbo.Empleado",
                c => new
                    {
                        EmpleadoID = c.Int(nullable: false, identity: true),
                        Nombre = c.String(),
                        Apellido = c.String(),
                        TipoEmpleadoID = c.String(),
                        TipoEstacionamientoID = c.String(),
                        TipoEmpleado_TipoEmpleadoID = c.Int(),
                        TipoEstacionamiento_TipoEstacionamientoID = c.Int(),
                    })
                .PrimaryKey(t => t.EmpleadoID)
                .ForeignKey("dbo.TipoEmpleado", t => t.TipoEmpleado_TipoEmpleadoID)
                .ForeignKey("dbo.TipoEstacionamiento", t => t.TipoEstacionamiento_TipoEstacionamientoID)
                .Index(t => t.TipoEmpleado_TipoEmpleadoID)
                .Index(t => t.TipoEstacionamiento_TipoEstacionamientoID);
            
            CreateTable(
                "dbo.TipoEmpleado",
                c => new
                    {
                        TipoEmpleadoID = c.Int(nullable: false, identity: true),
                        LaborSocial = c.String(),
                    })
                .PrimaryKey(t => t.TipoEmpleadoID);
            
            CreateTable(
                "dbo.TipoEstacionamiento",
                c => new
                    {
                        TipoEstacionamientoID = c.Int(nullable: false, identity: true),
                        ParkeoID = c.String(),
                        Cantidad = c.String(),
                        Parkeo_ParkeoID = c.Int(),
                    })
                .PrimaryKey(t => t.TipoEstacionamientoID)
                .ForeignKey("dbo.Parkeo", t => t.Parkeo_ParkeoID)
                .Index(t => t.Parkeo_ParkeoID);
            
            CreateTable(
                "dbo.Parkeo",
                c => new
                    {
                        ParkeoID = c.Int(nullable: false, identity: true),
                        Estado = c.String(),
                        Fecha = c.DateTime(nullable: false),
                        Hora = c.DateTime(nullable: false),
                        Mora = c.Double(nullable: false),
                    })
                .PrimaryKey(t => t.ParkeoID);
            
            CreateTable(
                "dbo.Evento",
                c => new
                    {
                        EventoID = c.Int(nullable: false, identity: true),
                        TipoEventoID = c.Int(nullable: false),
                        ClienteID = c.Int(nullable: false),
                        SedeID = c.Int(nullable: false),
                        Fecha = c.DateTime(nullable: false),
                        SedeEstacionamiento_SedeEstacionamientoID = c.Int(),
                    })
                .PrimaryKey(t => t.EventoID)
                .ForeignKey("dbo.Cliente", t => t.ClienteID, cascadeDelete: true)
                .ForeignKey("dbo.SedeEstacionamiento", t => t.SedeEstacionamiento_SedeEstacionamientoID)
                .ForeignKey("dbo.TipoEvento", t => t.TipoEventoID, cascadeDelete: true)
                .Index(t => t.TipoEventoID)
                .Index(t => t.ClienteID)
                .Index(t => t.SedeEstacionamiento_SedeEstacionamientoID);
            
            CreateTable(
                "dbo.TipoEvento",
                c => new
                    {
                        TipoEventoID = c.Int(nullable: false, identity: true),
                        DescripcionEvento = c.String(),
                        Fecha = c.DateTimeOffset(nullable: false, precision: 7),
                        Hora = c.DateTime(nullable: false),
                    })
                .PrimaryKey(t => t.TipoEventoID);
            
            CreateTable(
                "dbo.Publicidad",
                c => new
                    {
                        PublicidadID = c.Int(nullable: false, identity: true),
                        ParkeoID = c.String(),
                        ClienteID = c.Int(nullable: false),
                        Cantidad = c.Int(nullable: false),
                        Fecha = c.DateTime(nullable: false),
                        Parkeo_ParkeoID = c.Int(),
                    })
                .PrimaryKey(t => t.PublicidadID)
                .ForeignKey("dbo.Cliente", t => t.ClienteID, cascadeDelete: true)
                .ForeignKey("dbo.Parkeo", t => t.Parkeo_ParkeoID)
                .Index(t => t.ClienteID)
                .Index(t => t.Parkeo_ParkeoID);
            
            CreateTable(
                "dbo.TarjetaPrepago",
                c => new
                    {
                        TarjetaPrepagoID = c.Int(nullable: false, identity: true),
                        ClienteID = c.String(),
                        DescripcionTarjeta = c.String(),
                        Cliente_ClienteID = c.Int(nullable: false),
                    })
                .PrimaryKey(t => t.TarjetaPrepagoID)
                .ForeignKey("dbo.Cliente", t => t.Cliente_ClienteID, cascadeDelete: true)
                .Index(t => t.Cliente_ClienteID);
            
            CreateTable(
                "dbo.TipoVehiculo",
                c => new
                    {
                        TipoVehiculoID = c.Int(nullable: false, identity: true),
                        Marca = c.String(),
                        Modelo = c.String(),
                        Color = c.String(),
                    })
                .PrimaryKey(t => t.TipoVehiculoID);
            
            CreateTable(
                "dbo.UsoEstacionamientoes",
                c => new
                    {
                        UsoEstacionamientoID = c.Int(nullable: false, identity: true),
                        SedeEstacionamientoID = c.Int(nullable: false),
                        DNI = c.String(),
                        Fecha = c.DateTime(nullable: false),
                        Hora = c.DateTime(nullable: false),
                    })
                .PrimaryKey(t => t.UsoEstacionamientoID)
                .ForeignKey("dbo.SedeEstacionamiento", t => t.SedeEstacionamientoID, cascadeDelete: true)
                .Index(t => t.SedeEstacionamientoID);
            
            CreateTable(
                "dbo.ValetParkings",
                c => new
                    {
                        ValetParkingID = c.Int(nullable: false, identity: true),
                        UsoEstacionamientoID = c.String(),
                        ParkeoID = c.String(),
                        Estado = c.String(),
                        Parkeo_ParkeoID = c.Int(),
                        UsoEstacionamiento_UsoEstacionamientoID = c.Int(),
                    })
                .PrimaryKey(t => t.ValetParkingID)
                .ForeignKey("dbo.Parkeo", t => t.Parkeo_ParkeoID)
                .ForeignKey("dbo.UsoEstacionamientoes", t => t.UsoEstacionamiento_UsoEstacionamientoID)
                .Index(t => t.Parkeo_ParkeoID)
                .Index(t => t.UsoEstacionamiento_UsoEstacionamientoID);
            
            CreateTable(
                "dbo.Vehiculoes",
                c => new
                    {
                        VehiculoID = c.Int(nullable: false, identity: true),
                        Placa = c.String(),
                        TipoVehiculoID = c.String(),
                        TipoVehiculo_TipoVehiculoID = c.Int(),
                    })
                .PrimaryKey(t => t.VehiculoID)
                .ForeignKey("dbo.TipoVehiculo", t => t.TipoVehiculo_TipoVehiculoID)
                .Index(t => t.TipoVehiculo_TipoVehiculoID);
            
        }
        
        public override void Down()
        {
            DropForeignKey("dbo.Vehiculoes", "TipoVehiculo_TipoVehiculoID", "dbo.TipoVehiculo");
            DropForeignKey("dbo.ValetParkings", "UsoEstacionamiento_UsoEstacionamientoID", "dbo.UsoEstacionamientoes");
            DropForeignKey("dbo.ValetParkings", "Parkeo_ParkeoID", "dbo.Parkeo");
            DropForeignKey("dbo.UsoEstacionamientoes", "SedeEstacionamientoID", "dbo.SedeEstacionamiento");
            DropForeignKey("dbo.TarjetaPrepago", "Cliente_ClienteID", "dbo.Cliente");
            DropForeignKey("dbo.Publicidad", "Parkeo_ParkeoID", "dbo.Parkeo");
            DropForeignKey("dbo.Publicidad", "ClienteID", "dbo.Cliente");
            DropForeignKey("dbo.Evento", "TipoEventoID", "dbo.TipoEvento");
            DropForeignKey("dbo.Evento", "SedeEstacionamiento_SedeEstacionamientoID", "dbo.SedeEstacionamiento");
            DropForeignKey("dbo.Evento", "ClienteID", "dbo.Cliente");
            DropForeignKey("dbo.Empleado", "TipoEstacionamiento_TipoEstacionamientoID", "dbo.TipoEstacionamiento");
            DropForeignKey("dbo.TipoEstacionamiento", "Parkeo_ParkeoID", "dbo.Parkeo");
            DropForeignKey("dbo.Empleado", "TipoEmpleado_TipoEmpleadoID", "dbo.TipoEmpleado");
            DropForeignKey("dbo.Distrito", "SedeEstacionamientoID", "dbo.SedeEstacionamiento");
            DropForeignKey("dbo.Boleta", "TipoPagoID", "dbo.TipoPago");
            DropForeignKey("dbo.Boleta", "ClienteID", "dbo.Cliente");
            DropForeignKey("dbo.Cliente", "TipoClienteID", "dbo.TipoCliente");
            DropForeignKey("dbo.GestionReclamo", "ClienteID", "dbo.Cliente");
            DropForeignKey("dbo.Cliente", "BeneficioID", "dbo.Beneficio");
            DropForeignKey("dbo.Boleta", "ArticuloID", "dbo.Articulo");
            DropForeignKey("dbo.Beneficio", "TipoBeneficioID", "dbo.TipoBeneficio");
            DropForeignKey("dbo.Articulo", "TipoArticuloID", "dbo.TipoArticulo");
            DropIndex("dbo.Vehiculoes", new[] { "TipoVehiculo_TipoVehiculoID" });
            DropIndex("dbo.ValetParkings", new[] { "UsoEstacionamiento_UsoEstacionamientoID" });
            DropIndex("dbo.ValetParkings", new[] { "Parkeo_ParkeoID" });
            DropIndex("dbo.UsoEstacionamientoes", new[] { "SedeEstacionamientoID" });
            DropIndex("dbo.TarjetaPrepago", new[] { "Cliente_ClienteID" });
            DropIndex("dbo.Publicidad", new[] { "Parkeo_ParkeoID" });
            DropIndex("dbo.Publicidad", new[] { "ClienteID" });
            DropIndex("dbo.Evento", new[] { "SedeEstacionamiento_SedeEstacionamientoID" });
            DropIndex("dbo.Evento", new[] { "ClienteID" });
            DropIndex("dbo.Evento", new[] { "TipoEventoID" });
            DropIndex("dbo.TipoEstacionamiento", new[] { "Parkeo_ParkeoID" });
            DropIndex("dbo.Empleado", new[] { "TipoEstacionamiento_TipoEstacionamientoID" });
            DropIndex("dbo.Empleado", new[] { "TipoEmpleado_TipoEmpleadoID" });
            DropIndex("dbo.Distrito", new[] { "SedeEstacionamientoID" });
            DropIndex("dbo.GestionReclamo", new[] { "ClienteID" });
            DropIndex("dbo.Cliente", new[] { "BeneficioID" });
            DropIndex("dbo.Cliente", new[] { "TipoClienteID" });
            DropIndex("dbo.Boleta", new[] { "TipoPagoID" });
            DropIndex("dbo.Boleta", new[] { "ArticuloID" });
            DropIndex("dbo.Boleta", new[] { "ClienteID" });
            DropIndex("dbo.Beneficio", new[] { "TipoBeneficioID" });
            DropIndex("dbo.Articulo", new[] { "TipoArticuloID" });
            DropTable("dbo.Vehiculoes");
            DropTable("dbo.ValetParkings");
            DropTable("dbo.UsoEstacionamientoes");
            DropTable("dbo.TipoVehiculo");
            DropTable("dbo.TarjetaPrepago");
            DropTable("dbo.Publicidad");
            DropTable("dbo.TipoEvento");
            DropTable("dbo.Evento");
            DropTable("dbo.Parkeo");
            DropTable("dbo.TipoEstacionamiento");
            DropTable("dbo.TipoEmpleado");
            DropTable("dbo.Empleado");
            DropTable("dbo.SedeEstacionamiento");
            DropTable("dbo.Distrito");
            DropTable("dbo.TipoPago");
            DropTable("dbo.TipoCliente");
            DropTable("dbo.GestionReclamo");
            DropTable("dbo.Cliente");
            DropTable("dbo.Boleta");
            DropTable("dbo.TipoBeneficio");
            DropTable("dbo.Beneficio");
            DropTable("dbo.TipoArticulo");
            DropTable("dbo.Articulo");
        }
    }
}
