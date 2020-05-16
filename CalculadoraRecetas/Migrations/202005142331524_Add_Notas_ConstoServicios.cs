namespace CalculadoraRecetas.Migrations
{
    using System;
    using System.Data.Entity.Migrations;
    
    public partial class Add_Notas_ConstoServicios : DbMigration
    {
        public override void Up()
        {
            AddColumn("dbo.CostoServicios", "Notas", c => c.String(maxLength: 1000, unicode: false));
        }
        
        public override void Down()
        {
            DropColumn("dbo.CostoServicios", "Notas");
        }
    }
}
