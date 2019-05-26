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
    public class ClienteMap : EntityTypeConfiguration<Cliente>
    {
        public ClienteMap()
        {
            this.ToTable("Clientes");

            this.HasKey(a => a.Id);
            this.Property(a => a.Id).HasDatabaseGeneratedOption(DatabaseGeneratedOption.Identity);
            this.Property(a=>a.Nombre).HasColumnName("Nombre").HasColumnType("varchar").HasMaxLength(50);
            this.Property(a => a.Mail).HasColumnName("Mail").HasColumnType("varchar").HasMaxLength(75);
            this.Property(a => a.Direccion).HasColumnName("Direccion").HasColumnType("varchar").HasMaxLength(150);
            this.Property(a => a.Telefono).HasColumnName("Telefono").HasColumnType("varchar").HasMaxLength(25);
            this.Property(a => a.Celular).HasColumnName("Celular").HasColumnType("varchar").HasMaxLength(25);
            this.Property(a => a.Notas).HasColumnName("Notas").HasColumnType("varchar").HasMaxLength(2000);
            this.Property(a => a.ClienteDificil).HasColumnName("ClienteDificil").HasColumnType("bit");
        }
    }
}
