using CalculadoraRecetas.Clases.Dominio;
using System;
using System.Collections.Generic;
using System.Data.Entity;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CalculadoraRecetas.Clases.Mappings
{
    public class CalculadoraDataContext : DbContext
    {
        public CalculadoraDataContext() : base("CalculadoraRecetaBDLocal") { }

        public DbSet<Cliente> Clientes { get; set; }
        public DbSet<Ingrediente> Ingredientes { get; set; }
        public DbSet<MateriaPrima> MateriasPrimas { get; set; }
        public DbSet<Orden> Ordenes { get; set; }
        public DbSet<Pedido> Pedidos { get; set; }
        public DbSet<Receta> Recetas { get; set; }

        protected override void OnModelCreating(DbModelBuilder modelBuilder)
        {
            modelBuilder.Configurations.Add(new ClienteMap());
            modelBuilder.Configurations.Add(new IngredienteMap());
            modelBuilder.Configurations.Add(new MateriaPrimaMap());
            modelBuilder.Configurations.Add(new OrdenMap());
            modelBuilder.Configurations.Add(new PedidoMap());
            modelBuilder.Configurations.Add(new RecetaMap());
        }
    }
}
