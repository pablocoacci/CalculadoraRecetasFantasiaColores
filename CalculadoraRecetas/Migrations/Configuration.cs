namespace CalculadoraRecetas.Migrations
{
    using System;
    using System.Data.Entity;
    using System.Data.Entity.Migrations;
    using System.Linq;

    internal sealed class Configuration : DbMigrationsConfiguration<CalculadoraRecetas.Clases.Mappings.CalculadoraDataContext>
    {
        public Configuration()
        {
            AutomaticMigrationsEnabled = false;
            ContextKey = "CalculadoraRecetas.Clases.Mappings.CalculadoraDataContext";
        }

        protected override void Seed(CalculadoraRecetas.Clases.Mappings.CalculadoraDataContext context)
        {
            //  This method will be called after migrating to the latest version.

            //  You can use the DbSet<T>.AddOrUpdate() helper extension method 
            //  to avoid creating duplicate seed data.
        }
    }
}
