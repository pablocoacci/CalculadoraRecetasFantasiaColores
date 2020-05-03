namespace CalculadoraRecetas.Migrations
{
    using System;
    using System.Data.Entity.Migrations;
    
    public partial class Add_NotasYPrecioVenta_Pedidos : DbMigration
    {
        public override void Up()
        {
            AddColumn("dbo.Pedidos", "Notas", c => c.String(maxLength: 1500, unicode: false));
            AddColumn("dbo.Pedidos", "PrecioVentaReal", c => c.Decimal(nullable: false, precision: 19, scale: 2));
        }
        
        public override void Down()
        {
            DropColumn("dbo.Pedidos", "PrecioVentaReal");
            DropColumn("dbo.Pedidos", "Notas");
        }
    }
}
