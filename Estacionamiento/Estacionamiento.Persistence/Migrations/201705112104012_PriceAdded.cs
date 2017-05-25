namespace Estacionamiento.Persistence.Migrations
{
    using System;
    using System.Data.Entity.Migrations;
    
    public partial class PriceAdded : DbMigration
    {
        public override void Up()
        {
            AddColumn("dbo.Articuloes", "precio", c => c.Double(nullable: false));
        }
        
        public override void Down()
        {
            DropColumn("dbo.Articuloes", "precio");
        }
    }
}
