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
    public class PedidoMap : EntityTypeConfiguration<Pedido>
    {
        public PedidoMap()
        {
            this.ToTable("Pedidos");

            this.HasKey(a => a.Id);
            this.Property(a => a.Id).HasDatabaseGeneratedOption(DatabaseGeneratedOption.Identity);
            this.Property(a => a.Id_Cliente).HasColumnName("Id_Cliente").HasColumnType("int");
            this.Property(a => a.FechaPedido).HasColumnName("FechaPedido").HasColumnType("datetime");
            this.Property(a => a.FechaEntrega).HasColumnName("FechaEntrega").HasColumnType("datetime");
            this.Property(a => a.Estado).HasColumnName("Estado").HasColumnType("int");

            this.HasRequired(a => a.Cliente).WithMany().HasForeignKey(a => a.Id_Cliente);

            this.Ignore(a => a.EstadoStr);
            this.Ignore(a => a.NombreCliente);
            this.Ignore(a => a.DireccionCliente);
            this.Ignore(a => a.TelefonoCliente);
            this.Ignore(a => a.CelularCliente);
            this.Ignore(a => a.MailCliente);
            this.Ignore(a => a.GananciaTota);
            this.Ignore(a => a.PrecioFinalTotal);
            this.Ignore(a => a.OrdenesValidas);
            this.Ignore(a => a.PercioMPTotal);
            this.Ignore(a => a.CostoIndirectoTotal);
        }
    }
}
