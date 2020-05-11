using CalculadoraRecetas.Clases.Dominio;
using System.ComponentModel.DataAnnotations.Schema;
using System.Data.Entity.ModelConfiguration;

namespace CalculadoraRecetas.Clases.Mappings
{
    public class CostoMaterialesMap : EntityTypeConfiguration<CostoMateriales>
    {
        public CostoMaterialesMap()
        {
            this.ToTable("CostoMateriales");

            this.HasKey(a => a.Id);
            this.Property(a => a.Id).HasDatabaseGeneratedOption(DatabaseGeneratedOption.Identity);
            
            this.Property(a => a.Id_MateriaPrima).HasColumnName("Id_MateriaPrima").HasColumnType("int");
            this.Property(a => a.Id_Proveedor).HasColumnName("Id_Proveedor").HasColumnType("int");
            this.Property(a => a.FechaCompra).HasColumnName("FechaCompra").HasColumnType("datetime");
            this.Property(a => a.Notas).HasColumnName("Notas").HasColumnType("varchar").HasMaxLength(1500);
            this.Property(a => a.Detalle).HasColumnName("Detalle").HasColumnType("varchar").HasMaxLength(50);
            this.Property(a => a.PrecioUnitario).HasColumnName("PrecioUnitario").HasColumnType("decimal").HasPrecision(19, 2);
            this.Property(a => a.Cantidad).HasColumnName("Cantidad").HasColumnType("int");
            this.Property(a => a.CostoTotal).HasColumnName("CostoTotal").HasColumnType("decimal").HasPrecision(19, 2);

            this.HasRequired(a => a.MateriaPrima).WithMany().HasForeignKey(a => a.Id_MateriaPrima);
            this.HasRequired(a => a.Proveedor).WithMany().HasForeignKey(a => a.Id_Proveedor);

            this.Ignore(a => a.MesCompra);
            this.Ignore(a => a.CostoTotalSugerido);
            this.Ignore(a => a.NombreMateriaPrima);
            this.Ignore(a => a.NombreProveedor);
        }
    }
}
