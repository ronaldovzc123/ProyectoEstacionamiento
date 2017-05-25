namespace Estacionamiento.Persistence.Migrations
{
    using System;
    using System.Data.Entity.Migrations;
    
    public partial class PriceAdded1 : DbMigration
    {
        public override void Up()
        {
            AddColumn("dbo.Articuloes", "Cantidad", c => c.Int(nullable: false));
        }
        
        public override void Down()
        {
            DropColumn("dbo.Articuloes", "Cantidad");
        }
    }
}
