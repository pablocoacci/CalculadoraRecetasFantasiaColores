using CalculadoraRecetas.Clases.Dominio;
using System.Data.Entity;

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

        public DbSet<Proveedor> Proveedores { get; set; }
        public DbSet<Servicio> Servicios { get; set; }
        public DbSet<CostoMateriales> CostoMateriales { get; set; }
        public DbSet<CostoServicio> CostoServicios { get; set; }


        protected override void OnModelCreating(DbModelBuilder modelBuilder)
        {
            modelBuilder.Configurations.Add(new ClienteMap());
            modelBuilder.Configurations.Add(new IngredienteMap());
            modelBuilder.Configurations.Add(new MateriaPrimaMap());
            modelBuilder.Configurations.Add(new OrdenMap());
            modelBuilder.Configurations.Add(new PedidoMap());
            modelBuilder.Configurations.Add(new RecetaMap());

            modelBuilder.Configurations.Add(new ProveedorMap());
            modelBuilder.Configurations.Add(new ServicioMap());
            modelBuilder.Configurations.Add(new CostoMaterialesMap());
            modelBuilder.Configurations.Add(new CostoServicioMap());
        }
    }
}
