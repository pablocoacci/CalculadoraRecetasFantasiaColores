using CalculadoraRecetas.Clases.Dominio;
using System.ComponentModel.DataAnnotations.Schema;
using System.Data.Entity.ModelConfiguration;

namespace CalculadoraRecetas.Clases.Mappings
{
    public class ServicioMap : EntityTypeConfiguration<Servicio>
    {
        public ServicioMap()
        {
            this.ToTable("Servicios");

            this.HasKey(a => a.Id);
            this.Property(a => a.Id).HasDatabaseGeneratedOption(DatabaseGeneratedOption.Identity);

            this.Property(a=>a.Nombre).HasColumnName("Nombre").HasColumnType("varchar").HasMaxLength(50);
        }
    }
}
