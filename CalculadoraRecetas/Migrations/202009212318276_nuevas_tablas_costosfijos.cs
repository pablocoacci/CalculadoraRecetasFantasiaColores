namespace CalculadoraRecetas.Migrations
{
    using System;
    using System.Data.Entity.Migrations;
    
    public partial class nuevas_tablas_costosfijos : DbMigration
    {
        public override void Up()
        {
            CreateTable(
                "dbo.CostosFijos",
                c => new
                    {
                        Id = c.Int(nullable: false, identity: true),
                        Nombre = c.String(maxLength: 50, unicode: false),
                    })
                .PrimaryKey(t => t.Id);
            
            CreateTable(
                "dbo.CostosBasicos",
                c => new
                    {
                        Id = c.Int(nullable: false, identity: true),
                        IsCostoFijo = c.Boolean(nullable: false),
                        Nombre = c.String(maxLength: 50, unicode: false),
                        FechaCosto = c.DateTime(nullable: false),
                        Notas = c.String(maxLength: 1500, unicode: false),
                        CostoMonto = c.Decimal(nullable: false, precision: 19, scale: 2),
                    })
                .PrimaryKey(t => t.Id);
            
        }
        
        public override void Down()
        {
            DropTable("dbo.CostosBasicos");
            DropTable("dbo.CostosFijos");
        }
    }
}
