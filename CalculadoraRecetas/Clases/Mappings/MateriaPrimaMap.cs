using CalculadoraRecetas.Clases.Dominio;
using System.ComponentModel.DataAnnotations.Schema;
using System.Data.Entity.ModelConfiguration;

namespace CalculadoraRecetas.Clases.Mappings
{
    public class MateriaPrimaMap : EntityTypeConfiguration<MateriaPrima>
    {
        public MateriaPrimaMap()
        {
            this.ToTable("MateriasPrimas");

            this.HasKey(a => a.Id);
            this.Property(a => a.Id).HasDatabaseGeneratedOption(DatabaseGeneratedOption.Identity);
            this.Property(a => a.Nombre).HasColumnName("Nombre").HasColumnType("varchar").HasMaxLength(50);
            this.Property(a => a.Abreviatura).HasColumnName("Abreviatura").HasColumnType("varchar").HasMaxLength(10);
            this.Property(a => a.UnidadMedida).HasColumnName("UnidadMedida").HasColumnType("int");
            this.Property(a => a.Precio).HasColumnName("Precio").HasColumnType("decimal").HasPrecision(19, 2);

            this.Ignore(a => a.UnidadMedidaStr);
        }
    }
}
