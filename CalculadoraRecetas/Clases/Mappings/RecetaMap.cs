using CalculadoraRecetas.Clases.Dominio;
using System.ComponentModel.DataAnnotations.Schema;
using System.Data.Entity.ModelConfiguration;

namespace CalculadoraRecetas.Clases.Mappings
{
    public class RecetaMap : EntityTypeConfiguration<Receta>
    {
        public RecetaMap()
        {
            this.ToTable("Recetas");

            this.HasKey(a => a.Id);
            this.Property(a => a.Id).HasDatabaseGeneratedOption(DatabaseGeneratedOption.Identity);
            this.Property(a => a.Nombre).HasColumnName("Nombre").HasColumnType("varchar").HasMaxLength(50);
            this.Property(a => a.Descripcion).HasColumnName("Descripcion").HasColumnType("varchar").HasMaxLength(1500);
            this.Property(a => a.CantidadComensales).HasColumnName("CantidadComensales").HasColumnType("int");
            this.Property(a => a.UtilidadPorce).HasColumnName("UtilidadPorce").HasColumnType("decimal").HasPrecision(19, 2);
            this.Property(a => a.CostoIndirectoPorce).HasColumnName("CostoIndirectoPorce").HasColumnType("decimal").HasPrecision(19, 2);

            this.Ignore(a => a.IngredientesValidos);
            this.Ignore(a => a.CostoTotalIngredientes);
            this.Ignore(a => a.CostoIndirecto);
            this.Ignore(a => a.Utilidad);
            this.Ignore(a => a.PrecioFinal);
        }
    }
}
