namespace Estacionamiento.Persistence.Migrations
{
    using System;
    using System.Data.Entity.Migrations;
    
    public partial class InitailModel : DbMigration
    {
        public override void Up()
        {
            CreateTable(
                "dbo.Articuloes",
                c => new
                    {
                        ArticuloID = c.Int(nullable: false, identity: true),
                    })
                .PrimaryKey(t => t.ArticuloID);
            
            CreateTable(
                "dbo.Beneficios",
                c => new
                    {
                        BeneficioID = c.Int(nullable: false, identity: true),
                    })
                .PrimaryKey(t => t.BeneficioID);
            
            CreateTable(
                "dbo.Boletas",
                c => new
                    {
                        BoletaID = c.Int(nullable: false, identity: true),
                    })
                .PrimaryKey(t => t.BoletaID);
            
            CreateTable(
                "dbo.Clientes",
                c => new
                    {
                        ClienteID = c.Int(nullable: false, identity: true),
                    })
                .PrimaryKey(t => t.ClienteID);
            
            CreateTable(
                "dbo.Distritoes",
                c => new
                    {
                        DistritoID = c.Int(nullable: false, identity: true),
                    })
                .PrimaryKey(t => t.DistritoID);
            
            CreateTable(
                "dbo.Empleadoes",
                c => new
                    {
                        EmpleadoID = c.Int(nullable: false, identity: true),
                    })
                .PrimaryKey(t => t.EmpleadoID);
            
            CreateTable(
                "dbo.Eventoes",
                c => new
                    {
                        EventoID = c.Int(nullable: false, identity: true),
                    })
                .PrimaryKey(t => t.EventoID);
            
            CreateTable(
                "dbo.GestionReclamoes",
                c => new
                    {
                        GestionReclamoID = c.Int(nullable: false, identity: true),
                    })
                .PrimaryKey(t => t.GestionReclamoID);
            
            CreateTable(
                "dbo.Parkeos",
                c => new
                    {
                        ParkeoID = c.Int(nullable: false, identity: true),
                    })
                .PrimaryKey(t => t.ParkeoID);
            
            CreateTable(
                "dbo.Publicidads",
                c => new
                    {
                        PublicidadID = c.Int(nullable: false, identity: true),
                    })
                .PrimaryKey(t => t.PublicidadID);
            
            CreateTable(
                "dbo.SedeEstacionamientoes",
                c => new
                    {
                        SedeEstacionamientoID = c.Int(nullable: false, identity: true),
                    })
                .PrimaryKey(t => t.SedeEstacionamientoID);
            
            CreateTable(
                "dbo.TarjetaPrepagoes",
                c => new
                    {
                        TarjetaPrepagoID = c.Int(nullable: false, identity: true),
                    })
                .PrimaryKey(t => t.TarjetaPrepagoID);
            
            CreateTable(
                "dbo.TipoArticuloes",
                c => new
                    {
                        TipoArticuloID = c.Int(nullable: false, identity: true),
                    })
                .PrimaryKey(t => t.TipoArticuloID);
            
            CreateTable(
                "dbo.TipoBeneficios",
                c => new
                    {
                        TipoBeneficioID = c.Int(nullable: false, identity: true),
                    })
                .PrimaryKey(t => t.TipoBeneficioID);
            
            CreateTable(
                "dbo.TipoClientes",
                c => new
                    {
                        TipoClienteID = c.Int(nullable: false, identity: true),
                    })
                .PrimaryKey(t => t.TipoClienteID);
            
            CreateTable(
                "dbo.TipoEmpleadoes",
                c => new
                    {
                        TipoEmpleadoID = c.Int(nullable: false, identity: true),
                    })
                .PrimaryKey(t => t.TipoEmpleadoID);
            
            CreateTable(
                "dbo.TipoEstacionamientoes",
                c => new
                    {
                        TipoEstacionamientoID = c.Int(nullable: false, identity: true),
                    })
                .PrimaryKey(t => t.TipoEstacionamientoID);
            
            CreateTable(
                "dbo.TipoEventoes",
                c => new
                    {
                        TipoEventoID = c.Int(nullable: false, identity: true),
                    })
                .PrimaryKey(t => t.TipoEventoID);
            
            CreateTable(
                "dbo.TipoPagoes",
                c => new
                    {
                        TipoPagoID = c.Int(nullable: false, identity: true),
                    })
                .PrimaryKey(t => t.TipoPagoID);
            
            CreateTable(
                "dbo.TipoVehiculoes",
                c => new
                    {
                        TipoVehiculoID = c.Int(nullable: false, identity: true),
                    })
                .PrimaryKey(t => t.TipoVehiculoID);
            
            CreateTable(
                "dbo.UsoEstacionamientoes",
                c => new
                    {
                        UsoEstacionamientoID = c.Int(nullable: false, identity: true),
                    })
                .PrimaryKey(t => t.UsoEstacionamientoID);
            
            CreateTable(
                "dbo.ValetParkings",
                c => new
                    {
                        ValetParkingID = c.Int(nullable: false, identity: true),
                    })
                .PrimaryKey(t => t.ValetParkingID);
            
            CreateTable(
                "dbo.Vehiculoes",
                c => new
                    {
                        VehiculoID = c.Int(nullable: false, identity: true),
                    })
                .PrimaryKey(t => t.VehiculoID);
            
        }
        
        public override void Down()
        {
            DropTable("dbo.Vehiculoes");
            DropTable("dbo.ValetParkings");
            DropTable("dbo.UsoEstacionamientoes");
            DropTable("dbo.TipoVehiculoes");
            DropTable("dbo.TipoPagoes");
            DropTable("dbo.TipoEventoes");
            DropTable("dbo.TipoEstacionamientoes");
            DropTable("dbo.TipoEmpleadoes");
            DropTable("dbo.TipoClientes");
            DropTable("dbo.TipoBeneficios");
            DropTable("dbo.TipoArticuloes");
            DropTable("dbo.TarjetaPrepagoes");
            DropTable("dbo.SedeEstacionamientoes");
            DropTable("dbo.Publicidads");
            DropTable("dbo.Parkeos");
            DropTable("dbo.GestionReclamoes");
            DropTable("dbo.Eventoes");
            DropTable("dbo.Empleadoes");
            DropTable("dbo.Distritoes");
            DropTable("dbo.Clientes");
            DropTable("dbo.Boletas");
            DropTable("dbo.Beneficios");
            DropTable("dbo.Articuloes");
        }
    }
}
