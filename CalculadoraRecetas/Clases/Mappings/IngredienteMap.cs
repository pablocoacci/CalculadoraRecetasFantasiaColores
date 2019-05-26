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
    public class IngredienteMap : EntityTypeConfiguration<Ingrediente>
    {
        public IngredienteMap()
        {
            this.ToTable("Ingredientes");

            this.HasKey(a => a.Id);
            this.Property(a => a.Id).HasDatabaseGeneratedOption(DatabaseGeneratedOption.Identity);
            this.Property(a => a.Id_MateriaPrima).HasColumnName("Id_MateriaPrima").HasColumnType("int");
            this.Property(a => a.Id_Receta).HasColumnName("Id_Receta").HasColumnType("int");
            this.Property(a => a.Cantidad).HasColumnName("Cantidad").HasColumnType("decimal").HasPrecision(19, 2);

            this.HasRequired(a => a.MateriaPrima).WithMany().HasForeignKey(a => a.Id_MateriaPrima);
            this.HasRequired(a => a.Receta).WithMany(a => a.Ingredientes).HasForeignKey(a => a.Id_Receta);

            this.Ignore(a => a.IngredienteEliminado);
            this.Ignore(a => a.MPNombre);
            this.Ignore(a => a.MPAbreviatura);
            this.Ignore(a => a.MPUnidad);
            this.Ignore(a => a.MPPrecio);
            this.Ignore(a => a.CostoNetoMP);
        }
    }
}
