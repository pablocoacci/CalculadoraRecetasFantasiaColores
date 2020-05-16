using CalculadoraRecetas.Clases.Dominio;
using System.ComponentModel.DataAnnotations.Schema;
using System.Data.Entity.ModelConfiguration;

namespace CalculadoraRecetas.Clases.Mappings
{
    public class CostoServicioMap : EntityTypeConfiguration<CostoServicio>
    {
        public CostoServicioMap()
        {
            this.ToTable("CostoServicios");

            this.HasKey(a => a.Id);
            this.Property(a => a.Id).HasDatabaseGeneratedOption(DatabaseGeneratedOption.Identity);

            this.Property(a => a.Id_Servicio).HasColumnName("Id_Servicio").HasColumnType("int");
            this.Property(a => a.FechaCreacion).HasColumnName("FechaCreacion").HasColumnType("datetime");
            this.Property(a => a.PrecioFactura).HasColumnName("PrecioFactura").HasColumnType("decimal").HasPrecision(19, 2);
            this.Property(a => a.HorasLaborablesMensual).HasColumnName("HorasLaboralesMensual").HasColumnType("int").IsOptional();
            this.Property(a => a.IncidenciaPorce).HasColumnName("IncidenciaPorce").HasColumnType("decimal").IsOptional();
            this.Property(a => a.CostoTotal).HasColumnName("CostoTotal").HasColumnType("decimal").HasPrecision(19, 2);
            this.Property(a => a.Notas).HasColumnName("Notas").HasColumnType("varchar").HasMaxLength(1000);

            this.HasRequired(a => a.Servicio).WithMany().HasForeignKey(a => a.Id_Servicio);

            this.Ignore(a => a.MesCreacion);
            this.Ignore(a => a.CostoSugeridoEspecifico);
            this.Ignore(a => a.CostoSugeridoIncidencia);
            this.Ignore(a => a.NombreServicio);
        }
    }
}
