namespace CalculadoraRecetas.Migrations
{
    using System;
    using System.Data.Entity.Migrations;
    
    public partial class CulumnaEstadoPedido : DbMigration
    {
        public override void Up()
        {
            AddColumn("dbo.Pedidos", "Estado", c => c.Int(nullable: false));
        }
        
        public override void Down()
        {
            DropColumn("dbo.Pedidos", "Estado");
        }
    }
}
