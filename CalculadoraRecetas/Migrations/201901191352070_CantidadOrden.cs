namespace CalculadoraRecetas.Migrations
{
    using System;
    using System.Data.Entity.Migrations;
    
    public partial class CantidadOrden : DbMigration
    {
        public override void Up()
        {
            AddColumn("dbo.Ordenes", "Cantidad", c => c.Int(nullable: false));
        }
        
        public override void Down()
        {
            DropColumn("dbo.Ordenes", "Cantidad");
        }
    }
}
