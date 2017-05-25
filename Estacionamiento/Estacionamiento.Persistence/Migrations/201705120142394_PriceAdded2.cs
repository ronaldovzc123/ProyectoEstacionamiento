namespace Estacionamiento.Persistence.Migrations
{
    using System;
    using System.Data.Entity.Migrations;
    
    public partial class PriceAdded2 : DbMigration
    {
        public override void Up()
        {
            AddColumn("dbo.Beneficios", "Cantidad", c => c.Int(nullable: false));
            AddColumn("dbo.Boletas", "Total", c => c.Double(nullable: false));
            AddColumn("dbo.Clientes", "DNI", c => c.String());
            AddColumn("dbo.Clientes", "Nombre", c => c.String());
            AddColumn("dbo.Clientes", "Apellido", c => c.String());
            AddColumn("dbo.Distritoes", "NombreDistrito", c => c.String());
            AddColumn("dbo.Distritoes", "Direccion", c => c.String());
            AddColumn("dbo.Empleadoes", "Nombre", c => c.String());
            AddColumn("dbo.Empleadoes", "Apellido", c => c.String());
            AddColumn("dbo.GestionReclamoes", "Observacion", c => c.String());
            AddColumn("dbo.Parkeos", "Estado", c => c.String());
            AddColumn("dbo.Parkeos", "fecha", c => c.DateTime(nullable: false));
            AddColumn("dbo.Parkeos", "Hora", c => c.DateTime(nullable: false));
            AddColumn("dbo.Parkeos", "Mora", c => c.Double(nullable: false));
            AddColumn("dbo.Publicidads", "Cantidad", c => c.Int(nullable: false));
            AddColumn("dbo.SedeEstacionamientoes", "NombreSede", c => c.String());
            AddColumn("dbo.SedeEstacionamientoes", "Direccion", c => c.String());
            AddColumn("dbo.SedeEstacionamientoes", "CantidadLibre", c => c.Int(nullable: false));
            AddColumn("dbo.SedeEstacionamientoes", "Area", c => c.String());
            AddColumn("dbo.TarjetaPrepagoes", "DescripcionTarjeta", c => c.String());
            AddColumn("dbo.TipoArticuloes", "DescripcionArticulo", c => c.String());
            AddColumn("dbo.TipoArticuloes", "Precio", c => c.Double(nullable: false));
            AddColumn("dbo.TipoBeneficios", "DescripcionBeneficio", c => c.String());
            AddColumn("dbo.TipoBeneficios", "FechaRegistro", c => c.DateTimeOffset(nullable: false, precision: 7));
            AddColumn("dbo.TipoClientes", "Descripcion", c => c.String());
            AddColumn("dbo.TipoEmpleadoes", "LaborSocial", c => c.String());
            AddColumn("dbo.TipoEstacionamientoes", "Cantidad", c => c.String());
            AddColumn("dbo.TipoEventoes", "DescripcionEvento", c => c.String());
            AddColumn("dbo.TipoEventoes", "Fecha", c => c.DateTimeOffset(nullable: false, precision: 7));
            AddColumn("dbo.TipoEventoes", "Hora", c => c.DateTime(nullable: false));
            AddColumn("dbo.TipoPagoes", "NombreTipoPago", c => c.String());
            AddColumn("dbo.TipoVehiculoes", "Marca", c => c.String());
            AddColumn("dbo.TipoVehiculoes", "Modelo", c => c.String());
            AddColumn("dbo.TipoVehiculoes", "Color", c => c.String());
            AddColumn("dbo.UsoEstacionamientoes", "SedeID", c => c.Int(nullable: false));
            AddColumn("dbo.UsoEstacionamientoes", "Fecha", c => c.DateTime(nullable: false));
            AddColumn("dbo.UsoEstacionamientoes", "Hora", c => c.DateTime(nullable: false));
            AddColumn("dbo.UsoEstacionamientoes", "DNI", c => c.String());
            AddColumn("dbo.ValetParkings", "Estado", c => c.String());
            AddColumn("dbo.Vehiculoes", "Placa", c => c.String());
        }
        
        public override void Down()
        {
            DropColumn("dbo.Vehiculoes", "Placa");
            DropColumn("dbo.ValetParkings", "Estado");
            DropColumn("dbo.UsoEstacionamientoes", "DNI");
            DropColumn("dbo.UsoEstacionamientoes", "Hora");
            DropColumn("dbo.UsoEstacionamientoes", "Fecha");
            DropColumn("dbo.UsoEstacionamientoes", "SedeID");
            DropColumn("dbo.TipoVehiculoes", "Color");
            DropColumn("dbo.TipoVehiculoes", "Modelo");
            DropColumn("dbo.TipoVehiculoes", "Marca");
            DropColumn("dbo.TipoPagoes", "NombreTipoPago");
            DropColumn("dbo.TipoEventoes", "Hora");
            DropColumn("dbo.TipoEventoes", "Fecha");
            DropColumn("dbo.TipoEventoes", "DescripcionEvento");
            DropColumn("dbo.TipoEstacionamientoes", "Cantidad");
            DropColumn("dbo.TipoEmpleadoes", "LaborSocial");
            DropColumn("dbo.TipoClientes", "Descripcion");
            DropColumn("dbo.TipoBeneficios", "FechaRegistro");
            DropColumn("dbo.TipoBeneficios", "DescripcionBeneficio");
            DropColumn("dbo.TipoArticuloes", "Precio");
            DropColumn("dbo.TipoArticuloes", "DescripcionArticulo");
            DropColumn("dbo.TarjetaPrepagoes", "DescripcionTarjeta");
            DropColumn("dbo.SedeEstacionamientoes", "Area");
            DropColumn("dbo.SedeEstacionamientoes", "CantidadLibre");
            DropColumn("dbo.SedeEstacionamientoes", "Direccion");
            DropColumn("dbo.SedeEstacionamientoes", "NombreSede");
            DropColumn("dbo.Publicidads", "Cantidad");
            DropColumn("dbo.Parkeos", "Mora");
            DropColumn("dbo.Parkeos", "Hora");
            DropColumn("dbo.Parkeos", "fecha");
            DropColumn("dbo.Parkeos", "Estado");
            DropColumn("dbo.GestionReclamoes", "Observacion");
            DropColumn("dbo.Empleadoes", "Apellido");
            DropColumn("dbo.Empleadoes", "Nombre");
            DropColumn("dbo.Distritoes", "Direccion");
            DropColumn("dbo.Distritoes", "NombreDistrito");
            DropColumn("dbo.Clientes", "Apellido");
            DropColumn("dbo.Clientes", "Nombre");
            DropColumn("dbo.Clientes", "DNI");
            DropColumn("dbo.Boletas", "Total");
            DropColumn("dbo.Beneficios", "Cantidad");
        }
    }
}
