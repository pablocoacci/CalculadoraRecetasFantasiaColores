namespace CalculadoraRecetas.Migrations
{
    using System;
    using System.Data.Entity.Migrations;
    
    public partial class Add_MateriaPrimaFK_CostoMateriales : DbMigration
    {
        public override void Up()
        {
            AddColumn("dbo.CostoMateriales", "Id_MateriaPrima", c => c.Int(nullable: false));
            CreateIndex("dbo.CostoMateriales", "Id_MateriaPrima");
            AddForeignKey("dbo.CostoMateriales", "Id_MateriaPrima", "dbo.MateriasPrimas", "Id", cascadeDelete: true);
            DropColumn("dbo.CostoMateriales", "Nombre");
        }
        
        public override void Down()
        {
            AddColumn("dbo.CostoMateriales", "Nombre", c => c.String(maxLength: 50, unicode: false));
            DropForeignKey("dbo.CostoMateriales", "Id_MateriaPrima", "dbo.MateriasPrimas");
            DropIndex("dbo.CostoMateriales", new[] { "Id_MateriaPrima" });
            DropColumn("dbo.CostoMateriales", "Id_MateriaPrima");
        }
    }
}
