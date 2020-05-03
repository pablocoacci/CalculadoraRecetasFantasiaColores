namespace CalculadoraRecetas.Migrations
{
    using System;
    using System.Data.Entity.Migrations;
    
    public partial class InitialCreate : DbMigration
    {
        public override void Up()
        {
            CreateTable(
                "dbo.Clientes",
                c => new
                    {
                        Id = c.Int(nullable: false, identity: true),
                        Nombre = c.String(maxLength: 50, unicode: false),
                        Mail = c.String(maxLength: 75, unicode: false),
                        Telefono = c.String(maxLength: 25, unicode: false),
                        Celular = c.String(maxLength: 25, unicode: false),
                        Direccion = c.String(maxLength: 150, unicode: false),
                        Notas = c.String(maxLength: 2500, unicode: false),
                })
                .PrimaryKey(t => t.Id);
            
            CreateTable(
                "dbo.Ingredientes",
                c => new
                    {
                        Id = c.Int(nullable: false, identity: true),
                        Id_MateriaPrima = c.Int(nullable: false),
                        Id_Receta = c.Int(nullable: false),
                        Cantidad = c.Decimal(nullable: false, precision: 19, scale: 2),
                    })
                .PrimaryKey(t => t.Id)
                .ForeignKey("dbo.MateriasPrimas", t => t.Id_MateriaPrima, cascadeDelete: true)
                .ForeignKey("dbo.Recetas", t => t.Id_Receta, cascadeDelete: true)
                .Index(t => t.Id_MateriaPrima)
                .Index(t => t.Id_Receta);
            
            CreateTable(
                "dbo.MateriasPrimas",
                c => new
                    {
                        Id = c.Int(nullable: false, identity: true),
                        Nombre = c.String(maxLength: 50, unicode: false),
                        Abreviatura = c.String(maxLength: 10, unicode: false),
                        UnidadMedida = c.Int(nullable: false),
                        Precio = c.Decimal(nullable: false, precision: 19, scale: 2),
                    })
                .PrimaryKey(t => t.Id);
            
            CreateTable(
                "dbo.Recetas",
                c => new
                    {
                        Id = c.Int(nullable: false, identity: true),
                        Nombre = c.String(maxLength: 50, unicode: false),
                        Descripcion = c.String(maxLength: 1500, unicode: false),
                        CantidadComensales = c.Int(nullable: false),
                        UtilidadPorce = c.Decimal(nullable: false, precision: 19, scale: 2),
                        CostoIndirectoPorce = c.Decimal(nullable: false, precision: 19, scale: 2),
                    })
                .PrimaryKey(t => t.Id);
            
            CreateTable(
                "dbo.Ordenes",
                c => new
                    {
                        Id = c.Int(nullable: false, identity: true),
                        Id_Pedido = c.Int(nullable: false),
                        NombreReceta = c.String(maxLength: 50, unicode: false),
                        Formula = c.String(maxLength: 1500, unicode: false),
                        CostoMP = c.Decimal(nullable: false, precision: 19, scale: 2),
                        CostoIndirecto = c.Decimal(nullable: false, precision: 18, scale: 2),
                        Ganancia = c.Decimal(nullable: false, precision: 19, scale: 2),
                    })
                .PrimaryKey(t => t.Id)
                .ForeignKey("dbo.Pedidos", t => t.Id_Pedido, cascadeDelete: true)
                .Index(t => t.Id_Pedido);
            
            CreateTable(
                "dbo.Pedidos",
                c => new
                    {
                        Id = c.Int(nullable: false, identity: true),
                        Id_Cliente = c.Int(nullable: false),
                        FechaPedido = c.DateTime(nullable: false),
                        FechaEntrega = c.DateTime(nullable: false),
                    })
                .PrimaryKey(t => t.Id)
                .ForeignKey("dbo.Clientes", t => t.Id_Cliente, cascadeDelete: true)
                .Index(t => t.Id_Cliente);
            
        }
        
        public override void Down()
        {
            DropForeignKey("dbo.Ordenes", "Id_Pedido", "dbo.Pedidos");
            DropForeignKey("dbo.Pedidos", "Id_Cliente", "dbo.Clientes");
            DropForeignKey("dbo.Ingredientes", "Id_Receta", "dbo.Recetas");
            DropForeignKey("dbo.Ingredientes", "Id_MateriaPrima", "dbo.MateriasPrimas");
            DropIndex("dbo.Pedidos", new[] { "Id_Cliente" });
            DropIndex("dbo.Ordenes", new[] { "Id_Pedido" });
            DropIndex("dbo.Ingredientes", new[] { "Id_Receta" });
            DropIndex("dbo.Ingredientes", new[] { "Id_MateriaPrima" });
            DropTable("dbo.Pedidos");
            DropTable("dbo.Ordenes");
            DropTable("dbo.Recetas");
            DropTable("dbo.MateriasPrimas");
            DropTable("dbo.Ingredientes");
            DropTable("dbo.Clientes");
        }
    }
}
