namespace CalculadoraRecetas.Migrations
{
    using System;
    using System.Data.Entity.Migrations;
    
    public partial class NuevaTabla_CostoMateriales : DbMigration
    {
        public override void Up()
        {
            CreateTable(
                "dbo.CostoMateriales",
                c => new
                    {
                        Id = c.Int(nullable: false, identity: true),
                        Nombre = c.String(maxLength: 50, unicode: false),
                        FechaCompra = c.DateTime(nullable: false),
                        Notas = c.String(maxLength: 1500, unicode: false),
                        Detalle = c.String(maxLength: 50, unicode: false),
                        PrecioUnitario = c.Decimal(nullable: false, precision: 19, scale: 2),
                        Cantidad = c.Int(nullable: false),
                        CostoTotal = c.Decimal(nullable: false, precision: 19, scale: 2),
                    })
                .PrimaryKey(t => t.Id);
            
        }
        
        public override void Down()
        {
            DropTable("dbo.CostoMateriales");
        }
    }
}
