namespace CalculadoraRecetas.Migrations
{
    using System;
    using System.Data.Entity.Migrations;
    
    public partial class IdRecetaOrdenCampo : DbMigration
    {
        public override void Up()
        {
            AddColumn("dbo.Ordenes", "Id_Receta", c => c.Int(nullable: false));
        }
        
        public override void Down()
        {
            DropColumn("dbo.Ordenes", "Id_Receta");
        }
    }
}
