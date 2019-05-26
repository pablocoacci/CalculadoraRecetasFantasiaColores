namespace CalculadoraRecetas.Migrations
{
    using System;
    using System.Data.Entity.Migrations;
    
    public partial class CampoNotasCliente : DbMigration
    {
        public override void Up()
        {
            AlterColumn("dbo.Clientes", "Notas", c => c.String(maxLength: 2000, unicode: false));
        }
        
        public override void Down()
        {
            AlterColumn("dbo.Clientes", "Notas", c => c.String(maxLength: 2500, unicode: false));
        }
    }
}
