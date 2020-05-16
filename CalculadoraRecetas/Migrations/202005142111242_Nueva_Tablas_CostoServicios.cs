namespace CalculadoraRecetas.Migrations
{
    using System;
    using System.Data.Entity.Migrations;
    
    public partial class Nueva_Tablas_CostoServicios : DbMigration
    {
        public override void Up()
        {
            CreateTable(
                "dbo.CostoServicios",
                c => new
                    {
                        Id = c.Int(nullable: false, identity: true),
                        Id_Servicio = c.Int(nullable: false),
                        FechaCreacion = c.DateTime(nullable: false),
                        PrecioFactura = c.Decimal(nullable: false, precision: 19, scale: 2),
                        HorasLaboralesMensual = c.Int(),
                        IncidenciaPorce = c.Decimal(precision: 18, scale: 2),
                        CostoTotal = c.Decimal(nullable: false, precision: 19, scale: 2),
                    })
                .PrimaryKey(t => t.Id)
                .ForeignKey("dbo.Servicios", t => t.Id_Servicio, cascadeDelete: true)
                .Index(t => t.Id_Servicio);
            
            CreateTable(
                "dbo.Servicios",
                c => new
                    {
                        Id = c.Int(nullable: false, identity: true),
                        Nombre = c.String(maxLength: 50, unicode: false),
                    })
                .PrimaryKey(t => t.Id);
            
        }
        
        public override void Down()
        {
            DropForeignKey("dbo.CostoServicios", "Id_Servicio", "dbo.Servicios");
            DropIndex("dbo.CostoServicios", new[] { "Id_Servicio" });
            DropTable("dbo.Servicios");
            DropTable("dbo.CostoServicios");
        }
    }
}
