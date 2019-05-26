using CalculadoraRecetas.Clases.Dominio;
using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations.Schema;
using System.Data.Entity.ModelConfiguration;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CalculadoraRecetas.Clases.Mappings
{
    public class OrdenMap : EntityTypeConfiguration<Orden>
    {
        public OrdenMap()
        {
            this.ToTable("Ordenes");

            this.HasKey(a => a.Id);
            this.Property(a => a.Id).HasDatabaseGeneratedOption(DatabaseGeneratedOption.Identity);
            this.Property(a => a.Id_Pedido).HasColumnName("Id_Pedido").HasColumnType("int");
            this.Property(a => a.NombreReceta).HasColumnName("NombreReceta").HasColumnType("varchar").HasMaxLength(50);
            this.Property(a => a.Formula).HasColumnName("Formula").HasColumnType("varchar").HasMaxLength(1500);
            this.Property(a => a.CostoMP).HasColumnName("CostoMP").HasColumnType("decimal").HasPrecision(19, 2);
            this.Property(a => a.Ganancia).HasColumnName("Ganancia").HasColumnType("decimal").HasPrecision(19, 2);
            this.Property(a => a.Cantidad).HasColumnName("Cantidad").HasColumnType("int");
            this.Property(a => a.Id_Receta).HasColumnName("Id_Receta").HasColumnType("int");

            this.HasRequired(a => a.Pedido).WithMany(a => a.OrdenesRealizadas).HasForeignKey(a => a.Id_Pedido);

            this.Ignore(a => a.GananciaTotal);
            this.Ignore(a => a.PrecioTotal);
            this.Ignore(a => a.OrdenEliminada);
            this.Ignore(a => a.CostoTotalMP);
            this.Ignore(a => a.CostoIndirectoTotal);
        }
    }
}
