namespace CalculadoraRecetas.Migrations
{
    using System;
    using System.Data.Entity.Migrations;
    
    public partial class relation_CostoBasico_CostoFijo : DbMigration
    {
        public override void Up()
        {
            AddColumn("dbo.CostosBasicos", "IdCostoFijo", c => c.Int());
            CreateIndex("dbo.CostosBasicos", "IdCostoFijo");
            AddForeignKey("dbo.CostosBasicos", "IdCostoFijo", "dbo.CostosFijos", "Id");
            DropColumn("dbo.CostosBasicos", "IsCostoFijo");
        }
        
        public override void Down()
        {
            AddColumn("dbo.CostosBasicos", "IsCostoFijo", c => c.Boolean(nullable: false));
            DropForeignKey("dbo.CostosBasicos", "IdCostoFijo", "dbo.CostosFijos");
            DropIndex("dbo.CostosBasicos", new[] { "IdCostoFijo" });
            DropColumn("dbo.CostosBasicos", "IdCostoFijo");
        }
    }
}
