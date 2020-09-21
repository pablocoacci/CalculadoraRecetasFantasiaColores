using CalculadoraRecetas.Clases.Dominio;
using System.ComponentModel.DataAnnotations.Schema;
using System.Data.Entity.ModelConfiguration;

namespace CalculadoraRecetas.Clases.Mappings
{
    public class CostoFijoMap : EntityTypeConfiguration<CostoFijo>
    {
        public CostoFijoMap()
        {
            this.ToTable("CostosFijos");

            this.HasKey(a => a.Id);
            this.Property(a => a.Id).HasDatabaseGeneratedOption(DatabaseGeneratedOption.Identity);

            this.Property(a => a.Nombre).HasColumnName("Nombre").HasColumnType("varchar").HasMaxLength(50);
        }
    }
}
