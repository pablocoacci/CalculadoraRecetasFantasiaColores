namespace CalculadoraRecetas.Migrations
{
    using System;
    using System.Data.Entity.Migrations;
    
    public partial class NuevosCamposCliente : DbMigration
    {
        public override void Up()
        {
            AddColumn("dbo.Clientes", "ClienteDificil", c => c.Boolean(nullable: false));
        }
        
        public override void Down()
        {
            DropColumn("dbo.Clientes", "ClienteDificil");
        }
    }
}
