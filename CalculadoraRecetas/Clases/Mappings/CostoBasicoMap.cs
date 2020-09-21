using CalculadoraRecetas.Clases.Dominio;
using System.ComponentModel.DataAnnotations.Schema;
using System.Data.Entity.ModelConfiguration;

namespace CalculadoraRecetas.Clases.Mappings
{
    public class CostoBasicoMap : EntityTypeConfiguration<CostoBasico>
    {
        public CostoBasicoMap()
        {
            this.ToTable("CostosBasicos");

            this.HasKey(a => a.Id);
            this.Property(a => a.Id).HasDatabaseGeneratedOption(DatabaseGeneratedOption.Identity);

            this.Property(a => a.IsCostoFijo).HasColumnName("IsCostoFijo").HasColumnType("bit");
            this.Property(a => a.Nombre).HasColumnName("Nombre").HasColumnType("varchar").HasMaxLength(50);
            this.Property(a => a.FechaCosto).HasColumnName("FechaCosto").HasColumnType("datetime");
            this.Property(a => a.Notas).HasColumnName("Notas").HasColumnType("varchar").HasMaxLength(1500);
            this.Property(a=>a.CostoMonto).HasColumnName("CostoMonto").HasColumnType("decimal").HasPrecision(19, 2);
        }
    }
}
