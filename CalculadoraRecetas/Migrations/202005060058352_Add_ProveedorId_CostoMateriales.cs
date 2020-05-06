namespace CalculadoraRecetas.Migrations
{
    using System;
    using System.Data.Entity.Migrations;
    
    public partial class Add_ProveedorId_CostoMateriales : DbMigration
    {
        public override void Up()
        {
            AddColumn("dbo.CostoMateriales", "Id_Proveedor", c => c.Int(nullable: false));
            CreateIndex("dbo.CostoMateriales", "Id_Proveedor");
            AddForeignKey("dbo.CostoMateriales", "Id_Proveedor", "dbo.Proveedores", "Id", cascadeDelete: true);
        }
        
        public override void Down()
        {
            DropForeignKey("dbo.CostoMateriales", "Id_Proveedor", "dbo.Proveedores");
            DropIndex("dbo.CostoMateriales", new[] { "Id_Proveedor" });
            DropColumn("dbo.CostoMateriales", "Id_Proveedor");
        }
    }
}
